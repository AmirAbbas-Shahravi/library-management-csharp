using classha;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace bookstore1
{
    public partial class frm_Report : RadForm
    {
        frm_launcher luncher;
        public frm_Report(frm_launcher flauncher)
        {
            InitializeComponent();

            this.luncher = flauncher;

        }
        MyDBContext mdb = new MyDBContext();
        private void frm_Report_FormClosing(object sender, FormClosingEventArgs e)
        {
            luncher.Show();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            var k = mdb.books.ToList();
            dataGridView1.DataSource = k;
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            var k = mdb.author.ToList();
            dataGridView1.DataSource = k;
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            var k = mdb.customer.ToList();
            dataGridView1.DataSource = k;
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
           var k = mdb.sabad.ToList();
            dataGridView1.DataSource = k;
        }
    }
}
