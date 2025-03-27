using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_observer.Interfaces
{
    public interface ISujeitoObservavel
    {
        void RegistraObservador(IObservador o);
        void RemoveObservador(IObservador o);
        void NotificaObservadores();
        void DadosMudaram();
    }
}
