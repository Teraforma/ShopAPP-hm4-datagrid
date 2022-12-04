using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Classes
{
    public class Book : Merchandise
    {
        readonly int pages;
        readonly string publisher;
        readonly string autours;

        public Book(string name, double price, string countryOrigin, DateOnly packagingDate, string desription, int pages, string publisher, string autours) : base(price, countryOrigin, name, packagingDate, desription)
        {//this looks terrible

            if (pages < 0) { pages = 0; }
            this.autours = autours;//should it be deepcopy?
            this.pages = pages;
            this.publisher = publisher;
        }
        public Book(Merchandise toCopy, int pages, string publisher, string autours) : base(toCopy)
        {   
            this.autours = autours;
            this.pages = pages;
            this.publisher = publisher;
        }
        public override int addToGridView(DataGridView dt)
        {
            int index = base.addToGridView(dt);
            dt.Rows[index].Cells[5].Value = pages.ToString();
            dt.Rows[index].Cells[6].Value = publisher;
            dt.Rows[index].Cells[7].Value = autours.ToString();
            return index;
        }
    }
}
