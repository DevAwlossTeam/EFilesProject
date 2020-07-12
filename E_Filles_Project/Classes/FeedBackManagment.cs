using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Text;

namespace E_Filles_Project.Classes
{
    public class FeedBackManagment
    {

        public static HttpResponseMessage ReturnError(string ErrorMessage, System.Net.HttpStatusCode ErrCode )
        {
            var response = new HttpResponseMessage()
            {
                Content = new StringContent(ErrorMessage, Encoding.UTF8, "application/json"),
                StatusCode = ErrCode,
            };

            return response;
        }

    }
}