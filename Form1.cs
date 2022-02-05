using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_1
{
    public partial class Form1 : Form
    {
        Persona a = new Persona();
        public Form1()
        {
            InitializeComponent();
        }
    private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a.Dpi = textBoxDpi.Text;
            a.Nombre = textBoxNombre.Text;
            a.Apellido = textBoxApellido.Text;
            a.FechaNacimiento = dateTimePicker1.Value;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelDpi.Text = a.Dpi;
            labelNombre.Text = a.Nombre;
            labelApellido.Text = a.Apellido;
            labelFechaNacimiento.Text = a.FechaNacimiento.ToString();
            labelEdad.Text = a.edad().ToString();
        }
        public void normalizaNombre()
        {
            string nombre2 = "";
            a.Nombre = a.Nombre.Trim();
            nombre2 += char.ToUpper(a.Nombre[0]);
            for (int x = 1; x < a.Nombre.Length; x++)
            {
                if (a.Nombre[x - 1] == ' ')
                {
                    if (char.IsLetter(a.Nombre[x]) || char.IsWhiteSpace(a.Nombre[x]))
                        nombre2 += char.ToUpper(a.Nombre[x]);
                }
                else
                 if (char.IsLetter(a.Nombre[x]) || char.IsWhiteSpace(a.Nombre[x]))
                    nombre2 += a.Nombre[x];

            }
        }
    }
}
