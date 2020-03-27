using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e){ }


    protected void GetButton_Click(object sender, EventArgs e)
    {
        HttpWebRequest rq = (HttpWebRequest)HttpWebRequest.Create(String.Format("http://localhost:50311/get.SAA?ParmA={0}&ParmB={1}",
               TextBox1.Text, TextBox2.Text));
        rq.Method = "GET";
        HttpWebResponse response = (HttpWebResponse)rq.GetResponse();
        response.Headers.Add("A-SAA", "Septilko Anastasiya");

        StreamReader sr = new StreamReader(response.GetResponseStream());
        Response.Write(sr.ReadToEnd());
        sr.Close();
    }
    protected void Post_Click(object sender, EventArgs e)
    {
        string data = String.Format("ParmA={0}&ParmB={1}", TextBox1.Text, TextBox2.Text);
        byte[] databyte = Encoding.UTF8.GetBytes(data);
        HttpWebRequest rq = (HttpWebRequest)HttpWebRequest.Create("http://localhost:50311/yyy.gso");
        rq.ContentType = "application/x-www-form-urlencoded";
        rq.ContentLength = databyte.Length;
        rq.Method = "POST";
        rq.GetRequestStream().Write(databyte, 0, databyte.Length);
        rq.GetRequestStream().Close();
        HttpWebResponse response = (HttpWebResponse)rq.GetResponse();
        StreamReader sr = new StreamReader(response.GetResponseStream());
        Response.Write(sr.ReadToEnd());
        sr.Close();
    }
    protected void Put_Click(object sender, EventArgs e)
    {
        string data = String.Format("ParmA={0}&ParmB={1}", TextBox1.Text, TextBox2.Text);
        HttpWebRequest rq = (HttpWebRequest)HttpWebRequest.Create("http://localhost:50311/yyy.gso");
        rq.ContentLength = data.Length;
        rq.ContentType = "application/x-www-form-urlencoded";
        rq.AllowWriteStreamBuffering = false;
        rq.SendChunked = false;
        rq.MaximumResponseHeadersLength = 100;
        rq.Method = "PUT";
        using (StreamWriter stream = new StreamWriter(rq.GetRequestStream()))
        {
            stream.Write(data);
        }
        HttpWebResponse response = (HttpWebResponse)rq.GetResponse();
        StreamReader sr = new StreamReader(response.GetResponseStream());
        Response.Write(sr.ReadToEnd());
        sr.Close();
    }

    protected void ERROR_Click(object sender, EventArgs e)
    {
        try
        {
            HttpWebRequest rq = (HttpWebRequest)HttpWebRequest.Create(String.Format("http://localhost:50311/err.gso"));
            rq.Method = "GET";
            HttpWebResponse response = (HttpWebResponse)rq.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            Response.Write(sr.ReadToEnd());
            sr.Close();
        }
        catch (WebException ex)
        {
            Response.Write(ex.Status);
            Response.Write("<br/>" + ex.Message);
            Response.Write("<br/>" + ex.TargetSite);
            Response.Write("<br/>" + ex.Source);
        }
    }
}


