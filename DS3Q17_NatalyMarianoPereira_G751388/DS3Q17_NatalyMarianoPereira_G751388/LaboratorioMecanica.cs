namespace DS3Q17_NatalyMarianoPereira_G751388
{
    internal class LaboratorioMecanica : Laboratorio
    {
        public override string Usar(Aluno aluno)
        {
            string acoes = "";
            acoes += aluno.Nome + " vestiu roupa de proteção\r\n";
            acoes += aluno.Nome + " usou equipamento\r\n";
            acoes += aluno.Nome + " tirou roupa de proteçaõ\r\n";
            return acoes;
        }
    }
}
