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
using classha;
using MediaFoundation.Misc;

namespace bookstore1
{
    public partial class frm_AddBook : RadForm
    {
        frm_launcher launcher;
        MyDBContext mdb = new MyDBContext();
        public frm_AddBook(frm_launcher flauncher)
        {
            InitializeComponent();
            launcher = flauncher;
            comboBox1.DisplayMember = "LastName";
            comboBox1.ValueMember = "ID";
            //dataGridView1.AutoGenerateColumns = false;
            //dataGridView1.Columns.Add("Id", "ID");
            //dataGridView1.Columns.Add("bname", "Book Name");
            //dataGridView1.Columns.Add("genere", "Genre");
            //dataGridView1.Columns.Add("ISBN", "ISBN");
            //dataGridView1.Columns.Add("price", "Price");
            refreshgrid();
        }
        bool upstats = false;
        Guid bguid;

        private void frm_AddBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            launcher.Show();

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            //try
            {
                if (upstats)
                {
                    var alist = mdb.books.Where(x => x.Id == bguid).First();
                    alist.bname = radTextBoxControl1.Text;
                    alist.genere = radTextBoxControl2.Text;
                    alist.ISBN = Convert.ToInt64(radTextBoxControl3.Text);
                    alist.price = Convert.ToInt32(radTextBoxControl4.Text);
                }
                else
                {

                    Book b = new Book();
                    b.Id = Guid.NewGuid();
                    b.bname = radTextBoxControl1.Text;
                    b.genere = radTextBoxControl2.Text;
                    var a = mdb.author.Where(x => x.ID == (Guid)comboBox1.SelectedValue).First();
                    b.author = a;
                    b.ISBN = long.Parse(radTextBoxControl3.Text);
                    b.price = Convert.ToInt32(radTextBoxControl4.Text);
                    mdb.books.Add(b);

                }
                mdb.SaveChanges();
                refreshgrid();
            }
            ////catch
            //{
            //    MessageBox.Show("اطلاعات را کامل وارد کنید");
            //}
        }
        public void refreshgrid()
        {
            var books = mdb.books.ToList();

            dataGridView1.DataSource = books;
        }
        private void frm_AddBook_Load(object sender, EventArgs e)
        {
            // var b = mdb.author;

            var k = mdb.author.ToList();
            comboBox1.DataSource = k;
            refreshgrid();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radButton4_Click(object sender, EventArgs e)
        {

            
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("برای حذف یا بروزرسانی از توی باکس فرد مورد نظر را انتخاب کنید \nوبعد روی دکمه مورد نظر بزنید");
        }

        private void radButton2_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {

            try
            {
                var b = Guid.Parse(dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString());

                var blist = mdb.books.Where(x => x.Id == b).First();
                radTextBoxControl1.Text = blist.bname;
                radTextBoxControl2.Text = blist.genere;
                radTextBoxControl3.Text = blist.ISBN.ToString();
                radTextBoxControl4.Text = blist.price.ToString();

                upstats = true;
                bguid = blist.Id;
            }
            catch { }

        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            upstats = false;
            radTextBoxControl1.Text = "";
            radTextBoxControl2.Text = "";
            radTextBoxControl3.Text = "";
            radTextBoxControl4.Text = "";
        }

        private void radButton4_Click_1(object sender, EventArgs e)
        {
            try
            {
                var b = Guid.Parse(dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString());
                mdb.books.Remove(mdb.books.Where(c => c.Id == b).First());
                mdb.SaveChanges();
                refreshgrid();
            }
            catch
            {
                MessageBox.Show("یک ردیف را انتخاب کنید");
            }
        }
    }
}
