namespace Employee_Registration
{
    partial class Fenster1
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
            lblName = new Label();
            lblPosition = new Label();
            lblSurname = new Label();
            lblCity = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            txtBoxName = new TextBox();
            txtBoxPosition = new TextBox();
            txtBoxSurname = new TextBox();
            txtBoxCity = new TextBox();
            dataGridView1 = new DataGridView();
            Column_ID = new DataGridViewTextBoxColumn();
            Column_Name = new DataGridViewTextBoxColumn();
            Column_Surname = new DataGridViewTextBoxColumn();
            Column_Position = new DataGridViewTextBoxColumn();
            Column_City = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(36, 36);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(36, 74);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(56, 15);
            lblPosition.TabIndex = 1;
            lblPosition.Text = "Position: ";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new Point(236, 36);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(57, 15);
            lblSurname.TabIndex = 2;
            lblSurname.Text = "Surname:";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(236, 74);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(34, 15);
            lblCity.TabIndex = 3;
            lblCity.Text = "City: ";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(454, 32);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(454, 70);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(604, 32);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(604, 70);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(96, 28);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(100, 23);
            txtBoxName.TabIndex = 8;
            txtBoxName.TextChanged += txtBoxName_TextChanged;
            // 
            // txtBoxPosition
            // 
            txtBoxPosition.Location = new Point(96, 66);
            txtBoxPosition.Name = "txtBoxPosition";
            txtBoxPosition.Size = new Size(100, 23);
            txtBoxPosition.TabIndex = 9;
            txtBoxPosition.TextChanged += txtBoxPosition_TextChanged;
            // 
            // txtBoxSurname
            // 
            txtBoxSurname.Location = new Point(299, 28);
            txtBoxSurname.Name = "txtBoxSurname";
            txtBoxSurname.Size = new Size(100, 23);
            txtBoxSurname.TabIndex = 10;
            txtBoxSurname.TextChanged += txtBoxSurname_TextChanged;
            // 
            // txtBoxCity
            // 
            txtBoxCity.Location = new Point(299, 66);
            txtBoxCity.Name = "txtBoxCity";
            txtBoxCity.Size = new Size(100, 23);
            txtBoxCity.TabIndex = 11;
            txtBoxCity.TextChanged += txtBoxCity_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column_ID, Column_Name, Column_Surname, Column_Position, Column_City });
            dataGridView1.Location = new Point(96, 167);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(543, 150);
            dataGridView1.TabIndex = 12;
            // 
            // Column_ID
            // 
            Column_ID.HeaderText = "ID";
            Column_ID.Name = "Column_ID";
            // 
            // Column_Name
            // 
            Column_Name.HeaderText = "Name";
            Column_Name.Name = "Column_Name";
            // 
            // Column_Surname
            // 
            Column_Surname.HeaderText = "Surname";
            Column_Surname.Name = "Column_Surname";
            // 
            // Column_Position
            // 
            Column_Position.HeaderText = "Position";
            Column_Position.Name = "Column_Position";
            // 
            // Column_City
            // 
            Column_City.HeaderText = "City";
            Column_City.Name = "Column_City";
            // 
            // Fenster1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 450);
            Controls.Add(dataGridView1);
            Controls.Add(txtBoxCity);
            Controls.Add(txtBoxSurname);
            Controls.Add(txtBoxPosition);
            Controls.Add(txtBoxName);
            Controls.Add(btnClear);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(lblCity);
            Controls.Add(lblSurname);
            Controls.Add(lblPosition);
            Controls.Add(lblName);
            Name = "Fenster1";
            Text = "Fenster1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblPosition;
        private Label lblSurname;
        private Label lblCity;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClear;
        private TextBox txtBoxName;
        private TextBox txtBoxPosition;
        private TextBox txtBoxSurname;
        private TextBox txtBoxCity;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column_ID;
        private DataGridViewTextBoxColumn Column_Name;
        private DataGridViewTextBoxColumn Column_Surname;
        private DataGridViewTextBoxColumn Column_Position;
        private DataGridViewTextBoxColumn Column_City;
    }
}