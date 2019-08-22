namespace GEICOprojectV1
{
    partial class Movie
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRentPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMovieR = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtMovieID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGetDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMovieSelected = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(484, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rent Price";
            // 
            // txtRentPrice
            // 
            this.txtRentPrice.Location = new System.Drawing.Point(464, 122);
            this.txtRentPrice.Name = "txtRentPrice";
            this.txtRentPrice.ReadOnly = true;
            this.txtRentPrice.Size = new System.Drawing.Size(100, 20);
            this.txtRentPrice.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Movie";
            // 
            // cmbMovieR
            // 
            this.cmbMovieR.FormattingEnabled = true;
            this.cmbMovieR.Location = new System.Drawing.Point(454, 49);
            this.cmbMovieR.Name = "cmbMovieR";
            this.cmbMovieR.Size = new System.Drawing.Size(121, 21);
            this.cmbMovieR.TabIndex = 3;
            this.cmbMovieR.SelectedIndexChanged += new System.EventHandler(this.CmbMovieR_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(475, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // txtMovieID
            // 
            this.txtMovieID.Location = new System.Drawing.Point(646, 121);
            this.txtMovieID.Name = "txtMovieID";
            this.txtMovieID.Size = new System.Drawing.Size(100, 20);
            this.txtMovieID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(656, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "GetDate";
            // 
            // txtGetDate
            // 
            this.txtGetDate.Location = new System.Drawing.Point(646, 183);
            this.txtGetDate.Name = "txtGetDate";
            this.txtGetDate.Size = new System.Drawing.Size(100, 20);
            this.txtGetDate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(656, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Movie ID";
            // 
            // txtMovieSelected
            // 
            this.txtMovieSelected.Location = new System.Drawing.Point(646, 49);
            this.txtMovieSelected.Name = "txtMovieSelected";
            this.txtMovieSelected.Size = new System.Drawing.Size(100, 20);
            this.txtMovieSelected.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(643, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Movie Name Selected";
            // 
            // Movie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMovieSelected);
            this.Controls.Add(this.txtGetDate);
            this.Controls.Add(this.txtMovieID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmbMovieR);
            this.Controls.Add(this.txtRentPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Movie";
            this.Text = "Movie";
            this.Load += new System.EventHandler(this.Movie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRentPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMovieR;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtMovieID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGetDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMovieSelected;
        private System.Windows.Forms.Label label5;
    }
}