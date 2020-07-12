using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Net.Http.Headers;
using System.Web.Http.Description;
using System.Web;
using System.IO;

namespace E_Filles_Project.Controllers
{
    [RoutePrefix("api/E_Filles_Project")]
    public class BASF_Pdf_Controller : ApiController
    {
        [ResponseType(typeof(HttpResponseMessage))]
        [HttpPost]
        [Route("ActionMain")]
        public HttpResponseMessage ConvertHtmlPdf()
        {
            
            var res = new HttpResponseMessage(HttpStatusCode.OK);
            
            return res;

        }



        private static string ConvertAccentsToHtmlCodes(string HtmlString)
        {

            try // finally
            {

                HtmlString = HtmlString.Replace("ï", "&iuml;");
                HtmlString = HtmlString.Replace("Ï", "&Iuml;");
                HtmlString = HtmlString.Replace("à", "&agrave;");
                HtmlString = HtmlString.Replace("À", "&Agrave;");
                HtmlString = HtmlString.Replace("â", "&acirc;");
                HtmlString = HtmlString.Replace("Â", "&Acirc;");

                HtmlString = HtmlString.Replace("á", "&aacute;");
                HtmlString = HtmlString.Replace("Á", "&Aacute;");
                HtmlString = HtmlString.Replace("é", "&eacute;");
                HtmlString = HtmlString.Replace("É", "&Eacute;");
                HtmlString = HtmlString.Replace("è", "&egrave;");
                HtmlString = HtmlString.Replace("È", "&Egrave;");
                HtmlString = HtmlString.Replace("í", "&iacute;");
                HtmlString = HtmlString.Replace("Í", "&Iacute;");
                HtmlString = HtmlString.Replace("ñ", "&ntilde;");
                HtmlString = HtmlString.Replace("Ñ", "&Ntilde;");
                HtmlString = HtmlString.Replace("ó", "&oacute;");
                HtmlString = HtmlString.Replace("Ó", "&Oacute;");
                HtmlString = HtmlString.Replace("ú", "&uacute;");
                HtmlString = HtmlString.Replace("Ú", "&Uacute;");
                HtmlString = HtmlString.Replace("ü", "&uuml;");
                HtmlString = HtmlString.Replace("Ü", "&Uuml;");
                HtmlString = HtmlString.Replace("¿", "&iquest;");
                HtmlString = HtmlString.Replace("¡", "&iexcl;");
                HtmlString = HtmlString.Replace("Ä", "&Auml;");
                HtmlString = HtmlString.Replace("ä", "&auml;");
                HtmlString = HtmlString.Replace("Ö", "&Ouml;");
                HtmlString = HtmlString.Replace("ö", "&ouml;");
                HtmlString = HtmlString.Replace("ß", "&szlig;");

                HtmlString = HtmlString.Replace("ê", "&ecirc;");
                HtmlString = HtmlString.Replace("Ê", "&Ecirc;");
                HtmlString = HtmlString.Replace("ô", "&ocirc;");
                HtmlString = HtmlString.Replace("Ô", "&Ocirc;");
                HtmlString = HtmlString.Replace("û", "&ucirc;");

                HtmlString = HtmlString.Replace("°", "&deg;");
            }
            catch (Exception ex)
            {

            }

            return HtmlString;

        }


    }
}

