using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace WForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = String.Format("ParmA={0}&ParmB={1}", textBox1.Text, textBox2.Text);
            byte[] databyte = Encoding.UTF8.GetBytes(data);
            HttpWebRequest rq = (HttpWebRequest)HttpWebRequest.Create("http://localhost:50311/multi.gso");
            rq.ContentType = "application/x-www-form-urlencoded";
            rq.ContentLength = databyte.Length;
            rq.Method = "POST";
            rq.GetRequestStream().Write(databyte, 0, databyte.Length);
            rq.GetRequestStream().Close();
            HttpWebResponse response = (HttpWebResponse)rq.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            this.label1.Text = sr.ReadToEnd();
            sr.Close();
        }
    }
}
