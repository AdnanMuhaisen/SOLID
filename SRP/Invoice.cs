using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    public class Invoice
    {
        public Book _book;
        public int _quantity;
        public double _discountRate;
        public double _taxRate;
        public double _total;

        public Invoice(Book book, int quantity, double discountRate, double taxRate, double total)
        {
            _book = book;
            _quantity = quantity;
            _discountRate = discountRate;
            _taxRate = taxRate;
            _total = total;
        }
    }
}
