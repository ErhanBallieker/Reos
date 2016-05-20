using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reos.App.Model.User
{
    public class User
    {
        public User()
        {

        }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string ProfilePictureUrl { get; set; }

        public string FullName { get { return $"{Name} {LastName}"; } }
    }
}
