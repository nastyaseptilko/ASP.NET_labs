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
        WS.Service1Client client;
        private void makeColumnOrder()
        {
            dataGridView1.Columns["Id"].DisplayIndex = 0;
            dataGridView1.Columns["FIO"].DisplayIndex = 1;
            dataGridView1.Columns["Telephone"].DisplayIndex = 2;
        }
        public Form1()
        {
            InitializeComponent();
            this.client = new WS.Service1Client();
            UpdateTable();
            makeColumnOrder();
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
            if(dataGridView1.SelectedRows.Count != 0)
            {
                WS.Phone phone = new WS.Phone();
                phone.Id = int.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                phone.Telephone = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                phone.FIO = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                client.DelDict(phone);
                UpdateTable();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                WS.Phone phone = new WS.Phone();
                phone.Id = int.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                phone.Telephone = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                phone.FIO = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                client.AddDict(phone);
                UpdateTable();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                WS.Phone phone = new WS.Phone();
                phone.Id = int.Parse(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                phone.Telephone = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                phone.FIO = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                client.UpdDict(phone);
                UpdateTable();
            }
        }
    }
}
