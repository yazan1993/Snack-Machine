using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnackMachine.Classes
{
     public class Calculate 
    {
        
        public double calculatePrice(string z)
        {
            SnacksCost snacksCost = new SnacksCost();
            if(z != "")
            {

             var x = Int32.Parse(z);
                if (snacksCost.snackCost.ContainsKey(x))
                {

                    return snacksCost.snackCost[x];

                }
            }
            else
            {
                MessageBox.Show("Please choose the product");
            }

           

            return 0.0;
        }
        public double calculateRestPrice(string Meal, string Coins, string Cash, double Balance)
        {
            MainPage mainPage = new MainPage();
            double price =  calculatePrice(Meal);
            double coins = 0.0;
            double cash = 0.0;
            double rest;
         
            if (Balance != 0) {
                rest = (Balance) - price;
            }
            else
            {
                if (Cash != "")
                {
                    cash = Convert.ToDouble(Cash);
                }
                if(Coins != "")
                {
                    if (Coins == "10")
                    {
                        coins = 0.1;
                    }
                    else if (Coins == "20")
                    {
                        coins = 0.2;
                    }else if (Coins == "50")
                    {
                        coins = 0.5;
                    }else if(Coins == "1")
                    {
                        coins = 1;
                    }
                    else
                    {
                        coins = 0;
                    }
                }
                    rest = (coins + cash) - price;
            }
            return rest;
        }
    }
   
}
