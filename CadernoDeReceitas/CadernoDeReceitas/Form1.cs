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
using System.Threading;


namespace CadernoDeReceitas
{
    public partial class Form1 : Form
    {
        Thread newThread;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNovaReceita_Click(object sender, EventArgs e)
        {
            this.Close(); // opcional
            newThread = new Thread(FormCadastrarNova);
            newThread.SetApartmentState(ApartmentState.STA);
            newThread.Start();
        }

        private void FormCadastrarNova()
        {
            Application.Run(new FormCadastraReceita());
        }

        public void updateList()
        {
            ConexaoDB conecta = new ConexaoDB();
            try
            {
                MySqlConnection dbConnection = conecta.connectDB();
                MySqlCommand sqlSyntax = dbConnection.CreateCommand();
                sqlSyntax.CommandText = "SELECT * from cadernoReceitas.receitas;";

                MySqlDataReader reader = sqlSyntax.ExecuteReader();
                dgvListaReceitas.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dgvListaReceitas.Rows[0].Clone();

                    row.Cells[0].Value = reader.GetString(0);
                    row.Cells[1].Value = "Dificuldade: " + reader.GetString(1);
                    row.Cells[2].Value = reader.GetString(4);

                    dgvListaReceitas.Rows.Add(row);

                }
                dbConnection.Close();
                this.dgvListaReceitas.ClearSelection();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("falha ao carregar tabela");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateList();
            this.ActiveControl = label1;
        }

        private void btnExibeReceita_Click(object sender, EventArgs e)
        {
            if (SelectedID.idSelected != null)
            {
                this.Close(); // opcional
                newThread = new Thread(FormExibirReceita);
                newThread.SetApartmentState(ApartmentState.STA);
                newThread.Start();
            } else
            {
                MessageBox.Show("Selecione a receita que deseja exibir");
            }
        }
        

private void FormExibirReceita()
        {
            Application.Run(new FormReceita());
        }

       

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (SelectedID.idSelected != null)
            {
                DialogResult confirmaDelete = MessageBox.Show("Tem certeza que deseja excluir a receita de " + SelectedID.nomeSelected + "? \r\n Esta ação será permanente e irreversível.", "Confirma exclusão!", MessageBoxButtons.YesNo);
                if (confirmaDelete == DialogResult.Yes)
                {
                    ConexaoDB conecta = new ConexaoDB();
                    try
                    {
                        MySqlConnection dbConnection = conecta.connectDB();
                        MySqlCommand sqlSyntax = dbConnection.CreateCommand();
                        sqlSyntax.CommandText = "DELETE FROM `cadernoreceitas`.`receitas` WHERE(`id` = '"+ SelectedID.idSelected +"');";
                        sqlSyntax.ExecuteNonQuery();

                        dbConnection.Close();
                        MessageBox.Show("Receita de "+ SelectedID.nomeSelected+" excluída!");

                        updateList();

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        MessageBox.Show("Erro!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione a receita que deseja excluir");
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtCbOpcoesBusca.SelectedItem != null) { 
                string metodoPesquisa = txtCbOpcoesBusca.SelectedItem.ToString();
                string palavraChave = txtBusca.Text.Trim();
                if (palavraChave != "")
                {
                    ConexaoDB conecta = new ConexaoDB();
                    try
                    {
                        MySqlConnection dbConnection = conecta.connectDB();
                        MySqlCommand sqlSyntax = dbConnection.CreateCommand();
                        sqlSyntax.CommandText = "SELECT * from cadernoReceitas.receitas WHERE "+ metodoPesquisa +" LIKE '%"+ palavraChave+"%';";

                        MySqlDataReader reader = sqlSyntax.ExecuteReader();
                        dgvListaReceitas.Rows.Clear();
                        txtBusca.Text = "";

                        while (reader.Read())
                        {
                            DataGridViewRow row = (DataGridViewRow)dgvListaReceitas.Rows[0].Clone();

                            row.Cells[0].Value = reader.GetString(0);
                            row.Cells[1].Value = "Dificuldade: " + reader.GetString(1);
                            row.Cells[2].Value = reader.GetString(4);

                            dgvListaReceitas.Rows.Add(row);

                        }
                        dbConnection.Close();

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        MessageBox.Show("falha ao carregar tabela");
                    }
                } else
                {
                    MessageBox.Show("Preencha o campo de pesquisa com uma palavra-chave");
                }

            } else
            {
                MessageBox.Show("Selecione o método para pesquisa!");
            }
        }

        private void dgvListaReceitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvListaReceitas.CurrentRow.Selected = true;
            String newId = dgvListaReceitas.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
            SelectedID.idSelected = newId;
            SelectedID.nomeSelected = dgvListaReceitas.Rows[e.RowIndex].Cells["nome"].FormattedValue.ToString();
        }
    }

    class SelectedID
    {
        public static string idSelected { get; set; }
        public static string nomeSelected { get; set; }
    }
}


