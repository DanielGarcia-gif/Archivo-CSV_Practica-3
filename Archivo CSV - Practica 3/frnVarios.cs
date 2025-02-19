using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivo_CSV___Practica_3
{
    public partial class frnVarios : Form
    {
        public frnVarios()
        {
            InitializeComponent();
        }

        string[] estadosMexico = {
            "AS", // Aguascalientes
            "BC", // Baja California
            "BS", // Baja California Sur
            "CC", // Campeche
            "CS", // Chiapas
            "CH", // Chihuahua
            "CL", // Coahuila
            "CM", // Colima
            "DF", // Ciudad de México (antes Distrito Federal)
            "DG", // Durango
            "GT", // Guanajuato
            "GR", // Guerrero
            "HG", // Hidalgo
            "JC", // Jalisco
            "MC", // México (Estado de México)
            "MN", // Michoacán
            "MS", // Morelos
            "NT", // Nayarit
            "NL", // Nuevo León
            "OC", // Oaxaca
            "PL", // Puebla
            "QT", // Querétaro
            "QR", // Quintana Roo
            "SP", // San Luis Potosí
            "SL", // Sinaloa
            "SR", // Sonora
            "TC", // Tabasco
            "TS", // Tamaulipas
            "TL", // Tlaxcala
            "VZ", // Veracruz
            "YN", // Yucatán
            "ZS", // Zacatecas
            "NE"  // Nacido en el extranjero
          };

        string[] nombresEstados = {
            "Aguascalientes",
            "Baja California",
            "Baja California Sur",
            "Campeche",
            "Chiapas",
            "Chihuahua",
            "Coahuila",
            "Colima",
            "Ciudad de México",
            "Durango",
            "Guanajuato",
            "Guerrero",
            "Hidalgo",
            "Jalisco",
            "México", // Estado de México
            "Michoacán",
            "Morelos",
            "Nayarit",
            "Nuevo León",
            "Oaxaca",
            "Puebla",
            "Querétaro",
            "Quintana Roo",
            "San Luis Potosí",
            "Sinaloa",
            "Sonora",
            "Tabasco",
            "Tamaulipas",
            "Tlaxcala",
            "Veracruz",
            "Yucatán",
            "Zacatecas",
            "Nacido en el extranjero"
        };



        private void btnCalcular_Click(object sender, EventArgs e)
        {
            DateTime nacimiento = dtpNacimiento.Value;
            DateTime calculo = dtpCalculo.Value;

            int edad = calculo.Year - nacimiento.Year;
            int meses = calculo.Month - nacimiento.Month;
            int dias = calculo.Day - nacimiento.Day;

            if (dias < 0)
            {
                meses--;
                DateTime mesAnterior = calculo.AddMonths(-1);
                dias = dias + DateTime.DaysInMonth(mesAnterior.Year, mesAnterior.Month);
            }

            if (meses < 0)
            {
                edad--;
                meses = meses + 12;
            }

            MessageBox.Show("Años: " + edad + "\nMeses: " + meses + "\nDias: " + dias,
                            "Resultado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void dtpNacimiento_ValueChanged(object sender, EventArgs e)
        {
            dtpCalculo.Enabled = true;
            btnCalcular.Enabled = true;
            dtpCalculo.MinDate = dtpNacimiento.Value;
        }

        private void butCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int añoN = int.Parse(txtCURP.Text.Substring(4, 2));
                int mesN = int.Parse(txtCURP.Text.Substring(6, 2));
                int diaN = int.Parse(txtCURP.Text.Substring(8, 2));

                string sexo;
                string estado = "";


                //Estado de Nacimiento
                int cont = 0;
                while (txtCURP.Text.Substring(11, 2).CompareTo(estadosMexico[cont]) != 0)
                    cont++;
                estado = nombresEstados[cont];


                //Sexo
                if (txtCURP.Text.Substring(10, 1).CompareTo("H") == 0)
                    sexo = "Hombre";
                else if (txtCURP.Text.Substring(10, 1).CompareTo("M") == 0)
                    sexo = "Mujer";
                else
                    sexo = "";


                //Edad
                if (añoN >= 0 && añoN <= 24)
                    añoN += 2000;
                else
                    añoN += 1900;

                DateTime fecha = new DateTime(añoN, mesN, diaN);
                DateTime fechaActual = DateTime.Today;

                int edad = fechaActual.Year - fecha.Year;

                if (fechaActual < fecha.AddYears(edad))
                    edad--;


                //Sexo valido
                if(sexo.CompareTo("") == 0)
                {
                    MessageBox.Show("Error en los datos \nFavor de verificar sus datos",
                               "ERROR",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Estado de Nacimiento: " + estado + "\nSexo: " + sexo + "\nEdad: " + edad + " años",
                                    "Resultado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
            }
            catch(IndexOutOfRangeException ex)
            {
                MessageBox.Show("Error en los datos \nFavor de verificar sus datos",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Error en los datos \nFavor de verificar sus datos",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }
    }
}
