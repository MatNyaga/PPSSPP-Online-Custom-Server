namespace PPSSPPclient
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
            this.chattb = new System.Windows.Forms.TextBox();
            this.chatlabel = new System.Windows.Forms.Label();
            this.chatlb = new System.Windows.Forms.ListBox();
            this.sendbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chattb
            // 
            this.chattb.Location = new System.Drawing.Point(188, 392);
            this.chattb.Multiline = true;
            this.chattb.Name = "chattb";
            this.chattb.Size = new System.Drawing.Size(472, 56);
            this.chattb.TabIndex = 0;
            // 
            // chatlabel
            // 
            this.chatlabel.AutoSize = true;
            this.chatlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatlabel.Location = new System.Drawing.Point(134, 409);
            this.chatlabel.Name = "chatlabel";
            this.chatlabel.Size = new System.Drawing.Size(48, 18);
            this.chatlabel.TabIndex = 1;
            this.chatlabel.Text = "Chat:";
            // 
            // chatlb
            // 
            this.chatlb.BackColor = System.Drawing.SystemColors.Control;
            this.chatlb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chatlb.FormattingEnabled = true;
            this.chatlb.Location = new System.Drawing.Point(188, 91);
            this.chatlb.Name = "chatlb";
            this.chatlb.Size = new System.Drawing.Size(525, 260);
            this.chatlb.TabIndex = 2;
            // 
            // sendbtn
            // 
            this.sendbtn.Location = new System.Drawing.Point(671, 393);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(41, 54);
            this.sendbtn.TabIndex = 3;
            this.sendbtn.Text = "send";
            this.sendbtn.UseVisualStyleBackColor = true;
            this.sendbtn.Click += new System.EventHandler(this.sendbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 479);
            this.Controls.Add(this.sendbtn);
            this.Controls.Add(this.chatlb);
            this.Controls.Add(this.chatlabel);
            this.Controls.Add(this.chattb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox chattb;
        private System.Windows.Forms.Label chatlabel;
        private System.Windows.Forms.ListBox chatlb;
        private System.Windows.Forms.Button sendbtn;
    }
}

