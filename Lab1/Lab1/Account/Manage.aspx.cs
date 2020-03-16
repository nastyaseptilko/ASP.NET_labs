﻿using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using Lab1;

public partial class Account_Manage : System.Web.UI.Page
{
    protected string SuccessMessage
    {
        get;
        private set;
    }

    protected bool CanRemoveExternalLogins
    {
        get;
        private set;
    }

    private bool HasPassword(UserManager manager)
    {
        var user = manager.FindById(User.Identity.GetUserId());
        return (user != null && user.PasswordHash != null);
    }

    protected void Page_Load()
    {
        if (!IsPostBack)
        {
            // Определите разделы для отображения
            UserManager manager = new UserManager();
            if (HasPassword(manager))
            {
                changePasswordHolder.Visible = true;
            }
            else
            {
                setPassword.Visible = true;
                changePasswordHolder.Visible = false;
            }
            CanRemoveExternalLogins = manager.GetLogins(User.Identity.GetUserId()).Count() > 1;

            // Отобразить сообщение об успехе
            var message = Request.QueryString["m"];
            if (message != null)
            {
                // Извлечь строку запроса из действия
                Form.Action = ResolveUrl("~/Account/Manage");

                SuccessMessage =
                    message == "ChangePwdSuccess" ? "Ваш пароль изменен."
                    : message == "SetPwdSuccess" ? "Пароль задан."
                    : message == "RemoveLoginSuccess" ? "Учетная запись удалена."
                    : String.Empty;
                successMessage.Visible = !String.IsNullOrEmpty(SuccessMessage);
            }
        }
    }

    protected void ChangePassword_Click(object sender, EventArgs e)
    {
        if (IsValid)
        {
            UserManager manager = new UserManager();
            IdentityResult result = manager.ChangePassword(User.Identity.GetUserId(), CurrentPassword.Text, NewPassword.Text);
            if (result.Succeeded)
            {
                var user = manager.FindById(User.Identity.GetUserId());
                IdentityHelper.SignIn(manager, user, isPersistent: false);
                Response.Redirect("~/Account/Manage?m=ChangePwdSuccess");
            }
            else
            {
                AddErrors(result);
            }
        }
    }

    protected void SetPassword_Click(object sender, EventArgs e)
    {
        if (IsValid)
        {
            // Создание информации о локальном имени входа и связывание локальной учетной записи с пользователем
            UserManager manager = new UserManager();
            IdentityResult result = manager.AddPassword(User.Identity.GetUserId(), password.Text);
            if (result.Succeeded)
            {
                Response.Redirect("~/Account/Manage?m=SetPwdSuccess");
            }
            else
            {
                AddErrors(result);
            }
        }
    }

    public IEnumerable<UserLoginInfo> GetLogins()
    {
        UserManager manager = new UserManager();
        var accounts = manager.GetLogins(User.Identity.GetUserId());
        CanRemoveExternalLogins = accounts.Count() > 1 || HasPassword(manager);
        return accounts;
    }

    public void RemoveLogin(string loginProvider, string providerKey)
    {
        UserManager manager = new UserManager();
        var result = manager.RemoveLogin(User.Identity.GetUserId(), new UserLoginInfo(loginProvider, providerKey));
        string msg = String.Empty;
        if (result.Succeeded)
        {
            var user = manager.FindById(User.Identity.GetUserId());
            IdentityHelper.SignIn(manager, user, isPersistent: false);
            msg = "?m=RemoveLoginSuccess";
        }
        Response.Redirect("~/Account/Manage" + msg);
    }

    private void AddErrors(IdentityResult result)
    {
        foreach (var error in result.Errors)
        {
            ModelState.AddModelError("", error);
        }
    }
}