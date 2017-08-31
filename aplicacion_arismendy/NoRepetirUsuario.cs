using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicacion_arismendy
{
   
    public partial class NoRepetirUsuario : Form
    {
        private String nombre_usuario;
        public NoRepetirUsuario()
        {
            InitializeComponent();
        }

        public void obtenerTexto() {
            this.nombre_usuario = this.textBox1.Text;
        }

        public Boolean validar_nombre_usuario()
        {
            this.obtenerTexto();
            MySqlConnection conexion =
               new MySqlConnection("server=localhost;database=tienda_arismendy;Uid=root;pwd=;");
            conexion.Open();
            MySqlCommand cmd = conexion.CreateCommand();
            cmd.CommandText = "select * from usuario where usuario_nombre = '" + this.nombre_usuario + "' ";
            MySqlDataReader lector = cmd.ExecuteReader();
            if (lector.HasRows)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.validar_nombre_usuario())
            {
                MessageBox.Show("Puedes entrar");
            }
            else {
                MessageBox.Show("No puedes entrar");
            }
        }
    }
}
