namespace WineCardVersionFive.Uc
{
    partial class UcVintage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxVintage = new GroupBox();
            dateTimePickerVintage = new DateTimePicker();
            buttonSave = new Button();
            labelYear = new Label();
            buttonDelete = new Button();
            buttonEdit = new Button();
            buttonAdd = new Button();
            dataGridViewVintage = new DataGridView();
            groupBoxVintage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVintage).BeginInit();
            SuspendLayout();
            // 
            // groupBoxVintage
            // 
            groupBoxVintage.Controls.Add(dateTimePickerVintage);
            groupBoxVintage.Controls.Add(buttonSave);
            groupBoxVintage.Controls.Add(labelYear);
            groupBoxVintage.Location = new Point(724, 3);
            groupBoxVintage.Name = "groupBoxVintage";
            groupBoxVintage.Size = new Size(333, 150);
            groupBoxVintage.TabIndex = 9;
            groupBoxVintage.TabStop = false;
            groupBoxVintage.Text = "Vintage";
            // 
            // dateTimePickerVintage
            // 
            dateTimePickerVintage.Location = new Point(118, 51);
            dateTimePickerVintage.Name = "dateTimePickerVintage";
            dateTimePickerVintage.Size = new Size(209, 27);
            dateTimePickerVintage.TabIndex = 5;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(233, 110);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Speichern";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Location = new Point(15, 56);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(35, 20);
            labelYear.TabIndex = 0;
            labelYear.Text = "Jahr";
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(617, 411);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(101, 55);
            buttonDelete.TabIndex = 8;
            buttonDelete.Text = "Löschen";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(510, 411);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(101, 55);
            buttonEdit.TabIndex = 7;
            buttonEdit.Text = "Bearbeiten";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(403, 411);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(101, 55);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Hinzufügen";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // dataGridViewVintage
            // 
            dataGridViewVintage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewVintage.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewVintage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVintage.Location = new Point(3, 3);
            dataGridViewVintage.MultiSelect = false;
            dataGridViewVintage.Name = "dataGridViewVintage";
            dataGridViewVintage.ReadOnly = true;
            dataGridViewVintage.RowHeadersWidth = 51;
            dataGridViewVintage.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewVintage.Size = new Size(715, 402);
            dataGridViewVintage.TabIndex = 5;
            // 
            // UcVintage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxVintage);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewVintage);
            Name = "UcVintage";
            Size = new Size(1060, 469);
            groupBoxVintage.ResumeLayout(false);
            groupBoxVintage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVintage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxVintage;
        private Button buttonSave;
        private Label labelYear;
        private Button buttonDelete;
        private Button buttonEdit;
        private Button buttonAdd;
        private DataGridView dataGridViewVintage;
        private DateTimePicker dateTimePickerVintage;
    }
}
