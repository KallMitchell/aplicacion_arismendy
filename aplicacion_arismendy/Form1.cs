using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace aplicacion_arismendy
{
    public partial class Form1 : Form
    {
        private String rol = "administrador";
        private Boolean cajero = false;
        private Boolean supervisor = false;
        private Boolean administrador = false;
        private List<String> idUsuarios = new List<String>();
        
        public Form1()
        {
            InitializeComponent();
            this.usuario();

            this.validarRolUsuario();
            this.cargarComboBoxUsuario();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("id es : " + this.idUsuarios[this.comboBox1.SelectedIndex].ToString());
        }
        public void cargarComboBoxUsuario() {
            MySqlConnection conexion =
               new MySqlConnection("server=localhost;database=tienda_arismendy;Uid=root;pwd=;");
            conexion.Open();
            MySqlCommand cmd = conexion.CreateCommand();
            cmd.CommandText = "select * from usuario ";
            MySqlDataReader lector = cmd.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                   this.comboBox1.Items.Add( lector["usuario_nombre"].ToString());
                    this.idUsuarios.Add(lector["id"].ToString());
                }
            }
            else
            {
                MessageBox.Show("No hay registros");
            }
        }
        public void usuario(){
            MySqlConnection conexion = 
                new MySqlConnection("server=localhost;database=tienda_arismendy;Uid=root;pwd=;");
            conexion.Open();
            MySqlCommand cmd = conexion.CreateCommand();
            cmd.CommandText = "select * from usuario where id = '1' ";
            MySqlDataReader lector = cmd.ExecuteReader();
            if (lector.HasRows)
            {
                if (lector.Read()) {
                    this.rol = lector["rol"].ToString();
                }
            }
            else {
                MessageBox.Show("No hay registros");
            }
        }

        public void validarRolUsuario() {
            switch (this.rol)
            {
                case "administrador":
                    this.administrador = true;
                    break;
                case "cajero":
                    this.cajero = true;
                    break;
                case "supervisor":
                    this.supervisor = true;
                    break;
            }
        }
        public void msj() {
            MessageBox.Show("No tiene permiso");
        }
        public void correcto() {
            MessageBox.Show("Bien");
        }
        private void menu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.administrador || this.supervisor)
            {
                this.correcto();
            }
            else {
                this.msj();
            }
        }

        private void menu2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.administrador || this.cajero)
            {
                this.correcto();
            }
            else
            {
                this.msj();
            }
        }

        private void menu3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.administrador )
            {
                this.correcto();
            }
            else
            {
                this.msj();
            }
        }
        public void objectos() {
            
        }

    }
}
