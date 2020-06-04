using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFWebService
{
    public partial class Form1 : Form
    {
        WS.WebServiceSoapClient client;
        public Form1()
        {
            InitializeComponent();
            this.client = new WFWebService.WS.WebServiceSoapClient();
            UpdateTable();
        }
        public void UpdateTable()
        {
            List<WS.Phone> phones = this.client.GetDict().ToList();
            WS.Phone phone = new WS.Phone();
            phone.Id = 0;
            phone.FIO = "";
            phone.Telephone = "";
            phones.Add(phone);
            dataGridView1.DataSource = phones;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows[0]!=null)
            {
                WS.Phone phone = new WS.Phone();
                phone.Id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                phone.Telephone = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                phone.FIO = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                client.DelDict(phone);
                UpdateTable();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows[0] != null)
            {
                WS.Phone phone = new WS.Phone();
                phone.Id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                phone.Telephone = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                phone.FIO = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                client.AddDict(phone);
                UpdateTable();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows[0] != null)
            {
                WS.Phone phone = new WS.Phone();
                phone.Id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                phone.Telephone = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                phone.FIO = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                client.UpdDict(phone);
                UpdateTable();
            }
        }
    }
}
