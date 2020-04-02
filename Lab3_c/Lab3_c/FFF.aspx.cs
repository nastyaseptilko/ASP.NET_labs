using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab3_c
{
    public partial class FFF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void View_Click(object sender, EventArgs e)
        {
            this.MultiView.ActiveViewIndex = (this.MultiView.ActiveViewIndex + 1) % this.MultiView.Views.Count;
        }

        protected void ButtonChangeRotator_Click(object sender, EventArgs e)
        {
            var arr = new List<string> { "", "Group1", "Group2" };
            var el = arr.IndexOf(this.AdRotator.KeywordFilter);
            this.AdRotator.KeywordFilter = arr[(el + 1) % arr.Count];
            this.Response.Write(this.AdRotator.KeywordFilter);
        }

        protected void Wizard1_OnNextButtonClick(object sender, WizardNavigationEventArgs e)
        {
            if (this.Wizard1.ActiveStepIndex + 1 == this.Wizard1.WizardSteps.Count - 1)
            {
                var text = "";

                text += "TextBox: " + this.WizardTextbox.Text + "<br/>";
                text += "RadioButtonList: " + this.WizardRadioButtonList.SelectedValue + " < br/>";

                text += "CheckBoxList: <br/>";
                foreach (ListItem lst in this.WizardCheckBoxList.Items)
                {
                    if (lst.Selected)
                    {
                        text += "Selected Item Text: " + lst.Text + "<br/>";
                    }
                }

                text += "ListBox: " + this.WizardListBox.SelectedValue + " < br/>";
                text += this.WizardCalendar.SelectedDate.ToShortDateString() + "<br/>";

                text += "Selected dates: <br/>";
                for (var i = 0; i <= this.WizardCalendars.SelectedDates.Count - 1; i++)
                {
                    text += this.WizardCalendars.SelectedDates[i].ToShortDateString() + "<br/>";
                }

                this.WizardResult.Text = text;
            }
        }

        public static List<DateTime> list = new List<DateTime>();

        protected void WizardCalendars_OnSelectionChanged(object sender, EventArgs e)
        {
            if (this.Session["SelectedDates"] != null)
            {
                var newList = (List<DateTime>)this.Session["SelectedDates"];
                foreach (var dt in newList)
                {
                    this.WizardCalendars.SelectedDates.Add(dt);
                }

                list.Clear();
            }
        }

        protected void Calendars_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.IsSelected)
            {
                list.Add(e.Day.Date);
            }

            this.Session["SelectedDates"] = list;
        }

        protected void TreeViewButton_OnClick(object sender, EventArgs e)
        {
            var nodes = this.TreeView.Nodes;
            foreach (TreeNode n in nodes)
            {
                this.GetNodeRecursive(n);

            }
            var text = "<br/>";
            foreach (var obj in this.SelectedNodes)
            {
                text += obj + "<br/>";
            }

            this.TreeViewResult.Text = text;
        }

        protected void TreeView_OnSelectedNodeChanged(object sender, EventArgs e)
        {
            var items = this.GetSelected(this.TreeView.SelectedNode);
            var text = "<br/>";
            foreach (var obj in items)
            {
                text += obj + "<br/>";
            }

            this.TreeViewResult.Text = text;
        }

        List<string> GetSelected(TreeNode tree)
        {
            var result = new List<string>();
            foreach (var obj in tree.ChildNodes)
            {
                if (!(obj is TreeNode temp))
                {
                    continue;
                }

                if (temp.ChildNodes.Count != 0)
                {
                    result.AddRange(this.GetSelected(temp));
                }

                if (temp.Checked)
                {
                    result.AddRange(this.GetSelected(temp));
                }
            }

            return result;
        }

        private List<string> SelectedNodes = new List<string>();
        private void GetNodeRecursive(TreeNode treeNode)
        {
            if (treeNode.Checked)
            {
                this.SelectedNodes.Add(treeNode.Value);
            }
            foreach (TreeNode tn in treeNode.ChildNodes)
            {
                this.GetNodeRecursive(tn);
            }

        }

        protected void Menu_itemClick(object sender, MenuEventArgs e)
        {
            this.MenuResult.Text = ((Menu)sender).SelectedValue;
        }


    }
}