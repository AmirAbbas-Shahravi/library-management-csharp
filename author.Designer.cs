namespace bookstore1
{
    partial class frm_author
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            crystalDarkTheme1 = new Telerik.WinControls.Themes.CrystalDarkTheme();
            office2019DarkTheme1 = new Telerik.WinControls.Themes.Office2019DarkTheme();
            radLabel1 = new Telerik.WinControls.UI.RadLabel();
            radLabel2 = new Telerik.WinControls.UI.RadLabel();
            radLabel3 = new Telerik.WinControls.UI.RadLabel();
            radTextBoxControl1 = new Telerik.WinControls.UI.RadTextBoxControl();
            radTextBoxControl2 = new Telerik.WinControls.UI.RadTextBoxControl();
            radTextBoxControl3 = new Telerik.WinControls.UI.RadTextBoxControl();
            radButton1 = new Telerik.WinControls.UI.RadButton();
            dataGridView1 = new DataGridView();
            radButton3 = new Telerik.WinControls.UI.RadButton();
            radButton4 = new Telerik.WinControls.UI.RadButton();
            radButton5 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)radLabel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radLabel3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radTextBoxControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radTextBoxControl2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radTextBoxControl3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radButton1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radButton3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radButton4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radButton5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // radLabel1
            // 
            radLabel1.Location = new Point(311, 12);
            radLabel1.Name = "radLabel1";
            radLabel1.Size = new Size(19, 20);
            radLabel1.TabIndex = 0;
            radLabel1.Text = "نام";
            radLabel1.ThemeName = "CrystalDark";
            // 
            // radLabel2
            // 
            radLabel2.Location = new Point(288, 59);
            radLabel2.Name = "radLabel2";
            radLabel2.Size = new Size(66, 20);
            radLabel2.TabIndex = 1;
            radLabel2.Text = "نام خانوادگی";
            radLabel2.ThemeName = "CrystalDark";
            // 
            // radLabel3
            // 
            radLabel3.Location = new Point(311, 108);
            radLabel3.Name = "radLabel3";
            radLabel3.Size = new Size(28, 20);
            radLabel3.TabIndex = 2;
            radLabel3.Text = "ژانر";
            radLabel3.ThemeName = "CrystalDark";
            // 
            // radTextBoxControl1
            // 
            radTextBoxControl1.Location = new Point(396, 12);
            radTextBoxControl1.Name = "radTextBoxControl1";
            radTextBoxControl1.RightToLeft = RightToLeft.Yes;
            radTextBoxControl1.Size = new Size(125, 29);
            radTextBoxControl1.TabIndex = 3;
            radTextBoxControl1.ThemeName = "Office2019Dark";
            // 
            // radTextBoxControl2
            // 
            radTextBoxControl2.Location = new Point(396, 59);
            radTextBoxControl2.Name = "radTextBoxControl2";
            radTextBoxControl2.RightToLeft = RightToLeft.Yes;
            radTextBoxControl2.Size = new Size(125, 28);
            radTextBoxControl2.TabIndex = 4;
            radTextBoxControl2.ThemeName = "Office2019Dark";
            // 
            // radTextBoxControl3
            // 
            radTextBoxControl3.Location = new Point(396, 108);
            radTextBoxControl3.Name = "radTextBoxControl3";
            radTextBoxControl3.RightToLeft = RightToLeft.Yes;
            radTextBoxControl3.Size = new Size(125, 29);
            radTextBoxControl3.TabIndex = 5;
            radTextBoxControl3.ThemeName = "Office2019Dark";
            // 
            // radButton1
            // 
            radButton1.Location = new Point(396, 148);
            radButton1.Name = "radButton1";
            radButton1.Size = new Size(125, 24);
            radButton1.TabIndex = 6;
            radButton1.Text = "ثبت";
            radButton1.ThemeName = "Fluent";
            radButton1.Click += radButton1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Cursor = Cursors.Hand;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(50, 262);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(825, 151);
            dataGridView1.TabIndex = 7;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // radButton3
            // 
            radButton3.Location = new Point(527, 222);
            radButton3.Name = "radButton3";
            radButton3.Size = new Size(110, 24);
            radButton3.TabIndex = 9;
            radButton3.Text = "حدف";
            radButton3.ThemeName = "Fluent";
            radButton3.Click += radButton3_Click;
            // 
            // radButton4
            // 
            radButton4.Location = new Point(874, 12);
            radButton4.Name = "radButton4";
            radButton4.Size = new Size(47, 24);
            radButton4.TabIndex = 10;
            radButton4.Text = "راهنما";
            radButton4.ThemeName = "Fluent";
            radButton4.Click += radButton4_Click;
            // 
            // radButton5
            // 
            radButton5.Location = new Point(271, 222);
            radButton5.Name = "radButton5";
            radButton5.Size = new Size(110, 24);
            radButton5.TabIndex = 11;
            radButton5.Text = "جدید";
            radButton5.ThemeName = "Fluent";
            radButton5.Click += radButton5_Click;
            // 
            // frm_author
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 608);
            Controls.Add(radButton5);
            Controls.Add(radButton4);
            Controls.Add(radButton3);
            Controls.Add(dataGridView1);
            Controls.Add(radButton1);
            Controls.Add(radTextBoxControl3);
            Controls.Add(radTextBoxControl2);
            Controls.Add(radTextBoxControl1);
            Controls.Add(radLabel3);
            Controls.Add(radLabel2);
            Controls.Add(radLabel1);
            Name = "frm_author";
            Text = "author";
            ThemeName = "CrystalDark";
            FormClosing += frm_author_FormClosing;
            Load += frm_author_Load;
            ((System.ComponentModel.ISupportInitialize)radLabel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)radLabel3).EndInit();
            ((System.ComponentModel.ISupportInitialize)radTextBoxControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radTextBoxControl2).EndInit();
            ((System.ComponentModel.ISupportInitialize)radTextBoxControl3).EndInit();
            ((System.ComponentModel.ISupportInitialize)radButton1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radButton3).EndInit();
            ((System.ComponentModel.ISupportInitialize)radButton4).EndInit();
            ((System.ComponentModel.ISupportInitialize)radButton5).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Telerik.WinControls.Themes.CrystalDarkTheme crystalDarkTheme1;
        private Telerik.WinControls.Themes.Office2019DarkTheme office2019DarkTheme1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBoxControl radTextBoxControl1;
        private Telerik.WinControls.UI.RadTextBoxControl radTextBoxControl2;
        private Telerik.WinControls.UI.RadTextBoxControl radTextBoxControl3;
        private Telerik.WinControls.UI.RadButton radButton1;
        private DataGridView dataGridView1;
        private Telerik.WinControls.UI.RadButton radButton3;
        private Telerik.WinControls.UI.RadButton radButton4;
        private Telerik.WinControls.UI.RadButton radButton5;
    }
}