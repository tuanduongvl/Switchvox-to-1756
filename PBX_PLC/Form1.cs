using libplctag;
using libplctag.DataTypes.Simple;
//using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
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

        public TagBool  tagPLCEvent, tagPLC1001Event, tagPLC1002Event, tagPLC1003Event, tagPLC1004Event, tagPLCserverFail;
        public TagDint tagPLCTrigger, tagPLCNumber1, tagPLCNumber2, tagPLCFilter, tagPLCcallTo, tagPLC1001State, tagPLC1002State, tagPLC1003State, tagPLC1004State;
        public TagString tagPLCstate1, tagPLCstate2, tagPLCstate3, tagPLCstate4;
        private bool setEvent;

        public int tagNumber1, tagNumber2, tagFilter, tagNumberCallTo, tag1001State, tag1002State, tag1003State, tag1004State;
        public bool tagTrigger, tagEvent, triggerClear, tag1001Event, tag1002Event, tag1003Event, tag1004Event, tagServerFail;
        public string tagState1 = "", tagState2 = "", tagState3 = "", tagState4 = "";

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
            if (triggerClear)
            {
                tagPLCTrigger.Write(0);
                triggerClear = false;
            }

            tagPLC1001State.Write(tag1001State);
            tagPLC1002State.Write(tag1002State);
            tagPLC1003State.Write(tag1003State);
            tagPLC1004State.Write(tag1004State);

            tagPLC1001Event.Write(tag1001Event);
            tagPLC1002Event.Write(tag1002Event);    
            tagPLC1003Event.Write(tag1003Event);
            tagPLC1004Event.Write(tag1004Event);

            tagPLCserverFail.Write(tagServerFail);
        }

        private void writePBX()
        {
            if (tagTrigger)
            {
                timer1.Stop();
                try
                {
                    request1 = new RestRequest(txt_PBX_URL.Text, Method.Post);

                    request1.AddHeader("Authorization", "Basic YWRtaW46IVBhc3N3b3JkMDE=");
                    request1.AddHeader("Content-Type", "application/json");


                    callRequest.request.parameters.dial_as_account_id = "1106";
                    callRequest.request.parameters.dial_first = tagNumber1.ToString();
                    callRequest.request.parameters.dial_second = tagNumber2.ToString();

                    txt_PBX_status.Text = "Calling";

                    request1.AddJsonBody<CallRequest>(callRequest);
                    var response = client1.Post(request1);
                    txt_PBX_status.Text = response.Content;
                    triggerClear = true;
                    //timer1.Interval = int.Parse(txt_Interval.Text);
                }
                catch(Exception ex)
                {
                    tagServerFail = false;
                }

                timer1.Start();
            }
        }

        private void readPBX()
        {
            
                timer1.Stop();

            tagServerFail = true;
            try
            {
                request1 = new RestRequest(txt_PBX_URL.Text, Method.Post);

                request1.AddHeader("Authorization", "Basic YWRtaW46IVBhc3N3b3JkMDE=");
                request1.AddHeader("Content-Type", "application/json");


                callRequest.request.parameters.dial_as_account_id = "1106";
                callRequest.request.parameters.dial_first = tagNumber1.ToString();
                callRequest.request.parameters.dial_second = tagNumber2.ToString();
                request1.AddStringBody(@"{""request"": {""method"": ""switchvox.currentCalls.getList"", ""parameters"": {}}}", DataFormat.Json);
                var response = client1.Post(request1);
                txt_PBX_status.Text = response.Content;

                callListResult = JsonSerializer.Deserialize<CallListResult>(response.Content);
            }
            catch (Exception ex)
            {
                tagServerFail = false;
            }





            tag1001State = 0;
            tag1002State = 0;
            tag1003State = 0;
            tag1004State = 0;


            tag1001Event = false;
            tag1002Event = false;
            tag1003Event = false;
            tag1004Event = false;
            if (callListResult.response.result.current_calls.total_items != "0")
            {
                if (callListResult.response.result.current_calls.current_call is JsonElement items)
                    if (items.ValueKind == JsonValueKind.Array)
                    {
                        List<CurrentCall> these_call = JsonSerializer.Deserialize<List<CurrentCall>>(items.GetRawText());
                        foreach (CurrentCall this_call in these_call)
                        {
                            process_calls(this_call);
                        }
                    }

                    else
                    {
                        CurrentCall this_call = JsonSerializer.Deserialize<CurrentCall>(items.GetRawText());
                        //txt_Extension.Text = this_call.from_caller_id_number;
                        //txt_PBX_call_info.Text = this_call.ToString();
                        process_calls(this_call);
                    }

            }
            timer1.Start();


        }
        private void process_calls(CurrentCall this_call)
        {
            if (this_call.from_caller_id_number.Equals("1001"))
            {
                tag1001Event = true;
                if (this_call.state.Equals("ringing"))
                {
                    tag1001State = 1;
                }
                if (this_call.state.Equals("talking"))
                {
                    tag1001State = 2;
                }
            }

            if (this_call.from_caller_id_number.Equals("1002"))
            {
                tag1002Event = true;
                if (this_call.state.Equals("ringing"))
                {
                    tag1002State = 1;
                }
                if (this_call.state.Equals("talking"))
                {
                    tag1002State = 2;
                }
            }

            if (this_call.from_caller_id_number.Equals("1003"))
            {
                tag1003Event = true;
                if (this_call.state.Equals("ringing"))
                {
                    tag1003State = 1;
                }
                if (this_call.state.Equals("talking"))
                {
                    tag1003State = 2;
                }
            }

            if (this_call.from_caller_id_number.Equals("1004"))
            {
                tag1004Event = true;
                if (this_call.state.Equals("ringing"))
                {
                    tag1004State = 1;
                }
                if (this_call.state.Equals("talking"))
                {
                    tag1004State = 2;
                }
            }
        }
        private void readPLC()
        {
            tagNumber1 = tagPLCNumber1.Read();
            tagNumber2 = tagPLCNumber2.Read();
            //tagFilter = tagPLCFilter.Read();
            tagTrigger = (tagPLCTrigger.Read()==1);
            //tagEvent = tagPLCEvent.Read(); 
            //txt_PLC_status.Text = tagNumber1.ToString() + " " + tagNumber2.ToString() + " "+ tagFilter.ToString() + " " + tagTrigger.ToString() + " " + tagEvent.ToString();
            txt_Number1_value.Text = tagNumber1.ToString();
            txt_Number2_value.Text = tagNumber2.ToString();
            //txt_Filter_value.Text = tagFilter.ToString();
            //txt_Event_value.Text = tagEvent.ToString();
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
            tagPLCTrigger = new TagDint()
            {
                Name = txt_PLC_trigger.Text,
                Gateway = txt_PLC_IP.Text,
                Path = txt_PLC_path.Text,
                PlcType = libplctag.PlcType.ControlLogix,
                Protocol = libplctag.Protocol.ab_eip,
                Timeout = TimeSpan.FromSeconds(5)

            };
            tagPLC1001Event = new TagBool()
            {
                Name = "Phone_1001_CallEvent",
                Gateway = txt_PLC_IP.Text,
                Path = txt_PLC_path.Text,
                PlcType = libplctag.PlcType.ControlLogix,
                Protocol = libplctag.Protocol.ab_eip,
                Timeout = TimeSpan.FromSeconds(5)
            };
            tagPLC1002Event = new TagBool()
            {
                Name = "Phone_1002_CallEvent",
                Gateway = txt_PLC_IP.Text,
                Path = txt_PLC_path.Text,
                PlcType = libplctag.PlcType.ControlLogix,
                Protocol = libplctag.Protocol.ab_eip,
                Timeout = TimeSpan.FromSeconds(5)
            };
            tagPLC1003Event = new TagBool()
            {
                Name = "Phone_1003_CallEvent",
                Gateway = txt_PLC_IP.Text,
                Path = txt_PLC_path.Text,
                PlcType = libplctag.PlcType.ControlLogix,
                Protocol = libplctag.Protocol.ab_eip,
                Timeout = TimeSpan.FromSeconds(5)
            };
            tagPLC1004Event = new TagBool()
            {
                Name = "Phone_1004_CallEvent",
                Gateway = txt_PLC_IP.Text,
                Path = txt_PLC_path.Text,
                PlcType = libplctag.PlcType.ControlLogix,
                Protocol = libplctag.Protocol.ab_eip,
                Timeout = TimeSpan.FromSeconds(5)
            };

            tagPLC1001State = new TagDint()
            {
                Name = "Phone_1001_Status",
                Gateway = txt_PLC_IP.Text,
                Path = txt_PLC_path.Text,
                PlcType = libplctag.PlcType.ControlLogix,
                Protocol = libplctag.Protocol.ab_eip,
                Timeout = TimeSpan.FromSeconds(5)
            };
            tagPLC1002State = new TagDint()
            {
                Name = "Phone_1002_Status",
                Gateway = txt_PLC_IP.Text,
                Path = txt_PLC_path.Text,
                PlcType = libplctag.PlcType.ControlLogix,
                Protocol = libplctag.Protocol.ab_eip,
                Timeout = TimeSpan.FromSeconds(5)
            };
            tagPLC1003State = new TagDint()
            {
                Name = "Phone_1003_Status",
                Gateway = txt_PLC_IP.Text,
                Path = txt_PLC_path.Text,
                PlcType = libplctag.PlcType.ControlLogix,
                Protocol = libplctag.Protocol.ab_eip,
                Timeout = TimeSpan.FromSeconds(5)
            };
            tagPLC1004State = new TagDint()
            {
                Name = "Phone_1004_Status",
                Gateway = txt_PLC_IP.Text,
                Path = txt_PLC_path.Text,
                PlcType = libplctag.PlcType.ControlLogix,
                Protocol = libplctag.Protocol.ab_eip,
                Timeout = TimeSpan.FromSeconds(5)
            };
            tagPLCserverFail = new TagBool()
            {
                Name = "Phone_Server_Status",
                Gateway = txt_PLC_IP.Text,
                Path = txt_PLC_path.Text,
                PlcType = libplctag.PlcType.ControlLogix,
                Protocol = libplctag.Protocol.ab_eip,
                Timeout = TimeSpan.FromSeconds(5)
            };
            timer1.Start();
            cycleCount = 0;

        }



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
