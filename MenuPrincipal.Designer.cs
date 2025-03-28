
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
            observadorCheck = new CheckBox();
            label1 = new Label();
            maxTemp = new TextBox();
            label2 = new Label();
            label3 = new Label();
            minTemp = new TextBox();
            label4 = new Label();
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
            tabPage1.Controls.Add(dgvUltimosRegistros);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(349, 347);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Últimos 10 Registros";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvUltimosRegistros
            // 
            dgvUltimosRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUltimosRegistros.Columns.AddRange(new DataGridViewColumn[] { Temperatura, Umidade, Pressao });
            dgvUltimosRegistros.Location = new Point(6, 6);
            dgvUltimosRegistros.Name = "dgvUltimosRegistros";
            dgvUltimosRegistros.RowHeadersVisible = false;
            dgvUltimosRegistros.Size = new Size(339, 335);
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
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(minTemp);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(maxTemp);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(lbUMPressao);
            tabPage2.Controls.Add(lbUMUmidade);
            tabPage2.Controls.Add(lbUMTemperatura);
            tabPage2.Controls.Add(txtPressao);
            tabPage2.Controls.Add(txtUmidade);
            tabPage2.Controls.Add(txtTemperatura);
            tabPage2.Controls.Add(lbUmidade);
            tabPage2.Controls.Add(lbPressao);
            tabPage2.Controls.Add(lbTemperatura);
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
            lbUMPressao.Location = new Point(313, 85);
            lbUMPressao.Name = "lbUMPressao";
            lbUMPressao.Size = new Size(25, 15);
            lbUMPressao.TabIndex = 11;
            lbUMPressao.Text = "mb";
            // 
            // lbUMUmidade
            // 
            lbUMUmidade.AutoSize = true;
            lbUMUmidade.Location = new Point(316, 56);
            lbUMUmidade.Name = "lbUMUmidade";
            lbUMUmidade.Size = new Size(17, 15);
            lbUMUmidade.TabIndex = 10;
            lbUMUmidade.Text = "%";
            // 
            // lbUMTemperatura
            // 
            lbUMTemperatura.AutoSize = true;
            lbUMTemperatura.Location = new Point(313, 27);
            lbUMTemperatura.Name = "lbUMTemperatura";
            lbUMTemperatura.Size = new Size(20, 15);
            lbUMTemperatura.TabIndex = 9;
            lbUMTemperatura.Text = "°C";
            // 
            // txtPressao
            // 
            txtPressao.BorderStyle = BorderStyle.FixedSingle;
            txtPressao.Location = new Point(110, 83);
            txtPressao.Name = "txtPressao";
            txtPressao.ReadOnly = true;
            txtPressao.Size = new Size(200, 23);
            txtPressao.TabIndex = 8;
            // 
            // txtUmidade
            // 
            txtUmidade.BorderStyle = BorderStyle.FixedSingle;
            txtUmidade.Location = new Point(110, 54);
            txtUmidade.Name = "txtUmidade";
            txtUmidade.ReadOnly = true;
            txtUmidade.Size = new Size(200, 23);
            txtUmidade.TabIndex = 7;
            // 
            // txtTemperatura
            // 
            txtTemperatura.BorderStyle = BorderStyle.FixedSingle;
            txtTemperatura.Location = new Point(110, 25);
            txtTemperatura.Name = "txtTemperatura";
            txtTemperatura.ReadOnly = true;
            txtTemperatura.Size = new Size(200, 23);
            txtTemperatura.TabIndex = 6;
            // 
            // lbUmidade
            // 
            lbUmidade.AutoSize = true;
            lbUmidade.Location = new Point(25, 56);
            lbUmidade.Name = "lbUmidade";
            lbUmidade.Size = new Size(58, 15);
            lbUmidade.TabIndex = 5;
            lbUmidade.Text = "Umidade:";
            // 
            // lbPressao
            // 
            lbPressao.AutoSize = true;
            lbPressao.Location = new Point(25, 82);
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
            // observadorCheck
            // 
            observadorCheck.AutoSize = true;
            observadorCheck.Location = new Point(123, 393);
            observadorCheck.Name = "observadorCheck";
            observadorCheck.Size = new Size(132, 19);
            observadorCheck.TabIndex = 1;
            observadorCheck.Text = "Associar observador";
            observadorCheck.UseVisualStyleBackColor = true;
            observadorCheck.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 105);
            label1.Name = "label1";
            label1.Size = new Size(77, 30);
            label1.TabIndex = 12;
            label1.Text = "Temperatura \r\nmáxima:";
            // 
            // maxTemp
            // 
            maxTemp.BorderStyle = BorderStyle.FixedSingle;
            maxTemp.Location = new Point(110, 112);
            maxTemp.Name = "maxTemp";
            maxTemp.ReadOnly = true;
            maxTemp.Size = new Size(200, 23);
            maxTemp.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(316, 114);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 14;
            label2.Text = "°C";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(316, 145);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 17;
            label3.Text = "°C";
            // 
            // minTemp
            // 
            minTemp.BorderStyle = BorderStyle.FixedSingle;
            minTemp.Location = new Point(110, 143);
            minTemp.Name = "minTemp";
            minTemp.ReadOnly = true;
            minTemp.Size = new Size(200, 23);
            minTemp.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 141);
            label4.Name = "label4";
            label4.Size = new Size(77, 30);
            label4.TabIndex = 15;
            label4.Text = "Temperatura \rmínima:";
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 457);
            Controls.Add(observadorCheck);
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
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvUltimosRegistros;
        private Label lbUmidade;
        private Label lbPressao;
        private Label lbTemperatura;
        private TextBox txtPressao;
        private TextBox txtUmidade;
        private TextBox txtTemperatura;
        private DataGridViewTextBoxColumn Temperatura;
        private DataGridViewTextBoxColumn Umidade;
        private DataGridViewTextBoxColumn Pressao;
        private Label lbUMPressao;
        private Label lbUMUmidade;
        private Label lbUMTemperatura;
        private CheckBox observadorCheck;
        private TextBox maxTemp;
        private Label label1;
        private Label label3;
        private TextBox minTemp;
        private Label label4;
        private Label label2;
    }
}
