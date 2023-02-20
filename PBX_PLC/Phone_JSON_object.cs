using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBX_PLC
{
    internal class Phone_JSON_object
    {

    }
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class CurrentCall
    {
        public string provider { get; set; }
        public string start_time { get; set; }
        public string duration { get; set; }
        public string to_caller_id_number { get; set; }
        public string state { get; set; }
        public string format { get; set; }
        public string from_caller_id_name { get; set; }
        public string to_caller_id_name { get; set; }
        public string from_caller_id_number { get; set; }
        public string id { get; set; }
    }

    public class CurrentCalls
    {
        public object current_call { get; set; }
        public string total_items { get; set; }
    }

    public class Response
    {
        public string method { get; set; }
        public Result result { get; set; }
    }

    public class Result
    {
        public CurrentCalls current_calls { get; set; }
    }

    public class CallListResult
    {
        public Response response { get; set; }
    }

    //Class to make call request
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


    //Class to make Get Call List request
    public class GetCallParameters
    {
    }

    public class GetCallRequest
    {
        public string method { get; set; }
        public GetCallParameters parameters { get; set; }
    }

    public class Root
    {
        public GetCallRequest request { get; set; }
    }



}
