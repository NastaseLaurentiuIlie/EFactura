namespace EFactura.Forms
{
    partial class AdaugareClient
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
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
            groupBox1.Location = new Point(368, 69);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(428, 655);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Introduceti datele firmei";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // LocalitateTextBox
            // 
            LocalitateTextBox.Location = new Point(0, 584);
            LocalitateTextBox.Margin = new Padding(4, 4, 4, 4);
            LocalitateTextBox.Name = "LocalitateTextBox";
            LocalitateTextBox.Size = new Size(419, 31);
            LocalitateTextBox.TabIndex = 6;
            // 
            // JudetTextBox
            // 
            JudetTextBox.Location = new Point(0, 504);
            JudetTextBox.Margin = new Padding(4, 4, 4, 4);
            JudetTextBox.Name = "JudetTextBox";
            JudetTextBox.Size = new Size(419, 31);
            JudetTextBox.TabIndex = 5;
            // 
            // TaraTextBox
            // 
            TaraTextBox.Location = new Point(0, 426);
            TaraTextBox.Margin = new Padding(4, 4, 4, 4);
            TaraTextBox.Name = "TaraTextBox";
            TaraTextBox.Size = new Size(419, 31);
            TaraTextBox.TabIndex = 4;
            // 
            // AdresaTextBox
            // 
            AdresaTextBox.Location = new Point(0, 342);
            AdresaTextBox.Margin = new Padding(4, 4, 4, 4);
            AdresaTextBox.Name = "AdresaTextBox";
            AdresaTextBox.Size = new Size(419, 31);
            AdresaTextBox.TabIndex = 1;
            // 
            // NumeFirmaTextBox
            // 
            NumeFirmaTextBox.Location = new Point(0, 154);
            NumeFirmaTextBox.Margin = new Padding(4, 4, 4, 4);
            NumeFirmaTextBox.Name = "NumeFirmaTextBox";
            NumeFirmaTextBox.Size = new Size(419, 31);
            NumeFirmaTextBox.TabIndex = 3;
            // 
            // NRRegComertTextBox
            // 
            NRRegComertTextBox.Location = new Point(0, 256);
            NRRegComertTextBox.Margin = new Padding(4, 4, 4, 4);
            NRRegComertTextBox.Name = "NRRegComertTextBox";
            NRRegComertTextBox.Size = new Size(419, 31);
            NRRegComertTextBox.TabIndex = 2;
            // 
            // CUITextBox
            // 
            CUITextBox.Location = new Point(0, 55);
            CUITextBox.Margin = new Padding(4, 4, 4, 4);
            CUITextBox.Name = "CUITextBox";
            CUITextBox.Size = new Size(419, 31);
            CUITextBox.TabIndex = 0;
            // 
            // CUI
            // 
            CUI.AutoSize = true;
            CUI.Font = new Font("Microsoft Himalaya", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CUI.Location = new Point(46, 115);
            CUI.Margin = new Padding(4, 0, 4, 0);
            CUI.Name = "CUI";
            CUI.Size = new Size(63, 40);
            CUI.TabIndex = 2;
            CUI.Text = "CUI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Himalaya", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(46, 402);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 40);
            label3.TabIndex = 7;
            label3.Text = "Adresa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Himalaya", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 316);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(228, 40);
            label2.TabIndex = 6;
            label2.Text = "Nr Regsitru Comert";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Himalaya", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 214);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(153, 40);
            label1.TabIndex = 5;
            label1.Text = "Nume Firma";
            // 
            // button1
            // 
            button1.Location = new Point(331, 778);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(118, 36);
            button1.TabIndex = 8;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Himalaya", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(46, 495);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(66, 40);
            label4.TabIndex = 9;
            label4.Text = "Tara";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Himalaya", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(46, 572);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(72, 40);
            label5.TabIndex = 10;
            label5.Text = "Judet";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Himalaya", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(46, 651);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(122, 40);
            label6.TabIndex = 11;
            label6.Text = "Localitate";
            // 
            // AdaugareClient
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 829);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CUI);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "AdaugareClient";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox AdresaTextBox;
        private TextBox NumeFirmaTextBox;
        private TextBox NRRegComertTextBox;
        private TextBox CUITextBox;
        private Label CUI;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox LocalitateTextBox;
        private TextBox JudetTextBox;
        private TextBox TaraTextBox;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}