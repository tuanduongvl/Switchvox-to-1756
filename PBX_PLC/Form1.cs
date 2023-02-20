﻿using libplctag;
using libplctag.DataTypes.Simple;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBX_PLC
{
    public partial class Form1 : Form
    {
        


        RestClient client1;
        RestRequest request1;
        CallRequest callRequest = new CallRequest();
        long cycleCount;
        CallListResult callListResult;


        public int tagNumber1, tagNumber2, tagFilter;
        public bool tagTrigger, tagEvent, triggerClear;

        private void txt_Interval_TextChanged(object sender, EventArgs e)
        {
            timer1.Interval = int.Parse(txt_Interval.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            readPLC();
            readPBX();
            writePBX();
            writePLC();
            cycleCount++;
            lbl_cycle.Text = "Cycle: "+ cycleCount.ToString();
        }

        private void writePLC()
        {
            if(setEvent)
            {
                tagPLCEvent.Write(1);
                setEvent = false;
            }    
            if (triggerClear)
            {
                tagPLCTrigger.Write(0);
                triggerClear = false;
            }
        }

        private void writePBX()
        {
            if (tagTrigger)
            {
                timer1.Stop();
                request1 = new RestRequest(txt_PBX_URL.Text, Method.Post);

                request1.AddHeader("Authorization", "Basic YWRtaW46IVBhc3N3b3JkMDE=");
                request1.AddHeader("Content-Type", "application/json");


                callRequest.request.parameters.dial_as_account_id = "1106";
                callRequest.request.parameters.dial_first = tagNumber1.ToString();
                callRequest.request.parameters.dial_second = tagNumber2.ToString();

                txt_PBX_status.Text = "Calling Fire Department";

                request1.AddJsonBody<CallRequest>(callRequest);
                var response = client1.Post(request1);
                txt_PBX_status.Text = response.Content;
                triggerClear = true;
                //timer1.Interval = int.Parse(txt_Interval.Text);
                timer1.Start();
            }
        }

        private void readPBX()
        {
            
                timer1.Stop();
                request1 = new RestRequest(txt_PBX_URL.Text, Method.Post);

                request1.AddHeader("Authorization", "Basic YWRtaW46IVBhc3N3b3JkMDE=");
                request1.AddHeader("Content-Type", "application/json");


                callRequest.request.parameters.dial_as_account_id = "1106";
                callRequest.request.parameters.dial_first = tagNumber1.ToString();
                callRequest.request.parameters.dial_second = tagNumber2.ToString();
                request1.AddStringBody(@"{""request"": {""method"": ""switchvox.currentCalls.getList"", ""parameters"": {}}}", DataFormat.Json);
                var response = client1.Post(request1);
                txt_PBX_status.Text = response.Content;

                callListResult = JsonConvert.DeserializeObject<CallListResult>(response.Content);
            if (callListResult.response.result.current_calls.total_items != "0")
            {
                if (callListResult.response.result.current_calls.current_call is CurrentCall item)
                {
                    txt_Extension.Text = item.from_caller_id_number;
                    txt_PBX_call_info.Text = item.ToString();
                    if (item.state.Equals("ringing") && item.from_caller_id_number.Equals(tagFilter.ToString()))
                    {

                        setEvent = true;
                    }
                }
                if (callListResult.response.result.current_calls.current_call is CurrentCall[] items)

                    foreach (CurrentCall call in items)
                {
                    if (call.from_caller_id_number.Equals(tagFilter.ToString()))
                    {
                            txt_Extension.Text = call.from_caller_id_number;
                            setEvent = true;
                    }
                }
            }


            timer1.Start();


        }

        private void readPLC()
        {
            tagNumber1 = tagPLCNumber1.Read();
            tagNumber2 = tagPLCNumber2.Read();
            tagFilter = tagPLCFilter.Read();
            tagTrigger = (tagPLCTrigger.Read() == 1);
            tagEvent = (tagPLCEvent.Read() == 1); 
            txt_PLC_status.Text = tagNumber1.ToString() + " " + tagNumber2.ToString() + " "+ tagFilter.ToString() + " " + tagTrigger.ToString() + " " + tagEvent.ToString();
            txt_Number1_value.Text = tagNumber1.ToString();
            txt_Number2_value.Text = tagNumber2.ToString();
            txt_Filter_value.Text = tagFilter.ToString();
            txt_Event_value.Text = tagEvent.ToString();
            txt_Trigger_value.Text = tagTrigger.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tagPLCNumber1 = new TagDint()
            {
                Name = txt_PLC_Number1.Text,
                Gateway = txt_PLC_IP.Text,
                Path = txt_PLC_path.Text,
                PlcType = libplctag.PlcType.ControlLogix,
                Protocol = libplctag.Protocol.ab_eip,
                Timeout = TimeSpan.FromSeconds(5)

            };
            tagPLCNumber2 = new TagDint()
            {
                Name = txt_PLC_Number2.Text,
                Gateway = txt_PLC_IP.Text,
                Path = txt_PLC_path.Text,
                PlcType = libplctag.PlcType.ControlLogix,
                Protocol = libplctag.Protocol.ab_eip,
                Timeout = TimeSpan.FromSeconds(5)

            };
            tagPLCFilter = new TagDint()
            {
                Name = txt_PLC_Filter.Text,
                Gateway = txt_PLC_IP.Text,
                Path = txt_PLC_path.Text,
                PlcType = libplctag.PlcType.ControlLogix,
                Protocol = libplctag.Protocol.ab_eip,
                Timeout = TimeSpan.FromSeconds(5)

            };
            tagPLCTrigger = new TagDint()
            {
                Name = txt_PLC_trigger.Text,
                Gateway = txt_PLC_IP.Text,
                Path = txt_PLC_path.Text,
                PlcType = libplctag.PlcType.ControlLogix,
                Protocol = libplctag.Protocol.ab_eip,
                Timeout = TimeSpan.FromSeconds(5)

            };
            tagPLCEvent = new TagDint()
            {
                Name = txt_PLC_Event.Text,
                Gateway = txt_PLC_IP.Text,
                Path = txt_PLC_path.Text,
                PlcType = libplctag.PlcType.ControlLogix,
                Protocol = libplctag.Protocol.ab_eip,
                Timeout = TimeSpan.FromSeconds(5)

            };
            timer1.Start();
            cycleCount = 0;

        }

        public TagDint tagPLCTrigger, tagPLCEvent;
        public TagDint tagPLCNumber1, tagPLCNumber2, tagPLCFilter;
        private bool setEvent;

        public Form1()
        {
            InitializeComponent();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;

            client1 = new RestClient();

            callRequest.request = new Request();
            callRequest.request.parameters = new Parameters();
            callRequest.request.method = "switchvox.call";
            timer1.Interval = 1000;
        }
    }
}
