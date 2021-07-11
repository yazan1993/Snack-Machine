using SnackMachine.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnackMachine
{
    public partial class MainPage : Form
    {
        public int count = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        public void btn1_Click(object sender, EventArgs e)
        {
       
           if (count == 0)
            {
                if(txtMeal.Text.Length < 2)
                {

                txtMeal.Text += "1";
                }
                else
                {
                    MessageBox.Show("Can not enter more than two digits !!");
                }

                

            }
            else if (count == 1)
            {
                    txtCoins.Text += "1";

            }
            else
            {
                txtCash.Text += "1";
            }
       


        }


        public void btn2_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                if (txtMeal.Text.Length < 2)
                {

                    txtMeal.Text += "2";
                }
                else
                {
                    MessageBox.Show("Can not enter more than two digits !!");
                }



            }
            else if (count == 1)
            {
                txtCoins.Text += "2";

            }
            else
            {
                txtCash.Text += "2";
            }

        }

        public void btn3_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                if (txtMeal.Text.Length < 2)
                {

                    txtMeal.Text += "3";
                }
                else
                {
                    MessageBox.Show("Can not enter more than two digits !!");
                }



            }
            else if (count == 1)
            {
                txtCoins.Text += "3";

            }
            else
            {
                txtCash.Text += "3";
            }

        }

        public void btn4_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                if (txtMeal.Text.Length < 2)
                {

                    txtMeal.Text += "4";
                }
                else
                {
                    MessageBox.Show("Can not enter more than two digits !!");
                }



            }
            else if (count == 1)
            {
                txtCoins.Text += "4";

            }
            else
            {
                txtCash.Text += "4";
            }
        }

        public void btn5_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                if (txtMeal.Text.Length < 2)
                {

                    txtMeal.Text += "5";
                }
                else
                {
                    MessageBox.Show("Can not enter more than two digits !!");
                }



            }
            else if (count == 1)
            {
                txtCoins.Text += "5";

            }
            else
            {
                txtCash.Text += "5";
            }
        }

        public void btn6_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                if (txtMeal.Text.Length < 2)
                {

                    txtMeal.Text += "6";
                }
                else
                {
                    MessageBox.Show("Can not enter more than two digits !!");
                }



            }
            else if (count == 1)
            {
                txtCoins.Text += "6";

            }
            else
            {
                txtCash.Text += "6";
            }

        }

        public void btn7_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                if (txtMeal.Text.Length < 2)
                {

                    txtMeal.Text += "7";
                }
                else
                {
                    MessageBox.Show("Can not enter more than two digits !!");
                }



            }
            else if (count == 1)
            {
                txtCoins.Text += "7";

            }
            else
            {
                txtCash.Text += "7";
            }
        }

        public void btn8_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                if (txtMeal.Text.Length < 2)
                {

                    txtMeal.Text += "8";
                }
                else
                {
                    MessageBox.Show("Can not enter more than two digits !!");
                }



            }
            else if (count == 1)
            {
                txtCoins.Text += "8";

            }
            else
            {
                txtCash.Text += "8";
            }

        }

        public void btn9_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                if (txtMeal.Text.Length < 2)
                {

                    txtMeal.Text += "9";
                }
                else
                {
                    MessageBox.Show("Can not enter more than two digits !!");
                }



            }
            else if (count == 1)
            {
                txtCoins.Text += "9";

            }
            else
            {
                txtCash.Text += "9";
            }
        }

        public void btnDot_Click(object sender, EventArgs e)
        {
           
                txtCoins.Focus();
                txtCoins.Text += ".";
            

        }

        public void btn0_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                if (txtMeal.Text.Length < 2)
                {

                    txtMeal.Text += "0";
                }
                else
                {
                    MessageBox.Show("Can not enter more than two digits !!");
                }



            }
            else if (count == 1)
            {
                
                    txtCoins.Text += "0";
               

            }
            else
            {
                txtCash.Text += "0";
            }

        }

        public void btnDelete_Click(object sender, EventArgs e)
        {
           
            txtMeal.Text = "";
            txtCoins.Text = "";
            txtCash.Text = "";


        }

        public void btnOK_Click(object sender, EventArgs e)
        {
            Calculate calculate = new Calculate();
            var c = calculate.calculatePrice(txtMeal.Text);
            if(c != 0.0)
            {

            WelcomeScreen.Text = "Your order price " + c + " $ " + Environment.NewLine +
                "-Money Slots: the machine accepts money of the following types:" + Environment.NewLine+
                "-Coin slot: There are four denominations:10c,20c,50c,$1 " + Environment.NewLine +
                "-Machine only accepts USD currency" + Environment.NewLine +
                "-Notes Slot :20$ and 50$ only";
            }
            else
            {
                WelcomeScreen.Text = "You have entered the wrong number";

            }
        }



        public void MainPage_Load(object sender, EventArgs e)
        {
            WelcomeScreen.Text = "Welcome to snacks machine , please enter your meal number";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
   
             count++;
            if(count > 2)
            {
                count = 0;
            }
            if (count == 0)
            {
                txtMeal.BackColor = Color.Aqua;
                txtCoins.BackColor = Color.White;
                txtCash.BackColor = Color.White;
            }
            else if(count==1){
                txtMeal.BackColor = Color.White;
                txtCoins.BackColor = Color.Aqua;
                txtCash.BackColor = Color.White;
            }
            else
            {
                txtCash.BackColor =Color.White;
                txtCoins.BackColor = Color.White;
                txtCash.BackColor = Color.Aqua;

            }

        }

        public double Balance =0;
        public double rest;
        private void buy_Click(object sender, EventArgs e)
        {
            Calculate calculate = new Calculate();
            if(txtMeal.Text != "") { 
            if (txtCoins.Text == "10" || txtCoins.Text == "20" || txtCoins.Text == "50" || txtCoins.Text == "1" || Balance > 0)
            {
                if (txtCash.Text == "20" || txtCash.Text == "50" || Balance>0)
                {
                    this.rest = calculate.calculateRestPrice(txtMeal.Text, txtCoins.Text, txtCash.Text, Balance);
                    txtRest.Text = rest.ToString();
                }
                else
                {
                    MessageBox.Show("Please enter cash just 20 or 50");


                }
            }
            else
            {
                if (Balance == 0)
                {
                MessageBox.Show("Please enter coins just 10,20,50,1");

                }
               
                  
                
            }
            }
            else
            {
                MessageBox.Show("Please enter snack");

            }
            txtCash.Text = "";
            txtCoins.Text = "";
            txtMeal.Text = "";
            txtBalance.Text = "";
            Balance = 0;
            WelcomeScreen.Text = "Welcome to snacks machine , please enter your snack number";
            txtMeal.Focus();
            count = 0;
            






        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCash.Text != "")
            {
                if (txtCash.Text == "20" || txtCash.Text == "50")
                {
                Balance += Convert.ToDouble(txtCash.Text);

                }
                else
                {
                    MessageBox.Show("Please enter cash just 20 or 50");
                }


            }
            double coins = 0.0;


            if (txtCoins.Text != "")
            {
                if (txtCoins.Text == "10" || txtCoins.Text == "20" || txtCoins.Text == "50" || txtCoins.Text == "1")
                {
                    if (txtCoins.Text == "10")
                    {
                        coins = 0.1;
                    }
                    else if (txtCoins.Text == "20")
                    {
                        coins = 0.2;
                    }
                    else if (txtCoins.Text == "50")
                    {
                        coins = 0.5;
                    }
                    else if (txtCoins.Text == "1")
                    {
                        coins = 1;
                    }
                    else
                    {
                        coins = 0;
                    }
                    Balance += coins;
                }
                else
                {
                    MessageBox.Show("Please enter coins just 10c,20c,50c,1$");
                    
                }

            }
            txtBalance.Text = Balance.ToString();
            txtCash.Text = "";
            txtCoins.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            VisaCard visaCard = new VisaCard();
            visaCard.Show();
        }
    }
}
