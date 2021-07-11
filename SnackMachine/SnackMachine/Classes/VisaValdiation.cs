using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackMachine.Classes
{
  public  class VisaValdiation
    {
        public bool visaValdiation()
        {
            VisaCard visaCard = new VisaCard();
            var x = visaCard.txtCardType.Text;
            if (x == "Master Card")
            {
                if (visaCard.txtVisaNumber.TextLength == 14)
                {

                    return true;
                }
                else
                {
                    return false;
                }
            }
            
            if( x == "Visa Card")
            {
                if (visaCard.txtVisaNumber.TextLength == 16)
                {

                    return true;
                }
                else
                {
                    return false;
                }
            }
            
            if (visaCard.txtExpiryDate.TextLength == 5)
            {
                return true;
            }else
            {
                return false;
            }


           
            
        }
        
    }
}
