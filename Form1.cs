using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Lab2
{
    public partial class Form_Cartis : Form
    {
        string connectionString = "Server=127.0.0.1;Database=Cartis;Integrated Security=True";
        DataSet cartis = new DataSet();
        SqlDataAdapter adapterParinte = new SqlDataAdapter();
        SqlDataAdapter adapterCopil = new SqlDataAdapter();
        BindingSource bsParinte = new BindingSource();
        BindingSource bsCopil = new BindingSource();

        int nrCol = Convert.ToInt32(ConfigurationManager.AppSettings["nrCol"]);
        TextBox[] textBoxes = new TextBox[Convert.ToInt32(ConfigurationManager.AppSettings["nrCol"])];
        Label[] labels = new Label[Convert.ToInt32(ConfigurationManager.AppSettings["nrCol"])];
        public Form_Cartis()
        {
            InitializeComponent();
        }

        private void Form_Cartis_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    adapterParinte.SelectCommand = new SqlCommand(ConfigurationManager.AppSettings["selectParinte"], con);
                    adapterCopil.SelectCommand = new SqlCommand(ConfigurationManager.AppSettings["selectCopil"], con);
                    adapterParinte.Fill(cartis, ConfigurationManager.AppSettings["tabelParinte"]);
                    adapterCopil.Fill(cartis, ConfigurationManager.AppSettings["tabelCopil"]);
                    bsParinte.DataSource = cartis.Tables[ConfigurationManager.AppSettings["tabelParinte"]];
                    dataGridViewParinte.DataSource = bsParinte;
                    DataColumn pk = cartis.Tables[ConfigurationManager.AppSettings["tabelParinte"]].Columns[ConfigurationManager.AppSettings["numeColPK"]];
                    DataColumn fk = cartis.Tables[ConfigurationManager.AppSettings["tabelCopil"]].Columns[ConfigurationManager.AppSettings["numeColFK"]];
                    DataRelation rel = new DataRelation("fkParinteCopil", pk, fk);
                    cartis.Relations.Add(rel);
                    bsCopil.DataSource = bsParinte;
                    bsCopil.DataMember = "fkParinteCopil";
                    dataGridViewCopil.DataSource = bsCopil;

                    string[] numeCol = ConfigurationManager.AppSettings["numeCol"].Split(';');
                    int yTextBox = 10;
                    int yLabel = 14;
                    for(int i=0; i<nrCol; i++)
                    {
                        labels[i] = new Label();
                        labels[i].Text = numeCol[i];
                        labels[i].Location = new Point(550, yLabel);
                        textBoxes[i] = new TextBox();
                        textBoxes[i].Location = new Point(650, yTextBox);
                        this.Controls.Add(textBoxes[i]);
                        this.Controls.Add(labels[i]);
                        yTextBox += 40;
                        yLabel += 40;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butonSterge_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    int id = Convert.ToInt32(dataGridViewCopil.SelectedRows[0].Cells[0].Value);
                    SqlCommand sterge = new SqlCommand(ConfigurationManager.AppSettings["stergeCopil"], con);
                    sterge.Parameters.AddWithValue("@id", id);
                    sterge.ExecuteNonQuery();
                    adapterCopil.SelectCommand.Connection = con;
                    cartis.Tables[ConfigurationManager.AppSettings["tabelCopil"]].Clear();
                    adapterCopil.Fill(cartis, ConfigurationManager.AppSettings["tabelCopil"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butonAdauga_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    int id_parinte = Convert.ToInt32(dataGridViewParinte.SelectedRows[0].Cells[0].Value);
                    SqlCommand adauga = new SqlCommand(ConfigurationManager.AppSettings["adaugaCopil"] + "SELECT SCOPE_IDENTITY();", con);
                    adauga.Parameters.AddWithValue("@id", id_parinte);
                    int id_copil = Convert.ToInt32(adauga.ExecuteScalar());
                    string[] coloane = ConfigurationManager.AppSettings["coloane"].Split(';');
                    for (int i = 0; i < nrCol; i++)
                        if (textBoxes[i].TextLength != 0)
                        {
                            SqlCommand update = new SqlCommand(ConfigurationManager.AppSettings["updateCol"] + coloane[i] + "=@val WHERE " + ConfigurationManager.AppSettings["pk"] + "=@id;", con);
                            update.Parameters.AddWithValue("@id", id_copil);
                            update.Parameters.AddWithValue("@val", textBoxes[i].Text);
                            update.ExecuteNonQuery();
                            textBoxes[i].Text = String.Empty;
                        }
                    adapterCopil.SelectCommand.Connection = con;
                    cartis.Tables[ConfigurationManager.AppSettings["tabelCopil"]].Clear();
                    adapterCopil.Fill(cartis, ConfigurationManager.AppSettings["tabelCopil"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    int id_copil = Convert.ToInt32(dataGridViewCopil.SelectedRows[0].Cells[0].Value);
                    string[] coloane = ConfigurationManager.AppSettings["coloane"].Split(';');
                    for (int i = 0; i < nrCol; i++)
                        if (textBoxes[i].TextLength != 0)
                        {
                            SqlCommand update = new SqlCommand(ConfigurationManager.AppSettings["updateCol"] + coloane[i] + "=@val WHERE " + ConfigurationManager.AppSettings["pk"] + "=@id;", con);
                            update.Parameters.AddWithValue("@id", id_copil);
                            update.Parameters.AddWithValue("@val", textBoxes[i].Text);
                            update.ExecuteNonQuery();
                            textBoxes[i].Text = String.Empty;
                        }
                    adapterCopil.SelectCommand.Connection = con;
                    cartis.Tables[ConfigurationManager.AppSettings["tabelCopil"]].Clear();
                    adapterCopil.Fill(cartis, ConfigurationManager.AppSettings["tabelCopil"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
