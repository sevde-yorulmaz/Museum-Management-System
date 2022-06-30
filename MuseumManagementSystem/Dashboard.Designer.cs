
namespace MuseumManagementSystem
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMemberTotal = new System.Windows.Forms.TextBox();
            this.textBoxArtWorkTotal = new System.Windows.Forms.TextBox();
            this.textBoxTicketTotal = new System.Windows.Forms.TextBox();
            this.panelTicketCategory = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelMuseumCard = new System.Windows.Forms.Label();
            this.labelStudent = new System.Windows.Forms.Label();
            this.labelAdult = new System.Windows.Forms.Label();
            this.panelMuseumCard = new System.Windows.Forms.Panel();
            this.panelAdult = new System.Windows.Forms.Panel();
            this.panelStudent = new System.Windows.Forms.Panel();
            this.panelArtWork = new System.Windows.Forms.Panel();
            this.panelSaleArtWork = new System.Windows.Forms.Panel();
            this.panelRestoreArtWork = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.buttonDashboardExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelTicketCategory.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelArtWork.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.buttonDashboardExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1207, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(489, 22);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(7);
            this.label1.Size = new System.Drawing.Size(179, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // textBoxMemberTotal
            // 
            this.textBoxMemberTotal.Enabled = false;
            this.textBoxMemberTotal.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxMemberTotal.Location = new System.Drawing.Point(67, 154);
            this.textBoxMemberTotal.Name = "textBoxMemberTotal";
            this.textBoxMemberTotal.PlaceholderText = "Member Total";
            this.textBoxMemberTotal.Size = new System.Drawing.Size(100, 29);
            this.textBoxMemberTotal.TabIndex = 1;
            // 
            // textBoxArtWorkTotal
            // 
            this.textBoxArtWorkTotal.Enabled = false;
            this.textBoxArtWorkTotal.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxArtWorkTotal.Location = new System.Drawing.Point(204, 154);
            this.textBoxArtWorkTotal.Name = "textBoxArtWorkTotal";
            this.textBoxArtWorkTotal.PlaceholderText = "ArtWork Total";
            this.textBoxArtWorkTotal.Size = new System.Drawing.Size(100, 29);
            this.textBoxArtWorkTotal.TabIndex = 2;
            // 
            // textBoxTicketTotal
            // 
            this.textBoxTicketTotal.Enabled = false;
            this.textBoxTicketTotal.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxTicketTotal.Location = new System.Drawing.Point(347, 154);
            this.textBoxTicketTotal.Name = "textBoxTicketTotal";
            this.textBoxTicketTotal.PlaceholderText = "Ticket Total";
            this.textBoxTicketTotal.Size = new System.Drawing.Size(100, 29);
            this.textBoxTicketTotal.TabIndex = 3;
            // 
            // panelTicketCategory
            // 
            this.panelTicketCategory.Controls.Add(this.panel3);
            this.panelTicketCategory.Controls.Add(this.panel2);
            this.panelTicketCategory.Controls.Add(this.panelMuseumCard);
            this.panelTicketCategory.Controls.Add(this.panelAdult);
            this.panelTicketCategory.Controls.Add(this.panelStudent);
            this.panelTicketCategory.Location = new System.Drawing.Point(67, 208);
            this.panelTicketCategory.Name = "panelTicketCategory";
            this.panelTicketCategory.Size = new System.Drawing.Size(351, 289);
            this.panelTicketCategory.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 259);
            this.panel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.labelMuseumCard);
            this.panel2.Controls.Add(this.labelStudent);
            this.panel2.Controls.Add(this.labelAdult);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 259);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 30);
            this.panel2.TabIndex = 3;
            // 
            // labelMuseumCard
            // 
            this.labelMuseumCard.AutoSize = true;
            this.labelMuseumCard.Location = new System.Drawing.Point(280, 9);
            this.labelMuseumCard.Name = "labelMuseumCard";
            this.labelMuseumCard.Size = new System.Drawing.Size(19, 15);
            this.labelMuseumCard.TabIndex = 7;
            this.labelMuseumCard.Text = "50";
            // 
            // labelStudent
            // 
            this.labelStudent.AutoSize = true;
            this.labelStudent.Location = new System.Drawing.Point(71, 9);
            this.labelStudent.Name = "labelStudent";
            this.labelStudent.Size = new System.Drawing.Size(19, 15);
            this.labelStudent.TabIndex = 5;
            this.labelStudent.Text = "15";
            // 
            // labelAdult
            // 
            this.labelAdult.AutoSize = true;
            this.labelAdult.Location = new System.Drawing.Point(181, 9);
            this.labelAdult.Name = "labelAdult";
            this.labelAdult.Size = new System.Drawing.Size(19, 15);
            this.labelAdult.TabIndex = 6;
            this.labelAdult.Text = "30";
            // 
            // panelMuseumCard
            // 
            this.panelMuseumCard.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelMuseumCard.Location = new System.Drawing.Point(267, 56);
            this.panelMuseumCard.Name = "panelMuseumCard";
            this.panelMuseumCard.Size = new System.Drawing.Size(47, 156);
            this.panelMuseumCard.TabIndex = 2;
            // 
            // panelAdult
            // 
            this.panelAdult.BackColor = System.Drawing.Color.LimeGreen;
            this.panelAdult.Location = new System.Drawing.Point(166, 56);
            this.panelAdult.Name = "panelAdult";
            this.panelAdult.Size = new System.Drawing.Size(53, 156);
            this.panelAdult.TabIndex = 1;
            // 
            // panelStudent
            // 
            this.panelStudent.BackColor = System.Drawing.Color.Tomato;
            this.panelStudent.Location = new System.Drawing.Point(60, 56);
            this.panelStudent.Name = "panelStudent";
            this.panelStudent.Size = new System.Drawing.Size(51, 156);
            this.panelStudent.TabIndex = 0;
            // 
            // panelArtWork
            // 
            this.panelArtWork.BackColor = System.Drawing.Color.PaleGreen;
            this.panelArtWork.Controls.Add(this.panelSaleArtWork);
            this.panelArtWork.Controls.Add(this.panelRestoreArtWork);
            this.panelArtWork.Location = new System.Drawing.Point(556, 231);
            this.panelArtWork.Name = "panelArtWork";
            this.panelArtWork.Size = new System.Drawing.Size(521, 100);
            this.panelArtWork.TabIndex = 5;
            // 
            // panelSaleArtWork
            // 
            this.panelSaleArtWork.BackColor = System.Drawing.Color.LightPink;
            this.panelSaleArtWork.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSaleArtWork.Location = new System.Drawing.Point(324, 0);
            this.panelSaleArtWork.Name = "panelSaleArtWork";
            this.panelSaleArtWork.Size = new System.Drawing.Size(197, 100);
            this.panelSaleArtWork.TabIndex = 1;
            // 
            // panelRestoreArtWork
            // 
            this.panelRestoreArtWork.BackColor = System.Drawing.Color.Gold;
            this.panelRestoreArtWork.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRestoreArtWork.Location = new System.Drawing.Point(0, 0);
            this.panelRestoreArtWork.Name = "panelRestoreArtWork";
            this.panelRestoreArtWork.Size = new System.Drawing.Size(127, 100);
            this.panelRestoreArtWork.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1031, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "----";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1031, 458);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "----";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1031, 498);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "----";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gold;
            this.panel4.Location = new System.Drawing.Point(984, 413);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(28, 25);
            this.panel4.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.PaleGreen;
            this.panel5.Location = new System.Drawing.Point(984, 453);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(28, 25);
            this.panel5.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightPink;
            this.panel6.Location = new System.Drawing.Point(984, 493);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(28, 25);
            this.panel6.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(822, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Restorede Olan Eserler";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(850, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sergilenen Eserler";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(874, 496);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Satılan Eserler";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(67, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Toplam Üye Sayısı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(204, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "Toplam Eser Sayısı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(347, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 18);
            this.label10.TabIndex = 16;
            this.label10.Text = "Toplam Bilet Sayısı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(216, 593);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 18);
            this.label11.TabIndex = 22;
            this.label11.Text = "Satılan MüzeKart Sayısı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(219, 557);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 18);
            this.label12.TabIndex = 21;
            this.label12.Text = "Satılan Tam Bilet Sayısı";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(197, 521);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(172, 18);
            this.label13.TabIndex = 20;
            this.label13.Text = "Satılan Öğrenci Bilet Sayısı";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel7.Location = new System.Drawing.Point(384, 590);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(28, 25);
            this.panel7.TabIndex = 18;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LimeGreen;
            this.panel8.Location = new System.Drawing.Point(384, 554);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(28, 25);
            this.panel8.TabIndex = 19;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Tomato;
            this.panel9.Location = new System.Drawing.Point(384, 518);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(28, 25);
            this.panel9.TabIndex = 17;
            // 
            // buttonDashboardExit
            // 
            this.buttonDashboardExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonDashboardExit.BackgroundImage = global::MuseumManagementSystem.Properties.Resources.exit;
            this.buttonDashboardExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDashboardExit.Location = new System.Drawing.Point(1166, 3);
            this.buttonDashboardExit.Name = "buttonDashboardExit";
            this.buttonDashboardExit.Size = new System.Drawing.Size(38, 37);
            this.buttonDashboardExit.TabIndex = 1;
            this.buttonDashboardExit.UseVisualStyleBackColor = false;
            this.buttonDashboardExit.Click += new System.EventHandler(this.buttonDashboardExit_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1207, 686);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelArtWork);
            this.Controls.Add(this.panelTicketCategory);
            this.Controls.Add(this.textBoxTicketTotal);
            this.Controls.Add(this.textBoxArtWorkTotal);
            this.Controls.Add(this.textBoxMemberTotal);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTicketCategory.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelArtWork.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMemberTotal;
        private System.Windows.Forms.TextBox textBoxArtWorkTotal;
        private System.Windows.Forms.TextBox textBoxTicketTotal;
        private System.Windows.Forms.Panel panelTicketCategory;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelMuseumCard;
        private System.Windows.Forms.Panel panelAdult;
        private System.Windows.Forms.Panel panelStudent;
        private System.Windows.Forms.Panel panelArtWork;
        private System.Windows.Forms.Panel panelSaleArtWork;
        private System.Windows.Forms.Panel panelRestoreArtWork;
        private System.Windows.Forms.Label labelMuseumCard;
        private System.Windows.Forms.Label labelAdult;
        private System.Windows.Forms.Label labelStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button buttonDashboardExit;
    }
}