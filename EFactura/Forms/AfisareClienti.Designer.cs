namespace EFactura.Forms
{
    partial class AfisareClienti
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
            dataGridView1 = new DataGridView();
            ReturnBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(800, 220);
            dataGridView1.TabIndex = 0;
            // 
            // ReturnBTN
            // 
            ReturnBTN.Location = new Point(334, 344);
            ReturnBTN.Name = "ReturnBTN";
            ReturnBTN.Size = new Size(94, 29);
            ReturnBTN.TabIndex = 1;
            ReturnBTN.Text = "OK";
            ReturnBTN.UseVisualStyleBackColor = true;
            ReturnBTN.Click += ReturnBTN_Click;
            // 
            // AfisareClienti
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ReturnBTN);
            Controls.Add(dataGridView1);
            Name = "AfisareClienti";
            Text = "AfisareClienti";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button ReturnBTN;
    }
}