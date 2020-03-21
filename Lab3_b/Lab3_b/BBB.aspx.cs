using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab3_b
{
    public partial class BBB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            BirthdayValidator.Type = ValidationDataType.Date;
            BirthdayValidator.MinimumValue = DateTime.MinValue.ToShortDateString();
            BirthdayValidator.MaximumValue = DateTime.Now.ToShortDateString();

        }
        protected void OnServerValidate(object source, ServerValidateEventArgs args)
        {
            var pass = this.password.Text;
            if (pass.Length < 7)
            {
                args.IsValid = false;
                return;
            }

            for (var i = 0; i < pass.Length; i++)
            {
                for (var j = i + 1; j < pass.Length; j++)
                {
                    if (pass[i] == pass[j])
                    {
                        args.IsValid = false;
                        return;
                    }
                }
            }

            args.IsValid = true;
        }
    }
}