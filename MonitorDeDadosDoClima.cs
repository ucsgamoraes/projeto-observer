using projeto_observer.Interfaces;
using projeto_observer.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_observer
{    
    public class MonitorDeDadosDoClima : ISujeitoObservavel
    {
        private List<IObservador> observadores;
        private DadosMeterologicos dados;
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
                item.Atualizar(dados);
            }
        }

        public void DadosMudaram()
        {
            dados.SetTemperatura(equipamento.GetTemperaturaAtual());
            dados.SetUmidade(equipamento.GetUmidadeAtual());
            dados.SetPressao(equipamento.GetPressaoAtual());
            NotificaObservadores();
        }
    }

}
