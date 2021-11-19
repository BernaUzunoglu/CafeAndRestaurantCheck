namespace CafeAndRestaurant.Forms
{
    partial class FrmSiparis
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSiparis));
            this.gbMenü = new System.Windows.Forms.GroupBox();
            this.flwpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flpMenuElemanlari = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dtGrdSiparis = new System.Windows.Forms.DataGridView();
            this.urnAdiSiparis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urnFiyatSiparis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblToplam = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btn_SiparisAl = new System.Windows.Forms.Button();
            this.btnAdisyonKapat = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.gbMenü.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdSiparis)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMenü
            // 
            this.gbMenü.AutoSize = true;
            this.gbMenü.BackColor = System.Drawing.Color.White;
            this.gbMenü.Controls.Add(this.flwpMenu);
            this.gbMenü.Controls.Add(this.panel2);
            this.gbMenü.Controls.Add(this.panel1);
            this.gbMenü.ForeColor = System.Drawing.Color.Bisque;
            this.gbMenü.Location = new System.Drawing.Point(0, 0);
            this.gbMenü.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbMenü.Name = "gbMenü";
            this.gbMenü.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbMenü.Size = new System.Drawing.Size(1759, 1007);
            this.gbMenü.TabIndex = 2;
            this.gbMenü.TabStop = false;
            // 
            // flwpMenu
            // 
            this.flwpMenu.AutoScroll = true;
            this.flwpMenu.AutoSize = true;
            this.flwpMenu.BackColor = System.Drawing.Color.White;
            this.flwpMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.flwpMenu.Location = new System.Drawing.Point(3, 24);
            this.flwpMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flwpMenu.Name = "flwpMenu";
            this.flwpMenu.Size = new System.Drawing.Size(0, 878);
            this.flwpMenu.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.flpMenuElemanlari);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1753, 878);
            this.panel2.TabIndex = 7;
            // 
            // flpMenuElemanlari
            // 
            this.flpMenuElemanlari.AutoScroll = true;
            this.flpMenuElemanlari.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpMenuElemanlari.BackColor = System.Drawing.Color.White;
            this.flpMenuElemanlari.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpMenuElemanlari.Location = new System.Drawing.Point(0, 0);
            this.flpMenuElemanlari.Margin = new System.Windows.Forms.Padding(800, 4, 3, 4);
            this.flpMenuElemanlari.Name = "flpMenuElemanlari";
            this.flpMenuElemanlari.Size = new System.Drawing.Size(1290, 878);
            this.flpMenuElemanlari.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.dtGrdSiparis);
            this.flowLayoutPanel1.Controls.Add(this.lblToplam);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1290, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(463, 878);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // dtGrdSiparis
            // 
            this.dtGrdSiparis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdSiparis.BackgroundColor = System.Drawing.Color.White;
            this.dtGrdSiparis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGrdSiparis.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtGrdSiparis.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dtGrdSiparis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGrdSiparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdSiparis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urnAdiSiparis,
            this.urnFiyatSiparis});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGrdSiparis.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtGrdSiparis.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtGrdSiparis.GridColor = System.Drawing.Color.White;
            this.dtGrdSiparis.Location = new System.Drawing.Point(0, 4);
            this.dtGrdSiparis.Margin = new System.Windows.Forms.Padding(0, 4, 3, 4);
            this.dtGrdSiparis.Name = "dtGrdSiparis";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGrdSiparis.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtGrdSiparis.RowHeadersVisible = false;
            this.dtGrdSiparis.RowHeadersWidth = 60;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dtGrdSiparis.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtGrdSiparis.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dtGrdSiparis.RowTemplate.Height = 50;
            this.dtGrdSiparis.RowTemplate.ReadOnly = true;
            this.dtGrdSiparis.Size = new System.Drawing.Size(517, 556);
            this.dtGrdSiparis.TabIndex = 17;
            // 
            // urnAdiSiparis
            // 
            this.urnAdiSiparis.FillWeight = 150F;
            this.urnAdiSiparis.HeaderText = "Sipariş";
            this.urnAdiSiparis.MinimumWidth = 6;
            this.urnAdiSiparis.Name = "urnAdiSiparis";
            // 
            // urnFiyatSiparis
            // 
            this.urnFiyatSiparis.HeaderText = "Fiyat";
            this.urnFiyatSiparis.MinimumWidth = 6;
            this.urnFiyatSiparis.Name = "urnFiyatSiparis";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblToplam.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblToplam.Location = new System.Drawing.Point(3, 564);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(151, 46);
            this.lblToplam.TabIndex = 18;
            this.lblToplam.Text = "TOPLAM";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGeri);
            this.panel1.Controls.Add(this.btn_SiparisAl);
            this.panel1.Controls.Add(this.btnAdisyonKapat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 902);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1753, 101);
            this.panel1.TabIndex = 6;
            // 
            // btnGeri
            // 
            this.btnGeri.AutoEllipsis = true;
            this.btnGeri.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGeri.BackColor = System.Drawing.Color.Chocolate;
            this.btnGeri.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGeri.ForeColor = System.Drawing.Color.White;
            this.btnGeri.Location = new System.Drawing.Point(0, 0);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGeri.Size = new System.Drawing.Size(528, 101);
            this.btnGeri.TabIndex = 6;
            this.btnGeri.Text = "GERİ";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btn_SiparisAl
            // 
            this.btn_SiparisAl.AutoEllipsis = true;
            this.btn_SiparisAl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_SiparisAl.BackColor = System.Drawing.Color.Chocolate;
            this.btn_SiparisAl.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_SiparisAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SiparisAl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_SiparisAl.ForeColor = System.Drawing.Color.White;
            this.btn_SiparisAl.Location = new System.Drawing.Point(1290, 0);
            this.btn_SiparisAl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SiparisAl.Name = "btn_SiparisAl";
            this.btn_SiparisAl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_SiparisAl.Size = new System.Drawing.Size(463, 101);
            this.btn_SiparisAl.TabIndex = 5;
            this.btn_SiparisAl.Text = "SİPARİŞ AL";
            this.btn_SiparisAl.UseVisualStyleBackColor = false;
            this.btn_SiparisAl.Click += new System.EventHandler(this.btn_SiparisAl_Click_1);
            // 
            // btnAdisyonKapat
            // 
            this.btnAdisyonKapat.AutoEllipsis = true;
            this.btnAdisyonKapat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdisyonKapat.BackColor = System.Drawing.Color.Chocolate;
            this.btnAdisyonKapat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdisyonKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdisyonKapat.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdisyonKapat.ForeColor = System.Drawing.Color.White;
            this.btnAdisyonKapat.Location = new System.Drawing.Point(0, 0);
            this.btnAdisyonKapat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdisyonKapat.Name = "btnAdisyonKapat";
            this.btnAdisyonKapat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdisyonKapat.Size = new System.Drawing.Size(1753, 101);
            this.btnAdisyonKapat.TabIndex = 4;
            this.btnAdisyonKapat.Text = "HESAP";
            this.btnAdisyonKapat.UseVisualStyleBackColor = false;
            this.btnAdisyonKapat.Click += new System.EventHandler(this.btnAdisyonKapat_Click_1);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // FrmSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1759, 1007);
            this.ControlBox = false;
            this.Controls.Add(this.gbMenü);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSiparis";
            this.Text = "FrmSiparis";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSiparis_Load);
            this.gbMenü.ResumeLayout(false);
            this.gbMenü.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdSiparis)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gbMenü;
        private FlowLayoutPanel flpMenuElemanlari;
        private FlowLayoutPanel flwpMenu;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView dtGrdSiparis;
        private DataGridViewTextBoxColumn urnAdiSiparis;
        private DataGridViewTextBoxColumn urnFiyatSiparis;
        private Button btn_SiparisAl;
        private Button btnAdisyonKapat;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Panel panel1;
        private Button btnGeri;
        private Panel panel2;
        private Label lblToplam;
    }
}