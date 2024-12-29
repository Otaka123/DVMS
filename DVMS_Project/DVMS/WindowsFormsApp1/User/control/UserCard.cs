using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
        public partial class UserCard : UserControl
        {
            private int _userIID;
            private bool isUserInfoLoaded = false;

            public UserCard()
            {
                InitializeComponent();
            }

            public int userIID
            {
                get { return _userIID; }
                set
                {
                    if (_userIID != value)
                    {
                        _userIID = value;
                        isUserInfoLoaded = false; // تحديد أن البيانات بحاجة لإعادة تحميل
                    }
                }
            }

            public void LoadUserInfo()
            {
                // تحميل البيانات فقط إذا لم تكن محملة بعد
                if (!isUserInfoLoaded && _userIID > 0)
                {
                    clsUser user = clsUser.Find(_userIID);
                    if (user != null)
                    {
                        personCard1.loadinfo(user.PersonID);
                        lbUserId.Text = user.UserID.ToString();
                        lbUserName.Text = user.UserName.ToString();
                        lbIsActive.Text = user.IsActive ? "Yes" : "NO";
                        isUserInfoLoaded = true; // تحديد أن البيانات محملة الآن
                    }
                    else
                    {
                        MessageBox.Show("تأكد من UserID");
                    }
                }
            }
        }
        
       
    
}
