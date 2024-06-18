using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;

namespace DAL
{
    public class clsFuncs
    {
        public static string GetCurrentDateTime()
        {
            return  DateTime.Now.ToString(clsConst.constDate_SQLDateFmt);
            }

        public static string GetUnixTimestamp()
        {
            string result = "";

            try
            {
                result = (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds.ToString();
                result = (result.Replace(".", "")).Substring(0, 10);
            }
            catch (Exception ex)
            {
                result = "0000";
            }

            return result;
        }

        public static long genTS()
        {
            long res = 0;
            DateTime dt1970 = new DateTime(1970, 1, 1);
            DateTime current = DateTime.Now; //DateTime.UtcNow for unix timestamp
            TimeSpan span = current - dt1970;
            res = Convert.ToInt64(span.TotalMilliseconds);
            return res;
        }

        public static string SerializeJObj(JObject jobj)
        {
            string res = "";
            try
            {
                res = JsonConvert.SerializeObject(jobj);
            }
            catch (Exception ex)
            {
                clsLogger.ErrorLog("SerializeJObj", ex);
            }

            return res;
        }

        public static string SerializeDt(DataTable dt)
        {
            string res = "";
            try
            {
                res = JsonConvert.SerializeObject(dt);
            }
            catch (Exception ex)
            {
                clsLogger.ErrorLog("SerializeDt", ex);
            }

            return res;
        }

        public static JObject GenJObj(string data)
        {
            JObject res = new JObject();
            try
            {
                res = JObject.Parse(data);
            }
            catch (Exception ex)
            {
                clsLogger.ErrorLog("GenJObj", ex);
            }

            return res;
        }


        public static string ConvertObjToJSon(object obj)
        {
            try
            {
                string s = "";
                s = JsonConvert.SerializeObject(obj);
                return s;
            }
            catch (Exception ex)
            {
                clsLogger.ErrorLog("ConvertobjToJSon: ", ex);
            }
            return "";
        }

        public static string GetJsonNode(string sMessage, string NodeName)
        {
            string result = "";

            try
            {
                JObject json = new JObject();
                json = JObject.Parse(sMessage);
                result = json[NodeName].ToString();
            }
            catch (Exception ex)
            {
                //logger.Error("GetJsonNode", ex)
            }
            return result;
        }

        public static string GetJsonNode(JObject json, string key)
        {
            string res = "";

            try
            {
                res = json[key].ToString();
            }
            catch (Exception ex)
            {
                clsLogger.ErrorLog("GetJsonNode", ex);
            }

            return res;
        }

        public static string GetJsonNodeFromJobj(JObject jobj, string NodeName)
        {
            string result = "";
            try
            {
                result = jobj[NodeName].ToString();
            }
            catch (Exception ex)
            {
                clsLogger.ErrorLog("GetJsonNodeFromJobj-" + NodeName, ex);
            }
            return result;
        }
        public static JArray ConvertJSonToJObj(string Message)
        {
            try
            {
                //JObject jobj = new JObject();
                //jobj = JObject.Parse(Message);
                JArray a = JArray.Parse(Message);
                return a;
                //foreach (JObject o in a.Children<JObject>())
                //{
                //    foreach (JProperty p in o.Properties())
                //    {
                //        string name = p.Name;
                //        string value = (string)p.Value; 
                //    }
                //}
                //object obj;
                //obj = JsonConvert.DeserializeObject(Message);
                //return (JObject)JToken.FromObject(obj); 
            }
            catch (Exception ex)
            {
                clsLogger.ErrorLog("ConvertJSonToJObj", ex);
            }

            return null;
        }
        public static string ConvertDataTableToJSon(DataTable ldtResult)
        {
            try
            {
                string s = "";
                s = JsonConvert.SerializeObject(ldtResult);
                //s = JsonConvert.SerializeObject(ldtResult).Replace("\\\"", ""); 
                //s = s.Replace("\\","");
                return s;
            }
            catch (Exception ex)
            {
                clsLogger.ErrorLog("ConvertDataTableToJSon", ex);
            }
            return "";
        }

        public static bool DataTableIsNotNothing(DataTable dt)
        {
            bool flag = false;
            try
            {
                if (dt != null)
                {
                    flag = dt.Rows.Count > 0;
                }
            }
            catch (Exception ex)
            {
                clsLogger.ErrorLog("DataTableIsNotNothing", ex);
            }

            return flag;
        }

        public static bool ValidatePhoneNum(string str)
        {
            string rgx = @"60\d{8,9}";

            return Regex.IsMatch(str, rgx);
        }

        public static string TrimStr(string str)
        {
            return (str == null) ? "" : str.Trim('"');
        }
         

        public static void SendSMS(string MobileNo, string Content)
        {
            string API = "http://cloudsms.trio-mobile.com/index.php/api/bulk_mt?api_key=b7d6b2ffc42a496291aa448be2d633024997fe845a23a6952f0fb6eb41936230&action=send&to=[MOBILENO]&msg=[MESSAGE]&sender_id=CLOUDSMS&content_type=1&mode=shortcode";
            try
            {
                API = API.Replace("[MOBILENO]", MobileNo).Replace("[MESSAGE]", Content);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(API);
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    string reply = reader.ReadToEnd();
                    clsLogger.InfoLog(reply);
                }
            }
            catch (Exception ex)
            {

            }
        }

         
        public static JObject SortingJson(string json)
        {
            JObject obj = new JObject();
            obj = JObject.Parse(json);


            var sortedObj = new JObject(
                obj.Properties().OrderBy(p => (string)p.Name)
            );

            return sortedObj;
        }

    }
}