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

namespace CadernoDeReceitas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConexaoDB conecta = new ConexaoDB();
            try
            {
                MySqlConnection dbConnection = conecta.connectDB();
                MessageBox.Show("Conectado ao Banco de Dados");
                dbConnection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("conexão falhou");
            }
        }
    }
}
