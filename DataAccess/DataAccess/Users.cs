using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;

namespace DataAccess.DataAccess
{
   public class Users
    {
        GsuEventsDBEntities g = new GsuEventsDBEntities();

        public UserModel SaveUsers(UserModel model)
        {


            var um = new UserModel
            {
                UMessage = "Success Please proceed for login",
                UFlag = false,

            };
            try
            {
                var usr = g.UserTables.Where(s => s.UserName == model.UserName).FirstOrDefault();

                var usersObj = new UserTable();

                usersObj.UserPassword = model.UserPassword;
                usersObj.UserName = model.UserName;
                usersObj.UserEmail = model.UserEmail;
                usersObj.UserPhoneNumber = model.UserPhoneNumber;
                usersObj.isActive = "Y";
                usersObj.UserTypeID = 1;
                usersObj.isDelete = 0;
                usersObj.CreatedDate = DateTime.Now;
                usersObj.ModifiedDate = DateTime.Now;
                g.UserTables.Add(usersObj);

                var ema = new System.Net.Mail.MailAddress(model.UserEmail);
                if (model.UserPassword.Length < 6)
                {
                    um.UMessage = "Password Should be at least 6 Characters long";
                    um.UFlag = false;
                    return um;
                }
                if (ema == null)
                {
                    um.UMessage = "Please Check you Email";
                    um.UFlag = false;
                    return um;
                }

                if (usr == null)
                {
                    g.SaveChanges();
                    um.UFlag = true;
                }
                else
                {
                    um.UMessage = "Username/Email already Exists";
                }

            }
            catch (Exception ex)
            {
                um.UMessage = ex.Message;

            }
            return um;
        }
        public UserModel UserLogin(UserModel model)
        {
            var um = new UserModel
            {
                UMessage = "Success",
                UFlag = false,
                ReturnUrl = ""
            };
            try
            {
                var usr = g.UserTables.Where(s => s.UserName == model.UserName).FirstOrDefault();

                if (usr != null && usr.UserPassword == model.UserPassword)
                {
                    um.UserTypeID = usr.UserTypeID;
                    um.UserID = usr.UserID;
                    um.isDelete = usr.isDelete;
                    um.UFlag = true;
                }
                if (um.isDelete == 1)
                {
                    um.UMessage = "ID Deleted Contact Admin";
                    um.UFlag = false;
                }
                else
                {
                    um.UMessage = "Unable to Login!!";
                }
            }
            catch (Exception ex)
            {
                um.UMessage = ex.Message;
            }
            return um;
        }
    }
}
