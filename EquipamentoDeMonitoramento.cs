using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projeto_observer.Interfaces;
using projeto_observer.Modelos;

namespace projeto_observer
{

    public class EquipamentoDeMonitoramento
    {
        private Random gerador = new Random();
        private ISujeitoObservavel monitorDadosClima;
        public DadosMeterologicos Dados { get; } = new DadosMeterologicos();

        public void Coletar()
        {
            Dados.SetTemperatura(GetNumero(0, 35));
            Dados.SetUmidade(GetNumero(10, 100));
            Dados.SetPressao(GetNumero(900, 1100));

            monitorDadosClima?.DadosMudaram();
        }

        private double GetNumero(double min, double max)
        {
            return gerador.NextDouble() * (max - min) + min;
        }

        public void SetMonitorDadosClima(ISujeitoObservavel monitorDadosClima)
        {
            this.monitorDadosClima = monitorDadosClima;
        }

        public double GetTemperaturaAtual()
        {
            return Dados.Temperatura;
        }

        public double GetUmidadeAtual()
        {
            return Dados.Umidade;
        }

        public double GetPressaoAtual()
        {
            return Dados.Pressao;
        }
    }

}
