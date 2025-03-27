using projeto_observer.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_observer.Interfaces
{
    public interface IObservador
    {
        void Atualizar(DadosMeterologicos dados);
    }
}
