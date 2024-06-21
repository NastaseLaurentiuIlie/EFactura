namespace EFactura.Forms
{
    partial class AdaugareServiciu
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
            comboBox1 = new ComboBox();
            UMComboBox = new ComboBox();
            CantitateTextBox = new TextBox();
            PretTextBox = new TextBox();
            DescriereTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            AddServiciu = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(UMComboBox);
            groupBox1.Controls.Add(CantitateTextBox);
            groupBox1.Controls.Add(PretTextBox);
            groupBox1.Controls.Add(DescriereTextBox);
            groupBox1.Location = new Point(221, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(326, 250);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "0", "5", "9", "19" });
            comboBox1.Location = new Point(0, 204);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(320, 28);
            comboBox1.TabIndex = 5;
            // 
            // UMComboBox
            // 
            UMComboBox.FormattingEnabled = true;
            UMComboBox.Items.AddRange(new object[] { "KG", "buc", "L" });
            UMComboBox.Location = new Point(6, 151);
            UMComboBox.Name = "UMComboBox";
            UMComboBox.Size = new Size(320, 28);
            UMComboBox.TabIndex = 4;
            // 
            // CantitateTextBox
            // 
            CantitateTextBox.Location = new Point(6, 118);
            CantitateTextBox.Name = "CantitateTextBox";
            CantitateTextBox.Size = new Size(314, 27);
            CantitateTextBox.TabIndex = 3;
            // 
            // PretTextBox
            // 
            PretTextBox.Location = new Point(6, 75);
            PretTextBox.Name = "PretTextBox";
            PretTextBox.Size = new Size(314, 27);
            PretTextBox.TabIndex = 2;
            // 
            // DescriereTextBox
            // 
            DescriereTextBox.Location = new Point(6, 37);
            DescriereTextBox.Name = "DescriereTextBox";
            DescriereTextBox.Size = new Size(314, 27);
            DescriereTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 117);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 1;
            label1.Text = "Descriere";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 159);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 2;
            label2.Text = "Pret";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 202);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 3;
            label3.Text = "Cantiate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 236);
            label4.Name = "label4";
            label4.Size = new Size(32, 20);
            label4.TabIndex = 4;
            label4.Text = "UM";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 284);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 5;
            label5.Text = "TVA";
            // 
            // AddServiciu
            // 
            AddServiciu.Location = new Point(338, 369);
            AddServiciu.Name = "AddServiciu";
            AddServiciu.Size = new Size(94, 29);
            AddServiciu.TabIndex = 6;
            AddServiciu.Text = "OK";
            AddServiciu.UseVisualStyleBackColor = true;
            AddServiciu.Click += AddServiciu_Click;
            // 
            // AdaugareServiciu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddServiciu);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "AdaugareServiciu";
            Text = "AdaugareServiciu";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox CantitateTextBox;
        private TextBox PretTextBox;
        private TextBox DescriereTextBox;
        private ComboBox comboBox1;
        private ComboBox UMComboBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button AddServiciu;
    }
}