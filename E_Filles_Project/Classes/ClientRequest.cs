using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace E_Filles_Project.Classes
{
    public class ClientRequest
    {

        string APIKey { get; set; }
        string ModeleReference { get; set; }
        string GenerationMode { get; set; }
        List<Dictionary<string, string>> DictionaireDatas { get; set; }
        string HtmlDatas { get; set; }

        public static ClientRequest GenerateRequestObject(string NvAPIKey, string NvModeleReference, string NvGenerationMode, string RequestBody)
        {
            ClientRequest retReq = new ClientRequest();
            retReq.APIKey = NvAPIKey;
            retReq.ModeleReference = NvModeleReference;
            retReq.GenerationMode = NvGenerationMode;

            if (retReq.GenerationMode == "Html")
            {
                retReq.HtmlDatas = RequestBody;
            }
            else
            {
                retReq.DictionaireDatas= Newtonsoft.Json.JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(RequestBody);

            }

            return retReq;

        }

    }
}