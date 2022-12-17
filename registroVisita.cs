using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace proyectoFinal
{
    
    public partial class registroVisita : Form
    {
      
 
        public registroVisita()
        {
            InitializeComponent();
           
        }

        private void registroVisita_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            capaDatos registrar = new capaDatos();
            registrar.textBox1 = textBox1;
            registrar.textBox2 = textBox2;
            registrar.textBox3 = textBox3;
            registrar.maskedTextBox1 = maskedTextBox1;
            registrar.edificio = edificio;
            registrar.fechaEntrada = fechaEntrada;
            registrar.fechaSalida = fechaSalida;
            registrar.comboBox2 = comboBox2;
            registrar.AgregarVisita();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form consultaEdificios = new consultaEdificios();
            consultaEdificios.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form agregarUser = new agregarUsuario();
            agregarUser.Show();
        }
    }
}
