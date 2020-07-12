using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Filles_Project.Classes
{
    public class ClientResponse
    {

        string ModeleReference { get; set; }
        string JsonResponseDatas { get; set; }

        public static ClientResponse GenerateResponseObject( string NvModeleReference, List<ElementRetourne> ResultatTravaux)
        {

            ClientResponse retRep = new ClientResponse();
            retRep.ModeleReference = NvModeleReference;

            retRep.JsonResponseDatas = Newtonsoft.Json.JsonConvert.SerializeObject(ResultatTravaux);
            
            return retRep;

        }
    }

    public class ElementRetourne
    {
        string NomFichier { get; set; }
        string ContenuFichier { get; set; }
        string FormatFichier { get; set; }
    }
}