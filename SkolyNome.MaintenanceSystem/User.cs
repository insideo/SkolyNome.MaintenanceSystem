using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace SkolyNome.MaintenanceSystem
{  
    /// <summary>
    /// Base class for user's data
    /// </summary>
    public enum Role
    {
        user = 0,
        superUser = 1,
        admin = 2
    }
    public enum Status
    {
        active = 0,
        inactive = 1,
        suspended = 2
    }
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } //Normalne se password neuklada, jen se rychle spocita hash a ten se ulozi, porovnani pak jen ve funkci
        public string UserName { get; private set; } //Must be unique
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public Role UserRole { get; set; }
        public Status Status { get; set; }

        public DateTime LastAccess { get; private set; }

        //Methods
        public User CreateCopy()
        {
            return new User { FirstName = this.FirstName, LastName = this.LastName, UserName = this.UserName + "_",   Email = this.Email, UserRole = this.UserRole };
        }
        public override string ToString()
        {
            return "User = " + FirstName + " " + LastName + ",UserName = " + UserName + ", role =" + UserRole;
        }
        public void ChangeUserName(string userName)
        {
            //Tady by mela byt kontrola v db nebo jinde ulozenych data jestli username uz neexistuje
            if (IsUserNameAvailable(userName))
            {
                this.UserName = userName;
            }
            else
            {
                throw new Exception("User Name is not available.");
            }   
        }
        public bool IsUserNameAvailable(string userName)
        {
            return true;
        }




    }
}
