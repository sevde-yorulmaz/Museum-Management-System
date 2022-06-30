
namespace MuseumManagementSystem
{
    partial class Show_Sale_ArtWork_And_Sale_Ticket
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
            this.panelShowHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxSaleTicketArtExit = new System.Windows.Forms.PictureBox();
            this.panelShowContent = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewSaleTicket = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewSaleArt = new System.Windows.Forms.DataGridView();
            this.panelShowHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSaleTicketArtExit)).BeginInit();
            this.panelShowContent.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaleTicket)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaleArt)).BeginInit();
            this.SuspendLayout();
            // 
            // panelShowHeader
            // 
            this.panelShowHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelShowHeader.Controls.Add(this.label1);
            this.panelShowHeader.Controls.Add(this.pictureBoxSaleTicketArtExit);
            this.panelShowHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShowHeader.Location = new System.Drawing.Point(0, 0);
            this.panelShowHeader.Name = "panelShowHeader";
            this.panelShowHeader.Size = new System.Drawing.Size(807, 72);
            this.panelShowHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(174, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "SALE ART AND SALE TİCKET";
            // 
            // pictureBoxSaleTicketArtExit
            // 
            this.pictureBoxSaleTicketArtExit.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSaleTicketArtExit.BackgroundImage = global::MuseumManagementSystem.Properties.Resources.exitttttt1;
            this.pictureBoxSaleTicketArtExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSaleTicketArtExit.Location = new System.Drawing.Point(735, 3);
            this.pictureBoxSaleTicketArtExit.Name = "pictureBoxSaleTicketArtExit";
            this.pictureBoxSaleTicketArtExit.Size = new System.Drawing.Size(69, 50);
            this.pictureBoxSaleTicketArtExit.TabIndex = 3;
            this.pictureBoxSaleTicketArtExit.TabStop = false;
            this.pictureBoxSaleTicketArtExit.Click += new System.EventHandler(this.pictureBoxAddArtWorkExit_Click);
            // 
            // panelShowContent
            // 
            this.panelShowContent.Controls.Add(this.tabControl1);
            this.panelShowContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelShowContent.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelShowContent.Location = new System.Drawing.Point(0, 78);
            this.panelShowContent.Name = "panelShowContent";
            this.panelShowContent.Size = new System.Drawing.Size(807, 416);
            this.panelShowContent.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 18);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(782, 385);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabPage1.Controls.Add(this.dataGridViewSaleTicket);
            this.tabPage1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(774, 357);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sale Ticket";
            // 
            // dataGridViewSaleTicket
            // 
            this.dataGridViewSaleTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSaleTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSaleTicket.Location = new System.Drawing.Point(19, 27);
            this.dataGridViewSaleTicket.Name = "dataGridViewSaleTicket";
            this.dataGridViewSaleTicket.RowTemplate.Height = 25;
            this.dataGridViewSaleTicket.Size = new System.Drawing.Size(722, 314);
            this.dataGridViewSaleTicket.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabPage2.Controls.Add(this.dataGridViewSaleArt);
            this.tabPage2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(774, 357);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sale ArtWork";
            // 
            // dataGridViewSaleArt
            // 
            this.dataGridViewSaleArt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSaleArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSaleArt.Location = new System.Drawing.Point(25, 28);
            this.dataGridViewSaleArt.Name = "dataGridViewSaleArt";
            this.dataGridViewSaleArt.RowTemplate.Height = 25;
            this.dataGridViewSaleArt.Size = new System.Drawing.Size(715, 313);
            this.dataGridViewSaleArt.TabIndex = 0;
            // 
            // Show_Sale_ArtWork_And_Sale_Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(807, 494);
            this.Controls.Add(this.panelShowContent);
            this.Controls.Add(this.panelShowHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Show_Sale_ArtWork_And_Sale_Ticket";
            this.Text = "Show_Sale_ArtWork_And_Sale_Ticket";
            this.Load += new System.EventHandler(this.Show_Sale_ArtWork_And_Sale_Ticket_Load);
            this.panelShowHeader.ResumeLayout(false);
            this.panelShowHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSaleTicketArtExit)).EndInit();
            this.panelShowContent.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaleTicket)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaleArt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelShowHeader;
        private System.Windows.Forms.Panel panelShowContent;
        private System.Windows.Forms.PictureBox pictureBoxSaleTicketArtExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewSaleTicket;
        private System.Windows.Forms.DataGridView dataGridViewSaleArt;
    }
}