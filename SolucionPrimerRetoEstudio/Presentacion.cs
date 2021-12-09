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
    public partial class Presentacion : Form
    {
        public Presentacion()
        {
            InitializeComponent();
        }

 

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarMercancia mercancia = new RegistrarMercancia();
            this.Hide();
            mercancia.Show();
        }

        private void btnCRUD_Click(object sender, EventArgs e)
        {
            AdministrarMercancias CRUD = new AdministrarMercancias();
            this.Hide();
            CRUD.Show();
        }
    }
}
