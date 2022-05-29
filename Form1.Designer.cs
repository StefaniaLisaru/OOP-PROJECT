
namespace Proiect_aproape_final
{
    partial class MyPaint
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.labelSize = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.labelActualSize = new System.Windows.Forms.Label();
            this.btnElipsa = new System.Windows.Forms.Button();
            this.btnDreptunghi = new System.Windows.Forms.Button();
            this.btnLinie = new System.Windows.Forms.Button();
            this.btnPensula = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.labelConnected = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.labelSize);
            this.flowLayoutPanel1.Controls.Add(this.btnPlus);
            this.flowLayoutPanel1.Controls.Add(this.btnMinus);
            this.flowLayoutPanel1.Controls.Add(this.labelActualSize);
            this.flowLayoutPanel1.Controls.Add(this.btnElipsa);
            this.flowLayoutPanel1.Controls.Add(this.btnDreptunghi);
            this.flowLayoutPanel1.Controls.Add(this.btnLinie);
            this.flowLayoutPanel1.Controls.Add(this.btnPensula);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.btnConnect);
            this.flowLayoutPanel1.Controls.Add(this.labelConnected);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1763, 780);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            this.flowLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseDown);
            this.flowLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseMove);
            this.flowLayoutPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelSize
            // 
            this.labelSize.BackColor = System.Drawing.Color.Silver;
            this.labelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelSize.Location = new System.Drawing.Point(84, 0);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(97, 53);
            this.labelSize.TabIndex = 8;
            this.labelSize.Text = "Size";
            this.labelSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.Silver;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnPlus.Location = new System.Drawing.Point(187, 3);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(98, 56);
            this.btnPlus.TabIndex = 1;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.Silver;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnMinus.Location = new System.Drawing.Point(291, 3);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(93, 56);
            this.btnMinus.TabIndex = 2;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // labelActualSize
            // 
            this.labelActualSize.BackColor = System.Drawing.Color.Silver;
            this.labelActualSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelActualSize.Location = new System.Drawing.Point(390, 0);
            this.labelActualSize.Name = "labelActualSize";
            this.labelActualSize.Size = new System.Drawing.Size(77, 56);
            this.labelActualSize.TabIndex = 9;
            this.labelActualSize.Text = "Actual Size";
            this.labelActualSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelActualSize.Click += new System.EventHandler(this.labelActualSize_Click);
            // 
            // btnElipsa
            // 
            this.btnElipsa.BackColor = System.Drawing.Color.Silver;
            this.btnElipsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnElipsa.Location = new System.Drawing.Point(473, 3);
            this.btnElipsa.Name = "btnElipsa";
            this.btnElipsa.Size = new System.Drawing.Size(82, 49);
            this.btnElipsa.TabIndex = 5;
            this.btnElipsa.Text = "Elipsa";
            this.btnElipsa.UseVisualStyleBackColor = false;
            this.btnElipsa.Click += new System.EventHandler(this.btnElipsa_Click);
            // 
            // btnDreptunghi
            // 
            this.btnDreptunghi.BackColor = System.Drawing.Color.Silver;
            this.btnDreptunghi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnDreptunghi.Location = new System.Drawing.Point(561, 3);
            this.btnDreptunghi.Name = "btnDreptunghi";
            this.btnDreptunghi.Size = new System.Drawing.Size(116, 49);
            this.btnDreptunghi.TabIndex = 4;
            this.btnDreptunghi.Text = "Dreptunghi";
            this.btnDreptunghi.UseVisualStyleBackColor = false;
            this.btnDreptunghi.Click += new System.EventHandler(this.btnDreptunghi_Click);
            // 
            // btnLinie
            // 
            this.btnLinie.BackColor = System.Drawing.Color.Silver;
            this.btnLinie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnLinie.Location = new System.Drawing.Point(683, 3);
            this.btnLinie.Name = "btnLinie";
            this.btnLinie.Size = new System.Drawing.Size(77, 49);
            this.btnLinie.TabIndex = 3;
            this.btnLinie.Text = "Linie";
            this.btnLinie.UseVisualStyleBackColor = false;
            this.btnLinie.Click += new System.EventHandler(this.btnLinie_Click);
            // 
            // btnPensula
            // 
            this.btnPensula.BackColor = System.Drawing.Color.Silver;
            this.btnPensula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnPensula.Location = new System.Drawing.Point(766, 3);
            this.btnPensula.Name = "btnPensula";
            this.btnPensula.Size = new System.Drawing.Size(94, 49);
            this.btnPensula.TabIndex = 6;
            this.btnPensula.Text = "Pensula";
            this.btnPensula.UseVisualStyleBackColor = false;
            this.btnPensula.Click += new System.EventHandler(this.btnPensula_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Location = new System.Drawing.Point(866, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 56);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(3, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 40);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(272, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(70, 54);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox2.Location = new System.Drawing.Point(47, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 41);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox3.Location = new System.Drawing.Point(86, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 41);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox4.Location = new System.Drawing.Point(125, 8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 41);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Lime;
            this.pictureBox5.Location = new System.Drawing.Point(166, 8);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 40);
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Silver;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnConnect.Location = new System.Drawing.Point(1079, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(103, 56);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "Connect button";
            this.btnConnect.UseMnemonic = false;
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // labelConnected
            // 
            this.labelConnected.AutoSize = true;
            this.labelConnected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelConnected.Location = new System.Drawing.Point(1188, 0);
            this.labelConnected.Name = "labelConnected";
            this.labelConnected.Size = new System.Drawing.Size(143, 25);
            this.labelConnected.TabIndex = 11;
            this.labelConnected.Text = "Not Connected";
            this.labelConnected.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Silver;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnClear.Location = new System.Drawing.Point(2, 0);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 56);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // MyPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1763, 780);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MyPaint";
            this.Text = "My Paint";
            this.Load += new System.EventHandler(this.MyPaint_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnLinie;
        private System.Windows.Forms.Button btnDreptunghi;
        private System.Windows.Forms.Button btnElipsa;
        private System.Windows.Forms.Button btnPensula;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelActualSize;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label labelConnected;
    }
}

