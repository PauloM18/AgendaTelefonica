namespace ProjetoFinal
{
    public partial class frmAgendaContato : Form
    {
        private OperacaoEnum acao;
        public frmAgendaContato()
        {
            InitializeComponent();
        }
        private void frmAgendaContato_Load(object sender, EventArgs e)
        {

        }
        private void frmAgendaContato_Shown(object sender, EventArgs e)
        {
            AlterarBotoesSalvarECancelar(false);
            AlterarBotoesIncluirAlterarExcluir(true);
            CarregarListaContatos();
            AlterarEstadosCampos(false);
        }
        private void AlterarBotoesSalvarECancelar(bool estado)
        {
            btnSalvar.Enabled = estado;
            btnCancelar.Enabled = estado;
        }
        private void AlterarBotoesIncluirAlterarExcluir(bool estado)
        {
            btnIncluir.Enabled = estado;
            btnAlterar.Enabled = estado;
            btnExcluir.Enabled = estado;
        }
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            AlterarBotoesSalvarECancelar(true);
            AlterarBotoesIncluirAlterarExcluir(false);
            AlterarEstadosCampos(true);
            acao = OperacaoEnum.INCLUIR;
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlterarBotoesSalvarECancelar(true);
            AlterarBotoesIncluirAlterarExcluir(false);
            AlterarEstadosCampos(true);
            acao = OperacaoEnum.ALTERAR;

        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza?", "Pergunta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int indiceExcluido = lbxContatos.SelectedIndex;
                lbxContatos.SelectedIndex = 0;
                lbxContatos.Items.RemoveAt(indiceExcluido);
                List<Contato> contatosList = new List<Contato>();
                foreach (Contato contato in lbxContatos.Items)
                {
                    contatosList.Add(contato);
                }
                ManipuladorArquivo.EscreverArquivo(contatosList);
                CarregarListaContatos();
                LimparCampos();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            AlterarBotoesSalvarECancelar(false);
            AlterarBotoesIncluirAlterarExcluir(true);
            AlterarEstadosCampos(false);
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato
            {
                Nome = txbNome.Text,
                Email = txbEmail.Text,
                NumeroTelefone = txbTelefone.Text
            };
            List<Contato> contatoList = new List<Contato>();
            foreach (Contato contatoDaLista in lbxContatos.Items)
            {
                contatoList.Add(contatoDaLista);
            }
            contatoList.Add(contato);
            if (acao == OperacaoEnum.INCLUIR)
            {
                contatoList.Add(contato);
            }
            else
            {
                int indice = lbxContatos.SelectedIndex;
                contatoList.RemoveAt(indice);
                contatoList.Insert(indice, contato);
            }
            ManipuladorArquivo.EscreverArquivo(contatoList);
            CarregarListaContatos();
            AlterarBotoesSalvarECancelar(false);
            AlterarBotoesIncluirAlterarExcluir(true);
            LimparCampos();
            AlterarEstadosCampos(false);
        }
        private void CarregarListaContatos()
        {
            lbxContatos.Items.Clear();
            lbxContatos.Items.AddRange(ManipuladorArquivo.LerArquivo().ToArray());
            lbxContatos.SelectedIndex = 0;
        }
        private void LimparCampos()
        {
            txbNome.Text = "";
            txbEmail.Text = "";
            txbTelefone.Text = "";
        }
        private void AlterarEstadosCampos(bool estado)
        {
            txbNome.Enabled = estado;
            txbEmail.Enabled = estado;
            txbTelefone.Enabled = estado;
        }
        private void lbxContatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Contato contato = (Contato)lbxContatos.Items[lbxContatos.SelectedIndex];
            txbNome.Text = contato.Nome;
            txbEmail.Text = contato.Email;
            txbTelefone.Text = contato.NumeroTelefone;
        }
    }
}
