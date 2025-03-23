using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_observer
{
    using System;
    using System.Collections.Generic;

    public interface ISujeitoObservavel
    {
        void RegistraObservador(IObservador o);
        void RemoveObservador(IObservador o);
        void NotificaObservadores();
        void DadosMudaram();
    }

    public interface IObservador
    {
        void Atualizar(double temperatura, double humidade, double pressao);
    }

    public class MonitorDeDadosDoClima : ISujeitoObservavel
    {
        private List<IObservador> observadores;
        private double temperatura;
        private double humidade;
        private double pressao;
        private EquipamentoDeMonitoramento equipamento;

        public MonitorDeDadosDoClima(EquipamentoDeMonitoramento equipamento)
        {
            this.observadores = new List<IObservador>();
            this.equipamento = equipamento;
        }

        public void RegistraObservador(IObservador o)
        {
            observadores.Add(o);
        }

        public void RemoveObservador(IObservador o)
        {
            int i = observadores.IndexOf(o);
            // Note que, na tradução, mantemos a condição original (i > 0).
            // Caso deseje remover também o primeiro elemento, utilize (i >= 0).
            if (i > 0)
            {
                observadores.RemoveAt(i);
            }
        }

        public void NotificaObservadores()
        {
            foreach (IObservador item in observadores)
            {
                item.Atualizar(temperatura, humidade, pressao);
            }
        }

        public void DadosMudaram()
        {
            temperatura = equipamento.GetTemperaturaAtual();
            humidade = equipamento.GetHumidadeAtual();
            pressao = equipamento.GetPressaoAtual();
            NotificaObservadores();
        }
    }

}
