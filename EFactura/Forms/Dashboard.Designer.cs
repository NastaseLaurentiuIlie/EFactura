namespace EFactura.Forms
{
    partial class Dashboard
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
            Utilizator = new Label();
            ADDFirmaBtn = new Button();
            DeleteFirmaButton = new Button();
            AddFacturaButton = new Button();
            ShowFacBTN = new Button();
            AddContBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 105);
            dataGridView1.Margin = new Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(940, 249);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Utilizator
            // 
            Utilizator.AccessibleRole = AccessibleRole.None;
            Utilizator.AutoSize = true;
            Utilizator.Location = new Point(400, 48);
            Utilizator.Margin = new Padding(4, 0, 4, 0);
            Utilizator.Name = "Utilizator";
            Utilizator.Size = new Size(59, 25);
            Utilizator.TabIndex = 1;
            Utilizator.Text = "label1";
            // 
            // ADDFirmaBtn
            // 
            ADDFirmaBtn.Location = new Point(15, 386);
            ADDFirmaBtn.Margin = new Padding(4, 4, 4, 4);
            ADDFirmaBtn.Name = "ADDFirmaBtn";
            ADDFirmaBtn.Size = new Size(118, 36);
            ADDFirmaBtn.TabIndex = 2;
            ADDFirmaBtn.Text = "Adauga ";
            ADDFirmaBtn.UseVisualStyleBackColor = true;
            ADDFirmaBtn.Click += ADDFirmaBtn_Click;
            // 
            // DeleteFirmaButton
            // 
            DeleteFirmaButton.Location = new Point(222, 386);
            DeleteFirmaButton.Margin = new Padding(4, 4, 4, 4);
            DeleteFirmaButton.Name = "DeleteFirmaButton";
            DeleteFirmaButton.Size = new Size(118, 36);
            DeleteFirmaButton.TabIndex = 3;
            DeleteFirmaButton.Text = "Sterge";
            DeleteFirmaButton.UseVisualStyleBackColor = true;
            DeleteFirmaButton.Click += DeleteFirmaButton_Click;
            // 
            // AddFacturaButton
            // 
            AddFacturaButton.Location = new Point(400, 386);
            AddFacturaButton.Margin = new Padding(4, 4, 4, 4);
            AddFacturaButton.Name = "AddFacturaButton";
            AddFacturaButton.Size = new Size(184, 36);
            AddFacturaButton.TabIndex = 4;
            AddFacturaButton.Text = "Creeaza Factura";
            AddFacturaButton.UseVisualStyleBackColor = true;
            AddFacturaButton.Click += AddFacturaButton_Click;
            // 
            // ShowFacBTN
            // 
            ShowFacBTN.Location = new Point(652, 386);
            ShowFacBTN.Margin = new Padding(4, 4, 4, 4);
            ShowFacBTN.Name = "ShowFacBTN";
            ShowFacBTN.Size = new Size(218, 36);
            ShowFacBTN.TabIndex = 5;
            ShowFacBTN.Text = "Vizualizeaza Facturi";
            ShowFacBTN.UseVisualStyleBackColor = true;
            ShowFacBTN.Click += ShowFacBTN_Click;
            // 
            // AddContBtn
            // 
            AddContBtn.Location = new Point(15, 465);
            AddContBtn.Margin = new Padding(4, 4, 4, 4);
            AddContBtn.Name = "AddContBtn";
            AddContBtn.Size = new Size(219, 36);
            AddContBtn.TabIndex = 6;
            AddContBtn.Text = "Adauga Cont Bancar";
            AddContBtn.UseVisualStyleBackColor = true;
            AddContBtn.Click += AddContBtn_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(AddContBtn);
            Controls.Add(ShowFacBTN);
            Controls.Add(AddFacturaButton);
            Controls.Add(DeleteFirmaButton);
            Controls.Add(ADDFirmaBtn);
            Controls.Add(Utilizator);
            Controls.Add(dataGridView1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Dashboard";
            Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label Utilizator;
        private Button ADDFirmaBtn;
        private Button DeleteFirmaButton;
        private Button AddFacturaButton;
        private Button ShowFacBTN;
        private Button AddContBtn;
    }
}