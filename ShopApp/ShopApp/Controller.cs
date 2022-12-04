using ShopApp.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ShopApp
{
    public enum State
    { 
        Food = 0,
        Book = 1
    }
    internal class Controller
    {   
        private State curState;
        private DataGridView dt;
        private List<Merchandise> merchandises = new();
        public Controller(DataGridView dt, int state = 0)//name,price,cOfOrigin,packaging date,decription,
        {
            if(dt == null)
            {
                throw new ArgumentNullException("dt = null");
            }
            this.dt = dt;
            this.curState = (State)state;
        }

        public string ChangeStatus()
        {
            if (curState == State.Food)
            {
                curState = State.Book;
            }
            else
            {
                curState = State.Food;
            }
            
            return curState.ToString();
        }
        private Merchandise CreateNewMerch(string[] merch_data_str)
        {
            Merchandise newMerch;
            double price;
            DateOnly packaged;
            string name = merch_data_str[0];
            string price_str = merch_data_str[1];
            string country = merch_data_str[2];
            string packaged_str = merch_data_str[3];
            string decribtion = merch_data_str[4];
            string addInfo1_str = merch_data_str[5];
            string addInfo2_str = merch_data_str[6];
            string addInfo3_str = merch_data_str[7];

            if (!double.TryParse(price_str, out price))//string name, double price, string countryOrigin, DateOnly packagingDate, string desription, int pages, string publisher, List<string> autours
            {
                return null;
            }
            
            if (!DateOnly.TryParse(packaged_str, out packaged))
            {
                return null;
            }

            if (curState == State.Food)
            {
                MeasurUnit measurUnit; 
                DateOnly expireDate;

                if (!DateOnly.TryParse(addInfo1_str, out expireDate)) 
                {
                    return null;
                }
                if (!MeasurUnit.TryParse(addInfo2_str, out measurUnit))
                {
                    return null;
                }

                newMerch =  new Food(name, price, country, packaged, decribtion, expireDate, measurUnit);
            }
            else if(curState == State.Book)
            {
                int pages;

                if(!int.TryParse(addInfo1_str, out pages)){
                    return null;
                }
                 //make smt with it!

                newMerch = new Book(name, price, country, packaged, decribtion, pages, addInfo2_str, addInfo3_str); 
            }
            else{  throw new ArgumentException("curState has no right value");  }

            
            merchandises.Add(newMerch);

            return newMerch;
        }
        public void AddNewGrid(string[] merch_data_str)
        {
            Merchandise newMerch;
            newMerch = CreateNewMerch(merch_data_str);
            
            if (newMerch == null)
            {
                MessageBox.Show("Wrong input");//should we show messagebox in create function? just to be able to print what exactly was wrong
            }
            else
            {
                newMerch.addToGridView(dt);
            }
            //here it will check whether value in textBoxes are good //if not - through a messagebox 
            //than it will call createNewMerch
            
        }

        public static void EnterChange(TextBox ToChnage, string backgroundText)
        {
            if (ToChnage.Text == backgroundText)
            {
                ToChnage.Text = "";

                ToChnage.ForeColor = Color.Black;
            }

        }

        public static void LeaveChange(TextBox ToChnage, string backgroundText)
        {
            if (ToChnage.Text == "")
            {
                ToChnage.Text = backgroundText;
                ToChnage.ForeColor = Color.Silver;
            }
        }
        public int GetState()
        {
            return (int) curState;
        }
        public void LeaveChange(TextBox toChange, string[] sringArr)
        {
            LeaveChange(toChange, sringArr[GetState()]);
        }
        public void EnterChange(TextBox ToChnage, string[] sringArr)
        {
            EnterChange(ToChnage, sringArr[GetState()]);
        }

        public void DeleteMerch(int index)
        {
            MessageBox.Show(index.ToString());
            merchandises.RemoveAt(index);// will trash collector grab it after? 
        }
    }
}
