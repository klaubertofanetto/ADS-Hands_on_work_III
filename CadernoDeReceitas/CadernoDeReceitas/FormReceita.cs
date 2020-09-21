using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;


namespace CadernoDeReceitas
{
    public partial class FormReceita : Form
    {
        Thread newThread;
        public FormReceita()
        {
            InitializeComponent();
        }

        private void btnVoltaInicio_Click(object sender, EventArgs e)
        {
            voltaJanelaInicial();
        }

        private void FormInicio()
        {
            Application.Run(new Form1());
        }

        private void voltaJanelaInicial()
        {
            this.Close();
            newThread = new Thread(FormInicio);
            newThread.SetApartmentState(ApartmentState.STA);
            newThread.Start();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ConexaoDB conecta = new ConexaoDB();
            try
            {
                MySqlConnection dbConnection = conecta.connectDB();
                MySqlCommand sqlSyntax = dbConnection.CreateCommand();
                sqlSyntax.CommandText = "UPDATE `cadernoreceitas`.`receitas` SET `nome` = '"+ txtNome.Text + "', `ingrediente` = '"+ txtIngredientes.Text.Replace("\r\n", "; ")  +"', `modoPreparo` = '" + txtModoPreparo.Text +"' WHERE id = " + SelectedID.idSelected + ";";
                sqlSyntax.ExecuteNonQuery();

                dbConnection.Close();
                MessageBox.Show("Alterado com sucesso");

                voltaJanelaInicial();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("falha ao carregar tabela");
            }
        }

        private void FormReceita_Load(object sender, EventArgs e)
        {
            mostraReceita();
            this.ActiveControl = label1;
        }

        public void mostraReceita()
        {
            ConexaoDB conecta = new ConexaoDB();
            try
            {
                MySqlConnection dbConnection = conecta.connectDB();
                MySqlCommand sqlSyntax = dbConnection.CreateCommand();
                sqlSyntax.CommandText = "SELECT * FROM cadernoReceitas.receitas WHERE id = "+ SelectedID.idSelected + ";";

                MySqlDataReader reader = sqlSyntax.ExecuteReader();
                reader.Read();
                txtNome.Text = reader.GetString(0);
                txtIngredientes.Text = reader.GetString(2).Replace("; ", "\r\n");
                txtModoPreparo.Text = reader.GetString(3);
                

                dbConnection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("falha ao carregar receita");
            }

        }
    }
}
