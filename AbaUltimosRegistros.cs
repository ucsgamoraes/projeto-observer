using projeto_observer.Interfaces;
using projeto_observer.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_observer
{
    public class AbaUltimosRegistros : IObservador
    {
        
        List<DadosMeterologicos> dadosMeterologicos { get; set; }
        public AbaUltimosRegistros()
        {
            dadosMeterologicos = new List<DadosMeterologicos>(10);
        }

        public void Atualizar(DadosMeterologicos dados)
        {
            if (this.dadosMeterologicos.Count == 10)
            {
                dadosMeterologicos.RemoveAt(0);
            }

            dadosMeterologicos.Add(dados);
        }
    }
}
