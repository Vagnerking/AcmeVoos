using System;
using System.Data;
using System.Windows.Forms;
using AcmeVoos.Dados;
using AcmeVoos.Entidades;

namespace AcmeVoos
{
    public partial class Form1 : Form
    {

        private int vooSelecionado = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChecarBanco();
            SetupListView();
            CarregarItems();
            LimparCampos();
        }


        private bool CamposNulos()
        {
            if (mskData.Text.Replace(" ", "").Replace("_", "").Replace("/", "").Replace(":", "").Length == 12)
                if (txtCusto.Text.Length > 0)
                    if (txtDistancia.Text.Length > 0)
                        if (rdNao.Checked || rdSim.Checked)
                            if (numNivelDor.Value > -1 && numNivelDor.Value < 11)
                                return false;

            return true;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (CamposNulos())
                MessageBox.Show($"Verifique se os campos foram digitados corretamente.", "Ocorreu um erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (vooSelecionado != -1) // Atualizar Vôo
                {

                    var data = Convert.ToDateTime(mskData.Text);
                    var custo = Convert.ToDouble(txtCusto.Text);
                    var distancia = Convert.ToInt32(txtDistancia.Text);
                    char captura = 'N';

                    if (!rdNao.Checked)
                        captura = 'S';

                    var nivelDor = Convert.ToInt32(numNivelDor.Value);

                    Voos voo = new Voos()
                    {
                        ID_VOO = vooSelecionado,
                        DATA_VOO = data,
                        CUSTO = custo,
                        DISTANCIA = distancia,
                        CAPTURA = captura,
                        NIVEL_DOR = nivelDor
                    };

                    BancoDeDados.AtualizarVoo(voo);

                    LimparCampos();
                    LimparLista();
                    CarregarItems();
                    DesabilitarCampos();

                }
                else //Criar
                {
                    try
                    {
                        var data = Convert.ToDateTime(mskData.Text);
                        var custo = Convert.ToDouble(txtCusto.Text);
                        var distancia = Convert.ToInt32(txtDistancia.Text);
                        char captura = 'N';

                        if (!rdNao.Checked)
                            captura = 'S';

                        var nivelDor = Convert.ToInt32(numNivelDor.Value);

                        Voos voo = new Voos()
                        {
                            DATA_VOO = data,
                            CUSTO = custo,
                            DISTANCIA = distancia,
                            CAPTURA = captura,
                            NIVEL_DOR = nivelDor
                        };

                        BancoDeDados.AddVoos(voo);

                        LimparCampos();
                        LimparLista();
                        CarregarItems();
                        DesabilitarCampos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Verifique se os campos foram digitados e marcados corretamente. \n\nErro: {ex}", "Ocorreu um erro.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            vooSelecionado = -1;
            HabilitarCampos();
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            vooSelecionado = -1;
            DesabilitarCampos();
            LimparLista();
            LimparCampos();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            vooSelecionado = -1;
            DesabilitarCampos();
            LimparLista();
            CarregarItems();
            MessageBox.Show($"Lista carregada com sucesso!\nQtd Items: {listView.Items.Count}", "Sucesso");
        }

        private void CarregarItems()
        {

            //Ir ao banco e puxar todos os Vôos
            var todosVoos = BancoDeDados.TodosVoos();

            //Preencher a listview
            foreach (DataRow row in todosVoos.Rows)
            {
                ListViewItem novoItem = new ListViewItem(row[0].ToString()); // Id
                novoItem.SubItems.Add(row[1].ToString()); // Data
                var captura = (char)Convert.ToInt32(row[4].ToString()); //Convertendo de char numerico pra char alfabetico
                novoItem.SubItems.Add(captura.ToString()); // Captura
                novoItem.SubItems.Add(row[5].ToString()); // Nível De Dor
                listView.Items.Add(novoItem);
            }

        }

        private void LimparLista()
        {
            listView.Items.Clear();
        }

        private void SetupListView()
        {
            //Exibe Detalhes
            listView.View = View.Details;
            //Permite selecionar a linha toda
            listView.FullRowSelect = true;
            //Exibe as linhas na listview
            listView.GridLines = true;


            //Adiciona as colunas a list view
            listView.Columns.Add("Id", 30, HorizontalAlignment.Left);
            listView.Columns.Add("Data", 138, HorizontalAlignment.Left);
            listView.Columns.Add("Captura", 50, HorizontalAlignment.Left);
            listView.Columns.Add("Nível De Dor", 100, HorizontalAlignment.Left);
        }

        private void ChecarBanco()
        {
            //Essa função cria o banco se não existir.
            BancoDeDados.CriarBanco();

            //Criar a tabela se não existir também
            BancoDeDados.CriarTabela();
        }

        private void LimparCampos()
        {
            mskData.Clear();
            txtCusto.Clear();
            txtDistancia.Clear();
            rdNao.Checked = false;
            rdSim.Checked = false;
            numNivelDor.Value = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            vooSelecionado = -1;
            DesabilitarCampos();
        }


        private void HabilitarCampos()
        {
            LimparCampos();
            groupEditIncluir.Enabled = true;
        }

        private void DesabilitarCampos()
        {
            LimparCampos();
            vooSelecionado = -1;
            groupEditIncluir.Enabled = false;
        }

        private void txtCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Apenas dígitos no campo de Custo.", "Atenção!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void txtDistancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Apenas dígitos no campo de Distância.", "Atenção!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void numNivelDor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Apenas dígitos no campo de Nível De Dor.", "Atenção!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mskData_Enter(object sender, EventArgs e)
        {

        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.Items.Count > 0)
            {
                //Procurar pelo id do voo.
                if (listView.SelectedIndices.Count > 0)
                {
                    HabilitarCampos();
                    int selectionindex = listView.SelectedIndices[0];
                    ListViewItem seletedItem = listView.Items[selectionindex];

                    var idVoo = Convert.ToInt32(seletedItem.SubItems[0].Text);

                    var voo = BancoDeDados.BuscarPeloId(idVoo);

                    mskData.Text = voo.DATA_VOO.ToString("dd/MM/yyyy HH:mm");
                    txtCusto.Text = voo.CUSTO.ToString();
                    txtDistancia.Text = voo.DISTANCIA.ToString();

                    if (voo.CAPTURA == 'N')
                        rdNao.Checked = true;
                    else
                        rdSim.Checked = true;

                    numNivelDor.Value = voo.NIVEL_DOR;

                    vooSelecionado = voo.ID_VOO;
                }
                else
                {
                    vooSelecionado = -1;
                    LimparCampos();
                    DesabilitarCampos();
                }

            }
            else
            {
                DesabilitarCampos();
            }
        }

        private void btnExluir_Click(object sender, EventArgs e)
        {
            if (vooSelecionado != -1)
            {
                BancoDeDados.DeletarVoo(vooSelecionado);
                DesabilitarCampos();
                LimparLista();
                CarregarItems();
            }
            else
                MessageBox.Show("Você não selecionou nenhum registro para poder fazer a exclusão.", "Desculpe...", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
