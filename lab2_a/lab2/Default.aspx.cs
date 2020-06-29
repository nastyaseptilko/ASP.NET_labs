using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Title = "Lab2";

        }
        //это клиент
        //маршруты к handker прописаны в webConfig
        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpWebRequest rq = (HttpWebRequest)HttpWebRequest.Create(String.Format("http://localhost:50722/Lab2_a/yyy.saa?ParmA={0}&ParmB={1}",
                TextBox1.Text, TextBox2.Text)); //создаем запрос
            rq.Method = "GET";
            HttpWebResponse response = (HttpWebResponse)rq.GetResponse();//GetResponse посылаем запрос на сервер GetHandler.cs
            response.Headers.Add("yyy-SAA", "Septilko Anastasiya"); //заголовок 
            StreamReader sr = new StreamReader(response.GetResponseStream());
            Response.Write(sr.ReadToEnd());
            sr.Close();
        }

        protected void Post_Click(object sender, EventArgs e)
        {
            string data = String.Format("ParmA={0}&ParmB={1}",TextBox1.Text,TextBox2.Text);//тело
            byte[] databyte = Encoding.UTF8.GetBytes(data);
            HttpWebRequest rq = (HttpWebRequest)HttpWebRequest.Create("http://localhost:50722/Lab2_a/yyy.saa");
            rq.ContentType = "application/x-www-form-urlencoded";
            rq.ContentLength = databyte.Length;
            rq.Method = "POST";
            rq.GetRequestStream().Write(databyte, 0, databyte.Length);//запись тела 
            rq.GetRequestStream().Close();
            HttpWebResponse response = (HttpWebResponse)rq.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            Response.Write(sr.ReadToEnd());
            sr.Close();
        }

        protected void Put_Click(object sender, EventArgs e)
        {
            string data = String.Format("ParmA={0}&ParmB={1}", TextBox1.Text, TextBox2.Text);
            HttpWebRequest rq = (HttpWebRequest)HttpWebRequest.Create("http://localhost:50722/Lab2_a/yyy.saa");
            rq.ContentLength = data.Length;
            rq.ContentType = "application/x-www-form-urlencoded";
            rq.AllowWriteStreamBuffering = false;//позволить буфферизировтаь поток записи
            rq.SendChunked = false;//отправка по частям
            rq.MaximumResponseHeadersLength = 100;
            rq.Method = "PUT";
            using (StreamWriter stream = new StreamWriter(rq.GetRequestStream()))//запись в поток
            {
                stream.Write(data);
            }
            HttpWebResponse response = (HttpWebResponse)rq.GetResponse();//отправляем на сервер 
            StreamReader sr = new StreamReader(response.GetResponseStream());
            Response.Write(sr.ReadToEnd());
            sr.Close();
        }

        protected void ERROR_Click(object sender, EventArgs e)
        {
            try
            {
                HttpWebRequest rq = (HttpWebRequest)HttpWebRequest.Create(String.Format("http://localhost:50722/Lab2_a/err.gso"));
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
}