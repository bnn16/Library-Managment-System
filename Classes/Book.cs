using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace library4._0.Classes
{
    public class Book
    {
        public int BookId { get; set; }
        private string BookTitle { get; set; }
        private string BookAuthor { get; set; }
        private string BookGenre { get; set; }
        private int BookPages { get; set; }

        private long BookISBN { get; set; }
        private string BookDateTime { get; set; }

        private string BookDescription { get; set; }
        
        private int BookQuantity { get; set; }

        //private List<BorrowerList> borrowers = new List<BorrowerList>();

        public Book(string cTitle, string cAuthor, string cGenre, int cPages, long cISBN, string cDateTime, string cDescr, int bookQuantity)
        {

            this.BookTitle = cTitle;
            this.BookAuthor = cAuthor;
            this.BookGenre = cGenre;
            this.BookPages = cPages;
            this.BookISBN = cISBN;
            this.BookDateTime = cDateTime;
            this.BookDescription = cDescr;
            this.BookQuantity = bookQuantity;
        }

        public string getTitle()
        {
            return this.BookTitle;
        }
        public string getAuthor()
        {
            return this.BookAuthor;
        }
        public string getGenre()
        {
            return this.BookGenre;
        }
        public int getPages()
        {
            return this.BookPages;
        }
        public long getISBN()
        {
            return this.BookISBN;
        }
        public string getDate() 
        { 
            return this.BookDateTime;
        }
        public string getDesc() { 
            return this.BookDescription;
        }

        public int getBookQuantity() {
            return this.BookQuantity;
        }
    }
    }

