namespace bookstore1
{
    partial class frm_Report
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
            crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            office2019DarkTheme1 = new Telerik.WinControls.Themes.Office2019DarkTheme();
            crystalDarkTheme1 = new Telerik.WinControls.Themes.CrystalDarkTheme();
            dataGridView1 = new DataGridView();
            radButton1 = new Telerik.WinControls.UI.RadButton();
            radButton2 = new Telerik.WinControls.UI.RadButton();
            radButton3 = new Telerik.WinControls.UI.RadButton();
            radButton4 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radButton1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radButton2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radButton3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radButton4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 153);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(888, 187);
            dataGridView1.TabIndex = 0;
            // 
            // radButton1
            // 
            radButton1.Location = new Point(101, 75);
            radButton1.Name = "radButton1";
            radButton1.Size = new Size(110, 24);
            radButton1.TabIndex = 1;
            radButton1.Text = "کتاب";
            radButton1.ThemeName = "Fluent";
            radButton1.Click += radButton1_Click;
            // 
            // radButton2
            // 
            radButton2.Location = new Point(308, 75);
            radButton2.Name = "radButton2";
            radButton2.Size = new Size(110, 24);
            radButton2.TabIndex = 2;
            radButton2.Text = "نویسنده";
            radButton2.ThemeName = "Fluent";
            radButton2.Click += radButton2_Click;
            // 
            // radButton3
            // 
            radButton3.Location = new Point(488, 75);
            radButton3.Name = "radButton3";
            radButton3.Size = new Size(110, 24);
            radButton3.TabIndex = 3;
            radButton3.Text = "مشتری";
            radButton3.ThemeName = "Fluent";
            radButton3.Click += radButton3_Click;
            // 
            // radButton4
            // 
            radButton4.Location = new Point(691, 75);
            radButton4.Name = "radButton4";
            radButton4.Size = new Size(110, 24);
            radButton4.TabIndex = 4;
            radButton4.Text = "سبد";
            radButton4.ThemeName = "Fluent";
            radButton4.Click += radButton4_Click;
            // 
            // frm_Report
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 310);
            Controls.Add(radButton4);
            Controls.Add(radButton3);
            Controls.Add(radButton2);
            Controls.Add(radButton1);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            Name = "frm_Report";
            Text = "Report";
            ThemeName = "CrystalDark";
            FormClosing += frm_Report_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radButton1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radButton2).EndInit();
            ((System.ComponentModel.ISupportInitialize)radButton3).EndInit();
            ((System.ComponentModel.ISupportInitialize)radButton4).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
        private Telerik.WinControls.Themes.Office2019DarkTheme office2019DarkTheme1;
        private Telerik.WinControls.Themes.CrystalDarkTheme crystalDarkTheme1;
        private DataGridView dataGridView1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadButton radButton3;
        private Telerik.WinControls.UI.RadButton radButton4;
    }
}