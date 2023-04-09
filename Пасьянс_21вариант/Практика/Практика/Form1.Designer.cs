
namespace Практика
{
    partial class Пасьянс_Горем_Султана
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Пасьянс_Горем_Султана));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.играToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новаяИграToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменитьХодToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правилаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разработчикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.играToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1144, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // играToolStripMenuItem
            // 
            this.играToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяИграToolStripMenuItem,
            this.отменитьХодToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.играToolStripMenuItem.Name = "играToolStripMenuItem";
            this.играToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.играToolStripMenuItem.Text = "Игра";
            // 
            // новаяИграToolStripMenuItem
            // 
            this.новаяИграToolStripMenuItem.Name = "новаяИграToolStripMenuItem";
            this.новаяИграToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.новаяИграToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.новаяИграToolStripMenuItem.Text = "Новая игра";
            this.новаяИграToolStripMenuItem.Click += new System.EventHandler(this.НоваяИгра);
            // 
            // отменитьХодToolStripMenuItem
            // 
            this.отменитьХодToolStripMenuItem.Enabled = false;
            this.отменитьХодToolStripMenuItem.Name = "отменитьХодToolStripMenuItem";
            this.отменитьХодToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.отменитьХодToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.отменитьХодToolStripMenuItem.Text = "Отменить ход";
            this.отменитьХодToolStripMenuItem.Click += new System.EventHandler(this.отменитьХодToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.Выход);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.правилаToolStripMenuItem,
            this.разработчикиToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // правилаToolStripMenuItem
            // 
            this.правилаToolStripMenuItem.Name = "правилаToolStripMenuItem";
            this.правилаToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.правилаToolStripMenuItem.Text = "Правила";
            this.правилаToolStripMenuItem.Click += new System.EventHandler(this.takerules);
            // 
            // разработчикиToolStripMenuItem
            // 
            this.разработчикиToolStripMenuItem.Name = "разработчикиToolStripMenuItem";
            this.разработчикиToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.разработчикиToolStripMenuItem.Text = "Разработчики";
            this.разработчикиToolStripMenuItem.Click += new System.EventHandler(this.dev);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "0.bmp");
            this.imageList1.Images.SetKeyName(1, "1.bmp");
            this.imageList1.Images.SetKeyName(2, "2.bmp");
            this.imageList1.Images.SetKeyName(3, "3.bmp");
            this.imageList1.Images.SetKeyName(4, "4.bmp");
            this.imageList1.Images.SetKeyName(5, "5.bmp");
            this.imageList1.Images.SetKeyName(6, "6.bmp");
            this.imageList1.Images.SetKeyName(7, "7.bmp");
            this.imageList1.Images.SetKeyName(8, "8.bmp");
            this.imageList1.Images.SetKeyName(9, "9.bmp");
            this.imageList1.Images.SetKeyName(10, "10.bmp");
            this.imageList1.Images.SetKeyName(11, "11.bmp");
            this.imageList1.Images.SetKeyName(12, "12.bmp");
            this.imageList1.Images.SetKeyName(13, "13.bmp");
            this.imageList1.Images.SetKeyName(14, "14.bmp");
            this.imageList1.Images.SetKeyName(15, "15.bmp");
            this.imageList1.Images.SetKeyName(16, "16.bmp");
            this.imageList1.Images.SetKeyName(17, "17.bmp");
            this.imageList1.Images.SetKeyName(18, "18.bmp");
            this.imageList1.Images.SetKeyName(19, "19.bmp");
            this.imageList1.Images.SetKeyName(20, "20.bmp");
            this.imageList1.Images.SetKeyName(21, "21.bmp");
            this.imageList1.Images.SetKeyName(22, "22.bmp");
            this.imageList1.Images.SetKeyName(23, "23.bmp");
            this.imageList1.Images.SetKeyName(24, "24.bmp");
            this.imageList1.Images.SetKeyName(25, "25.bmp");
            this.imageList1.Images.SetKeyName(26, "26.bmp");
            this.imageList1.Images.SetKeyName(27, "27.bmp");
            this.imageList1.Images.SetKeyName(28, "28.bmp");
            this.imageList1.Images.SetKeyName(29, "29.bmp");
            this.imageList1.Images.SetKeyName(30, "30.bmp");
            this.imageList1.Images.SetKeyName(31, "31.bmp");
            this.imageList1.Images.SetKeyName(32, "32.bmp");
            this.imageList1.Images.SetKeyName(33, "33.bmp");
            this.imageList1.Images.SetKeyName(34, "34.bmp");
            this.imageList1.Images.SetKeyName(35, "35.bmp");
            this.imageList1.Images.SetKeyName(36, "36.bmp");
            this.imageList1.Images.SetKeyName(37, "37.bmp");
            this.imageList1.Images.SetKeyName(38, "38.bmp");
            this.imageList1.Images.SetKeyName(39, "39.bmp");
            this.imageList1.Images.SetKeyName(40, "40.bmp");
            this.imageList1.Images.SetKeyName(41, "41.bmp");
            this.imageList1.Images.SetKeyName(42, "42.bmp");
            this.imageList1.Images.SetKeyName(43, "43.bmp");
            this.imageList1.Images.SetKeyName(44, "44.bmp");
            this.imageList1.Images.SetKeyName(45, "45.bmp");
            this.imageList1.Images.SetKeyName(46, "46.bmp");
            this.imageList1.Images.SetKeyName(47, "47.bmp");
            this.imageList1.Images.SetKeyName(48, "48.bmp");
            this.imageList1.Images.SetKeyName(49, "49.bmp");
            this.imageList1.Images.SetKeyName(50, "50.bmp");
            this.imageList1.Images.SetKeyName(51, "51.bmp");
            this.imageList1.Images.SetKeyName(52, "52.bmp");
            this.imageList1.Images.SetKeyName(53, "53.bmp");
            this.imageList1.Images.SetKeyName(54, "54.bmp");
            this.imageList1.Images.SetKeyName(55, "");
            // 
            // Пасьянс_Горем_Султана
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1144, 516);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1162, 563);
            this.Name = "Пасьянс_Горем_Султана";
            this.Text = "Пирамида Султана";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новаяИграToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменитьХодToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правилаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разработчикиToolStripMenuItem;
    }
}

