namespace EFactura.Forms
{
    partial class RegisterForm
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
            groupBox1 = new GroupBox();
            InregistrareParola = new TextBox();
            InregistrareNume = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ButtonInreg = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Himalaya", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(218, 36);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(316, 48);
            label1.TabIndex = 0;
            label1.Text = "Inregistrare utilizator";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(InregistrareParola);
            groupBox1.Controls.Add(InregistrareNume);
            groupBox1.Location = new Point(218, 110);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(236, 156);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Introduceti credentialele";
            // 
            // InregistrareParola
            // 
            InregistrareParola.Location = new Point(0, 96);
            InregistrareParola.Margin = new Padding(4, 4, 4, 4);
            InregistrareParola.Name = "InregistrareParola";
            InregistrareParola.PasswordChar = '*';
            InregistrareParola.PlaceholderText = "parola";
            InregistrareParola.Size = new Size(228, 31);
            InregistrareParola.TabIndex = 3;
            // 
            // InregistrareNume
            // 
            InregistrareNume.Location = new Point(0, 32);
            InregistrareNume.Margin = new Padding(4, 4, 4, 4);
            InregistrareNume.Name = "InregistrareNume";
            InregistrareNume.Size = new Size(228, 31);
            InregistrareNume.TabIndex = 2;
            InregistrareNume.Text = "nume";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Himalaya", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(76, 146);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 40);
            label2.TabIndex = 2;
            label2.Text = "Nume:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Himalaya", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(76, 210);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 40);
            label3.TabIndex = 3;
            label3.Text = "Parola:";
            // 
            // ButtonInreg
            // 
            ButtonInreg.Location = new Point(276, 302);
            ButtonInreg.Margin = new Padding(4, 4, 4, 4);
            ButtonInreg.Name = "ButtonInreg";
            ButtonInreg.Size = new Size(118, 36);
            ButtonInreg.TabIndex = 4;
            ButtonInreg.Text = "OK";
            ButtonInreg.UseVisualStyleBackColor = true;
            ButtonInreg.Click += ButtonInreg_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 380);
            Controls.Add(ButtonInreg);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox InregistrareParola;
        private TextBox InregistrareNume;
        private Label label2;
        private Label label3;
        private Button ButtonInreg;
    }
}