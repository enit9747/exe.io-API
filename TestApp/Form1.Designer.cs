
namespace TestApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.apitokenTxt = new System.Windows.Forms.TextBox();
            this.destinationTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customaliasTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.shortenedTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "API Token:";
            // 
            // apitokenTxt
            // 
            this.apitokenTxt.Location = new System.Drawing.Point(172, 83);
            this.apitokenTxt.Name = "apitokenTxt";
            this.apitokenTxt.Size = new System.Drawing.Size(256, 20);
            this.apitokenTxt.TabIndex = 1;
            // 
            // destinationTxt
            // 
            this.destinationTxt.Location = new System.Drawing.Point(172, 109);
            this.destinationTxt.Name = "destinationTxt";
            this.destinationTxt.Size = new System.Drawing.Size(256, 20);
            this.destinationTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Destionation Link:";
            // 
            // customaliasTxt
            // 
            this.customaliasTxt.Location = new System.Drawing.Point(172, 135);
            this.customaliasTxt.Name = "customaliasTxt";
            this.customaliasTxt.Size = new System.Drawing.Size(256, 20);
            this.customaliasTxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Custom Alias:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Shorten Url";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // shortenedTxt
            // 
            this.shortenedTxt.Location = new System.Drawing.Point(172, 190);
            this.shortenedTxt.Name = "shortenedTxt";
            this.shortenedTxt.Size = new System.Drawing.Size(256, 20);
            this.shortenedTxt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Shortened Url:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 293);
            this.Controls.Add(this.shortenedTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.customaliasTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.destinationTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.apitokenTxt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "exe.io api | TestApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox apitokenTxt;
        private System.Windows.Forms.TextBox destinationTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customaliasTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox shortenedTxt;
        private System.Windows.Forms.Label label4;
    }
}

