namespace WineCardVersionFive.Uc
{
    partial class UcWinery
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
            dataGridViewWinery = new DataGridView();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            groupBoxWinery = new GroupBox();
            buttonSave = new Button();
            label1 = new Label();
            comboBoxRegion = new ComboBox();
            textBoxName = new TextBox();
            labelName = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWinery).BeginInit();
            groupBoxWinery.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewWinery
            // 
            dataGridViewWinery.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewWinery.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewWinery.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewWinery.Location = new Point(3, 3);
            dataGridViewWinery.MultiSelect = false;
            dataGridViewWinery.Name = "dataGridViewWinery";
            dataGridViewWinery.ReadOnly = true;
            dataGridViewWinery.RowHeadersWidth = 51;
            dataGridViewWinery.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewWinery.Size = new Size(715, 402);
            dataGridViewWinery.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(403, 411);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(101, 55);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Hinzufügen";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(510, 411);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(101, 55);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Bearbeiten";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(617, 411);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(101, 55);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Löschen";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // groupBoxWinery
            // 
            groupBoxWinery.Controls.Add(buttonSave);
            groupBoxWinery.Controls.Add(label1);
            groupBoxWinery.Controls.Add(comboBoxRegion);
            groupBoxWinery.Controls.Add(textBoxName);
            groupBoxWinery.Controls.Add(labelName);
            groupBoxWinery.Location = new Point(724, 3);
            groupBoxWinery.Name = "groupBoxWinery";
            groupBoxWinery.Size = new Size(333, 217);
            groupBoxWinery.TabIndex = 4;
            groupBoxWinery.TabStop = false;
            groupBoxWinery.Text = "Weingut";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(233, 176);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Speichern";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 89);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 3;
            label1.Text = "Region";
            // 
            // comboBoxRegion
            // 
            comboBoxRegion.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRegion.FormattingEnabled = true;
            comboBoxRegion.Location = new Point(120, 86);
            comboBoxRegion.Name = "comboBoxRegion";
            comboBoxRegion.Size = new Size(207, 28);
            comboBoxRegion.TabIndex = 2;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(120, 53);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(207, 27);
            textBoxName.TabIndex = 1;
            textBoxName.KeyPress += textBoxName_KeyPress;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(6, 56);
            labelName.Name = "labelName";
            labelName.Size = new Size(49, 20);
            labelName.TabIndex = 0;
            labelName.Text = "Name";
            // 
            // UcWinery
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxWinery);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewWinery);
            Name = "UcWinery";
            Size = new Size(1060, 469);
            ((System.ComponentModel.ISupportInitialize)dataGridViewWinery).EndInit();
            groupBoxWinery.ResumeLayout(false);
            groupBoxWinery.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewWinery;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
        private GroupBox groupBoxWinery;
        private Button buttonSave;
        private Label label1;
        private ComboBox comboBoxRegion;
        private TextBox textBoxName;
        private Label labelName;
    }
}
