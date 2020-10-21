using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge
{
    public class Apresentacao
    {
        public Apresentacao()
        {
            rotas = new List<string>();
            rotas.Add("/usuarios");
        }

        private List<string> rotas { get; set; }
        public string Mensagem { get { return "ola"; } }
        public List<string> Rotas { get { return this.rotas; } }
    }
}
