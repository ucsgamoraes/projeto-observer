using projeto_observer.Interfaces;
using projeto_observer.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace projeto_observer
{
    public class DisplayEstatistico : IObservador
    {
        List<DadosMeterologicos> dadosMeterologicos { get; set; }
        public DadosMeterologicos media { get; set; }
        public DisplayEstatistico()
        {
            dadosMeterologicos = new List<DadosMeterologicos>(10);
            media = new DadosMeterologicos();
        }
        public void Atualizar(DadosMeterologicos dados)
        {
            if (this.dadosMeterologicos.Count == 10)
            {
                dadosMeterologicos.RemoveAt(0);
            }

            DadosMeterologicos dadosCopia = new DadosMeterologicos();
            dadosCopia.SetTemperatura(Math.Round(dados.Temperatura, 2));
            dadosCopia.SetUmidade(Math.Round(dados.Umidade, 2));
            dadosCopia.SetPressao(Math.Round(dados.Pressao, 2));
            dadosMeterologicos.Add(dadosCopia);

            double somaTemperatura = 0, somaUmidade = 0, somaPressao = 0;
            double minTemp = double.MaxValue;
            double maxTemp = double.MinValue;

            foreach (var dado in dadosMeterologicos) 
            { 
                if(dado.Temperatura < minTemp) minTemp = dado.Temperatura;
                if(dados.Temperatura > maxTemp) maxTemp = dado.Temperatura;

                somaTemperatura += dado.Temperatura;
                somaUmidade += dado.Umidade;
                somaPressao += dado.Pressao;
            }

            media.SetTemperatura(Math.Round(somaTemperatura / dadosMeterologicos.Count, 2));
            media.SetUmidade(Math.Round(somaUmidade / dadosMeterologicos.Count, 2));
            media.SetPressao(Math.Round(somaPressao / dadosMeterologicos.Count, 2));

            MenuPrincipal.Instance.AtualizarMedia(this.media, minTemp, maxTemp);
        }
    }
}
