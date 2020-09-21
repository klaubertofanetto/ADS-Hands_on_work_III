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
    public partial class FormCadastraReceita : Form
    {
        Thread newThread;
        public FormCadastraReceita()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            ConexaoDB conecta = new ConexaoDB();
            try
            {
                MySqlConnection dbConnection = conecta.connectDB();
                MySqlCommand sqlSyntax = dbConnection.CreateCommand();
                sqlSyntax.CommandText = "INSERT INTO `cadernoreceitas`.`receitas` " +
                    "(`nome`, `dificuldade`, `ingrediente`, `modoPreparo`) " +
                    "VALUES " +
                    "('"+ txtNome.Text + "', '"+ txtCbDificuldade.SelectedItem.ToString() + "', '"+ txtIngredientes.Text +"', '"+ txtModoPreparo.Text +"');";
                sqlSyntax.ExecuteNonQuery();

                dbConnection.Close();
                MessageBox.Show("Inserido com sucesso");

                voltaJanelaInicial();

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Preencha todos os campos");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("conexão falhou");
            }
        }

        private void txtIngredientes_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtIngredientes.ForeColor != Color.Black)
            {
                txtIngredientes.Clear();
                txtIngredientes.ForeColor = Color.Black;
            }
        }
    }
}
