namespace Responsi_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbNama = new TextBox();
            cbDept = new ComboBox();
            listBox1 = new ListBox();
            btnInsert = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dgvData = new DataGridView();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2023_12_12_102713;
            pictureBox1.Location = new Point(30, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 39);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 1;
            label1.Text = "Logo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 98);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 2;
            label2.Text = "Nama Karyawan :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 136);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 3;
            label3.Text = "Dep. Karyawan :";
            // 
            // tbNama
            // 
            tbNama.Location = new Point(138, 95);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(119, 23);
            tbNama.TabIndex = 4;
            // 
            // cbDept
            // 
            cbDept.FormattingEnabled = true;
            cbDept.Items.AddRange(new object[] { "HR", "ENG", "DEV", "PM", "FIN" });
            cbDept.Location = new Point(138, 133);
            cbDept.Name = "cbDept";
            cbDept.Size = new Size(121, 23);
            cbDept.TabIndex = 5;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "ID Departemen", "HR : HR", "ENG : Engineer", "DEV : Developer", "PM : Product M", "FIN : Finance" });
            listBox1.Location = new Point(288, 17);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(156, 139);
            listBox1.TabIndex = 6;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(33, 174);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(106, 27);
            btnInsert.TabIndex = 7;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(179, 176);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(105, 23);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(326, 176);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(101, 23);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(31, 220);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(412, 151);
            dgvData.TabIndex = 10;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(333, 383);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(113, 22);
            btnLoad.TabIndex = 11;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 450);
            Controls.Add(btnLoad);
            Controls.Add(dgvData);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Controls.Add(listBox1);
            Controls.Add(cbDept);
            Controls.Add(tbNama);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbNama;
        private ComboBox cbDept;
        private ListBox listBox1;
        private Button btnInsert;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dgvData;
        private Button btnLoad;
    }
}