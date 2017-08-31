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

    public partial class nuevaPersona : Form
    {
        //SELECT max(id) as id FROM `usuario`
        private String nombre_usuario,clave_usuario,nombre,apellido;

        
        public nuevaPersona()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.insert();
        }

        public void obtenerTexto()
        {
            this.nombre_usuario = this.textBox1.Text;
            this.clave_usuario = this.textBox2.Text;
            this.nombre= this.textBox3.Text;
            this.apellido = this.textBox4.Text;
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

        public void insert() {
            //validar usuario para que no se repitan
            if (this.validar_nombre_usuario()) {
                
                //insertar usuario
                MySqlConnection conexion =
               new MySqlConnection("server=localhost;database=tienda_arismendy;Uid=root;pwd=;");
                conexion.Open();
                MySqlCommand cmd = conexion.CreateCommand();
                cmd.CommandText = 
                    "insert into  usuario (usuario_nombre,usuario_clave) values( '" +
                    this.nombre_usuario + "','" + this.clave_usuario + "' ) ";
                cmd.ExecuteNonQuery();
                conexion.Close();
                
                //Buscar el ultimo id de usuario generado
                conexion.Open();
                cmd = conexion.CreateCommand();
                cmd.CommandText = "SELECT max(id) as id FROM `usuario` ";
                int IDUsuario = int.Parse(cmd.ExecuteScalar().ToString());
                MessageBox.Show("Usuario id "+IDUsuario);
                conexion.Close();

                //insertar persona relacionada al usuario
                conexion.Open();
                cmd.CommandText =
                    "insert into  persona (nombre,apellido, usuario_id) values( '" +
                    this.nombre + "','" + this.apellido + "', '"+IDUsuario+"' ) ";
                cmd.ExecuteNonQuery();
                conexion.Close();

            }
            else {
                MessageBox.Show("El usuario "+this.nombre_usuario+ " No disponible  ");
            }
        }
    }
}
