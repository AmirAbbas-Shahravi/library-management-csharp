namespace bookstore1
{
    partial class frm_launcher
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            crystalDarkTheme1 = new Telerik.WinControls.Themes.CrystalDarkTheme();
            radButton1 = new Telerik.WinControls.UI.RadButton();
            radButton2 = new Telerik.WinControls.UI.RadButton();
            radButton3 = new Telerik.WinControls.UI.RadButton();
            radButton4 = new Telerik.WinControls.UI.RadButton();
            office2019DarkTheme1 = new Telerik.WinControls.Themes.Office2019DarkTheme();
            radButton5 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)radButton1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radButton2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radButton3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radButton4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radButton5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this).BeginInit();
            SuspendLayout();
            // 
            // radButton1
            // 
            radButton1.Location = new Point(202, 12);
            radButton1.Name = "radButton1";
            radButton1.Size = new Size(120, 32);
            radButton1.TabIndex = 0;
            radButton1.Text = "ثبت نویسنده";
            radButton1.ThemeName = "Office2019Dark";
            radButton1.Click += radButton1_Click;
            // 
            // radButton2
            // 
            radButton2.Location = new Point(202, 62);
            radButton2.Name = "radButton2";
            radButton2.Size = new Size(120, 31);
            radButton2.TabIndex = 1;
            radButton2.Text = "ثبت کتاب ";
            radButton2.ThemeName = "Office2019Dark";
            radButton2.Click += radButton2_Click;
            // 
            // radButton3
            // 
            radButton3.Location = new Point(202, 113);
            radButton3.Name = "radButton3";
            radButton3.Size = new Size(120, 30);
            radButton3.TabIndex = 2;
            radButton3.Text = "ثبت مشتری";
            radButton3.ThemeName = "Office2019Dark";
            radButton3.Click += radButton3_Click;
            // 
            // radButton4
            // 
            radButton4.Location = new Point(202, 165);
            radButton4.Name = "radButton4";
            radButton4.Size = new Size(120, 31);
            radButton4.TabIndex = 3;
            radButton4.Text = "فروش کتاب";
            radButton4.ThemeName = "Office2019Dark";
            radButton4.Click += radButton4_Click;
            // 
            // radButton5
            // 
            radButton5.Location = new Point(202, 216);
            radButton5.Name = "radButton5";
            radButton5.Size = new Size(120, 30);
            radButton5.TabIndex = 4;
            radButton5.Text = "گزارش";
            radButton5.ThemeName = "Office2019Dark";
            radButton5.Click += radButton5_Click;
            // 
            // frm_launcher
            // 
            AutoScaleBaseSize = new Size(7, 15);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 315);
            Controls.Add(radButton5);
            Controls.Add(radButton4);
            Controls.Add(radButton3);
            Controls.Add(radButton2);
            Controls.Add(radButton1);
            MaximizeBox = false;
            Name = "frm_launcher";
            Text = "Launcher";
            ThemeName = "CrystalDark";
            ((System.ComponentModel.ISupportInitialize)radButton1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radButton2).EndInit();
            ((System.ComponentModel.ISupportInitialize)radButton3).EndInit();
            ((System.ComponentModel.ISupportInitialize)radButton4).EndInit();
            ((System.ComponentModel.ISupportInitialize)radButton5).EndInit();
            ((System.ComponentModel.ISupportInitialize)this).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Telerik.WinControls.Themes.CrystalDarkTheme crystalDarkTheme1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadButton radButton3;
        private Telerik.WinControls.UI.RadButton radButton4;
        private Telerik.WinControls.Themes.Office2019DarkTheme office2019DarkTheme1;
        private Telerik.WinControls.UI.RadButton radButton5;
    }
}
