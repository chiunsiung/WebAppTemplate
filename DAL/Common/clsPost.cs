using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace DAL
{
    public class clsPost
    {
        public static string sendByBrowser(string url, bool isPost = false, bool isSecured = false, string AuthorizationHeader = "", string bodyContent = "", string contentType = "")
        {
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            StreamReader reader = null;
            string reply_text = null;
            //Flag for secured connection 
            try
            {
                clsLogger.InfoLog($"URL: {url}");
                clsLogger.InfoLog("Request: " + bodyContent);
                ServicePointManager.MaxServicePointIdleTime = 1000;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                //ServicePointManager.ServerCertificateValidationCallback = Nothing

                request = (HttpWebRequest)WebRequest.Create(url);
                if (!string.IsNullOrEmpty(AuthorizationHeader))
                {
                    //Add the authorization header
                    request.Headers.Add("Authorization", AuthorizationHeader);
                }
                //Flag to determine whether it's HTTP POST or GET, GET by default
                if (isPost)
                {
                    request.Method = WebRequestMethods.Http.Post;

                    //request.ContentLength = bodyContent.Length;

                    //Check for content type
                    if (!string.IsNullOrEmpty(contentType))
                    {
                        request.ContentType = contentType;
                    }
                    //Check for body content
                    if (!string.IsNullOrEmpty(bodyContent))
                    {
                        using (StreamWriter sw = new StreamWriter(request.GetRequestStream()))
                        {
                            sw.Write(bodyContent);
                            sw.Flush();
                        }
                    }
                }
                else
                {
                    request.Method = WebRequestMethods.Http.Get;
                }

                try
                {
                    response = (HttpWebResponse)request.GetResponse();
                    reader = new StreamReader(response.GetResponseStream());
                    reply_text = reader.ReadToEnd();
                }
                catch (WebException ex)
                {
                    using (WebResponse response1 = ex.Response)
                    {
                        var httpResponse = (HttpWebResponse)response1;

                        using (Stream data = response1.GetResponseStream())
                        {
                            StreamReader sr = new StreamReader(data);
                            reply_text = sr.ReadToEnd();
                        }
                    }
                }
                catch (Exception)
                {

                    throw;
                }

            }

            catch (Exception ex)
            {
                reply_text = ex.Message;
            }
            clsLogger.InfoLog("Reply: " + reply_text);
            return reply_text;
        }
    }
}