using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL
{
    public class clsConst
    {
        public static bool const_Live = true;
        public static string SysDBConnString()
        {
            string DbHost = "47.254.229.107";
            string DbName = "TestingDB";
            string DbUsername = "sa";
            string DbPassword = "Nomoneynotalk88!";

            string DBConn = $"data source={DbHost};initial catalog={DbName};user id={DbUsername};password={DbPassword}";

            //if (const_Live)
            //{
            //    DBConn = "data source=47.254.229.107;initial catalog=windgrab;user id=sa; password=Nomoneynotalk88!";

            //}
            //else
            //    DBConn = "data source=47.254.229.107;initial catalog=windgrab;user id=sa; password=Nomoneynotalk88!";

            return DBConn;
        }

        #region ResponseCode
        public const string const_ResponseCode_Successful = "00";
        public const string const_ResponseCode_Posted = "01";
        public const string const_ResponseCode_API_Duplicate_Transaction = "11";
        public const string const_ResponseCode_API_SignatureVerification_Fail = "10";
        public const string const_ResponseCode_GenerateCode_Error = "97";
        public const string const_ResponseCode_Invalid_Application_Data = "98";
        public const string const_ResponseCode_SystemError = "99";
        public const string const_Response_Code_API_Application_No_Found = "001001";
        public const string const_Response_Code_API_SignatureVerification_Fail = "001002";
        public const string const_Response_Code_API_MissingInformation = "001003";
        public const string const_Response_Code_Invalid_MobileNo = "001004";
        public const string const_Response_Code_Invalid_AIMeasurement = "001005";
        public const string const_Response_Code_ImageFileError = "00106";
        public const string const_Response_Code_InvalidAddress = "00107";
        public const string const_Response_Code_PaymentError = "00108";
        public const string const_Response_Code_ReferralCode_Invalid = "002011";
        public const string const_Response_Code_ReferralCode_CannotBeSelf = "002012";
        public const string const_Response_Code_ReferralCode_HaveBeenEnter = "002013";
        #endregion


        public static string Url_Header = "";
        public static string THEME_PATH = "/Content/Images";
        public static string SELFIE_PATH = "/Selfie";
        public static string AUDIO_PATH = "/Content/Audio";
        public static string AUDIO_II_PATH = "/Audio";
        public static string TMP_PATH = "/Trash";



        #region Parameter
        public static int TransactionType_Product_Selling = 1;
        public static int TransactionType_Product_Redeem = 2;
        public static int CampaignType_WelcomeGift = 1;
        #endregion



        #region "Key Field"
        public const string const_Key_Field_ResponseCode = "ResponseCode";
        #endregion
 
        public static string SessionExpired = "/logout.aspx";
        public const double constTrx_MinAmount = 0.0;
        public const double constTrx_MaxAmount = 99999999999.99;
        public const string constDate_DateFmt = "yyyy-MM-dd";
        public const string constDate_DateCulture = "en-CA";
        public const string constDate_DateTimeFmt = "yyyy-MM-dd HH:mm:ss";
        public static string const_DateTime_Format_001 = "yyyy-MM-dd hh:mm:ss";
        public const string constDate_DateTimeFmt_Agent = "MM/dd/yyyy HH:mm:ss tt";
        public const string constDate_SQLDateFmt = "yyyy-MM-dd HH:mm:ss";
        public const string constDate_MinDate = "1900-01-01";
        public const string constDate_MaxDate = "9999-12-31";

        public const int const_Terminal_log_Request = 1;
        public const int const_Terminal_log_Response = 2;

        public const string const_Content_Type_Text = "application/text";

        public const int constPassword_MinLength = 6;
        public const string constSystemDefault_Language = "System";
        public const string constSessionID_LanguageCode = "languagecode";
        public const int constSQLCommandTimeout = 6000000;
        public const string constEmpty_GUID = "00000000-0000-0000-0000-000000000000";

         

    }
}