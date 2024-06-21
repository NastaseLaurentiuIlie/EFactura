namespace EFactura.Forms
{
    partial class AdaugareContBancar
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
            BancaTextBox = new TextBox();
            MonedaTextBox = new TextBox();
            IBANTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            AddContBtn = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BancaTextBox);
            groupBox1.Controls.Add(MonedaTextBox);
            groupBox1.Controls.Add(IBANTextBox);
            groupBox1.Location = new Point(115, 92);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(451, 179);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Introduceti detaliile contului";
            groupBox1.UseCompatibleTextRendering = true;
            // 
            // BancaTextBox
            // 
            BancaTextBox.Location = new Point(8, 122);
            BancaTextBox.Margin = new Padding(4, 4, 4, 4);
            BancaTextBox.Name = "BancaTextBox";
            BancaTextBox.Size = new Size(435, 31);
            BancaTextBox.TabIndex = 3;
            BancaTextBox.TextChanged += textBox3_TextChanged;
            // 
            // MonedaTextBox
            // 
            MonedaTextBox.Location = new Point(8, 85);
            MonedaTextBox.Margin = new Padding(4, 4, 4, 4);
            MonedaTextBox.Name = "MonedaTextBox";
            MonedaTextBox.Size = new Size(435, 31);
            MonedaTextBox.TabIndex = 2;
            // 
            // IBANTextBox
            // 
            IBANTextBox.Location = new Point(8, 44);
            IBANTextBox.Margin = new Padding(4, 4, 4, 4);
            IBANTextBox.Name = "IBANTextBox";
            IBANTextBox.Size = new Size(435, 31);
            IBANTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 136);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(52, 25);
            label1.TabIndex = 4;
            label1.Text = "IBAN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 178);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 5;
            label2.Text = "Moneda";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 219);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 6;
            label3.Text = "Banca";
            // 
            // AddContBtn
            // 
            AddContBtn.Location = new Point(275, 329);
            AddContBtn.Margin = new Padding(4, 4, 4, 4);
            AddContBtn.Name = "AddContBtn";
            AddContBtn.Size = new Size(118, 36);
            AddContBtn.TabIndex = 4;
            AddContBtn.Text = "OK";
            AddContBtn.UseVisualStyleBackColor = true;
            AddContBtn.Click += AddContBtn_Click;
            // 
            // AdaugareContBancar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 396);
            Controls.Add(AddContBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "AdaugareContBancar";
            Text = "AdaugareContBancar";
            Load += AdaugareContBancar_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox BancaTextBox;
        private TextBox MonedaTextBox;
        private TextBox IBANTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button AddContBtn;
    }
}