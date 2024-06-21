namespace EFactura.Forms
{
    partial class AfisareServicii
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
            AddServiciuBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 201);
            dataGridView1.TabIndex = 0;
            // 
            // AddServiciuBtn
            // 
            AddServiciuBtn.Location = new Point(319, 385);
            AddServiciuBtn.Name = "AddServiciuBtn";
            AddServiciuBtn.Size = new Size(94, 29);
            AddServiciuBtn.TabIndex = 1;
            AddServiciuBtn.Text = "OK";
            AddServiciuBtn.UseVisualStyleBackColor = true;
            AddServiciuBtn.Click += AddServiciuBtn_Click;
            // 
            // AfisareServicii
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddServiciuBtn);
            Controls.Add(dataGridView1);
            Name = "AfisareServicii";
            Text = "AfisareServicii";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button AddServiciuBtn;
    }
}