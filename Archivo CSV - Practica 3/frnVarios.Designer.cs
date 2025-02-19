namespace Archivo_CSV___Practica_3
{
    partial class frnVarios
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            dtpNacimiento = new DateTimePicker();
            dtpCalculo = new DateTimePicker();
            btnCalcular = new Button();
            label3 = new Label();
            txtCURP = new TextBox();
            butCalcular = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(dtpNacimiento, 0, 1);
            tableLayoutPanel1.Controls.Add(dtpCalculo, 0, 3);
            tableLayoutPanel1.Controls.Add(btnCalcular, 1, 4);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45.6140366F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 54.3859634F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.Size = new Size(527, 172);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 0;
            label1.Text = "Fecha de Nacimiento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 57);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 1;
            label2.Text = "Fecha de Calculo";
            // 
            // dtpNacimiento
            // 
            dtpNacimiento.Location = new Point(3, 29);
            dtpNacimiento.Name = "dtpNacimiento";
            dtpNacimiento.Size = new Size(256, 23);
            dtpNacimiento.TabIndex = 2;
            dtpNacimiento.ValueChanged += dtpNacimiento_ValueChanged;
            // 
            // dtpCalculo
            // 
            dtpCalculo.Enabled = false;
            dtpCalculo.Location = new Point(3, 89);
            dtpCalculo.Name = "dtpCalculo";
            dtpCalculo.Size = new Size(256, 23);
            dtpCalculo.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnCalcular.Enabled = false;
            btnCalcular.Location = new Point(266, 134);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(258, 23);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 202);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 1;
            label3.Text = "CURP";
            // 
            // txtCURP
            // 
            txtCURP.Location = new Point(15, 223);
            txtCURP.Name = "txtCURP";
            txtCURP.Size = new Size(222, 23);
            txtCURP.TabIndex = 2;
            // 
            // butCalcular
            // 
            butCalcular.Location = new Point(255, 227);
            butCalcular.Name = "butCalcular";
            butCalcular.Size = new Size(75, 23);
            butCalcular.TabIndex = 3;
            butCalcular.Text = "Calcular";
            butCalcular.UseVisualStyleBackColor = true;
            butCalcular.Click += butCalcular_Click;
            // 
            // frnVarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 276);
            Controls.Add(butCalcular);
            Controls.Add(txtCURP);
            Controls.Add(label3);
            Controls.Add(tableLayoutPanel1);
            Name = "frnVarios";
            Text = "frnVarios";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpNacimiento;
        private DateTimePicker dtpCalculo;
        private Button btnCalcular;
        private Label label3;
        private TextBox txtCURP;
        private Button butCalcular;
    }
}