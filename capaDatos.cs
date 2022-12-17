using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace proyectoFinal
{

    public class capaDatos : registroVisita
    {
        SqlConnection SqlConnection_conn = new SqlConnection("server=STWARD_PC\\SQLEXPRESS; database=proyectoFinal; integrated security=true");

        public void Login(string user, string pass)
        {
            SqlConnection_conn.Open();
            SqlCommand cmdLogin = new SqlCommand("SELECT Nombre, rol from Login WHERE Usuario = @user AND Contraseña =@pass", SqlConnection_conn);
            cmdLogin.Parameters.AddWithValue("user", user);
            cmdLogin.Parameters.AddWithValue("pass", pass);
            SqlDataAdapter sda = new SqlDataAdapter(cmdLogin);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                this.Hide();
                if (dt.Rows[0][1].ToString() == "Administrador")
                {
                    new registroVisita().Show();

                } else if (dt.Rows[0][1].ToString() == "General")
                {
                    new registroVisita().Show();
                }

            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos");
            }
            SqlConnection_conn.Close();
        }
        public void AgregarVisita()
        {
            try {

                SqlConnection_conn.Open();
                SqlCommand cmdRegistrar = new SqlCommand();
                cmdRegistrar.Connection = SqlConnection_conn;

                cmdRegistrar.CommandText = $"EXEC registrarVisita1 @nombre={textBox1.Text}," +
                $"@apellido={textBox2.Text}, @carrera={textBox3.Text}," +
                $"@correo='{maskedTextBox1.Text}', @Edificio='{edificio.SelectedItem.ToString()}'," +
                $"@horaEntrada='{fechaEntrada.Text}', @horaSalida='{fechaSalida.Text}', @Aula={comboBox2.Text}";


                cmdRegistrar.ExecuteNonQuery();
                MessageBox.Show("Datos ingresados con exito");
                SqlConnection_conn.Close(); 
                 }   catch(Exception e){
                Console.WriteLine(e.Message+"--------------");
            }
            

        }
        
    }
}
