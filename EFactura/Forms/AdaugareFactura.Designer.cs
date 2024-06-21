namespace EFactura.Forms
{
    partial class AdaugareFactura
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
            ADDClientBtn = new Button();
            groupBox1 = new GroupBox();
            MetodaPlataTextBox = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            NrTextBox = new TextBox();
            SerieTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label7 = new Label();
            ADDFacturaBtn = new Button();
            SelectClientBTN = new Button();
            SelectCont = new Button();
            label3 = new Label();
            AddServiciu = new Button();
            AfisServiciiBtn = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ADDClientBtn
            // 
            ADDClientBtn.Location = new Point(447, 12);
            ADDClientBtn.Name = "ADDClientBtn";
            ADDClientBtn.Size = new Size(130, 29);
            ADDClientBtn.TabIndex = 0;
            ADDClientBtn.Text = "Adauga Client";
            ADDClientBtn.UseVisualStyleBackColor = true;
            ADDClientBtn.Click += ADDClientBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(MetodaPlataTextBox);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(NrTextBox);
            groupBox1.Controls.Add(SerieTextBox);
            groupBox1.Location = new Point(251, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(387, 304);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // MetodaPlataTextBox
            // 
            MetodaPlataTextBox.Location = new Point(0, 139);
            MetodaPlataTextBox.Name = "MetodaPlataTextBox";
            MetodaPlataTextBox.Size = new Size(387, 27);
            MetodaPlataTextBox.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(0, 97);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(387, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // NrTextBox
            // 
            NrTextBox.Location = new Point(0, 56);
            NrTextBox.Name = "NrTextBox";
            NrTextBox.Size = new Size(387, 27);
            NrTextBox.TabIndex = 1;
            // 
            // SerieTextBox
            // 
            SerieTextBox.Location = new Point(0, 23);
            SerieTextBox.Name = "SerieTextBox";
            SerieTextBox.Size = new Size(387, 27);
            SerieTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Himalaya", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 102);
            label1.Name = "label1";
            label1.Size = new Size(42, 23);
            label1.TabIndex = 2;
            label1.Text = "Serie";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Himalaya", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 136);
            label2.Name = "label2";
            label2.Size = new Size(31, 23);
            label2.TabIndex = 3;
            label2.Text = "NR";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Himalaya", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(42, 176);
            label7.Name = "label7";
            label7.Size = new Size(91, 23);
            label7.TabIndex = 8;
            label7.Text = "Data Emiterii";
            // 
            // ADDFacturaBtn
            // 
            ADDFacturaBtn.Location = new Point(359, 389);
            ADDFacturaBtn.Name = "ADDFacturaBtn";
            ADDFacturaBtn.Size = new Size(94, 29);
            ADDFacturaBtn.TabIndex = 10;
            ADDFacturaBtn.Text = "OK";
            ADDFacturaBtn.UseVisualStyleBackColor = true;
            ADDFacturaBtn.Click += ADDFacturaBtn_Click;
            // 
            // SelectClientBTN
            // 
            SelectClientBTN.Location = new Point(583, 12);
            SelectClientBTN.Name = "SelectClientBTN";
            SelectClientBTN.Size = new Size(171, 29);
            SelectClientBTN.TabIndex = 11;
            SelectClientBTN.Text = "Selecteaza Client";
            SelectClientBTN.UseVisualStyleBackColor = true;
            SelectClientBTN.Click += SelectClientBTN_Click;
            // 
            // SelectCont
            // 
            SelectCont.Location = new Point(42, 12);
            SelectCont.Name = "SelectCont";
            SelectCont.Size = new Size(162, 29);
            SelectCont.TabIndex = 13;
            SelectCont.Text = "Selecteaza Cont";
            SelectCont.UseVisualStyleBackColor = true;
            SelectCont.Click += SelectCont_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Himalaya", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 222);
            label3.Name = "label3";
            label3.Size = new Size(92, 23);
            label3.TabIndex = 14;
            label3.Text = "Metoda Plata";
            // 
            // AddServiciu
            // 
            AddServiciu.Location = new Point(232, 12);
            AddServiciu.Name = "AddServiciu";
            AddServiciu.Size = new Size(162, 29);
            AddServiciu.TabIndex = 15;
            AddServiciu.Text = "Adauga Serviciu";
            AddServiciu.UseVisualStyleBackColor = true;
            AddServiciu.Click += AddServiciu_Click;
            // 
            // AfisServiciiBtn
            // 
            AfisServiciiBtn.Location = new Point(232, 44);
            AfisServiciiBtn.Name = "AfisServiciiBtn";
            AfisServiciiBtn.Size = new Size(162, 29);
            AfisServiciiBtn.TabIndex = 16;
            AfisServiciiBtn.Text = "Selecteaza Serviciu Existent";
            AfisServiciiBtn.UseVisualStyleBackColor = true;
            AfisServiciiBtn.Click += AfisServiciiBtn_Click;
            // 
            // AdaugareFactura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AfisServiciiBtn);
            Controls.Add(AddServiciu);
            Controls.Add(label3);
            Controls.Add(SelectCont);
            Controls.Add(SelectClientBTN);
            Controls.Add(ADDFacturaBtn);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(ADDClientBtn);
            Name = "AdaugareFactura";
            Text = "AdaugareFactura";
            Load += AdaugareFactura_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ADDClientBtn;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox NrTextBox;
        private TextBox SerieTextBox;
        private Label label1;
        private Label label2;
        private Label label7;
        private Button ADDFacturaBtn;
        private Button SelectClientBTN;
        private Button SelectCont;
        private TextBox MetodaPlataTextBox;
        private Label label3;
        private Button AddServiciu;
        private Button AfisServiciiBtn;
    }
}