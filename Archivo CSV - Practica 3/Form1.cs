namespace Archivo_CSV___Practica_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butAbrir_Click(object sender, EventArgs e)
        {
            //Codigo de Prueba 

            //DialogResult res = openFileDialogAbrir.ShowDialog();

            //if (res == DialogResult.OK)
            //{
            //    string[] text = File.ReadAllLines(openFileDialogAbrir.FileName);
            //    string text2 = File.ReadAllText(openFileDialogAbrir.FileName);

            //    string[] col = text[0].Split(',');
            //    string[] ren = text2.Split('\n');

            //    dataGridViewAbrir.ColumnCount = col.Length;
            //    dataGridViewAbrir.RowCount = ren.Length;

            //    for (int i = 0; i < ren.Length-1; i++)
            //    {
            //        string[] linea = text[i].Split(',');

            //        for (int j = 0; j < col.Length; j++)
            //        {
            //            string dato = linea[j];
            //            dataGridViewAbrir.Rows[i].Cells[j].Value = dato;
            //        }
            //    }

            //}



            //Codigo final
            try
            {

                DialogResult res = openFileDialogAbrir.ShowDialog();

                if (res == DialogResult.OK)
                {
                    string text = File.ReadAllText(openFileDialogAbrir.FileName);
                    string[] ren = text.Split('\n');
                    string[] col = ren[0].Split(',');

                    dataGridViewAbrir.RowCount = ren.Length;
                    dataGridViewAbrir.ColumnCount = col.Length;

                    for (int i = 0; i < ren.Length - 1; i++)
                    {
                        string[] linea = ren[i].Split(',');

                        for (int j = 0; j < col.Length; j++)
                        {
                            string dato = linea[j];
                            dataGridViewAbrir.Rows[i].Cells[j].Value = dato;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el archivo" + ex);
            }
        }

        private void fechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frnVarios varios = new frnVarios();
            varios.Show();
        }
    }
}
