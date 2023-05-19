using System.Collections.Generic;
using System.Security.Policy;


namespace CW.Data
{
    public class Member
    {

        public int Id { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public string Role { get; set; }
        public Member() { }

    }
}
