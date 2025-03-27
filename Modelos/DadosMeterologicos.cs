using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_observer.Modelos
{
    public class DadosMeterologicos
    {
        public double Temperatura { get; private set; }
        public double Umidade { get; private set; }
        public double Pressao { get; private set; }
        public void SetTemperatura(double Temperatura)
        {
            this.Temperatura = Temperatura;
        }
        public void SetUmidade(double Umidade)
        {
            this.Umidade = Umidade;
        }
        public void SetPressao(double Pressao)
        {
            this.Pressao = Pressao;
        }
    }
}
