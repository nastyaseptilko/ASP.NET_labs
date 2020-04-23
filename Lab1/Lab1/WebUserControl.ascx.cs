using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebUserControl : System.Web.UI.UserControl
{
    public String Name { get; set; }
    public String Surname { get; set; }
    public String Fathername { get; set; }
    public String Date { get; set; }
    public String Sex { get; set; }
    public String Faculty { get; set; }
    public String Group { get; set; }
    public String Year { get; set; }
    public String Input { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {
         
        if (!this.IsPostBack)
        {
            name.Text = Name;
            surname.Text = Surname;
            father_name.Text = Fathername;
            birthday.Text = Date;
            group.Text = Group;
            faculties.SelectedValue = Faculty;
            sex.SelectedIndex = Sex == "мужской" || Sex == null ? 0 : 1;
            year.Text = Year;
            submit.Text = Input;
        }

    }
}