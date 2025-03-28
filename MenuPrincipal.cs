using projeto_observer.Modelos;

namespace projeto_observer
{
    public partial class MenuPrincipal : Form
    {
        public static MenuPrincipal Instance { get; private set; }

        private EquipamentoDeMonitoramento equipamentoDeMonitoramento;
        private MonitorDeDadosDoClima monitorDeDadosDoClima;
        private DisplayDeCondicoesAtuais abaUltimosRegistros;
        private DisplayEstatistico abaMedia;
        private Thread coletaThread;

        public MenuPrincipal()
        {
            InitializeComponent();
            Instance = this;

            equipamentoDeMonitoramento = new EquipamentoDeMonitoramento();
            monitorDeDadosDoClima = new MonitorDeDadosDoClima(equipamentoDeMonitoramento);
            equipamentoDeMonitoramento.SetMonitorDadosClima(monitorDeDadosDoClima);

            abaUltimosRegistros = new DisplayDeCondicoesAtuais();
            abaMedia = new DisplayEstatistico();

            observadorCheck.Checked = true;

            this.Shown += MenuPrincipal_Shown;
        }

        private void MenuPrincipal_Shown(object sender, EventArgs e)
        {
            coletaThread = new Thread(() =>
            {
                while (true)
                {
                    this.Invoke(new Action(() =>
                    {
                        equipamentoDeMonitoramento.Coletar();
                    }));

                    Thread.Sleep(3000);
                }
            });
            coletaThread.IsBackground = true;
            coletaThread.Start();
        }

        public void AtualizarUltimos(List<DadosMeterologicos> dados)
        {
            dgvUltimosRegistros.Rows.Clear();

            foreach (var registro in dados)
            {
                dgvUltimosRegistros.Rows.Add(registro.Temperatura, registro.Umidade, registro.Pressao);
            }
        }

        public void AtualizarMedia(DadosMeterologicos dados, double minTemp_, double maxTemp_)
        {
            txtPressao.Text = dados.Pressao.ToString();
            txtTemperatura.Text = dados.Temperatura.ToString();
            txtUmidade.Text = dados.Umidade.ToString();
            minTemp.Text = minTemp_.ToString();
            maxTemp.Text = maxTemp_.ToString();
        }

        private void coletarButton_Click(object sender, EventArgs e)
        {
            equipamentoDeMonitoramento.Coletar();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (observadorCheck.Checked)
            {
                monitorDeDadosDoClima.RegistraObservador(abaUltimosRegistros);
                monitorDeDadosDoClima.RegistraObservador(abaMedia);
            }
            else
            {
                monitorDeDadosDoClima.RemoveObservador(abaUltimosRegistros);
                monitorDeDadosDoClima.RemoveObservador(abaMedia);
            }
        }
    }
}
