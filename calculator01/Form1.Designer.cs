namespace calculator01
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
            this.txtnumber1 = new System.Windows.Forms.TextBox();
            this.txtnumber2 = new System.Windows.Forms.TextBox();
            this.nmb1 = new System.Windows.Forms.NumericUpDown();
            this.nmb2 = new System.Windows.Forms.NumericUpDown();
            this.btnplus = new System.Windows.Forms.Button();
            this.btndivide = new System.Windows.Forms.Button();
            this.btnmultiple = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmb2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnumber1
            // 
            this.txtnumber1.Location = new System.Drawing.Point(375, 24);
            this.txtnumber1.Name = "txtnumber1";
            this.txtnumber1.Size = new System.Drawing.Size(100, 21);
            this.txtnumber1.TabIndex = 1;
            this.txtnumber1.Text = "عدد اول :";
            // 
            // txtnumber2
            // 
            this.txtnumber2.Location = new System.Drawing.Point(375, 74);
            this.txtnumber2.Name = "txtnumber2";
            this.txtnumber2.Size = new System.Drawing.Size(100, 21);
            this.txtnumber2.TabIndex = 2;
            this.txtnumber2.Text = "عدد دوم:";
            // 
            // nmb1
            // 
            this.nmb1.Location = new System.Drawing.Point(222, 25);
            this.nmb1.Name = "nmb1";
            this.nmb1.Size = new System.Drawing.Size(120, 21);
            this.nmb1.TabIndex = 3;
            // 
            // nmb2
            // 
            this.nmb2.Location = new System.Drawing.Point(222, 75);
            this.nmb2.Name = "nmb2";
            this.nmb2.Size = new System.Drawing.Size(120, 21);
            this.nmb2.TabIndex = 4;
            // 
            // btnplus
            // 
            this.btnplus.Location = new System.Drawing.Point(400, 120);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(75, 23);
            this.btnplus.TabIndex = 9;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // btndivide
            // 
            this.btndivide.Location = new System.Drawing.Point(116, 120);
            this.btndivide.Name = "btndivide";
            this.btndivide.Size = new System.Drawing.Size(75, 23);
            this.btndivide.TabIndex = 10;
            this.btndivide.Text = "/";
            this.btndivide.UseVisualStyleBackColor = true;
            this.btndivide.Click += new System.EventHandler(this.btndivide_Click);
            // 
            // btnmultiple
            // 
            this.btnmultiple.Location = new System.Drawing.Point(206, 120);
            this.btnmultiple.Name = "btnmultiple";
            this.btnmultiple.Size = new System.Drawing.Size(75, 23);
            this.btnmultiple.TabIndex = 11;
            this.btnmultiple.Text = "*";
            this.btnmultiple.UseVisualStyleBackColor = true;
            this.btnmultiple.Click += new System.EventHandler(this.btnmultiple_Click);
            // 
            // btnminus
            // 
            this.btnminus.Location = new System.Drawing.Point(295, 120);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(75, 23);
            this.btnminus.TabIndex = 12;
            this.btnminus.Text = "-";
            this.btnminus.UseVisualStyleBackColor = true;
            this.btnminus.Click += new System.EventHandler(this.btnminus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 270);
            this.Controls.Add(this.btnminus);
            this.Controls.Add(this.btnmultiple);
            this.Controls.Add(this.btndivide);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.nmb2);
            this.Controls.Add(this.nmb1);
            this.Controls.Add(this.txtnumber2);
            this.Controls.Add(this.txtnumber1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ماشین حساب";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmb2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtnumber1;
        private System.Windows.Forms.TextBox txtnumber2;
        private System.Windows.Forms.NumericUpDown nmb1;
        private System.Windows.Forms.NumericUpDown nmb2;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btndivide;
        private System.Windows.Forms.Button btnmultiple;
        private System.Windows.Forms.Button btnminus;
    }
}

