using libplctag.DataTypes.Simple;
using RestSharp;
using System.Net;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace testAllenBradleyNetcore
{
    public partial class Form1 : Form
    {
        X509Certificate2 cert;
        X509CertificateCollection certCollection;
        public Form1()
        {
            InitializeComponent();
            IEnumerable<string> headerValues;
            String certPemString = @"MIIDzTCCArWgAwIBAgIJAKnlg8/ACE2TMA0GCSqGSIb3DQEBCwUAMHUxPDA6BgNV
BAoMM1N3aXRjaHZveCBVVUlEOmRlM2MzMWVmLTMxMWItNGFlNy1iMWRkLTQ3ZTYz
MzIxYjczYzEWMBQGA1UEBRMNMTY3NTkxNzQ3ODgzNDEdMBsGA1UEAwwUU3dpdGNo
dm94IE1hbmFnZWQgQ0EwHhcNMjMwMjA5MDQzODAwWhcNMzMwMjA2MDQzODAwWjB1
MTwwOgYDVQQKDDNTd2l0Y2h2b3ggVVVJRDpkZTNjMzFlZi0zMTFiLTRhZTctYjFk
ZC00N2U2MzMyMWI3M2MxFjAUBgNVBAUTDTE2NzU5MTc0Nzg4MzQxHTAbBgNVBAMM
FFN3aXRjaHZveCBNYW5hZ2VkIENBMIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIB
CgKCAQEA5akl0WzQRwySn9NA54ICXrFXaLsCJNNRgljnK47FJKO7Px2x8dgxG5Yl
FYsTuXt74iA4OVCqcnWZLfUsKmHQ6ZpLlRXyUAwS7IK59RBKqCRGQAolL0+xeIes
RF2GT/hzBsE2eDLlWWgBxUu/y1evVHu+lIcNyFpcnlxYGYMJiIDlAivnSuv93F/k
5HdcFaTZGixIsGIKdi2Na0q0S17vEA0dj66mwix/XQ+faPSZ3Bl4RT5HG5OZbT/w
PJXQIGuNrzi15GgWZQ8zknrRRJNV7Fc18L7AJAqcrUSy/DcxkAp9F6KoRG84QUZX
cODW3TbTCwRTRXCjTiK5OWJTEns/XwIDAQABo2AwXjAdBgNVHQ4EFgQUR2MxMdCm
JMffK73m9TVsy7tBdbEwHwYDVR0jBBgwFoAUR2MxMdCmJMffK73m9TVsy7tBdbEw
CwYDVR0PBAQDAgEGMA8GA1UdEwEB/wQFMAMBAf8wDQYJKoZIhvcNAQELBQADggEB
AF4cqxMM7/Dct1ygzX1qVpWtHEjhUk8hjO8DzlseyDHOPYIcWZjLOID+JfNXgptG
2pj3BgqFQR5p423D3JpPEo9eZ1usdQ53MIhGtm0qAgoo+cpfSl4DbHjM2vbhO/X3
MteEgRfaGvXzoDMXejt0BN/soXH0WP67rl+llOhj2iRXmiTxIwGgsffe7c2ZYfli
lyM1A43h80RDwfZL7GTzfGrBJc84Ft+TlYcGjGXN04AuOoObm5xUcW7N5GtQ75IL
fs7EQBlfMPETQehbi3e3sbeCAnnJWWFpS3B6h/alJMGzRuHs8eONeLNk+nC3vvWu
XSc3rrCJw5opCHM8A1wFkkA=";
            cert = new X509Certificate2(Convert.FromBase64String(certPemString));
            certCollection = new X509CertificateCollection();
            certCollection.Add(cert);

            var options = new RestClientOptions()
            { ClientCertificates = certCollection };
            client1 = new RestClient(options);

            client1.Options.ClientCertificates.Add(cert);
            callRequest.request = new Request();
            callRequest.request.parameters = new Parameters();
            callRequest.request.method = "switchvox.call";
        }

        public class Parameters
        {
            public string dial_first { get; set; } = "1010";
            public string dial_second { get; set; } = "1011";
            public string dial_as_account_id { get; set; } = "1106";
        }

        public class Request
        {
            public string method { get; set; } = "switchvox.call";
            public Parameters parameters { get; set; }
        }

        public class CallRequest
        {
            public Request request { get; set; }
        }

        RestClient client1 ;
        RestRequest request1 ;
        CallRequest callRequest = new CallRequest();


        public int tagNumber1, tagNumber2, tagFilter;
        public bool tagTrigger, tagEvent, triggerClear;
        public TagDint tagPLCTrigger, tagPLCEvent;
        public TagDint tagPLCNumber1, tagPLCNumber2, tagPLCFilter;

        private void button1_Click(object sender, EventArgs e)
        {
            tagPLCNumber1 = new TagDint()
            {
                Name = txt_tagNumber1.Text,
                Gateway = txt_IP.Text,
                Path = txt_Path.Text,
                PlcType = libplctag.PlcType.ControlLogix,
                Protocol = libplctag.Protocol.ab_eip,
                Timeout = TimeSpan.FromSeconds(5)

            };
            tagPLCNumber2 = new TagDint()
            {
                Name = txt_tagNumber2.Text,
                Gateway = txt_IP.Text,
                Path = txt_Path.Text,
                PlcType = libplctag.PlcType.ControlLogix,
                Protocol = libplctag.Protocol.ab_eip,
                Timeout = TimeSpan.FromSeconds(5)

            };
            tagPLCFilter = new TagDint()
            {
                Name = txt_callFilter.Text,
                Gateway = txt_IP.Text,
                Path = txt_Path.Text,
                PlcType = libplctag.PlcType.ControlLogix,
                Protocol = libplctag.Protocol.ab_eip,
                Timeout = TimeSpan.FromSeconds(5)

            };
            tagPLCTrigger = new TagDint()
            {
                Name = txt_callTrigger.Text,
                Gateway = txt_IP.Text,
                Path = txt_Path.Text,
                PlcType = libplctag.PlcType.ControlLogix,
                Protocol = libplctag.Protocol.ab_eip,
                Timeout = TimeSpan.FromSeconds(5)

            };
            tagPLCEvent = new TagDint()
            {
                Name = txt_callEvent.Text,
                Gateway = txt_IP.Text,
                Path = txt_Path.Text,
                PlcType = libplctag.PlcType.ControlLogix,
                Protocol = libplctag.Protocol.ab_eip,
                Timeout = TimeSpan.FromSeconds(5)

            };
            timer1.Start();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //readPLC();
            //readPBX();
            writePBX();
            //writePLC();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            timer1.Interval = int.Parse(textBox2.Text);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
        }


        private void readPLC()
        {
            tagNumber1 = tagPLCNumber1.Read();
            tagNumber2 = tagPLCNumber2.Read();
            tagFilter = tagPLCFilter.Read();
            tagTrigger = (tagPLCTrigger.Read() == 1);
            textBox1.Text = tagNumber1.ToString() + " " + tagTrigger.ToString();
            //tagEvent = tagPLCEvent.Read();
        }

        private void writePLC()
        {
            if (triggerClear)
            {
                tagPLCTrigger.Write(0);
                triggerClear = false;
            }
        }

        private void readPBX()
        {

        }

        private void writePBX()
        {
            if (!tagTrigger)
            {
                timer1.Stop();
                request1 = new RestRequest(txt_PBX_URL.Text, Method.Post);

                request1.AddHeader("Authorization", "Basic YWRtaW46IVBhc3N3b3JkMDE=");
                request1.AddHeader("Content-Type", "application/json");


                callRequest.request.parameters.dial_as_account_id = "1106";
                callRequest.request.parameters.dial_first = tagNumber1.ToString();
                callRequest.request.parameters.dial_second = tagNumber2.ToString();

                textBox1.Text = "Calling Fire Department";

                request1.AddJsonBody<CallRequest>(callRequest);
                var response = client1.Post(request1);
                textBox1.Text = response.Content;
                triggerClear = true;
                timer1.Start();
            }
        }
    }
}