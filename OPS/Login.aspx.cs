using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using System.Data;

using System.Configuration;
namespace OPS
{
    public partial class Login : System.Web.UI.Page
    {
        string HostPath = ConfigurationSettings.AppSettings["HostPath"];
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Page.Title = "BCOS Portal Login";
                txtUsername.Focus();
                if (Session["MessageNotification"] != null)
                {
                    string myStringVariable = Session["MessageNotification"].ToString();
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Duplication Login", "alert('" + myStringVariable + "');", true);
                    Session["MessageNotification"] = null;
                }
            }
        }

        protected void cmdLogin_Click(object sender, EventArgs e)
        {
            if (ErrorFree())
            {
                if (Login_function())
                {
                    Console.WriteLine("Success!");

                    // Redirect To First Default Page
                    Response.Redirect(HostPath + "/Form/Debug/frmTest.aspx");
                } else
                {
                    Console.WriteLine("Error!");
                }
            }

        }

        public bool ErrorFree()
        {
            try
            {
                if (string.IsNullOrEmpty(txtUsername.Text))
                {
                    txtErrorMsg.Text = "Username is blank";
                    txtPopupMessage.ForeColor = System.Drawing.Color.Red;
                    return false;
                }

                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    txtErrorMsg.Text = "Password is blank";
                    txtPopupMessage.ForeColor = System.Drawing.Color.Red;
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                clsLogger.ErrorLog("Login", ex);
                return false;
            }
        }

        public bool Login_function()
        {
            try
            {
                DataTable ldtChecking = new DataTable();
                //ldtChecking = clsMUser.GetDataTable_By_Username_For_Login(txtUsername.Text);

                //if (!clsFuncs.DataTableIsNotNothing(ldtChecking))
                //{
                //    txtErrorMsg.Text = "Invalid username or email, Please enter valid username or email";
                //    txtPopupMessage.ForeColor = System.Drawing.Color.Red;
                //    //Invalid login.  Please enter valid email or password."
                //    return false;
                //}

                ////if (ldtChecking.Rows[0]["loginlock"].Equals(1))
                ////{
                ////    txtErrorMsg.Text = "Your account have been locked, please check with admin to unlock your account.";
                ////    txtPopupMessage.ForeColor = System.Drawing.Color.Red;
                ////    //Invalid login.  Please enter valid email or password."
                ////    return false;
                ////}

                //string lstrPinBlock = txtPassword.Text;
                ////lstrPinBlock = clsHSM.EncryptData(txtPassword.Text);
                ////lstrPinBlock = "/J/xePyMaGPGvsTJou9Sug=="
                //DataTable ldtResult = new DataTable();
                ////ldtResult = clsMUser.GetDataTable_For_Login(txtUsername.Text, lstrPinBlock, 0);

                //if (lstrPinBlock == ldtChecking.Rows[0]["password"].ToString())
                //{
                //    Session["Username"] = ldtChecking.Rows[0]["Username"];
                //    string tmp = ldtChecking.Rows[0]["UserGroupCode"].ToString();
                //    Session["UserGroupCode"] = ldtChecking.Rows[0]["UserGroupCode"];
                //    Session["UserId"] = ldtChecking.Rows[0]["UserId"];
                //    Session["MerchantId"] = ldtChecking.Rows[0]["MerchantId"];
                //    Session["ForceChangePassword"] = ldtChecking.Rows[0]["ForceChangePassword"];
                //    string SessionId = Guid.NewGuid().ToString();
                //    Session["SessionId"] = SessionId;
                //    DataTable dtCredentail = clsMUserGroupFunction.GetAllDataTable(ldtChecking.Rows[0]["usergroupcode"].ToString(), "%");
                //    string credential = "1,1";
                //    if (clsFuncs.DataTableIsNotNothing(dtCredentail))
                //    {
                //        credential = "";
                //        for (int i = 0; i < dtCredentail.Rows.Count; i++)
                //        {
                //            credential = credential + dtCredentail.Rows[i]["functioncode"].ToString() + ",";

                //        }
                //    }
                //    Session["usergroupcode"] = ldtChecking.Rows[0]["usergroupcode"];
                //    Session["Credential"] = credential;

                //    clsMUser.update_AfterLogin(txtUsername.Text, SessionId, 1);

                //    string ipAddress = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
                //    if (string.IsNullOrEmpty(ipAddress))
                //    {
                //        ipAddress = Request.ServerVariables["REMOTE_ADDR"];
                //    }
                //    string WebBrowserName = HttpContext.Current.Request.Browser.Browser;
                //    //clsTIPTracking obj_track = new clsTIPTracking();
                //    //obj_track.TypeId = 1;
                //    //obj_track.SessionId = SessionId;
                //    //obj_track.Browser = WebBrowserName;
                //    //obj_track.IP = ipAddress;
                //    //obj_track.LastUpdateBy = Session["Username"].ToString();
                //    //clsTIPTracking.Insert(obj_track);
                //    ////Session["AccessRight"] = ldtChecking.Rows(0).Item("AccessLevel")  
                //    return true;
                //}
                //else
                //{
                //    txtErrorMsg.Text = "Invalid login.  Please enter valid email or password.";
                //    txtPopupMessage.ForeColor = System.Drawing.Color.Red;
                //    //Invalid login.  Please enter valid email or password."
                //    return false;
                //}

            }
            catch (Exception ex)
            {
                clsLogger.ErrorLog("Login", ex);
                return false;
            }

            return false;

        }


        protected void cmdForgotPassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("ResetPassword.aspx");
        }
    }
}