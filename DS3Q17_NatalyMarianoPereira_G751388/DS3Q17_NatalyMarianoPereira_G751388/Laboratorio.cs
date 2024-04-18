using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS3Q17_NatalyMarianoPereira_G751388
{
    internal abstract class Laboratorio
    {
        public string Sala {  get; set; }
        public abstract string Usar(Aluno aluno);
    }
}
