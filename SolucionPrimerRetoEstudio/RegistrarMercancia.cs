using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolucionPrimerRetoEstudio
{
    public partial class RegistrarMercancia : Form
    {
        //Creamos unas variables extras para ser utilizadas en caso de emergencia (dígase que uno de los métodos falle) utílizamos estas variables.
        Negocios objetoNegocios = new Negocios();
        private string IdMercancia = null;
        private bool Editar = false;
     
        public RegistrarMercancia()
        {
            InitializeComponent();
        }
       
        //Método para que nuestro formulario detenga la ejecución del programa al cerrarlo.
        private void RegistrarMercancia_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Método para limpiar las casillas automáticamente después de la insersión.
        public void LimpiarCasillas()
        {
            txtDescripcion.ResetText();
            txtExistencia.ResetText();
            txtComentario.ResetText();
            comboStatus.ResetText();
            comboEliminable.ResetText();
            comboEliminable.ResetText();
        }


        private void RegistrarMercancia_Load(object sender, EventArgs e)
        {

        }

        //Nuestro método para insertar la mercancía.
        private void button1_Click(object sender, EventArgs e)
        {

                try
                {
                    objetoNegocios.InsertarMercancia(txtDescripcion.Text, txtExistencia.Text, txtComentario.Text, comboStatus.Text, comboEliminable.Text);
                    MessageBox.Show("Mercancía registrada correctamente");

                Presentacion verPresentacion = new Presentacion();
                this.Hide();
                verPresentacion.Show();
            }
            catch (Exception ex)
                {
                Datos.OpenDB();
                    MessageBox.Show("No se pudo registrar la mercancía, error: "+ex);
                Presentacion verPresentacion = new Presentacion();
                this.Hide();
                verPresentacion.Show();
                }



        }


    }
}
