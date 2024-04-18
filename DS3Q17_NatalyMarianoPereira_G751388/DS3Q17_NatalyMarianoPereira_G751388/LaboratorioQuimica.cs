using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS3Q17_NatalyMarianoPereira_G751388
{
    internal class LaboratorioQuimica : Laboratorio
    {
        public override string Usar(Aluno aluno)
        {
            string acoes = "";
            acoes += aluno.Nome + " vestiu jaleco\r\n";
            acoes += aluno.Nome + " usou tubo de ensaio\r\n";
            acoes += aluno.Nome + " tirou jaleco\r\n";
            return acoes;
        }
    }
}
