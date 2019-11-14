using System;
using System.Collections.Generic;
using System.Text;

namespace Ex01_TrelloApp.Models
{
    public class TrelloMember
    {
        //full name ('FullName'), de username ('UserName') en de avatar hash ('AvatarImg')
        public String FullName { get; set; }
        public String UserName { get; set; }
        public String gravatarHash { get; set; }
    }
}
