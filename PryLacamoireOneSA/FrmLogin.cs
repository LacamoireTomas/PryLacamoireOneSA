using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryLacamoireOneSA
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (TxtUsuario.Text!=(""))

            {
                TxtContra.Enabled = true;
            }
            else 
                TxtContra.Enabled = false;

        }
        int intentos = 0; // contador de intentos de acceso
        private void CmdIngresar_Click(object sender, EventArgs e)
        {
            if ((TxtUsuario.Text == "Administrador" &&
 TxtContra.Text == "adm135$") ||
 (TxtUsuario.Text == "Operador" &&
 TxtContra.Text == "ope246$"))
            {
                this.Hide(); // oculta este formualrio
                FrmBienvenido f = new FrmBienvenido(); // crea el frmInicio
                f.Text = TxtUsuario.Text; // asigna el texto de título
                f.ShowDialog(); // visualiza y ejecuta el frmInicio
                this.Show(); // visualiza nuevamente este formulario
            }
            else
            {
                MessageBox.Show("Datos incorrectos. Acceso Denegado.");
                intentos++; // incrementa el contador de intentos fallidos
                if (intentos == 3) // si es 3 se cierra el formulario
                {
                    this.Close();
                }
            }





        }

        private void TxtContra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
