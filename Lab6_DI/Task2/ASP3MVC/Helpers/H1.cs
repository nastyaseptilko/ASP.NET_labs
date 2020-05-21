using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP3MVC.Helpers
{
    public static class H1
    {
        public static MvcHtmlString AddForm(this HtmlHelper html)
        {
            TagBuilder tag = new TagBuilder("form");
            tag.MergeAttribute("method", "post");
            tag.MergeAttribute("action", "./AddSave");
            string[] cl = { "text", "text"};
            string[] c2 = { "FIO", "Telephone" };
            string[] c3 = { "Введите свое ФИО", " Введите телефон :" };
            TagBuilder item2 = new TagBuilder("br");
            for (int f = 0;f < 2;f++)
            {
                TagBuilder item1 = new TagBuilder("p");
                item1.SetInnerText(c3[f]);
                TagBuilder item3 = new TagBuilder("input");
                item3.MergeAttribute("type", cl[f]);
                item3.MergeAttribute("name", c2[f]);
                tag.InnerHtml += item1.ToString() + item3.ToString() + item2.ToString();
            }
            TagBuilder tag2 = new TagBuilder("input");
            tag2.MergeAttribute("type", "submit");
            tag2.MergeAttribute("value", "Отправить");
            tag.InnerHtml += tag2.ToString();
            return new MvcHtmlString(tag.ToString());
        }
        public static MvcHtmlString EditForm(this HtmlHelper html, string [] values)
        {
            TagBuilder tag = new TagBuilder("form");
            tag.MergeAttribute("method", "post");
            tag.MergeAttribute("action", "./UpdateSave");
            string[] cl = { "hidden", "text", "text" };
            string[] c2 = { "Id", "FIO", "Telephone" };
            string[] c3 = { " ", "Введите свое ФИО", " Введите телефон :" };
            TagBuilder item2 = new TagBuilder("br");
            for (int f = 0; f < 3; f++)
            {
                TagBuilder item1 = new TagBuilder("p");
                item1.SetInnerText(c3[f]);
                TagBuilder item3 = new TagBuilder("input");
                item3.MergeAttribute("type", cl[f]);
                item3.MergeAttribute("name", c2[f]);
                item3.MergeAttribute("value", values[f]);
                tag.InnerHtml += item1.ToString() + item3.ToString() + item2.ToString();
            }
            TagBuilder tag2 = new TagBuilder("input");
            tag2.MergeAttribute("type", "submit");
            tag2.MergeAttribute("value", "Отправить");
            tag.InnerHtml += tag2.ToString();
            return new MvcHtmlString(tag.ToString());
        }
    }
}