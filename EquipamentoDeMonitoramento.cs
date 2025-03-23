using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_observer
{
    using System;
    using System.Threading;

    public class EquipamentoDeMonitoramento
    {
        private Random gerador = new Random();
        private ISujeitoObservavel monitorDadosClima;

        // Propriedades para armazenar os valores atuais
        public double TemperaturaAtual { get; private set; }
        public double HumidadeAtual { get; private set; }
        public double PressaoAtual { get; private set; }

        public void Coletar()
        {
            for (int i = 0; i < 10; i++)
            {
                this.TemperaturaAtual = GetNumero(0, 35);
                this.HumidadeAtual = GetNumero(10, 100);
                this.PressaoAtual = GetNumero(900, 1100);

                monitorDadosClima?.DadosMudaram();

                Thread.Sleep(3000);
            }
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
            return TemperaturaAtual;
        }

        public double GetHumidadeAtual()
        {
            return HumidadeAtual;
        }

        public double GetPressaoAtual()
        {
            return PressaoAtual;
        }
    }

}
