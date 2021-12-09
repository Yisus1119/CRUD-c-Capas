using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SolucionPrimerRetoEstudio
{
    public partial class AdministrarMercancias : Form
    {
        Negocios objetoNegocios = new Negocios();
        public AdministrarMercancias()
        {
            InitializeComponent();
        }

        SqlCommand comando = new SqlCommand();

            //Propiedad de nuestro form, para que al dar click al botón de cerrar nos detenga el programa.
        private void AdministrarMercancias_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Método de acceso privado para mostrar nuestras mercancías en el DataGridView1.
        private void AdministrarMercancias_Load(object sender, EventArgs e)
        {
            MostrarMercancias();
        }

        //Creamos un método para limpiar nuestros campos.
        public void LimpiarCasillas()
        {
            txtIdMercancia.ResetText();
            txtDescripcion.ResetText();
            txtExistencia.ResetText();
            txtComentario.ResetText();
            comboStatus.ResetText();
            comboEliminable.ResetText();
            comboEliminable.ResetText();
        }


        private void MostrarMercancias()
        {
            Negocios objeto = new Negocios();
            dataGridView1.DataSource = objeto.MostrarMercancias();
        }

        /* Aquí creamos un método con un bloque de manejo de código, en dicho bloque utilizamos arreglos
            los cuales indican que cuando hagamos click en una mercancía aparezca en nuestros campos.
        NOTA: Para que los datos aparezcan en nuestros campos, debemos dar doble click en las celdas.*/

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIdMercancia.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtDescripcion.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtExistencia.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtComentario.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                comboStatus.SelectedItem = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                comboEliminable.SelectedItem = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            }
            catch { }


        }

        //Método para insertar nuestras mercancías.
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                objetoNegocios.InsertarMercancia(txtDescripcion.Text, txtExistencia.Text, txtComentario.Text, comboStatus.Text, comboEliminable.Text);
                MessageBox.Show("Mercancía insertada correctamente.");
                LimpiarCasillas();
                MostrarMercancias();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar la mercancía, error: " + ex);
                Application.Exit();
            }
        }

        //Método para editar nuestra mercancía.
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                objetoNegocios.ActualizarMercancia(txtIdMercancia.Text, txtDescripcion.Text, txtExistencia.Text, txtComentario.Text, comboStatus.Text, comboEliminable.Text);
                MessageBox.Show("Se ha actualizado la mercancía.");
                LimpiarCasillas();
                MostrarMercancias();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar la mercancía, asegurese que el campo NoEliminable tenga un valor seleccionado");
            }

        }

        //Método para borrar nuestra mercancía.
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                objetoNegocios.BorrarMercancia(txtIdMercancia.Text);
                MessageBox.Show("Se ha borrado la mercancía.");
                LimpiarCasillas();
                MostrarMercancias();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo borrar la mercancía, error: " + ex);
                Application.Exit();
            }

        }

        /* Para este método de busqueda, realicé el store procedure manualmente desde esta capa/clase. */
        private void btnBuscarMercancia_Click(object sender, EventArgs e)
        {
            Datos.OpenDB();
            DataTable dt = new DataTable();
            string ejecutar = "exec BuscarMercancia @Descripcion";
            SqlCommand command = new SqlCommand(ejecutar, Datos.OpenDB());

            command.Parameters.AddWithValue("@Descripcion", txtIdMercancia.Text);

            SqlDataAdapter adapter = new SqlDataAdapter(command);         
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        //Botón para limpiar nuestros campos.
        private void lblLimpiarCampos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LimpiarCasillas();
        }

        //Método para volver a nuestro menú de inicio.
        private void lblVolver_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Presentacion verPresentacion = new Presentacion();
            this.Hide();
            verPresentacion.Show();
        }

        //Método para refrescar el DataGridView1 después de buscar una mercancía en específico.
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            MostrarMercancias();
        }
    }
}
