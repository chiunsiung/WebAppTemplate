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
    public partial class ResetPassword : System.Web.UI.Page
    {
        string Message = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cmdResetPassword_Click(object sender, EventArgs e)
        {
            txtErrorMsg.Text = "";
            try
            {
                if (txtUsername.Text != "")
                {
                    ResetPassword_Function();
                }
            }
            catch (Exception ex)
            {
                clsLogger.ErrorLog("Reset Password", ex);
            }
        }

        private bool ResetPassword_Function()
        {
            try
            {
                DataTable dt = new DataTable();
                //dt = clsMUser.GetDataTable_By_Username(txtUsername.Text);
                //if (clsFuncs.DataTableIsNotNothing(dt))
                //{
                //    Random rnd = new Random();
                //    //string SE = rnd.Next(10000000, 99999999).ToString();
                //    string PINBlock = "", Password = "";
                //    if (clsHSM.GeneratePassword(ref PINBlock, ref Password))
                //    {


                //        string Body = ConfigurationSettings.AppSettings["body_ResetPassowrd"];
                //        if (clsMUser.Update_Password(txtUsername.Text, PINBlock, "ResetPassword", 0))
                //        {
                //            Body = Body.Replace("[PASSWORD]", Password);
                //            clsMail.SendMail("VMS OPS Password Reset", Body, dt.Rows[0]["Email"].ToString(), "", "", null);
                //            Message = "Successful reset Password.";
                //            txtErrorMsg.Text = Message;
                //            txtErrorMsg.ForeColor = System.Drawing.Color.Green;

                //        }
                //        else
                //        {
                //            Message = "Fail reset Password.";
                //            txtErrorMsg.Text = Message;
                //            txtErrorMsg.ForeColor = System.Drawing.Color.Red;

                //        }
                //    }
                //    else
                //    {
                //        Message = "Fail reset Password.";
                //        txtErrorMsg.Text = Message;
                //        txtErrorMsg.ForeColor = System.Drawing.Color.Red;

                //    }
                //}
                //else
                //{
                //    Message = "Fail reset Password.";
                //    txtErrorMsg.Text = Message;
                //    txtErrorMsg.ForeColor = System.Drawing.Color.Red;

                //}
            }
            catch (Exception ex)
            {
                clsLogger.ErrorLog("Reset Password", ex);
            }
            return false;
        }

    }
}