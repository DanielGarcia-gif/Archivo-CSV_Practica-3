namespace Archivo_CSV___Practica_3
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
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridViewAbrir = new DataGridView();
            butAbrir = new Button();
            openFileDialogAbrir = new OpenFileDialog();
            menuStrip1 = new MenuStrip();
            variosToolStripMenuItem = new ToolStripMenuItem();
            fechasToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAbrir).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(butAbrir, 0, 1);
            tableLayoutPanel1.Controls.Add(dataGridViewAbrir, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 32);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90.14085F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.859155F));
            tableLayoutPanel1.Size = new Size(776, 406);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridViewAbrir
            // 
            dataGridViewAbrir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAbrir.Location = new Point(3, 3);
            dataGridViewAbrir.Name = "dataGridViewAbrir";
            dataGridViewAbrir.Size = new Size(770, 359);
            dataGridViewAbrir.TabIndex = 0;
            // 
            // butAbrir
            // 
            butAbrir.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            butAbrir.Location = new Point(3, 374);
            butAbrir.Name = "butAbrir";
            butAbrir.Size = new Size(770, 23);
            butAbrir.TabIndex = 1;
            butAbrir.Text = "Abrir";
            butAbrir.UseVisualStyleBackColor = true;
            butAbrir.Click += butAbrir_Click;
            // 
            // openFileDialogAbrir
            // 
            openFileDialogAbrir.Filter = "Archivo CSV | *.csv";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { variosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // variosToolStripMenuItem
            // 
            variosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fechasToolStripMenuItem });
            variosToolStripMenuItem.Name = "variosToolStripMenuItem";
            variosToolStripMenuItem.Size = new Size(50, 20);
            variosToolStripMenuItem.Text = "Varios";
            // 
            // fechasToolStripMenuItem
            // 
            fechasToolStripMenuItem.Name = "fechasToolStripMenuItem";
            fechasToolStripMenuItem.Size = new Size(180, 22);
            fechasToolStripMenuItem.Text = "Fechas";
            fechasToolStripMenuItem.Click += fechasToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Archivo CSV";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAbrir).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridViewAbrir;
        private Button butAbrir;
        private OpenFileDialog openFileDialogAbrir;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem variosToolStripMenuItem;
        private ToolStripMenuItem fechasToolStripMenuItem;
    }
}
