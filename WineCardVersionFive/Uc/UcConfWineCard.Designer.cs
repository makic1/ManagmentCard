namespace WineCardVersionFive.Uc
{
    partial class UcConfWineCard
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
            buttonAdd = new Button();
            buttonDelete = new Button();
            dataGridViewWine = new DataGridView();
            label1 = new Label();
            textBoxWineType = new TextBox();
            buttonSearch = new Button();
            textBoxRegion = new TextBox();
            labelRegion = new Label();
            textBoxCountry = new TextBox();
            labelCountry = new Label();
            textBoxWinery = new TextBox();
            labelwinery = new Label();
            textBoxGrapeVariety = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBoxVintage = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWine).BeginInit();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(852, 411);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(96, 55);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Hinzufügen";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(954, 411);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(101, 55);
            buttonDelete.TabIndex = 8;
            buttonDelete.Text = "Löschen";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // dataGridViewWine
            // 
            dataGridViewWine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewWine.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewWine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewWine.Location = new Point(3, 77);
            dataGridViewWine.MultiSelect = false;
            dataGridViewWine.Name = "dataGridViewWine";
            dataGridViewWine.ReadOnly = true;
            dataGridViewWine.RowHeadersWidth = 51;
            dataGridViewWine.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewWine.Size = new Size(1054, 328);
            dataGridViewWine.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 9;
            label1.Text = "Weinart";
            // 
            // textBoxWineType
            // 
            textBoxWineType.Location = new Point(73, 3);
            textBoxWineType.Name = "textBoxWineType";
            textBoxWineType.Size = new Size(146, 27);
            textBoxWineType.TabIndex = 10;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(954, 3);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(94, 68);
            buttonSearch.TabIndex = 11;
            buttonSearch.Text = "Suchen";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxRegion
            // 
            textBoxRegion.Location = new Point(322, 3);
            textBoxRegion.Name = "textBoxRegion";
            textBoxRegion.Size = new Size(146, 27);
            textBoxRegion.TabIndex = 13;
            // 
            // labelRegion
            // 
            labelRegion.AutoSize = true;
            labelRegion.Location = new Point(252, 3);
            labelRegion.Name = "labelRegion";
            labelRegion.Size = new Size(56, 20);
            labelRegion.TabIndex = 12;
            labelRegion.Text = "Region";
            // 
            // textBoxCountry
            // 
            textBoxCountry.Location = new Point(563, 3);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.Size = new Size(146, 27);
            textBoxCountry.TabIndex = 15;
            // 
            // labelCountry
            // 
            labelCountry.AutoSize = true;
            labelCountry.Location = new Point(493, 3);
            labelCountry.Name = "labelCountry";
            labelCountry.Size = new Size(60, 20);
            labelCountry.TabIndex = 14;
            labelCountry.Text = "Country";
            // 
            // textBoxWinery
            // 
            textBoxWinery.Location = new Point(73, 36);
            textBoxWinery.Name = "textBoxWinery";
            textBoxWinery.Size = new Size(146, 27);
            textBoxWinery.TabIndex = 17;
            // 
            // labelwinery
            // 
            labelwinery.AutoSize = true;
            labelwinery.Location = new Point(3, 36);
            labelwinery.Name = "labelwinery";
            labelwinery.Size = new Size(64, 20);
            labelwinery.TabIndex = 16;
            labelwinery.Text = "Weingut";
            // 
            // textBoxGrapeVariety
            // 
            textBoxGrapeVariety.Location = new Point(322, 36);
            textBoxGrapeVariety.Name = "textBoxGrapeVariety";
            textBoxGrapeVariety.Size = new Size(146, 27);
            textBoxGrapeVariety.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(252, 36);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 18;
            label2.Text = "Rebsorte";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(493, 36);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 20;
            label3.Text = "Jahrgang";
            // 
            // textBoxVintage
            // 
            textBoxVintage.Location = new Point(563, 36);
            textBoxVintage.Name = "textBoxVintage";
            textBoxVintage.Size = new Size(146, 27);
            textBoxVintage.TabIndex = 21;
            textBoxVintage.Text = "0";
            // 
            // UcConfWineCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBoxVintage);
            Controls.Add(label3);
            Controls.Add(textBoxGrapeVariety);
            Controls.Add(label2);
            Controls.Add(textBoxWinery);
            Controls.Add(labelwinery);
            Controls.Add(textBoxCountry);
            Controls.Add(labelCountry);
            Controls.Add(textBoxRegion);
            Controls.Add(labelRegion);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxWineType);
            Controls.Add(label1);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewWine);
            Name = "UcConfWineCard";
            Size = new Size(1060, 469);
            ((System.ComponentModel.ISupportInitialize)dataGridViewWine).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonAdd;
        private Button buttonDelete;
        private DataGridView dataGridViewWine;
        private Label label1;
        private TextBox textBoxWineType;
        private Button buttonSearch;
        private TextBox textBoxRegion;
        private Label labelRegion;
        private TextBox textBoxCountry;
        private Label labelCountry;
        private TextBox textBoxWinery;
        private Label labelwinery;
        private TextBox textBoxGrapeVariety;
        private Label label2;
        private Label label3;
        private TextBox textBoxVintage;
    }
}
