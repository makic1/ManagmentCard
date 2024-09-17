namespace WineCardVersionFive.Uc
{
    partial class UcManageUserControls
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
            tabControlMain = new TabControl();
            tabPageWinery = new TabPage();
            tabPageVintage = new TabPage();
            tabPageImportCsv = new TabPage();
            tabPageWineCard = new TabPage();
            tabControlMain.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageWinery);
            tabControlMain.Controls.Add(tabPageVintage);
            tabControlMain.Controls.Add(tabPageImportCsv);
            tabControlMain.Controls.Add(tabPageWineCard);
            tabControlMain.Location = new Point(3, 3);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1068, 502);
            tabControlMain.TabIndex = 0;
            tabControlMain.SelectedIndexChanged += tabControlMain_SelectedIndexChanged;
            // 
            // tabPageWinery
            // 
            tabPageWinery.Location = new Point(4, 29);
            tabPageWinery.Name = "tabPageWinery";
            tabPageWinery.Padding = new Padding(3);
            tabPageWinery.Size = new Size(1060, 469);
            tabPageWinery.TabIndex = 0;
            tabPageWinery.Text = "Weingüter";
            tabPageWinery.UseVisualStyleBackColor = true;
            // 
            // tabPageVintage
            // 
            tabPageVintage.Location = new Point(4, 29);
            tabPageVintage.Name = "tabPageVintage";
            tabPageVintage.Padding = new Padding(3);
            tabPageVintage.Size = new Size(1060, 469);
            tabPageVintage.TabIndex = 1;
            tabPageVintage.Text = "Jahrgng";
            tabPageVintage.UseVisualStyleBackColor = true;
            // 
            // tabPageImportCsv
            // 
            tabPageImportCsv.Location = new Point(4, 29);
            tabPageImportCsv.Name = "tabPageImportCsv";
            tabPageImportCsv.Size = new Size(1060, 469);
            tabPageImportCsv.TabIndex = 2;
            tabPageImportCsv.Text = "CSV Import";
            tabPageImportCsv.UseVisualStyleBackColor = true;
            // 
            // tabPageWineCard
            // 
            tabPageWineCard.Location = new Point(4, 29);
            tabPageWineCard.Name = "tabPageWineCard";
            tabPageWineCard.Size = new Size(1060, 469);
            tabPageWineCard.TabIndex = 3;
            tabPageWineCard.Text = "Weinkarte erstellen";
            tabPageWineCard.UseVisualStyleBackColor = true;
            // 
            // UcManageUserControls
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControlMain);
            Name = "UcManageUserControls";
            Size = new Size(1074, 508);
            tabControlMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabPageWinery;
        private TabPage tabPageVintage;
        private TabPage tabPageImportCsv;
        private TabPage tabPageWineCard;
    }
}
