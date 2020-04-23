using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{

   
    // init вызывается один раз при закрузки стр
    protected void Page_Init(object sender, EventArgs e)
    {
        ViewState["state"] = " Init ";
    }

    // перезагрузка стр
    protected void Page_Load(object sender, EventArgs e)
    {

        ViewState["state"] += " Load ";
    }

    // перед тем как стр начнет строиться 
    protected void Page_Prerender(object sender, EventArgs e)
    {
        ViewState["state"] += " Prerender ";
    }
    // выгрузка
    protected void Page_Unload(object sender, EventArgs e)
    {
        ViewState["state"] += " Unload ";
      
    }

    protected void TestButton_Click(object sender, EventArgs e)
    {
        ViewState["state"] += " Click ";

        Title = "new title";
        //testLabel.Text = textBox.Text;

        ViewState["1"] = 121242;
        ViewState["2"] = 2254;

        //stateLabel.Text = ViewState["state"].ToString();
        
    }

    protected void TestCheckbox_CheckedChanged(object sender, EventArgs e)
    {
        ViewState["state"] += " Check ";
    }
}
