namespace DS3Q17_NatalyMarianoPereira_G751388
{
    public partial class Form1 : Form
    {
        private List<Aluno> alunos = new List<Aluno>()
        {
            new Aluno
            {
                Nome = "Nataly Mariano",
                RA = "G751388",
            },
            new Aluno
            {
                Nome = "Fernando Mariano",
                RA = "A12345",
            },
            new Aluno
            {
                Nome = "Bruno Matheus",
                RA = "B67890",
            }
        };

        private Aluno _aluno;

        public Form1()
        {
            InitializeComponent();
        }
        private bool pesquisarPorRA(Aluno aluno)
        {
            string RA = txtRA.Text;
            return aluno.RA == RA;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _aluno = alunos.Find(pesquisarPorRA);
            if (_aluno == null)
            {
                txtMensangem.Text = "RA não encontrado";
                btnLaboratorioInformatica.Enabled = false;
                btnLaboratorioQuimica.Enabled = false;
                btnLaboratorioMecanica.Enabled = false;
            }
            else
            {
                txtMensangem.Text = "Aluno encontradon " + _aluno.Nome;
                btnLaboratorioInformatica.Enabled = true;
                btnLaboratorioQuimica.Enabled = true;
                btnLaboratorioMecanica.Enabled = true;
            }
        }

        private void Form1_Load(object  sender, EventArgs e)
        {

        }

        private void LaboratorioInformatica_Click(object sender, EventArgs e)
        {
            Usar(new LaboratorioInformatica(), _aluno);
        }

        private void LaboratorioQuimica_Click(object sender, EventArgs e)
        {
            Usar(new LaboratorioQuimica(), _aluno);
        }

        private void LaboratorioMecanica_Click(object sender, EventArgs e)
        {
            Usar(new LaboratorioMecanica(), _aluno);
        }

        private void Usar( Laboratorio laboratorio, Aluno aluno)
        {
            txtLaboratorio.Text = laboratorio.Usar(aluno);
        }
    }
}
