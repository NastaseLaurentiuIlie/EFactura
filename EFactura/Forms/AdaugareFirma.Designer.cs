namespace EFactura.Forms
{
    partial class AdaugareFirma
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
            groupBox1 = new GroupBox();
            LocalitateTextBox = new TextBox();
            JudetTextBox = new TextBox();
            TaraTextBox = new TextBox();
            AdresaTextBox = new TextBox();
            NumeFirmaTextBox = new TextBox();
            NRRegComertTextBox = new TextBox();
            CUITextBox = new TextBox();
            CUI = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            AdaugareFirmBtn = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LocalitateTextBox);
            groupBox1.Controls.Add(JudetTextBox);
            groupBox1.Controls.Add(TaraTextBox);
            groupBox1.Controls.Add(AdresaTextBox);
            groupBox1.Controls.Add(NumeFirmaTextBox);
            groupBox1.Controls.Add(NRRegComertTextBox);
            groupBox1.Controls.Add(CUITextBox);
            groupBox1.Location = new Point(249, 69);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(449, 569);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Introduceti datele firmei";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // LocalitateTextBox
            // 
            LocalitateTextBox.Location = new Point(8, 452);
            LocalitateTextBox.Margin = new Padding(4, 4, 4, 4);
            LocalitateTextBox.Name = "LocalitateTextBox";
            LocalitateTextBox.Size = new Size(419, 31);
            LocalitateTextBox.TabIndex = 6;
            // 
            // JudetTextBox
            // 
            JudetTextBox.Location = new Point(8, 391);
            JudetTextBox.Margin = new Padding(4, 4, 4, 4);
            JudetTextBox.Name = "JudetTextBox";
            JudetTextBox.Size = new Size(419, 31);
            JudetTextBox.TabIndex = 5;
            // 
            // TaraTextBox
            // 
            TaraTextBox.Location = new Point(8, 322);
            TaraTextBox.Margin = new Padding(4, 4, 4, 4);
            TaraTextBox.Name = "TaraTextBox";
            TaraTextBox.Size = new Size(419, 31);
            TaraTextBox.TabIndex = 4;
            // 
            // AdresaTextBox
            // 
            AdresaTextBox.Location = new Point(8, 528);
            AdresaTextBox.Margin = new Padding(4, 4, 4, 4);
            AdresaTextBox.Name = "AdresaTextBox";
            AdresaTextBox.Size = new Size(419, 31);
            AdresaTextBox.TabIndex = 1;
            AdresaTextBox.TextChanged += textBox4_TextChanged;
            // 
            // NumeFirmaTextBox
            // 
            NumeFirmaTextBox.Location = new Point(8, 180);
            NumeFirmaTextBox.Margin = new Padding(4, 4, 4, 4);
            NumeFirmaTextBox.Name = "NumeFirmaTextBox";
            NumeFirmaTextBox.Size = new Size(419, 31);
            NumeFirmaTextBox.TabIndex = 3;
            // 
            // NRRegComertTextBox
            // 
            NRRegComertTextBox.Location = new Point(8, 255);
            NRRegComertTextBox.Margin = new Padding(4, 4, 4, 4);
            NRRegComertTextBox.Name = "NRRegComertTextBox";
            NRRegComertTextBox.Size = new Size(419, 31);
            NRRegComertTextBox.TabIndex = 2;
            // 
            // CUITextBox
            // 
            CUITextBox.Location = new Point(8, 108);
            CUITextBox.Margin = new Padding(4, 4, 4, 4);
            CUITextBox.Name = "CUITextBox";
            CUITextBox.Size = new Size(419, 31);
            CUITextBox.TabIndex = 0;
            // 
            // CUI
            // 
            CUI.AutoSize = true;
            CUI.Font = new Font("Microsoft Himalaya", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CUI.Location = new Point(15, 176);
            CUI.Margin = new Padding(4, 0, 4, 0);
            CUI.Name = "CUI";
            CUI.Size = new Size(63, 40);
            CUI.TabIndex = 1;
            CUI.Text = "CUI";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Himalaya", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 248);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(153, 40);
            label1.TabIndex = 2;
            label1.Text = "Nume Firma";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Himalaya", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 324);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(228, 40);
            label2.TabIndex = 3;
            label2.Text = "Nr Regsitru Comert";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Himalaya", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 391);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(66, 40);
            label3.TabIndex = 4;
            label3.Text = "Tara";
            // 
            // AdaugareFirmBtn
            // 
            AdaugareFirmBtn.Location = new Point(270, 678);
            AdaugareFirmBtn.Margin = new Padding(4, 4, 4, 4);
            AdaugareFirmBtn.Name = "AdaugareFirmBtn";
            AdaugareFirmBtn.Size = new Size(118, 36);
            AdaugareFirmBtn.TabIndex = 5;
            AdaugareFirmBtn.Text = "OK";
            AdaugareFirmBtn.UseVisualStyleBackColor = true;
            AdaugareFirmBtn.Click += AdaugareFirmBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Himalaya", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 451);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(72, 40);
            label4.TabIndex = 6;
            label4.Text = "Judet";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Himalaya", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 520);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(122, 40);
            label5.TabIndex = 7;
            label5.Text = "Localitate";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Himalaya", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(15, 596);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(92, 40);
            label6.TabIndex = 8;
            label6.Text = "Adresa";
            // 
            // AdaugareFirma
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 808);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(AdaugareFirmBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(CUI);
            Margin = new Padding(4, 4, 4, 4);
            Name = "AdaugareFirma";
            Text = "AdaugareFirma";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox NRRegComertTextBox;
        private Label CUI;
        private TextBox CUITextBox;
        private TextBox AdresaTextBox;
        private TextBox NumeFirmaTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button AdaugareFirmBtn;
        private TextBox LocalitateTextBox;
        private TextBox JudetTextBox;
        private TextBox TaraTextBox;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}