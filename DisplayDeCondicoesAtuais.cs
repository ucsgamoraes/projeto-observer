using projeto_observer.Interfaces;
using projeto_observer.Modelos;
using System;
using System.Collections.Generic;

namespace projeto_observer
{
    public class DisplayDeCondicoesAtuais : IObservador
    {
        private List<DadosMeterologicos> dadosMeterologicos = new List<DadosMeterologicos>();

        // Instância única de Random para gerar números aleatórios
        private static Random random = new Random();

        public DisplayDeCondicoesAtuais()
        {
        }

        public void Atualizar(DadosMeterologicos dados)
        {
            if (dadosMeterologicos.Count == 10)
            {
                dadosMeterologicos.RemoveAt(0);
            }

            var novoDado = new DadosMeterologicos();
            novoDado.SetTemperatura(Math.Round(dados.Temperatura, 2));
            novoDado.SetUmidade(Math.Round(dados.Umidade, 2));
            novoDado.SetPressao(Math.Round(dados.Pressao, 2));
            dadosMeterologicos.Add(novoDado);

            MenuPrincipal.Instance.AtualizarUltimos(dadosMeterologicos);
        }
    }
}
