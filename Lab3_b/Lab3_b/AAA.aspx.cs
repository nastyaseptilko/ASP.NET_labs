using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab3_b
{
    public partial class AAA : System.Web.UI.Page
    {
        protected void Page_PreRender(object sender, EventArgs e)
        {
            DateValidator.MinimumValue = new DateTime(2018, 1, 1).ToShortDateString();
            DateValidator.MaximumValue = new DateTime(2020, 12, 31).ToShortDateString();
        }
       
        protected void MyHandler(object source, ServerValidateEventArgs args)
        {
            args.IsValid = IsPrime(TextBox7.Text);
        }
        private bool IsPrime(string str)
        {
            int number = Int32.Parse(str);

            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Title = "Lab3_b";
        }
    }
}