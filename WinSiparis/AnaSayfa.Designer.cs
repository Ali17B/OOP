namespace WinSiparis
{
    partial class AnaSayfa
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
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            siparisYonetimiToolStripMenuItem = new ToolStripMenuItem();
            urunYonetimiToolStripMenuItem = new ToolStripMenuItem();
            siparisOlusturToolStripMenuItem = new ToolStripMenuItem();
            siparisRapuruToolStripMenuItem = new ToolStripMenuItem();
            menuEklToolStripMenuItem = new ToolStripMenuItem();
            extraMalzemeEkleToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(633, 66);
            button1.Name = "button1";
            button1.Size = new Size(112, 66);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { siparisYonetimiToolStripMenuItem, urunYonetimiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // siparisYonetimiToolStripMenuItem
            // 
            siparisYonetimiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { siparisOlusturToolStripMenuItem, siparisRapuruToolStripMenuItem });
            siparisYonetimiToolStripMenuItem.Name = "siparisYonetimiToolStripMenuItem";
            siparisYonetimiToolStripMenuItem.Size = new Size(153, 29);
            siparisYonetimiToolStripMenuItem.Text = "Siparis Yonetimi";
            // 
            // urunYonetimiToolStripMenuItem
            // 
            urunYonetimiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuEklToolStripMenuItem, extraMalzemeEkleToolStripMenuItem });
            urunYonetimiToolStripMenuItem.Name = "urunYonetimiToolStripMenuItem";
            urunYonetimiToolStripMenuItem.Size = new Size(139, 29);
            urunYonetimiToolStripMenuItem.Text = "Urun Yonetimi";
            // 
            // siparisOlusturToolStripMenuItem
            // 
            siparisOlusturToolStripMenuItem.Name = "siparisOlusturToolStripMenuItem";
            siparisOlusturToolStripMenuItem.Size = new Size(270, 34);
            siparisOlusturToolStripMenuItem.Text = "Siparis Olustur";
            // 
            // siparisRapuruToolStripMenuItem
            // 
            siparisRapuruToolStripMenuItem.Name = "siparisRapuruToolStripMenuItem";
            siparisRapuruToolStripMenuItem.Size = new Size(270, 34);
            siparisRapuruToolStripMenuItem.Text = "Siparis Rapuru";
            // 
            // menuEklToolStripMenuItem
            // 
            menuEklToolStripMenuItem.Name = "menuEklToolStripMenuItem";
            menuEklToolStripMenuItem.Size = new Size(270, 34);
            menuEklToolStripMenuItem.Text = "Menu Ekle";
            // 
            // extraMalzemeEkleToolStripMenuItem
            // 
            extraMalzemeEkleToolStripMenuItem.Name = "extraMalzemeEkleToolStripMenuItem";
            extraMalzemeEkleToolStripMenuItem.Size = new Size(270, 34);
            extraMalzemeEkleToolStripMenuItem.Text = "Extra Malzeme Ekle";
            // 
            // AnaSayfa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "AnaSayfa";
            Text = "Ana Sayfa";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem siparisYonetimiToolStripMenuItem;
        private ToolStripMenuItem urunYonetimiToolStripMenuItem;
        private ToolStripMenuItem siparisOlusturToolStripMenuItem;
        private ToolStripMenuItem siparisRapuruToolStripMenuItem;
        private ToolStripMenuItem menuEklToolStripMenuItem;
        private ToolStripMenuItem extraMalzemeEkleToolStripMenuItem;
    }
}
