using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;

namespace Lab3_c
{
    public partial class Lab3_d : System.Web.UI.Page
    {
        private static int timer1inc = 0;
        private static int timer2inc = 0;

        protected void Button1_OnClick(object sender, EventArgs e)
        {
            switch (Radio1.SelectedValue)
            {
                case "1":
                    {
                        if (CheckBox1.Checked) Label1.Text = DateTime.Now.ToLongDateString();
                        else Label1.Text = DateTime.Now.ToShortDateString();
                        break;
                    }
                case "2":
                    {
                        if (CheckBox1.Checked) Label1.Text = DateTime.Now.ToLongTimeString();
                        else Label1.Text = DateTime.Now.ToShortTimeString();
                        break;
                    }
            }
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            Label3.Text = timer1inc++.ToString();
        }

        protected void Timer2_Tick(object sender, EventArgs e)
        {
            Label4.Text = timer2inc++.ToString();
        }

        protected void Button2_OnClick(object sender, EventArgs e)
        {
            Random rand = new Random();

            int randInt = rand.Next(0, 1);

            if (randInt == 0)
            {
                Thread.Sleep(TimeSpan.FromSeconds(15));
                TextBox1.Text = "HELLO";

            }

           

        }

        protected void Button3_OnClick(object sender, EventArgs e)
        {
            float x, y,z ;
            if(
                Single.TryParse(this.TextBox2.Text, out x) &&
                 Single.TryParse(this.TextBox3.Text, out y)
            )

            {
                z = x + y;
                this.TextBox4.Text = z.ToString();

            }
            else throw new ApplicationException("My error");

        }

        protected void ScriptManager1_AsyncPostBackError(object sender, AsyncPostBackErrorEventArgs e)
        {
            ScriptManager1.AsyncPostBackErrorMessage = "My Error";
        }
    }
}