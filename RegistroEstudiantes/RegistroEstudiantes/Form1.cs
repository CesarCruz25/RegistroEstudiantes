using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroEstudiantes
{
    public partial class RegistroEstudiante : Form
    {
        public RegistroEstudiante()
        {
            InitializeComponent();
        }

        string[] Nombre = new string[1];
        int[] Edad = new int[1];
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            
            //int contador = -1;

            for (int i = 0; i < Nombre.Length; i++) 
            {
                Nombre[i] = NombreTextBox.Text;

            }

            for (int i = 0; i < Edad.Length; i++) 
            {
                Edad[i] = Convert.ToInt32(EdadTextBox.Text);

            }

            NombreTextBox.Text = "";
            EdadTextBox.Text = "";
            //DatosComboBox.Items.Add(Nombre); DatosComboBox.Items.Add(Edad);
        }

        private void LeerButton_Click(object sender, EventArgs e)
        {
            foreach (string item in Nombre)
            {
                DatosComboBox.Items.Add(item);

            }

            foreach (int item in Edad)
            {
                DatosComboBox.Items.Add(item);
            }
        }
    }
}
