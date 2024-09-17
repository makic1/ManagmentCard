namespace WineCardVersionFive.Uc
{
    partial class UcImportCSV
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
            buttonImportCsv = new Button();
            SuspendLayout();
            // 
            // buttonImportCsv
            // 
            buttonImportCsv.Location = new Point(350, 97);
            buttonImportCsv.Name = "buttonImportCsv";
            buttonImportCsv.Size = new Size(336, 249);
            buttonImportCsv.TabIndex = 0;
            buttonImportCsv.Text = "Import CSV";
            buttonImportCsv.UseVisualStyleBackColor = true;
            buttonImportCsv.Click += buttonImportCsv_Click;
            // 
            // UcImportCSV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonImportCsv);
            Name = "UcImportCSV";
            Size = new Size(1060, 469);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonImportCsv;
    }
}
