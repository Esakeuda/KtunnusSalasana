namespace KtunnusSalasana
{
    partial class SalasanaForm
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
            SalasanaPanel = new Panel();
            VirheviestiLB = new Label();
            TarkistaBT = new Button();
            SalasanaTB = new TextBox();
            KayttajaTB = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SalasanaOikeinPanel = new Panel();
            TervetuloaSivuilleniLB = new Label();
            SalasanaPanel.SuspendLayout();
            SalasanaOikeinPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SalasanaPanel
            // 
            SalasanaPanel.BackColor = Color.MidnightBlue;
            SalasanaPanel.Controls.Add(VirheviestiLB);
            SalasanaPanel.Controls.Add(TarkistaBT);
            SalasanaPanel.Controls.Add(SalasanaTB);
            SalasanaPanel.Controls.Add(KayttajaTB);
            SalasanaPanel.Controls.Add(label2);
            SalasanaPanel.Controls.Add(label1);
            SalasanaPanel.Dock = DockStyle.Fill;
            SalasanaPanel.Font = new Font("Segoe Script", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            SalasanaPanel.ForeColor = Color.Gold;
            SalasanaPanel.Location = new Point(0, 0);
            SalasanaPanel.Name = "SalasanaPanel";
            SalasanaPanel.Size = new Size(707, 359);
            SalasanaPanel.TabIndex = 0;
            // 
            // VirheviestiLB
            // 
            VirheviestiLB.AutoSize = true;
            VirheviestiLB.Location = new Point(29, 213);
            VirheviestiLB.Name = "VirheviestiLB";
            VirheviestiLB.Size = new Size(86, 40);
            VirheviestiLB.TabIndex = 5;
            VirheviestiLB.Text = "Virhe";
            VirheviestiLB.Visible = false;
            // 
            // TarkistaBT
            // 
            TarkistaBT.ForeColor = Color.Black;
            TarkistaBT.Location = new Point(29, 133);
            TarkistaBT.Name = "TarkistaBT";
            TarkistaBT.Size = new Size(140, 40);
            TarkistaBT.TabIndex = 4;
            TarkistaBT.Text = "Tarkista";
            TarkistaBT.UseVisualStyleBackColor = true;
            TarkistaBT.Click += TarkistaBT_Click;
            // 
            // SalasanaTB
            // 
            SalasanaTB.Location = new Point(307, 133);
            SalasanaTB.Name = "SalasanaTB";
            SalasanaTB.Size = new Size(268, 46);
            SalasanaTB.TabIndex = 3;
            // 
            // KayttajaTB
            // 
            KayttajaTB.Location = new Point(307, 44);
            KayttajaTB.Name = "KayttajaTB";
            KayttajaTB.Size = new Size(268, 46);
            KayttajaTB.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(170, 139);
            label2.Name = "label2";
            label2.Size = new Size(138, 40);
            label2.TabIndex = 1;
            label2.Text = "Salasana:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 44);
            label1.Name = "label1";
            label1.Size = new Size(220, 40);
            label1.TabIndex = 0;
            label1.Text = "Käyttäjätunnus:";
            // 
            // SalasanaOikeinPanel
            // 
            SalasanaOikeinPanel.BackColor = Color.DarkRed;
            SalasanaOikeinPanel.Controls.Add(TervetuloaSivuilleniLB);
            SalasanaOikeinPanel.Dock = DockStyle.Fill;
            SalasanaOikeinPanel.Font = new Font("Segoe Script", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            SalasanaOikeinPanel.ForeColor = Color.Snow;
            SalasanaOikeinPanel.Location = new Point(0, 0);
            SalasanaOikeinPanel.Name = "SalasanaOikeinPanel";
            SalasanaOikeinPanel.Size = new Size(707, 359);
            SalasanaOikeinPanel.TabIndex = 1;
            SalasanaOikeinPanel.Visible = false;
            // 
            // TervetuloaSivuilleniLB
            // 
            TervetuloaSivuilleniLB.AutoSize = true;
            TervetuloaSivuilleniLB.Location = new Point(57, 74);
            TervetuloaSivuilleniLB.Name = "TervetuloaSivuilleniLB";
            TervetuloaSivuilleniLB.Size = new Size(574, 80);
            TervetuloaSivuilleniLB.TabIndex = 0;
            TervetuloaSivuilleniLB.Text = "Tervetuloa sivuilleni";
            // 
            // SalasanaForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 359);
            Controls.Add(SalasanaOikeinPanel);
            Controls.Add(SalasanaPanel);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "SalasanaForm";
            Text = "Salasanan tarkastus";
            SalasanaPanel.ResumeLayout(false);
            SalasanaPanel.PerformLayout();
            SalasanaOikeinPanel.ResumeLayout(false);
            SalasanaOikeinPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel SalasanaPanel;
        private Button TarkistaBT;
        private TextBox SalasanaTB;
        private TextBox KayttajaTB;
        private Label label2;
        private Label label1;
        private Label VirheviestiLB;
        private Panel SalasanaOikeinPanel;
        private Label TervetuloaSivuilleniLB;
    }
}