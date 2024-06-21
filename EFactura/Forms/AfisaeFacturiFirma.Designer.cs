namespace EFactura.Forms
{
    partial class AfisaeFacturiFirma
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
            PDFBtn = new Button();
            GenXMLBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 82);
            dataGridView1.Margin = new Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1676, 235);
            dataGridView1.TabIndex = 0;
            // 
            // PDFBtn
            // 
            PDFBtn.Location = new Point(5, 369);
            PDFBtn.Margin = new Padding(4, 4, 4, 4);
            PDFBtn.Name = "PDFBtn";
            PDFBtn.Size = new Size(176, 36);
            PDFBtn.TabIndex = 1;
            PDFBtn.Text = "Genereaza PDF";
            PDFBtn.UseVisualStyleBackColor = true;
            PDFBtn.Click += PDFBtn_Click;
            // 
            // GenXMLBtn
            // 
            GenXMLBtn.Location = new Point(235, 369);
            GenXMLBtn.Margin = new Padding(4, 4, 4, 4);
            GenXMLBtn.Name = "GenXMLBtn";
            GenXMLBtn.Size = new Size(169, 36);
            GenXMLBtn.TabIndex = 2;
            GenXMLBtn.Text = "Genereaza XML";
            GenXMLBtn.UseVisualStyleBackColor = true;
            GenXMLBtn.Click += GenXMLBtn_Click;
            // 
            // AfisaeFacturiFirma
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1696, 562);
            Controls.Add(GenXMLBtn);
            Controls.Add(PDFBtn);
            Controls.Add(dataGridView1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "AfisaeFacturiFirma";
            Text = "AfisaeFacturiFirma";
            Load += AfisaeFacturiFirma_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button PDFBtn;
        private Button GenXMLBtn;
    }
}