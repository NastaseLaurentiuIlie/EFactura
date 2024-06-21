namespace EFactura.Forms
{
    partial class LoginForm
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
            LoginParola = new TextBox();
            LoginNume = new TextBox();
            label2 = new Label();
            label3 = new Label();
            LoginButt = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Himalaya", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(295, 50);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(357, 48);
            label1.TabIndex = 1;
            label1.Text = "Introduceti credentialele";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LoginParola);
            groupBox1.Controls.Add(LoginNume);
            groupBox1.Location = new Point(295, 204);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(374, 156);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Introduceti credentialele";
            // 
            // LoginParola
            // 
            LoginParola.Location = new Point(0, 96);
            LoginParola.Margin = new Padding(4, 4, 4, 4);
            LoginParola.Name = "LoginParola";
            LoginParola.PasswordChar = '*';
            LoginParola.PlaceholderText = "parola";
            LoginParola.Size = new Size(365, 31);
            LoginParola.TabIndex = 3;
            // 
            // LoginNume
            // 
            LoginNume.Location = new Point(0, 32);
            LoginNume.Margin = new Padding(4, 4, 4, 4);
            LoginNume.Name = "LoginNume";
            LoginNume.Size = new Size(365, 31);
            LoginNume.TabIndex = 2;
            LoginNume.Text = "nume";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Himalaya", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(119, 228);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 40);
            label2.TabIndex = 3;
            label2.Text = "Nume:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Himalaya", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(119, 300);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 40);
            label3.TabIndex = 4;
            label3.Text = "Parola:";
            // 
            // LoginButt
            // 
            LoginButt.Location = new Point(414, 421);
            LoginButt.Margin = new Padding(4, 4, 4, 4);
            LoginButt.Name = "LoginButt";
            LoginButt.Size = new Size(118, 36);
            LoginButt.TabIndex = 5;
            LoginButt.Text = "OK";
            LoginButt.UseVisualStyleBackColor = true;
            LoginButt.Click += LoginButt_Click_1;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(LoginButt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "LoginForm";
            Text = "Login";
            Load += LoginForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox LoginParola;
        private TextBox LoginNume;
        private Label label2;
        private Label label3;
        private Button LoginButt;
    }
}