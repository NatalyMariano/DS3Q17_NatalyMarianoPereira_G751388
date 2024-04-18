using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS3Q17_NatalyMarianoPereira_G751388
{
    internal class LaboratorioInformatica : Laboratorio
    {
        public override string Usar(Aluno aluno)
        {
            string acoes = "";
            acoes += aluno.Nome + " ligou computador\r\n";
            acoes += aluno.Nome + " usou internet\r\n";
            acoes += aluno.Nome + " desligou computador\r\n";
            return acoes;

        }
    }
}
