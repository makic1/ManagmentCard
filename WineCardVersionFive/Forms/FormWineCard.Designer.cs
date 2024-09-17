namespace WineCardVersionFive.Forms
{
    partial class FormWineCard
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
            label1 = new Label();
            panel1 = new Panel();
            dataGridViewWineCard = new DataGridView();
            checkBoxWineType = new CheckBox();
            checkBoxWineName = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWineCard).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(494, 57);
            label1.TabIndex = 0;
            label1.Text = "Die Heutige Weinkarte ... ";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.ForeColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(25, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(1165, 3);
            panel1.TabIndex = 1;
            // 
            // dataGridViewWineCard
            // 
            dataGridViewWineCard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewWineCard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewWineCard.Location = new Point(25, 116);
            dataGridViewWineCard.MultiSelect = false;
            dataGridViewWineCard.Name = "dataGridViewWineCard";
            dataGridViewWineCard.ReadOnly = true;
            dataGridViewWineCard.RowHeadersWidth = 51;
            dataGridViewWineCard.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewWineCard.Size = new Size(1165, 453);
            dataGridViewWineCard.TabIndex = 2;
            // 
            // checkBoxWineType
            // 
            checkBoxWineType.AutoSize = true;
            checkBoxWineType.Location = new Point(25, 78);
            checkBoxWineType.Name = "checkBoxWineType";
            checkBoxWineType.Size = new Size(176, 24);
            checkBoxWineType.TabIndex = 3;
            checkBoxWineType.Text = "Weinart(alphabetisch)";
            checkBoxWineType.UseVisualStyleBackColor = true;
            checkBoxWineType.CheckedChanged += checkBoxWineType_CheckedChanged;
            // 
            // checkBoxWineName
            // 
            checkBoxWineName.AutoSize = true;
            checkBoxWineName.Location = new Point(222, 78);
            checkBoxWineName.Name = "checkBoxWineName";
            checkBoxWineName.Size = new Size(209, 24);
            checkBoxWineName.TabIndex = 4;
            checkBoxWineName.Text = "Bezeichnung(alphabetisch)";
            checkBoxWineName.UseVisualStyleBackColor = true;
            checkBoxWineName.CheckedChanged += checkBoxWineName_CheckedChanged;
            // 
            // WineCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 581);
            Controls.Add(checkBoxWineName);
            Controls.Add(checkBoxWineType);
            Controls.Add(dataGridViewWineCard);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "WineCard";
            Text = "WineCard";
            ((System.ComponentModel.ISupportInitialize)dataGridViewWineCard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private DataGridView dataGridViewWineCard;
        private CheckBox checkBoxWineType;
        private CheckBox checkBoxWineName;
    }
}