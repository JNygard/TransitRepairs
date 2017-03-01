namespace WindowsFormsApplication1
{
    partial class MainGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGame));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TBpartPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CBshopChoosePart = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TBbankBalance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.LVfailureList = new System.Windows.Forms.ListBox();
            this.PBshopItem = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TBweldingGas = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TBweldingWire = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TBpartsPercentage = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TBweldedPercentage = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TBdeadline = new System.Windows.Forms.Label();
            this.TBtimeLeft = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBcurrentTime = new System.Windows.Forms.Label();
            this.IVtransit = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBshopItem)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IVtransit)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.TBpartPrice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CBshopChoosePart);
            this.groupBox1.Controls.Add(this.PBshopItem);
            this.groupBox1.Location = new System.Drawing.Point(799, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shop";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_buy);
            // 
            // TBpartPrice
            // 
            this.TBpartPrice.AutoSize = true;
            this.TBpartPrice.Font = new System.Drawing.Font("Magneto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBpartPrice.ForeColor = System.Drawing.SystemColors.Desktop;
            this.TBpartPrice.Location = new System.Drawing.Point(87, 118);
            this.TBpartPrice.Name = "TBpartPrice";
            this.TBpartPrice.Size = new System.Drawing.Size(18, 17);
            this.TBpartPrice.TabIndex = 3;
            this.TBpartPrice.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Price(€)";
            // 
            // CBshopChoosePart
            // 
            this.CBshopChoosePart.FormattingEnabled = true;
            this.CBshopChoosePart.Location = new System.Drawing.Point(21, 138);
            this.CBshopChoosePart.Name = "CBshopChoosePart";
            this.CBshopChoosePart.Size = new System.Drawing.Size(120, 21);
            this.CBshopChoosePart.TabIndex = 1;
            this.CBshopChoosePart.SelectedValueChanged += new System.EventHandler(this.CBshopChoosePart_SelectedValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TBbankBalance);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(799, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 47);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bank account";
            // 
            // TBbankBalance
            // 
            this.TBbankBalance.AutoSize = true;
            this.TBbankBalance.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBbankBalance.Location = new System.Drawing.Point(109, 20);
            this.TBbankBalance.Name = "TBbankBalance";
            this.TBbankBalance.Size = new System.Drawing.Size(36, 16);
            this.TBbankBalance.TabIndex = 1;
            this.TBbankBalance.Text = "1000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Balance(€)";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.LVfailureList);
            this.groupBox5.Location = new System.Drawing.Point(800, 296);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(169, 155);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Car parts";
            // 
            // LVfailureList
            // 
            this.LVfailureList.FormattingEnabled = true;
            this.LVfailureList.Location = new System.Drawing.Point(7, 20);
            this.LVfailureList.Name = "LVfailureList";
            this.LVfailureList.Size = new System.Drawing.Size(156, 121);
            this.LVfailureList.TabIndex = 0;
            // 
            // PBshopItem
            // 
            this.PBshopItem.Location = new System.Drawing.Point(21, 19);
            this.PBshopItem.Name = "PBshopItem";
            this.PBshopItem.Size = new System.Drawing.Size(100, 80);
            this.PBshopItem.TabIndex = 0;
            this.PBshopItem.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.IVtransit);
            this.groupBox3.Location = new System.Drawing.Point(12, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(781, 519);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.welder;
            this.pictureBox2.Location = new System.Drawing.Point(77, 263);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 184);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.click_welder);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.TBweldingGas);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.TBweldingWire);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.TBpartsPercentage);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.TBweldedPercentage);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.TBdeadline);
            this.groupBox4.Controls.Add(this.TBtimeLeft);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.TBcurrentTime);
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(781, 75);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Time";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // TBweldingGas
            // 
            this.TBweldingGas.AutoSize = true;
            this.TBweldingGas.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBweldingGas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TBweldingGas.Location = new System.Drawing.Point(396, 36);
            this.TBweldingGas.Name = "TBweldingGas";
            this.TBweldingGas.Size = new System.Drawing.Size(17, 18);
            this.TBweldingGas.TabIndex = 14;
            this.TBweldingGas.Text = "5";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(330, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Gas (l)";
            // 
            // TBweldingWire
            // 
            this.TBweldingWire.AutoSize = true;
            this.TBweldingWire.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBweldingWire.ForeColor = System.Drawing.Color.LightGray;
            this.TBweldingWire.Location = new System.Drawing.Point(396, 18);
            this.TBweldingWire.Name = "TBweldingWire";
            this.TBweldingWire.Size = new System.Drawing.Size(17, 18);
            this.TBweldingWire.TabIndex = 12;
            this.TBweldingWire.Text = "5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(330, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Wire (m)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.speaker;
            this.pictureBox1.Location = new System.Drawing.Point(6, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 54);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.click_speaker);
            // 
            // TBpartsPercentage
            // 
            this.TBpartsPercentage.AutoSize = true;
            this.TBpartsPercentage.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBpartsPercentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TBpartsPercentage.Location = new System.Drawing.Point(298, 34);
            this.TBpartsPercentage.Name = "TBpartsPercentage";
            this.TBpartsPercentage.Size = new System.Drawing.Size(26, 18);
            this.TBpartsPercentage.TabIndex = 9;
            this.TBpartsPercentage.Text = "67";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(223, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Parts %";
            // 
            // TBweldedPercentage
            // 
            this.TBweldedPercentage.AutoSize = true;
            this.TBweldedPercentage.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBweldedPercentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TBweldedPercentage.Location = new System.Drawing.Point(298, 16);
            this.TBweldedPercentage.Name = "TBweldedPercentage";
            this.TBweldedPercentage.Size = new System.Drawing.Size(26, 18);
            this.TBweldedPercentage.TabIndex = 7;
            this.TBweldedPercentage.Text = "89";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(223, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Welded %";
            // 
            // TBdeadline
            // 
            this.TBdeadline.AutoSize = true;
            this.TBdeadline.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBdeadline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TBdeadline.Location = new System.Drawing.Point(145, 28);
            this.TBdeadline.Name = "TBdeadline";
            this.TBdeadline.Size = new System.Drawing.Size(72, 16);
            this.TBdeadline.TabIndex = 5;
            this.TBdeadline.Text = "12.12.2012";
            // 
            // TBtimeLeft
            // 
            this.TBtimeLeft.AutoSize = true;
            this.TBtimeLeft.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBtimeLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TBtimeLeft.Location = new System.Drawing.Point(145, 44);
            this.TBtimeLeft.Name = "TBtimeLeft";
            this.TBtimeLeft.Size = new System.Drawing.Size(36, 19);
            this.TBtimeLeft.TabIndex = 4;
            this.TBtimeLeft.Text = "234";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(62, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Curr time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(64, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Time left";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(64, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Deadline";
            // 
            // TBcurrentTime
            // 
            this.TBcurrentTime.AutoSize = true;
            this.TBcurrentTime.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBcurrentTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TBcurrentTime.Location = new System.Drawing.Point(145, 14);
            this.TBcurrentTime.Name = "TBcurrentTime";
            this.TBcurrentTime.Size = new System.Drawing.Size(72, 16);
            this.TBcurrentTime.TabIndex = 0;
            this.TBcurrentTime.Text = "12.12.2012";
            // 
            // IVtransit
            // 
            this.IVtransit.BackColor = System.Drawing.Color.Transparent;
            this.IVtransit.Image = global::WindowsFormsApplication1.Properties.Resources.pieniromu2;
            this.IVtransit.InitialImage = null;
            this.IVtransit.Location = new System.Drawing.Point(214, 170);
            this.IVtransit.Name = "IVtransit";
            this.IVtransit.Size = new System.Drawing.Size(513, 318);
            this.IVtransit.TabIndex = 1;
            this.IVtransit.TabStop = false;
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 549);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainGame";
            this.Text = "MainGame";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBshopItem)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IVtransit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox PBshopItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label TBpartPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBshopChoosePart;
        private System.Windows.Forms.Label TBbankBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox IVtransit;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label TBdeadline;
        private System.Windows.Forms.Label TBtimeLeft;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TBcurrentTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label TBpartsPercentage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label TBweldedPercentage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox LVfailureList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label TBweldingGas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label TBweldingWire;
        private System.Windows.Forms.Label label7;
    }
}