
namespace projeto_observer
{
    partial class MenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            toggleObservadorUltimos = new Button();
            dgvUltimosRegistros = new DataGridView();
            Temperatura = new DataGridViewTextBoxColumn();
            Umidade = new DataGridViewTextBoxColumn();
            Pressao = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            lbUMPressao = new Label();
            lbUMUmidade = new Label();
            lbUMTemperatura = new Label();
            txtPressao = new TextBox();
            txtUmidade = new TextBox();
            txtTemperatura = new TextBox();
            lbUmidade = new Label();
            lbPressao = new Label();
            lbTemperatura = new Label();
            toggleObservadorMedia = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUltimosRegistros).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(357, 375);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(toggleObservadorUltimos);
            tabPage1.Controls.Add(dgvUltimosRegistros);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(349, 347);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Últimos 10 Registros";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // toggleObservadorUltimos
            // 
            toggleObservadorUltimos.Location = new Point(106, 318);
            toggleObservadorUltimos.Name = "toggleObservadorUltimos";
            toggleObservadorUltimos.Size = new Size(139, 23);
            toggleObservadorUltimos.TabIndex = 1;
            toggleObservadorUltimos.Text = "Associar Observador";
            toggleObservadorUltimos.UseVisualStyleBackColor = true;
            // 
            // dgvUltimosRegistros
            // 
            dgvUltimosRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUltimosRegistros.Columns.AddRange(new DataGridViewColumn[] { Temperatura, Umidade, Pressao });
            dgvUltimosRegistros.Location = new Point(6, 6);
            dgvUltimosRegistros.Name = "dgvUltimosRegistros";
            dgvUltimosRegistros.RowHeadersVisible = false;
            dgvUltimosRegistros.Size = new Size(339, 306);
            dgvUltimosRegistros.TabIndex = 0;
            // 
            // Temperatura
            // 
            Temperatura.HeaderText = "Temperatura (°C)";
            Temperatura.Name = "Temperatura";
            Temperatura.ReadOnly = true;
            Temperatura.Width = 125;
            // 
            // Umidade
            // 
            Umidade.HeaderText = "Umidade (%)";
            Umidade.Name = "Umidade";
            Umidade.ReadOnly = true;
            Umidade.Width = 105;
            // 
            // Pressao
            // 
            Pressao.HeaderText = "Pressão (mb)";
            Pressao.Name = "Pressao";
            Pressao.ReadOnly = true;
            Pressao.Width = 105;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lbUMPressao);
            tabPage2.Controls.Add(lbUMUmidade);
            tabPage2.Controls.Add(lbUMTemperatura);
            tabPage2.Controls.Add(txtPressao);
            tabPage2.Controls.Add(txtUmidade);
            tabPage2.Controls.Add(txtTemperatura);
            tabPage2.Controls.Add(lbUmidade);
            tabPage2.Controls.Add(lbPressao);
            tabPage2.Controls.Add(lbTemperatura);
            tabPage2.Controls.Add(toggleObservadorMedia);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(349, 347);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Média";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbUMPressao
            // 
            lbUMPressao.AutoSize = true;
            lbUMPressao.Location = new Point(316, 77);
            lbUMPressao.Name = "lbUMPressao";
            lbUMPressao.Size = new Size(25, 15);
            lbUMPressao.TabIndex = 11;
            lbUMPressao.Text = "mb";
            // 
            // lbUMUmidade
            // 
            lbUMUmidade.AutoSize = true;
            lbUMUmidade.Location = new Point(316, 51);
            lbUMUmidade.Name = "lbUMUmidade";
            lbUMUmidade.Size = new Size(17, 15);
            lbUMUmidade.TabIndex = 10;
            lbUMUmidade.Text = "%";
            // 
            // lbUMTemperatura
            // 
            lbUMTemperatura.AutoSize = true;
            lbUMTemperatura.Location = new Point(316, 25);
            lbUMTemperatura.Name = "lbUMTemperatura";
            lbUMTemperatura.Size = new Size(20, 15);
            lbUMTemperatura.TabIndex = 9;
            lbUMTemperatura.Text = "°C";
            // 
            // txtPressao
            // 
            txtPressao.BorderStyle = BorderStyle.FixedSingle;
            txtPressao.Location = new Point(110, 74);
            txtPressao.Name = "txtPressao";
            txtPressao.ReadOnly = true;
            txtPressao.Size = new Size(200, 23);
            txtPressao.TabIndex = 8;
            // 
            // txtUmidade
            // 
            txtUmidade.BorderStyle = BorderStyle.FixedSingle;
            txtUmidade.Location = new Point(110, 48);
            txtUmidade.Name = "txtUmidade";
            txtUmidade.ReadOnly = true;
            txtUmidade.Size = new Size(200, 23);
            txtUmidade.TabIndex = 7;
            // 
            // txtTemperatura
            // 
            txtTemperatura.BorderStyle = BorderStyle.FixedSingle;
            txtTemperatura.Location = new Point(110, 23);
            txtTemperatura.Name = "txtTemperatura";
            txtTemperatura.ReadOnly = true;
            txtTemperatura.Size = new Size(200, 23);
            txtTemperatura.TabIndex = 6;
            // 
            // lbUmidade
            // 
            lbUmidade.AutoSize = true;
            lbUmidade.Location = new Point(25, 51);
            lbUmidade.Name = "lbUmidade";
            lbUmidade.Size = new Size(58, 15);
            lbUmidade.TabIndex = 5;
            lbUmidade.Text = "Umidade:";
            // 
            // lbPressao
            // 
            lbPressao.AutoSize = true;
            lbPressao.Location = new Point(25, 77);
            lbPressao.Name = "lbPressao";
            lbPressao.Size = new Size(50, 15);
            lbPressao.TabIndex = 4;
            lbPressao.Text = "Pressão:";
            // 
            // lbTemperatura
            // 
            lbTemperatura.AutoSize = true;
            lbTemperatura.Location = new Point(25, 25);
            lbTemperatura.Name = "lbTemperatura";
            lbTemperatura.Size = new Size(77, 15);
            lbTemperatura.TabIndex = 3;
            lbTemperatura.Text = "Temperatura:";
            // 
            // toggleObservadorMedia
            // 
            toggleObservadorMedia.Location = new Point(106, 318);
            toggleObservadorMedia.Name = "toggleObservadorMedia";
            toggleObservadorMedia.Size = new Size(139, 23);
            toggleObservadorMedia.TabIndex = 2;
            toggleObservadorMedia.Text = "Associar Observador";
            toggleObservadorMedia.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 399);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MenuPrincipal";
            Text = "Sistema Metereológico";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUltimosRegistros).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvUltimosRegistros;
        private Button toggleObservadorUltimos;
        private Label lbUmidade;
        private Label lbPressao;
        private Label lbTemperatura;
        private Button toggleObservadorMedia;
        private TextBox txtPressao;
        private TextBox txtUmidade;
        private TextBox txtTemperatura;
        private DataGridViewTextBoxColumn Temperatura;
        private DataGridViewTextBoxColumn Umidade;
        private DataGridViewTextBoxColumn Pressao;
        private Label lbUMPressao;
        private Label lbUMUmidade;
        private Label lbUMTemperatura;
    }
}
