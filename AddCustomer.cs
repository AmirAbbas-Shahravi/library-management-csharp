using classha;
using MediaFoundation.Misc;
using SHJ.PersianCulture.DateTimes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace bookstore1
{
    public partial class frm_AddCustomer : RadForm
    {
        frm_launcher launcher;
        MyDBContext mdb = new MyDBContext();
        public frm_AddCustomer(frm_launcher flauncher)
        {
            InitializeComponent();
            launcher = flauncher;
            CultureInfo.CurrentCulture = PersianCulture.Instance;
            CultureInfo.CurrentUICulture = PersianCulture.Instance;
            var faCulture = new CultureInfo("fa-IR");
            radDateTimePicker1.Culture = faCulture;
        }
        bool upstats = false;
        Guid cguid;

        private void AddCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            launcher.Show();
        }

        private void radLabel1_Click(object sender, EventArgs e)
        {

        }
        public void refreshgrid()
        {
            var customers = mdb.customer.ToList();

            dataGridView1.DataSource = customers;
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (upstats)
                {

                    var alist = mdb.customer.Where(x => x.ID == cguid).First();
                    alist.FirstName = radTextBoxControl1.Text;
                    alist.LastName = radTextBoxControl2.Text;
                    alist.phone = long.Parse(radTextBoxControl3.Text);
                    alist.email = radTextBoxControl4.Text;
                    var k = radDateTimePicker1.Value;
                    alist.birthday = k;
                    alist.addres = radTextBoxControl5.Text;
                    alist.National_code = long.Parse(radTextBoxControl6.Text);

                }
                else
                {
                    customer a = new customer();
                    a.FirstName = radTextBoxControl1.Text;
                    a.LastName = radTextBoxControl2.Text;
                    a.phone = long.Parse(radTextBoxControl3.Text);
                    a.email = radTextBoxControl4.Text;
                    a.birthday = radDateTimePicker1.Value;
                    a.addres = radTextBoxControl5.Text;
                    a.National_code = long.Parse(radTextBoxControl6.Text);
                    mdb.customer.Add(a);
                }
                mdb.SaveChanges();
                refreshgrid();

            }
            catch
            {
                MessageBox.Show("اطلاعات را درست وارد کنید");
            }
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            try
            {
                var b = Guid.Parse(dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString());
                mdb.customer.Remove(mdb.customer.Where(c => c.ID == b).First());
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

                var alist = mdb.customer.Where(x => x.ID == b).First();
                radTextBoxControl1.Text = alist.FirstName;
                radTextBoxControl2.Text = alist.LastName;
                radTextBoxControl3.Text = alist.phone.ToString();
                radTextBoxControl4.Text = alist.email;
                radTextBoxControl5.Text = alist.phone.ToString();
                radTextBoxControl6.Text = alist.National_code.ToString();
                upstats = true;
                cguid = alist.ID;
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
            radTextBoxControl5.Text = "";
            radTextBoxControl6.Text = "";
        }
    }
}
