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
    public class AbaMedia : IObservador
    {
        List<DadosMeterologicos> dadosMeterologicos { get; set; }
        public DadosMeterologicos media { get; set; }
        public AbaMedia()
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

            double somaTemperatura = 0, somaUmidade = 0, somaPressao = 0;
            foreach (var dado in dadosMeterologicos) 
            { 
                somaTemperatura += dado.Temperatura;
                somaUmidade += dado.Umidade;
                somaPressao += dado.Pressao;
            }

            media.SetTemperatura(somaTemperatura / dadosMeterologicos.Count);
            media.SetUmidade(somaUmidade / dadosMeterologicos.Count);
            media.SetPressao(somaPressao / dadosMeterologicos.Count);
        }
    }
}
