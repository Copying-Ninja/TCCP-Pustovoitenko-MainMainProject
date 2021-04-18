namespace DBEntity
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contValTextBox = new System.Windows.Forms.TextBox();
            this.contactValueLabel = new System.Windows.Forms.Label();
            this.personIdTextBox = new System.Windows.Forms.TextBox();
            this.personIdLabel = new System.Windows.Forms.Label();
            this.contTypeIdTextBox = new System.Windows.Forms.TextBox();
            this.contactTypeIdLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.id_contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_contact,
            this.contactTypeId,
            this.personId,
            this.contactValue});
            this.dataGridView.Location = new System.Drawing.Point(396, 54);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(557, 426);
            this.dataGridView.TabIndex = 16;
            this.dataGridView.DoubleClick += new System.EventHandler(this.dataGridView_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.contValTextBox);
            this.panel1.Controls.Add(this.contactValueLabel);
            this.panel1.Controls.Add(this.personIdTextBox);
            this.panel1.Controls.Add(this.personIdLabel);
            this.panel1.Controls.Add(this.contTypeIdTextBox);
            this.panel1.Controls.Add(this.contactTypeIdLabel);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.delButton);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Location = new System.Drawing.Point(27, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 426);
            this.panel1.TabIndex = 17;
            // 
            // contValTextBox
            // 
            this.contValTextBox.Location = new System.Drawing.Point(154, 202);
            this.contValTextBox.Name = "contValTextBox";
            this.contValTextBox.Size = new System.Drawing.Size(175, 22);
            this.contValTextBox.TabIndex = 33;
            // 
            // contactValueLabel
            // 
            this.contactValueLabel.AutoSize = true;
            this.contactValueLabel.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactValueLabel.Location = new System.Drawing.Point(14, 196);
            this.contactValueLabel.Name = "contactValueLabel";
            this.contactValueLabel.Size = new System.Drawing.Size(128, 37);
            this.contactValueLabel.TabIndex = 30;
            this.contactValueLabel.Text = "contact_value";
            // 
            // personIdTextBox
            // 
            this.personIdTextBox.Location = new System.Drawing.Point(154, 158);
            this.personIdTextBox.Name = "personIdTextBox";
            this.personIdTextBox.Size = new System.Drawing.Size(175, 22);
            this.personIdTextBox.TabIndex = 34;
            // 
            // personIdLabel
            // 
            this.personIdLabel.AutoSize = true;
            this.personIdLabel.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personIdLabel.Location = new System.Drawing.Point(14, 152);
            this.personIdLabel.Name = "personIdLabel";
            this.personIdLabel.Size = new System.Drawing.Size(99, 37);
            this.personIdLabel.TabIndex = 31;
            this.personIdLabel.Text = "person_id";
            // 
            // contTypeIdTextBox
            // 
            this.contTypeIdTextBox.Location = new System.Drawing.Point(154, 111);
            this.contTypeIdTextBox.Name = "contTypeIdTextBox";
            this.contTypeIdTextBox.Size = new System.Drawing.Size(175, 22);
            this.contTypeIdTextBox.TabIndex = 35;
            // 
            // contactTypeIdLabel
            // 
            this.contactTypeIdLabel.AutoSize = true;
            this.contactTypeIdLabel.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactTypeIdLabel.Location = new System.Drawing.Point(7, 105);
            this.contactTypeIdLabel.Name = "contactTypeIdLabel";
            this.contactTypeIdLabel.Size = new System.Drawing.Size(150, 37);
            this.contactTypeIdLabel.TabIndex = 32;
            this.contactTypeIdLabel.Text = "contact_type_id";
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(230, 341);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(85, 49);
            this.cancelButton.TabIndex = 27;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // delButton
            // 
            this.delButton.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delButton.Location = new System.Drawing.Point(129, 341);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(92, 49);
            this.delButton.TabIndex = 28;
            this.delButton.Text = "Delete";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click_1);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(27, 341);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(93, 49);
            this.saveButton.TabIndex = 29;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 48);
            this.label1.TabIndex = 36;
            this.label1.Text = "Contacts";
            // 
            // id_contact
            // 
            this.id_contact.DataPropertyName = "contact_id";
            this.id_contact.HeaderText = "contact_id";
            this.id_contact.MinimumWidth = 6;
            this.id_contact.Name = "id_contact";
            this.id_contact.ReadOnly = true;
            this.id_contact.Visible = false;
            this.id_contact.Width = 125;
            // 
            // contactTypeId
            // 
            this.contactTypeId.DataPropertyName = "contact_type_id";
            this.contactTypeId.HeaderText = "contact_type_id";
            this.contactTypeId.MinimumWidth = 6;
            this.contactTypeId.Name = "contactTypeId";
            this.contactTypeId.ReadOnly = true;
            this.contactTypeId.Width = 125;
            // 
            // personId
            // 
            this.personId.DataPropertyName = "person_id";
            this.personId.HeaderText = "person_id";
            this.personId.MinimumWidth = 6;
            this.personId.Name = "personId";
            this.personId.ReadOnly = true;
            this.personId.Width = 125;
            // 
            // contactValue
            // 
            this.contactValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contactValue.DataPropertyName = "contact_value";
            this.contactValue.HeaderText = "contact_value";
            this.contactValue.MinimumWidth = 6;
            this.contactValue.Name = "contactValue";
            this.contactValue.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1001, 535);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox contValTextBox;
        private System.Windows.Forms.Label contactValueLabel;
        private System.Windows.Forms.TextBox personIdTextBox;
        private System.Windows.Forms.Label personIdLabel;
        private System.Windows.Forms.TextBox contTypeIdTextBox;
        private System.Windows.Forms.Label contactTypeIdLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn personId;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactValue;
    }
}

