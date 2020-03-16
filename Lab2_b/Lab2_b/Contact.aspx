<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Lab2_b.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <script type="text/javascript">
        var ws;
        function exe_start() {
            if (ws == null) {
                ws = new WebSocket('ws://localhost:10512/yyy.websocket');
                ws.onopen = function () { ws.send('Connecting') }
                ws.onclose = function (s) { console.log('onclose' + s); }
                ws.onmessage = function (evt) { ta.innerHTML += '\n' + evt.data; }
                bstart.disabled = true;
                bstop.disabled = false;
            }
        }
        var ta;
        var bstart;
        var bstop;
        window.onload = function () {
            if (Modernizr.websockets) {
                WriteMessage('support', 'YES');
                ta = document.getElementById('ta');
                bstart = document.getElementById('bstart');
                bstop = document.getElementById('bstop');
                bstart.disabled = false;
                bstop.disabled = true;
            }
        }
        function WriteMessage(idspan, txt) {
            var span = document.getElementById(idspan);
            span.innerHTML = txt;
        }
        function exe_stop() {
            ws.close(3001, ' stopapplication');
            ws = null;
            bstart.disabled = false;
            bstop.disabled = true;
        }
    </script>

    <h1 style="width: 800px">Web Sockets</h1>
    <span style="font-size:20px; ">Web sockets поддерживается?</span>
    <span id="support"></span>
    <br />
    <div>
        <input type="button" value="Start" id="bstart" onclick="exe_start()" style="width: 150px;height:35px; background: pink" />
        <input type="button" value="Stop" id="bstop" onclick="exe_stop()" style="width: 150px; height:35px; background: pink" />
    </div>
    <div>
        <textarea id="ta" rows="20" cols="45" style="text-align: center; background:#f4e1f0" readonly>
        </textarea>
    </div>

</asp:Content>
