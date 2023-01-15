using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library4._0.Classes
{
    public class IssuedBook
    {
        private long pcn { get; set; }
        private string student_name { get; set; }

        private string student_email { get; set; }
        private string book_borrowed { get; set; }
        private string date_borrowed { get; set; }

        public IssuedBook(long cPCN, string cStudentName, string cStudentEmail, string cBookBorrowed, string cDateBorrowed) {
            this.pcn = cPCN;
            this.student_name = cStudentName;
            this.student_email = cStudentEmail;
            this.book_borrowed = cBookBorrowed;
            this.date_borrowed= cDateBorrowed;
        }

        public long getPcn() { return this.pcn; }
        public string getStudentName() { return this.student_name;}
        public string getStudentEmail() { return this.student_email;}

        public string getBook_borrowed() { return this.book_borrowed;}
        public string getDate_borrowed() { return this.date_borrowed;}
    }
}
