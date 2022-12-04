using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Classes
{
    public enum MeasurUnit
    { //perhaps, base should be byte?
        PerKilo,
        PerPiece
    }
    public class Food : Merchandise
    {
        readonly DateOnly expiration;
        readonly MeasurUnit measurUnit;
        public Food(string name, double price, string cOfOrigin, DateOnly packagingDate, string desription, DateOnly expir, MeasurUnit measurUnit = 0) : base(price, cOfOrigin, name, packagingDate, desription)
        {   
            if (expir < packagingDate) { expir = packagingDate; }
            expiration = expir;
            this.measurUnit = measurUnit;
        }
        public Food(Merchandise toCopy, DateOnly expir, MeasurUnit measurUnit = 0) : base(toCopy)
        {
            expiration = expir;
            this.measurUnit = measurUnit;
        }
        public override int addToGridView(DataGridView dt)
        {   
            int index = base.addToGridView(dt);
            
            dt.Rows[index].Cells[5].Value = expiration.ToString();
            dt.Rows[index].Cells[6].Value = measurUnit.ToString();
            return index;
        }
        
            
        
    }
}
