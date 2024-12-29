using dataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class clsUser
    {
        public enum enMode { AddNew=0, Update=1};
        private enMode _Mode = enMode.AddNew;
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName {  get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public clsUser()
        {
            UserID = -1;
            PersonID = -1;
            UserName = "";
            Password = "";
            IsActive=false;
        }
        private clsUser(int G_UserID,int G_personID,string G_UserName,string G_Password,bool G_IsActive)
        {

            UserID   = G_UserID;
            PersonID = G_personID;
            UserName = G_UserName;
            Password = G_Password;
            IsActive = G_IsActive;
            _Mode=enMode.Update;

        }
        public static int GetUserIdByUserName(string UserName)
        {
            return clsUserDataAccess.GetUserID(UserName);
        }
        public bool Delete()
        {
            return clsUserDataAccess.DeleteUser(this.UserID);
        }
        private bool _UpdateUser()
        {
            return clsUserDataAccess.UpdateUser(this.UserID,this.PersonID,this.UserName,this.Password,this.IsActive);
        }
        private bool _AddNewUser()
        {
            this.UserID=clsUserDataAccess.AddNewUser(this.PersonID,this.UserName,this.Password,this.IsActive);
            return (this.UserID>0);
        }
        public static DataTable GetAllUsers()
        {
            return clsUserDataAccess.GetAllUsers();
        }
        public static bool ISExist(int personID)
        {
            return clsUserDataAccess.IsExist(personID);
        }
        public static clsUser Find(int G_UserID)
        {
            int G_personID=-1;
            string G_UserName = "";
            string G_password = "";
            bool G_IsActive =false ;
            if(clsUserDataAccess.GetUserByUserID(G_UserID,ref G_personID,ref G_UserName,ref G_password,ref G_IsActive))
            {
                clsUser UserInfo = new clsUser(G_UserID, G_personID, G_UserName, G_password, G_IsActive);
                return UserInfo;
            }
            else
            {
                return null;
            }
        }
        public static clsUser Get(string G_UserName,string G_password)
        {
            int G_UserID = -1;
            int G_personID = -1;
            bool G_IsActive =false ;
            if (clsUserDataAccess.IsExistByUserName_Password(G_UserName, G_password, ref G_UserID, ref G_personID, ref G_IsActive))
            {
                clsUser UserInfo = new clsUser(G_UserID, G_personID, G_UserName, G_password, G_IsActive);
                return UserInfo;
            }
            else
                { return null; }
        }

        public static bool IsExist(string UserName)
        {
            return clsUserDataAccess.IsExist(UserName);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                       _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateUser();


            }
            return false;
        }
    }
}
