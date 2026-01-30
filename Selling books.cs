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
    public partial class frm_SellingBooks : RadForm
    {
        frm_launcher launcher;
        MyDBContext mdb = new MyDBContext();
        public frm_SellingBooks(frm_launcher flauncher)
        {
            InitializeComponent();
            this.launcher = flauncher;
            comboBox3.DisplayMember = "FullName";
            comboBox3.ValueMember = "ID";
            comboBox1.DisplayMember = "DateTime";
            comboBox1.ValueMember = "id";
            comboBox2.DisplayMember = "bname";
            comboBox3.ValueMember = "Id";
        }

        private void Selling_books_FormClosing(object sender, FormClosingEventArgs e)
        {
            launcher.Show();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            
            sabadha sbh = new sabadha();
            sbh.id = Guid.NewGuid();
            var a = mdb.customer.Where(x => x.ID == (Guid)comboBox3.SelectedValue).First();
            sbh.customer = a;
            sbh.DateTime = radDateTimePicker1.Value;
            mdb.sabadhas.Add(sbh);
            mdb.SaveChanges();
            refreshgrid();

        }
        public void refreshgrid()
        {
            var sabads = mdb.sabad.ToList();

            dataGridView1.DataSource = sabads;
        }
        private void radButton3_Click(object sender, EventArgs e)
        {
          
            sabad sb = new sabad();
            var a = mdb.sabadhas.Where(x => x.id == (Guid)comboBox1.SelectedValue).First();
            sb.sabadha = a;
            var b = mdb.books.Where(x => x.Id == (Guid)comboBox3.SelectedValue).First();
            sb.books = b;
            sb.amount = int.Parse(radTextBoxControl5.Text);
            mdb.sabad.Add(sb);
            mdb.SaveChanges();
            refreshgrid();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            try
            {
                var b = Guid.Parse(dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString());
                mdb.sabad.Remove(mdb.sabad.Where(c => c.ID == b).First());
                mdb.SaveChanges();
                refreshgrid();
            }
            catch
            {
                MessageBox.Show("یک ردیف را انتخاب کنید");
            }
        }

        private void frm_SellingBooks_Load(object sender, EventArgs e)
        {
            var g = mdb.customer.ToList();
            comboBox3.DataSource = g;
            var k = mdb.sabadhas.ToList();
            comboBox1.DataSource = k;
            var j = mdb.books.ToList();
            comboBox2.DataSource = j;
            refreshgrid();
        }
    }
}
