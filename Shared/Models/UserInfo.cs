using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAssessment.Shared.Models
{
    public class UserInfo
    {
        public int UserPk { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public string Password { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordConfirm { get; set; }


        public DateTime CreationDate { get; set; }
        public long CreationDateStamp { get; set; }


        public DateTime? UpdateDate { get; set; }
        public long UpdateDateStamp { get; set; }


        public int DeleteBy { get; set; }
        public DateTime? DeleteDate { get; set; }
        public long DeleteDateStamp { get; set; }

        public bool IsAuthenticated { get; set; }
        public bool RememberMe { get; set; }
        public Dictionary<string, string> Claims { get; set; }


    }
}
