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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proyectoFinal
{
    public partial class consultaEdificios : Form
    {
        SqlConnection SqlConnection_conn = new SqlConnection("server=STWARD_PC\\SQLEXPRESS; database=proyectoFinal; integrated security=true");
        public consultaEdificios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultarVisitas();

        }
        public void ConsultarVisitas()
        {
            SqlConnection_conn.Open();
            string sp = $"EXEC ConsultarVisita @buscar = '{comboBox1.SelectedItem.ToString()}'";
            SqlCommand comando = new SqlCommand(sp, SqlConnection_conn);
            SqlDataReader registros = comando.ExecuteReader();
            
                if(registros.Read())
                {
                    richTextBox1.AppendText(registros["Nombre"].ToString());
                    richTextBox1.AppendText(Environment.NewLine);
                    richTextBox2.AppendText(registros["Correo"].ToString());
                    richTextBox2.AppendText(Environment.NewLine);
                    richTextBox3.AppendText(registros["Aula"].ToString());
                    richTextBox3.AppendText(Environment.NewLine);
                }
                else {
                    MessageBox.Show("No hay registros de visita de ese edificio.");
                }
              

            
            SqlConnection_conn.Close();
        }
    }
}
