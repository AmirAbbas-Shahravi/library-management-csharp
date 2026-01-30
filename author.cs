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
    public partial class frm_author : RadForm
    {
        frm_launcher frm_Launcher;

        public frm_author(frm_launcher fLauncher)
        {
            InitializeComponent();
            frm_Launcher = fLauncher;
            //dataGridView1.AutoGenerateColumns = false;
            //dataGridView1.Columns.Add("ID", "ID");
            //dataGridView1.Columns.Add("FirstName", "First Name");
            //dataGridView1.Columns.Add("LastName", "Last Name");
            //dataGridView1.Columns.Add("genre", "Genre");
            //refreshgrid();
        }
        MyDBContext mdb = new MyDBContext();
        private void frm_author_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_Launcher.Show();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {



                if (upstats)
                {

                    var alist = mdb.author.Where(x => x.ID == aguid).First();
                    alist.FirstName = radTextBoxControl1.Text;
                    alist.LastName = radTextBoxControl2.Text;
                    alist.genre = radTextBoxControl3.Text;

                }
                else
                {
                    author a = new author();
                    a.FirstName = radTextBoxControl1.Text;
                    a.LastName = radTextBoxControl2.Text;
                    a.genre = radTextBoxControl3.Text;
                    mdb.author.Add(a);
                }
                mdb.SaveChanges();
                refreshgrid();

            }
            catch
            {
                MessageBox.Show("اطلاعات را درست وارد کنید");
            }

        }
        bool upstats = false;
        Guid aguid;
        public void refreshgrid()
        {
            var authors = mdb.author.ToList();

            dataGridView1.DataSource = authors;
        }
        private void frm_author_Load(object sender, EventArgs e)
        {
            refreshgrid();
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("برای حذف یا بروزرسانی از توی باکس فرد مورد نظر را انتخاب کنید \nوبعد روی دکمه مورد نظر بزنید");
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            try
            {
                var b = Guid.Parse(dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString());
                mdb.author.Remove(mdb.author.Where(c => c.ID == b).First());
                mdb.SaveChanges();
                refreshgrid();
            }
            catch
            {
                MessageBox.Show("یک ردیف را انتخاب کنید");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            try
            {
                var b = Guid.Parse(dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString());

                var alist = mdb.author.Where(x => x.ID == b).First();
                radTextBoxControl1.Text = alist.FirstName;
                radTextBoxControl2.Text = alist.LastName;
                radTextBoxControl3.Text = alist.genre;
                upstats = true;
                aguid = alist.ID;
            }
            catch { }
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            upstats = false;
            radTextBoxControl1.Text = "";
            radTextBoxControl2.Text = "";
            radTextBoxControl3.Text = "";
        }

        private void radButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
