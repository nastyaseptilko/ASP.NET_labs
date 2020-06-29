using AbstractPhoneDataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab6.Helper
{
    public static class MarkupHelper
    {
        public static MvcHtmlString AddNewForm(this HtmlHelper html)
        {
            TagBuilder form = new TagBuilder("form");
            form.MergeAttribute("method", "post");
            form.MergeAttribute("action", "/dict/addsave");

            TagBuilder lastNameInputWrapper = new TagBuilder("div");
            TagBuilder lastNameInput = new TagBuilder("input");
            lastNameInput.MergeAttribute("type", "text");
            lastNameInput.MergeAttribute("name", "lastname");
            lastNameInput.MergeAttribute("placeholder", "LastName");
            lastNameInputWrapper.InnerHtml = lastNameInput.ToString();

            TagBuilder phoneInputWrapper = new TagBuilder("div");
            TagBuilder phoneInput = new TagBuilder("input");
            phoneInput.MergeAttribute("type", "text");
            phoneInput.MergeAttribute("name", "phone");
            phoneInput.MergeAttribute("placeholder", "Phone");
            phoneInputWrapper.InnerHtml = phoneInput.ToString();

            TagBuilder submitButtonWrapper = new TagBuilder("div");
            TagBuilder submitButton = new TagBuilder("button");
            submitButton.MergeAttribute("type", "submit");
            submitButton.SetInnerText("Add");
            submitButtonWrapper.InnerHtml = submitButton.ToString();

            form.InnerHtml = lastNameInputWrapper.ToString() + phoneInputWrapper.ToString() + submitButtonWrapper.ToString();

            return new MvcHtmlString(form.ToString());
        }

        public static MvcHtmlString UpdateForm(this HtmlHelper html, object personObj)
        {
            Person person = personObj as Person;
            TagBuilder form = new TagBuilder("form");
            form.MergeAttribute("method", "post");
            form.MergeAttribute("action", "/dict/updatesave");

            TagBuilder idInput = new TagBuilder("input");
            idInput.MergeAttribute("type", "hidden");
            idInput.MergeAttribute("name", "id");
            idInput.MergeAttribute("value", person.Id.ToString());

            TagBuilder lastNameInputWrapper = new TagBuilder("div");
            TagBuilder lastNameInput = new TagBuilder("input");
            lastNameInput.MergeAttribute("type", "text");
            lastNameInput.MergeAttribute("name", "lastname");
            lastNameInput.MergeAttribute("value", person.LastName);
            lastNameInput.MergeAttribute("placeholder", "LastName");
            lastNameInputWrapper.InnerHtml = lastNameInput.ToString();

            TagBuilder phoneInputWrapper = new TagBuilder("div");
            TagBuilder phoneInput = new TagBuilder("input");
            phoneInput.MergeAttribute("type", "text");
            phoneInput.MergeAttribute("name", "phone");
            phoneInput.MergeAttribute("value", person.Phone);
            phoneInput.MergeAttribute("placeholder", "Phone");
            phoneInputWrapper.InnerHtml = phoneInput.ToString();

            TagBuilder submitButtonWrapper = new TagBuilder("div");
            TagBuilder submitButton = new TagBuilder("button");
            submitButton.MergeAttribute("type", "submit");
            submitButton.SetInnerText("Update");
            submitButtonWrapper.InnerHtml = submitButton.ToString();

            form.InnerHtml = idInput.ToString() + lastNameInputWrapper.ToString() + phoneInputWrapper.ToString() + submitButtonWrapper.ToString();

            return new MvcHtmlString(form.ToString());
        }
    }
}
