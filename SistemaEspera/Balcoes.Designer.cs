
namespace SistemaEspera
{
    partial class Balcoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.paneCentro = new Guna.UI2.WinForms.Guna2Panel();
            this.fichas = new Guna.UI2.WinForms.Guna2Button();
            this.fichaPBalcao1 = new SistemaEspera.FichaPBalcao();
            this.paneBalcao1 = new SistemaEspera.PaneBalcao();
            this.atenderCliente1 = new SistemaEspera.AtenderCliente();
            this.obterFicha1 = new SistemaEspera.ObterFicha();
            this.paneCentro.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneCentro
            // 
            this.paneCentro.Controls.Add(this.fichas);
            this.paneCentro.Controls.Add(this.fichaPBalcao1);
            this.paneCentro.Controls.Add(this.paneBalcao1);
            this.paneCentro.Controls.Add(this.atenderCliente1);
            this.paneCentro.Controls.Add(this.obterFicha1);
            this.paneCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneCentro.Location = new System.Drawing.Point(0, 0);
            this.paneCentro.Name = "paneCentro";
            this.paneCentro.ShadowDecoration.Parent = this.paneCentro;
            this.paneCentro.Size = new System.Drawing.Size(950, 640);
            this.paneCentro.TabIndex = 0;
            // 
            // fichas
            // 
            this.fichas.BorderRadius = 10;
            this.fichas.CheckedState.Parent = this.fichas;
            this.fichas.CustomImages.Parent = this.fichas;
            this.fichas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fichas.ForeColor = System.Drawing.Color.White;
            this.fichas.HoverState.Parent = this.fichas;
            this.fichas.Location = new System.Drawing.Point(368, 583);
            this.fichas.Name = "fichas";
            this.fichas.ShadowDecoration.Parent = this.fichas;
            this.fichas.Size = new System.Drawing.Size(183, 45);
            this.fichas.TabIndex = 9;
            this.fichas.Text = "Fichas";
            this.fichas.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // fichaPBalcao1
            // 
            this.fichaPBalcao1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fichaPBalcao1.Location = new System.Drawing.Point(12, -3);
            this.fichaPBalcao1.Name = "fichaPBalcao1";
            this.fichaPBalcao1.Size = new System.Drawing.Size(966, 673);
            this.fichaPBalcao1.TabIndex = 8;
            this.fichaPBalcao1.Load += new System.EventHandler(this.fichaPBalcao1_Load);
            // 
            // paneBalcao1
            // 
            this.paneBalcao1.Location = new System.Drawing.Point(0, -3);
            this.paneBalcao1.Name = "paneBalcao1";
            this.paneBalcao1.Size = new System.Drawing.Size(950, 640);
            this.paneBalcao1.TabIndex = 7;
            this.paneBalcao1.Load += new System.EventHandler(this.paneBalcao1_Load_1);
            // 
            // atenderCliente1
            // 
            this.atenderCliente1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.atenderCliente1.Location = new System.Drawing.Point(0, 0);
            this.atenderCliente1.Name = "atenderCliente1";
            this.atenderCliente1.Size = new System.Drawing.Size(966, 679);
            this.atenderCliente1.TabIndex = 6;
            // 
            // obterFicha1
            // 
            this.obterFicha1.Location = new System.Drawing.Point(362, 68);
            this.obterFicha1.Name = "obterFicha1";
            this.obterFicha1.Size = new System.Drawing.Size(966, 450);
            this.obterFicha1.TabIndex = 4;
            // 
            // Balcoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 640);
            this.Controls.Add(this.paneCentro);
            this.Name = "Balcoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balcao";
            this.Load += new System.EventHandler(this.Balcao_Load);
            this.paneCentro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel paneCentro;
        private ObterFicha obterFicha1;
        private AtenderCliente atenderCliente1;
        private PaneBalcao paneBalcao1;
        private FichaPBalcao fichaPBalcao1;
        private Guna.UI2.WinForms.Guna2Button fichas;
    }
}