using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Header.Controllers
{
    public class HeaderController : ApiController
    {
        //Declare an instance for log4net
        private static readonly ILog Log =
              LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        // GET api/header
        public string Get()
        {

            var Referrer = "";


           var CIp=   HttpContext.Current.Request.UserHostAddress;

           var RemoteIp=          HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];

            var ForwardIp=         HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
        

            var header = Request.Headers;

            var userAgent = header.UserAgent;
            if (header.Referrer != null)
            {
                Referrer = header.Referrer.ToString();
            }
            Referrer = HttpContext.Current.Request.Headers["Referer"];
            
            var Msisdn = "";
            var Opertaor = "";


            Log.Info("userAgent:" + Environment.NewLine + userAgent);
            Log.Info("Referrer:" + Environment.NewLine + Referrer);

            Log.Info("CIP:" + Environment.NewLine + CIp);
            Log.Info("RemoteIp:" + Environment.NewLine + RemoteIp);
            Log.Info("ForwardIp:" + Environment.NewLine + ForwardIp);
           // Log.Info(id+Environment.NewLine);
            //for (int i = 0; i < header.Count(); i++)
            //{ 
            //    Log.Info(header.)
            //}

                return "value1";
        }

        // GET api/header/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/header
        public void Post([FromBody]string value)
        {
        }

        // PUT api/header/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/header/5
        public void Delete(int id)
        {
        }
    }
}
