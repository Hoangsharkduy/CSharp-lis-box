namespace CSharp_lis_box
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
            this.label2 = new System.Windows.Forms.Label();
            this.lbskqten = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btnt = new System.Windows.Forms.Button();
            this.btns = new System.Windows.Forms.Button();
            this.btnx = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "NHẬP HỌ VÀ TÊN";
            // 
            // lbskqten
            // 
            this.lbskqten.FormattingEnabled = true;
            this.lbskqten.Location = new System.Drawing.Point(265, 256);
            this.lbskqten.Name = "lbskqten";
            this.lbskqten.Size = new System.Drawing.Size(565, 277);
            this.lbskqten.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 55);
            this.label1.TabIndex = 7;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(265, 181);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(271, 47);
            this.txt1.TabIndex = 6;
            // 
            // btnt
            // 
            this.btnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnt.Location = new System.Drawing.Point(622, 179);
            this.btnt.Name = "btnt";
            this.btnt.Size = new System.Drawing.Size(153, 49);
            this.btnt.TabIndex = 5;
            this.btnt.Text = "TÌM";
            this.btnt.UseVisualStyleBackColor = true;
            this.btnt.Click += new System.EventHandler(this.btnt_Click);
            // 
            // btns
            // 
            this.btns.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btns.Location = new System.Drawing.Point(942, 179);
            this.btns.Name = "btns";
            this.btns.Size = new System.Drawing.Size(153, 49);
            this.btns.TabIndex = 10;
            this.btns.Text = "SỬA";
            this.btns.UseVisualStyleBackColor = true;
            this.btns.Click += new System.EventHandler(this.btns_Click);
            // 
            // btnx
            // 
            this.btnx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnx.Location = new System.Drawing.Point(781, 179);
            this.btnx.Name = "btnx";
            this.btnx.Size = new System.Drawing.Size(153, 49);
            this.btnx.TabIndex = 11;
            this.btnx.Text = "XÓA";
            this.btnx.UseVisualStyleBackColor = true;
            this.btnx.Click += new System.EventHandler(this.btnx_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 611);
            this.Controls.Add(this.btnx);
            this.Controls.Add(this.btns);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbskqten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btnt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbskqten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btnt;
        private System.Windows.Forms.Button btns;
        private System.Windows.Forms.Button btnx;
    }
}

