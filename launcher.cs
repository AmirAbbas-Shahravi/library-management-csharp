using Telerik.WinControls;
using Telerik.WinControls.UI;
using Telerik.Windows.Documents.Fixed.Model.Objects;

namespace bookstore1
{
    public partial class frm_launcher : RadForm
    {
        public frm_launcher()
        {
            InitializeComponent();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            frm_author frm_Author = new frm_author(this);
            this.Hide();
            frm_Author.Show();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            frm_AddBook frm_AddBook = new frm_AddBook(this);
            this.Hide();
            frm_AddBook.Show();
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            frm_AddCustomer frm_AddCustomer = new frm_AddCustomer(this);
            this.Hide();
            frm_AddCustomer.Show();
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            frm_SellingBooks frm_SellingBooks = new frm_SellingBooks(this);
            this.Hide();
            frm_SellingBooks.Show();
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            frm_Report frm_Report = new frm_Report(this);
            this.Hide();
            frm_Report.Show();
        }
    }
}
