namespace GEICOprojectV1
{
    partial class AutoCombo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label movie_nameLabel;
            System.Windows.Forms.Label picLabel;
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbMovie2 = new System.Windows.Forms.ComboBox();
            this.lblAA = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClosed = new System.Windows.Forms.Button();
            this.geicoDataSet = new GEICOprojectV1.GeicoDataSet();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieTableAdapter = new GEICOprojectV1.GeicoDataSetTableAdapters.MovieTableAdapter();
            this.tableAdapterManager = new GEICOprojectV1.GeicoDataSetTableAdapters.TableAdapterManager();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.movie_nameTextBox = new System.Windows.Forms.TextBox();
            this.picPictureBox = new System.Windows.Forms.PictureBox();
            this.movieDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDisply = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            movie_nameLabel = new System.Windows.Forms.Label();
            picLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.geicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(495, 367);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 5;
            idLabel.Text = "id:";
            // 
            // movie_nameLabel
            // 
            movie_nameLabel.AutoSize = true;
            movie_nameLabel.Location = new System.Drawing.Point(495, 393);
            movie_nameLabel.Name = "movie_nameLabel";
            movie_nameLabel.Size = new System.Drawing.Size(68, 13);
            movie_nameLabel.TabIndex = 7;
            movie_nameLabel.Text = "Movie name:";
            // 
            // picLabel
            // 
            picLabel.AutoSize = true;
            picLabel.Location = new System.Drawing.Point(495, 416);
            picLabel.Name = "picLabel";
            picLabel.Size = new System.Drawing.Size(24, 13);
            picLabel.TabIndex = 9;
            picLabel.Text = "pic:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(46, 64);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbCategory.TabIndex = 0;
            this.cmbCategory.Text = "Movie Category";
            this.cmbCategory.SelectedValueChanged += new System.EventHandler(this.CmbCategory_SelectedValueChanged);
            this.cmbCategory.Enter += new System.EventHandler(this.CmbCategory_Enter);
            this.cmbCategory.Leave += new System.EventHandler(this.CmbCategory_Leave);
            // 
            // cmbMovie2
            // 
            this.cmbMovie2.FormattingEnabled = true;
            this.cmbMovie2.Location = new System.Drawing.Point(46, 155);
            this.cmbMovie2.Name = "cmbMovie2";
            this.cmbMovie2.Size = new System.Drawing.Size(121, 21);
            this.cmbMovie2.TabIndex = 1;
            this.cmbMovie2.Text = "Select Movie";
            this.cmbMovie2.Enter += new System.EventHandler(this.CmbMovie2_Enter);
            this.cmbMovie2.Leave += new System.EventHandler(this.CmbMovie2_Leave);
            // 
            // lblAA
            // 
            this.lblAA.AutoSize = true;
            this.lblAA.Location = new System.Drawing.Point(43, 113);
            this.lblAA.Name = "lblAA";
            this.lblAA.Size = new System.Drawing.Size(27, 13);
            this.lblAA.TabIndex = 2;
            this.lblAA.Text = "AA--";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(-5, 213);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // btnClosed
            // 
            this.btnClosed.Location = new System.Drawing.Point(-5, 247);
            this.btnClosed.Name = "btnClosed";
            this.btnClosed.Size = new System.Drawing.Size(75, 23);
            this.btnClosed.TabIndex = 4;
            this.btnClosed.Text = "closed";
            this.btnClosed.UseVisualStyleBackColor = true;
            this.btnClosed.Click += new System.EventHandler(this.BtnClosed_Click);
            // 
            // geicoDataSet
            // 
            this.geicoDataSet.DataSetName = "GeicoDataSet";
            this.geicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataMember = "Movie";
            this.movieBindingSource.DataSource = this.geicoDataSet;
            // 
            // movieTableAdapter
            // 
            this.movieTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MovieTableAdapter = this.movieTableAdapter;
            this.tableAdapterManager.UpdateOrder = GEICOprojectV1.GeicoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(569, 364);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(159, 20);
            this.idTextBox.TabIndex = 6;
            // 
            // movie_nameTextBox
            // 
            this.movie_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieBindingSource, "Movie_name", true));
            this.movie_nameTextBox.Location = new System.Drawing.Point(569, 390);
            this.movie_nameTextBox.Name = "movie_nameTextBox";
            this.movie_nameTextBox.Size = new System.Drawing.Size(159, 20);
            this.movie_nameTextBox.TabIndex = 8;
            // 
            // picPictureBox
            // 
            this.picPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.movieBindingSource, "pic", true));
            this.picPictureBox.Location = new System.Drawing.Point(569, 436);
            this.picPictureBox.Name = "picPictureBox";
            this.picPictureBox.Size = new System.Drawing.Size(159, 112);
            this.picPictureBox.TabIndex = 10;
            this.picPictureBox.TabStop = false;
            // 
            // movieDataGridView
            // 
            this.movieDataGridView.AutoGenerateColumns = false;
            this.movieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movieDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewImageColumn1});
            this.movieDataGridView.DataSource = this.movieBindingSource;
            this.movieDataGridView.Location = new System.Drawing.Point(175, 367);
            this.movieDataGridView.Name = "movieDataGridView";
            this.movieDataGridView.Size = new System.Drawing.Size(300, 220);
            this.movieDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Movie_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Movie_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "pic";
            this.dataGridViewImageColumn1.HeaderText = "pic";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Gridview display picture, list of data, column";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "https://www.youtube.com/watch?v=W_cOlBBlFGM";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(391, 29);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 14;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(391, 62);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(391, 101);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 14;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(190, 188);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(276, 97);
            this.listView.TabIndex = 15;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.ListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(190, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(654, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 172);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(838, 12);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 18;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(702, 12);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Movie Type";
            // 
            // txtDisply
            // 
            this.txtDisply.Location = new System.Drawing.Point(31, 312);
            this.txtDisply.Name = "txtDisply";
            this.txtDisply.Size = new System.Drawing.Size(100, 20);
            this.txtDisply.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Display Text Hint";
            // 
            // AutoCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 701);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDisply);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.movieDataGridView);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(movie_nameLabel);
            this.Controls.Add(this.movie_nameTextBox);
            this.Controls.Add(picLabel);
            this.Controls.Add(this.picPictureBox);
            this.Controls.Add(this.btnClosed);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblAA);
            this.Controls.Add(this.cmbMovie2);
            this.Controls.Add(this.cmbCategory);
            this.Name = "AutoCombo";
            this.Text = "AutoCombo";
            this.Load += new System.EventHandler(this.AutoCombo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.geicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbMovie2;
        private System.Windows.Forms.Label lblAA;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClosed;
        private GeicoDataSet geicoDataSet;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private GeicoDataSetTableAdapters.MovieTableAdapter movieTableAdapter;
        private GeicoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox movie_nameTextBox;
        private System.Windows.Forms.PictureBox picPictureBox;
        private System.Windows.Forms.DataGridView movieDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDisply;
        private System.Windows.Forms.Label label4;
    }
}