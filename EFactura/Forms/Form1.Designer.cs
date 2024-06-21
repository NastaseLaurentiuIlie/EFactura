namespace EFactura
{
    partial class Form1
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
            Reg = new Button();
            Log = new Button();
            SuspendLayout();
            // 
            // Reg
            // 
            Reg.Location = new Point(163, 304);
            Reg.Name = "Reg";
            Reg.Size = new Size(94, 29);
            Reg.TabIndex = 0;
            Reg.Text = "Register";
            Reg.UseVisualStyleBackColor = true;
            Reg.Click += button1_Click;
            // 
            // Log
            // 
            Log.Location = new Point(395, 304);
            Log.Name = "Log";
            Log.Size = new Size(94, 29);
            Log.TabIndex = 1;
            Log.Text = "Login";
            Log.UseVisualStyleBackColor = true;
            Log.Click += Log_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Log);
            Controls.Add(Reg);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Reg;
        private Button Log;
    }
}
