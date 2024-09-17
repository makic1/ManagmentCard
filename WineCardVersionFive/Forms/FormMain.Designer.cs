namespace WineCardVersionFive
{
    partial class FormMain
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
            panelMain = new Panel();
            buttonWineCard = new Button();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Location = new Point(12, 39);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1074, 508);
            panelMain.TabIndex = 0;
            // 
            // buttonWineCard
            // 
            buttonWineCard.Location = new Point(992, 4);
            buttonWineCard.Name = "buttonWineCard";
            buttonWineCard.Size = new Size(94, 29);
            buttonWineCard.TabIndex = 1;
            buttonWineCard.Text = "Weinkarte";
            buttonWineCard.UseVisualStyleBackColor = true;
            buttonWineCard.Click += buttonWineCard_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 559);
            Controls.Add(buttonWineCard);
            Controls.Add(panelMain);
            Name = "FormMain";
            Text = "Wein Managment";
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Button buttonWineCard;
    }
}
