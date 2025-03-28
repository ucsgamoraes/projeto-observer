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
            this.dados = new DadosMeterologicos();
        }

        public void RegistraObservador(IObservador o)
        {
            observadores.Add(o);
        }

        public void RemoveObservador(IObservador o)
        {
            observadores.Remove(o);
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
