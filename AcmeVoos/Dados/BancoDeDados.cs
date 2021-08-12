using AcmeVoos.Entidades;
using System;
using System.Data;
using System.IO;
using System.Data.SQLite;
using System.Windows.Forms;

namespace AcmeVoos.Dados
{
    public class BancoDeDados
    {
        public Voos voos { get; set; }
        private static SQLiteConnection ConecxaoLite;
        public BancoDeDados() { }

        private static SQLiteConnection DbConecxao()
        {
            ConecxaoLite = new SQLiteConnection(@"Data Source=C:\acme_db\acme.sqlite;");
            ConecxaoLite.Open();
            return ConecxaoLite;
        }

        public static void CriarBanco()
        {
            try
            {
                var ConecxaoLite = @"C:\acme_db\acme.sqlite";
                if (!File.Exists(ConecxaoLite))
                    SQLiteConnection.CreateFile(ConecxaoLite);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        public static void CriarTabela()
        {
            try
            {
                using (var comando = DbConecxao().CreateCommand())
                {
                    comando.CommandText = "CREATE TABLE IF NOT EXISTS TB_VOO(ID_VOO integer PRIMARY KEY, DATA_VOO DateTime NOT NULL, CUSTO numeric(10,2) NOT NULL, DISTANCIA integer NOT NULL, CAPTURA Char(1) NOT NULL, NIVEL_DOR integer NOT NULL)";

                    comando.ExecuteNonQuery();

                    comando.Connection.Close();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show($"{ex}");
            }

        }



        public static DataTable TodosVoos()
        {
            SQLiteDataAdapter dap = null;
            DataTable table = new DataTable();
            try
            {
                using (var comando = DbConecxao().CreateCommand())
                {
                    comando.CommandText = "SELECT * FROM TB_VOO";
                    dap = new SQLiteDataAdapter(comando.CommandText, DbConecxao());
                    dap.Fill(table);
                    comando.Connection.Close();
                    return table;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
                return null;
            }
        }

        public static Voos BuscarPeloId(int id)
        {
            try
            {
                SQLiteDataAdapter dap = null;
                DataTable table = new DataTable();

                using (var comando = DbConecxao().CreateCommand())
                {
                    comando.CommandText = " SELECT * FROM TB_VOO WHERE ID_VOO = @id";
                    comando.Parameters.AddWithValue("@id", id);

                    var dr = comando.ExecuteReader();

                    while (dr.Read())
                    {
                        Voos voo = new Voos()
                        {
                            ID_VOO = Convert.ToInt32(dr[0]),
                            DATA_VOO = Convert.ToDateTime(dr[1]),
                            CUSTO = Convert.ToDouble(dr[2]),
                            DISTANCIA = Convert.ToInt32(dr[3]),
                            CAPTURA = (char)Convert.ToInt32(dr[4]),
                            NIVEL_DOR = Convert.ToInt32(dr[5])
                        };
                        dr.Close(); //fechar data reader pra não dar sql block

                        return voo; //retornar o objeto voo
                    }

                }

                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
                return null;

            }
        }

        public static void AddVoos(Voos voos)
        {
            try
            {
                using (var comando = DbConecxao().CreateCommand())
                {
                    comando.CommandText = "INSERT INTO TB_VOO(DATA_VOO, CUSTO, DISTANCIA , CAPTURA , NIVEL_DOR) values (@DATA_VOO, @CUSTO, @DISTANCIA , @CAPTURA , @NIVEL_DOR)";
                    comando.Parameters.AddWithValue("@DATA_VOO", voos.DATA_VOO);
                    comando.Parameters.AddWithValue("@CUSTO", voos.CUSTO);
                    comando.Parameters.AddWithValue("@DISTANCIA", voos.DISTANCIA);
                    comando.Parameters.AddWithValue("@CAPTURA", voos.CAPTURA);
                    comando.Parameters.AddWithValue("@NIVEL_DOR", voos.NIVEL_DOR);

                    int insert = comando.ExecuteNonQuery();

                    if (insert > 0)
                    {
                        MessageBox.Show("Sucesso ao incluir o Vôo, você já pode visualiza-lo na lista.", "Cadastrado com sucesso.", MessageBoxButtons.OK);
                    }

                    comando.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");

            }
        }
        public static void AtualizarVoo(Voos voo)
        {
            try
            {
                using (var comando = new SQLiteCommand(DbConecxao()))
                {
                    comando.CommandText = "UPDATE TB_VOO SET DATA_VOO=@DATA_VOO, CUSTO=@CUSTO, DISTANCIA=@DISTANCIA , CAPTURA=@CAPTURA , NIVEL_DOR=@NIVEL_DOR WHERE ID_VOO=@ID_VOO";

                    comando.Parameters.AddWithValue("@ID_VOO", voo.ID_VOO);
                    comando.Parameters.AddWithValue("@DATA_VOO", voo.DATA_VOO);
                    comando.Parameters.AddWithValue("@CUSTO", voo.CUSTO);
                    comando.Parameters.AddWithValue("@DISTANCIA", voo.DISTANCIA);
                    comando.Parameters.AddWithValue("@CAPTURA", voo.CAPTURA);
                    comando.Parameters.AddWithValue("@NIVEL_DOR", voo.NIVEL_DOR);
                    comando.ExecuteNonQuery();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }
        public static void DeletarVoo(int Id)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConecxao()))
                {
                    cmd.CommandText = "DELETE FROM TB_VOO WHERE ID_VOO=@ID_VOO";
                    cmd.Parameters.AddWithValue("@ID_VOO", Id);
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }
    }
}




