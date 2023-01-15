using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library4._0.Classes
{
    public class Student
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private long Pcn { get; set; }
        private string Email { get; set; }

        public Student(string cName, long cPcn, string cEmail)
        {
            this.Name = cName;
            this.Pcn = cPcn;
            this.Email = cEmail;
        }

        public string getName() { return this.Name;}

        public long getPcn () { return this.Pcn;}

        public string getEmail() { return this.Email;}
    }
}
