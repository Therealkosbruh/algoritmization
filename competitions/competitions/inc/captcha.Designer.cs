namespace competitions.inc
{
    partial class captcha
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
            this.cpt_pb = new System.Windows.Forms.PictureBox();
            this.chnge_btn = new ePOSOne.btnProduct.Button_WOC();
            this.capthca_btn = new ePOSOne.btnProduct.Button_WOC();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cptch_tb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cpt_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // cpt_pb
            // 
            this.cpt_pb.Location = new System.Drawing.Point(251, 108);
            this.cpt_pb.Name = "cpt_pb";
            this.cpt_pb.Size = new System.Drawing.Size(268, 60);
            this.cpt_pb.TabIndex = 55;
            this.cpt_pb.TabStop = false;
            // 
            // chnge_btn
            // 
            this.chnge_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(7)))), ((int)(((byte)(64)))));
            this.chnge_btn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.chnge_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chnge_btn.FlatAppearance.BorderSize = 0;
            this.chnge_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chnge_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chnge_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chnge_btn.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chnge_btn.Location = new System.Drawing.Point(574, 117);
            this.chnge_btn.Name = "chnge_btn";
            this.chnge_btn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.chnge_btn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.chnge_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.chnge_btn.Size = new System.Drawing.Size(143, 42);
            this.chnge_btn.TabIndex = 54;
            this.chnge_btn.Text = "Поменять";
            this.chnge_btn.TextColor = System.Drawing.Color.White;
            this.chnge_btn.UseVisualStyleBackColor = true;
            this.chnge_btn.Click += new System.EventHandler(this.chnge_btn_Click);
            // 
            // capthca_btn
            // 
            this.capthca_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(7)))), ((int)(((byte)(64)))));
            this.capthca_btn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.capthca_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.capthca_btn.FlatAppearance.BorderSize = 0;
            this.capthca_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.capthca_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.capthca_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.capthca_btn.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.capthca_btn.Location = new System.Drawing.Point(310, 303);
            this.capthca_btn.Name = "capthca_btn";
            this.capthca_btn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.capthca_btn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.capthca_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.capthca_btn.Size = new System.Drawing.Size(143, 42);
            this.capthca_btn.TabIndex = 53;
            this.capthca_btn.Text = "Отправить";
            this.capthca_btn.TextColor = System.Drawing.Color.White;
            this.capthca_btn.UseVisualStyleBackColor = true;
            this.capthca_btn.Click += new System.EventHandler(this.capthca_btn_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(338, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 26);
            this.label2.TabIndex = 52;
            this.label2.Text = "Captcha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(49, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(705, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Вы использовали много попыток для авторизации, нужно убедиться, что вы не робот, " +
    "введите текст с картинки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(263, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 26);
            this.label1.TabIndex = 50;
            this.label1.Text = "Ввод";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(7)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(347, 248);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 1);
            this.panel1.TabIndex = 49;
            // 
            // cptch_tb
            // 
            this.cptch_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.cptch_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cptch_tb.Location = new System.Drawing.Point(347, 222);
            this.cptch_tb.Name = "cptch_tb";
            this.cptch_tb.Size = new System.Drawing.Size(130, 13);
            this.cptch_tb.TabIndex = 48;
            // 
            // captcha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cpt_pb);
            this.Controls.Add(this.chnge_btn);
            this.Controls.Add(this.capthca_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cptch_tb);
            this.Name = "captcha";
            this.Text = "captcha";
            ((System.ComponentModel.ISupportInitialize)(this.cpt_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cpt_pb;
        private ePOSOne.btnProduct.Button_WOC chnge_btn;
        private ePOSOne.btnProduct.Button_WOC capthca_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox cptch_tb;
    }
}