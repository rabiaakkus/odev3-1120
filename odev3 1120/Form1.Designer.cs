namespace odev3_1120
{
    partial class Form1
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
            this.lblMüşteriler = new System.Windows.Forms.Label();
            this.lbladi = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMüşteriler
            // 
            this.lblMüşteriler.AutoSize = true;
            this.lblMüşteriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMüşteriler.Location = new System.Drawing.Point(30, 21);
            this.lblMüşteriler.Name = "lblMüşteriler";
            this.lblMüşteriler.Size = new System.Drawing.Size(107, 24);
            this.lblMüşteriler.TabIndex = 0;
            this.lblMüşteriler.Text = "Müşteriler ; ";
            // 
            // lbladi
            // 
            this.lbladi.AutoSize = true;
            this.lbladi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbladi.Location = new System.Drawing.Point(30, 248);
            this.lbladi.Name = "lbladi";
            this.lbladi.Size = new System.Drawing.Size(111, 24);
            this.lbladi.TabIndex = 1;
            this.lbladi.Text = "Müşteri adı ;";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Tolga",
            "Selman",
            "Emre",
            "Şaban",
            "Abdulkadir",
            "Harun",
            "Murat",
            "Ayşe ",
            "Rabia",
            "Sedef",
            "Hiranur",
            "Selma"});
            this.listBox1.Location = new System.Drawing.Point(147, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 212);
            this.listBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 252);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 99);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbladi);
            this.Controls.Add(this.lblMüşteriler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMüşteriler;
        private System.Windows.Forms.Label lbladi;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

