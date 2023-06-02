using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace iXhibitFinal
{
    class Information
    {
        public ObjectId _id { get; set; }

        public String First_Name { get; set; }

        public String Surname { get; set; }

        public String Profession { get; set; }

        public int Age { get; set; }

        public String Gender { get; set; }

        public String BirthDate { get; set; }

        public String Email { get; set; }

        public String Username { get; set; }

        public String Password { get; set; }

        public byte[] Image { get; set; }

        

        
    }
}
