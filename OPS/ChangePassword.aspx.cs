using DAL;
using System;
using System.Data;
using System.Text.RegularExpressions;

namespace OPS
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        private string fstrPageName = "Change Password";
        private string Message = "";





        protected void Page_Load(object sender, System.EventArgs e)
        {
            try
            {
                if (clsCommon.IsNotNothing(Session["ForceChangePassword"]))
                {
                    if (Session["ForceChangePassword"].ToString() == "2")
                        txtFirstTimeLogin.Visible = true;
                    else
                        txtFirstTimeLogin.Visible = false;
                }

            }
            catch (Exception ex)
            {
                clsLogger.ErrorLog(fstrPageName + ":  Page_Load", ex);
            }
        }

        protected void cmdChangePassword_Click(object sender, EventArgs e)
        {
            if (ErrorFree())
            {
                if (RecordSaved())
                {
                    txtMessage.Text = "Password have been changed successfully.";
                    txtMessage.ForeColor = System.Drawing.Color.Green;

                    Session["ForceChangePassword"] = 1;
                }
                else
                {
                    txtMessage.Text = Message;
                    txtMessage.ForeColor = System.Drawing.Color.Red;
                    txtPopupMessage.Text = txtMessage.Text;
                    txtPopupMessage.ForeColor = System.Drawing.Color.Red;
                    pcMain.ShowOnPageLoad = true;
                }
            }
            else
            {
                txtMessage.Text = Message;
                txtMessage.ForeColor = System.Drawing.Color.Red;
                txtPopupMessage.Text = txtMessage.Text;
                txtPopupMessage.ForeColor = System.Drawing.Color.Red;
                pcMain.ShowOnPageLoad = true;
            }

        }


        private bool RecordSaved()
        {
            try
            {

                DataTable ldtResult = new DataTable();
                //ldtResult = clsMUser.GetDataTable_By_Username(Session["Username"].ToString());
                //if (clsFuncs.DataTableIsNotNothing(ldtResult))
                //{
                //    string PINBlock = clsHSM.EncryptData(txtOldPassword.Text);
                //    if (ldtResult.Rows[0]["Password"].Equals(PINBlock))
                //    {
                //        string NewPassword = clsHSM.EncryptData(txtNewPassword.Text);
                //        if (clsMUser.Update_Password(Session["Username"].ToString(), NewPassword, Session["Username"].ToString(), 1))
                //        {
                //            Message = "Successful Change Password.";
                //            Session["ForceChangePassword"] = 1;
                //            return true;
                //        }
                //        else
                //        {
                //            Message = "Fail Change Password";
                //            return false;
                //        }
                //    }
                //    else
                //    {
                //        Message = "Invalid Password";
                //        return false;
                //    }
                //}
            }

            catch (Exception ex)
            {
                clsLogger.ErrorLog(fstrPageName + ":  RecordSaved", ex);
            }
            return false;
        }

        private bool ErrorFree()
        {
            try
            {
                if (txtOldPassword.Text == "")
                {
                    Message = "Old password cannot be empty.";
                    return false;
                }
                var input = txtNewPassword.Text;

                var hasNumber = new Regex(@"[0-9]+");
                var hasUpperChar = new Regex(@"[A-Z]+");
                var hasMinimum8Chars = new Regex(@".{8,}");

                var isValidated = hasNumber.IsMatch(input) && hasUpperChar.IsMatch(input) && input.Length>=8;
                if (!isValidated)
                {

                    Message = "Password must be 8 characters including 1 uppercase letter, 1 special character, alphanumeric characters";
                    return false;
                }
                //if (txtNewPassword.Text == "")
                //{
                //    Message = "New password cannot be empty";
                //    return false;
                //}

                //if (txtNewPassword.Text.Length < 6)
                //{
                //    Message = "Password cannot less than 6 character.";
                //    return false;
                //}
                if (txtRetypeNewPassword.Text == "")
                {
                    Message = "Retype new password cannot be blank.";
                    return false;
                }
                if (txtNewPassword.Text != txtRetypeNewPassword.Text)
                {
                    Message = "Passwords don't match";
                    return false;
                }


                return true;
            }
            catch (Exception ex)
            {
                clsLogger.ErrorLog(fstrPageName + ":  ErrorFree", ex);
            }
            return false;
        }

        protected void cmdReset_Click(object sender, EventArgs e)
        {
            txtOldPassword.Text = "";
            txtNewPassword.Text = "";
            txtRetypeNewPassword.Text = "";
        }
    }
}