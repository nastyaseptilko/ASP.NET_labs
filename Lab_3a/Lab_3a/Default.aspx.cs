using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Lab_3a
{
    public partial class _Default : Page
    {
        private HtmlTable t;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Select1.Items.Add("1111111111111");
                Select1.Items.Add("2222222222222");
                Select1.Items.Add("3333333333333");
            }


            if (this.t == null)
            {
                this.t = new HtmlTable(); ;

                this.t.Border =2;
                this.t.CellPadding = 3;
                this.t.CellSpacing = 3;
                this.t.Align = "center";
                this.t.BorderColor = "#bc40ac";
                HtmlTableRow r;
                HtmlTableCell c;
                r = new HtmlTableRow();
                c = new HtmlTableCell(); c.InnerHtml = "Html Control"; r.Cells.Add(c);
                c = new HtmlTableCell(); c.InnerHtml = "onserverclic"; r.Cells.Add(c);
                c = new HtmlTableCell(); c.InnerHtml = "onserverchange"; r.Cells.Add(c);
                this.t.Rows.Add(r);
                r = new HtmlTableRow();
                c = new HtmlTableCell(); c.InnerHtml = "HtmlInputReset"; r.Cells.Add(c);
                c = new HtmlTableCell(); c.InnerHtml = "NO"; r.Cells.Add(c);
                c = new HtmlTableCell(); c.InnerHtml = "NO"; r.Cells.Add(c);
                this.t.Rows.Add(r);
                this.Controls.Add(this.t);
            }
        }

        protected void Common_Onserverchange(object sender, EventArgs e)
        {
            if (sender is Control control)
            {
                AddToTable(control.ToString(), "NO", "YES");
            }
        }

        private void AddToTable(string method, string onClick, string onChange)
        {
            this.t.Rows.Add(new HtmlTableRow
            {
                Cells = { new HtmlTableCell { InnerText = method }, new HtmlTableCell { InnerText = onClick }, new HtmlTableCell { InnerText = onChange } }
            });
        }

        protected void OnClick(object sender, EventArgs e)
        {
            if (sender is Control control)
            {
                AddToTable(control.ToString(), "YES", "NO");
            }
        }
    }
}