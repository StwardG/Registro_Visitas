using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoFinal
{
    public partial class agregarUsuario : Form
    {
        SqlConnection SqlConnection_conn = new SqlConnection("server=STWARD_PC\\SQLEXPRESS; database=proyectoFinal; integrated security=true");

        public agregarUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection_conn.Open();
            SqlCommand cmdCrear = new SqlCommand();
            cmdCrear.Connection = SqlConnection_conn;

            cmdCrear.CommandText = $"EXEC crear_Usuario @Nombre= {textBox1.Text}, @Apellido={textBox2.Text}, " +
            $"@feNacimiento='{dateTimePicker1.Text}', @rol='{comboBox1.SelectedItem.ToString()}'," +
            $" @usuario={textBox3.Text}";
            
            cmdCrear.ExecuteNonQuery();
            MessageBox.Show("Usuario creado con éxito");
            SqlConnection_conn.Close();
        }  
    }
}
