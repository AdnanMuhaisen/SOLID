using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    public class Book
    {
        public string Name { get; set; }

        public string AutherName {  get; set; }

        public int Year {  get; set; }

        public decimal Price {  get; set; }

        public string ISBN {  get; set; }

        public Book(string name, string autherName, int year, decimal price, string iSBN)
        {
            Name = name;
            AutherName = autherName;
            Year = year;
            Price = price;
            ISBN = iSBN;
        }
    }
}
