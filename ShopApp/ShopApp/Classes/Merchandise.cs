using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp.Classes
{
    public abstract class Merchandise 
    {
        double price;
        protected readonly string cOfOrigin;
        protected string name;
        protected readonly DateOnly packagingDate;
        protected string desription;
        public Merchandise(double price, string countryOrigin, string name, DateOnly packagingDate, string desription)
        {
            if (price < 0) { price = 0; }
            this.price = price;
            cOfOrigin = countryOrigin;
            this.name = name;
            this.packagingDate = packagingDate;
            this.desription = desription;
        }
        protected Merchandise(Merchandise toCopy)
        {
            price = toCopy.price;
            cOfOrigin = toCopy.cOfOrigin;
            name = toCopy.name;
            packagingDate = toCopy.packagingDate;
            desription = toCopy.desription;

        }
        //public int addBaseToGrid(DataGridView dt )
        
        public virtual int  addToGridView(DataGridView dt)
        {
            int index = dt.Rows.Add();
            dt.Rows[index].Cells[0].Value = name;
            dt.Rows[index].Cells[1].Value = price.ToString();
            dt.Rows[index].Cells[2].Value = cOfOrigin;
            dt.Rows[index].Cells[3].Value = packagingDate.ToString();
            dt.Rows[index].Cells[4].Value = desription;
            return index;
        }
        
    }
}
