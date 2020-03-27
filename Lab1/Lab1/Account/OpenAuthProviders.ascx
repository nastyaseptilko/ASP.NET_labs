<%@ Control Language="C#" AutoEventWireup="true" CodeFile="OpenAuthProviders.ascx.cs" Inherits="OpenAuthProviders" %>

<div id="socialLoginList">
    <h4>Используйте для входа другую службу.</h4>
    <hr />
    <asp:ListView runat="server" ID="providerDetails" ItemType="System.String"
        SelectMethod="GetProviderNames" ViewStateMode="Disabled">
        <ItemTemplate>
            <p>
                <button type="submit" class="btn btn-default" name="provider" value="<%#: Item %>"
                    title="Войдите, используя <%#: Item %> свою учетную запись.">
                    <%#: Item %>
                </button>
            </p>
        </ItemTemplate>
        <EmptyDataTemplate>
            <div>
                <p>Внешние службы проверки подлинности не настроены. Подробности о настройке входа через сторонние службы для этого приложения ASP.NET см. в <a href="https://go.microsoft.com/fwlink/?LinkId=252803">этой статье</a>.</p>
            </div>
        </EmptyDataTemplate>
    </asp:ListView>
</div>