
namespace SistemaEspera
{
    partial class ObterFicha
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnficha = new Guna.UI2.WinForms.Guna2Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblTempo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnficha
            // 
            this.btnficha.BackColor = System.Drawing.Color.Transparent;
            this.btnficha.BorderColor = System.Drawing.Color.Transparent;
            this.btnficha.BorderRadius = 10;
            this.btnficha.CheckedState.Parent = this.btnficha;
            this.btnficha.CustomImages.Parent = this.btnficha;
            this.btnficha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnficha.ForeColor = System.Drawing.Color.White;
            this.btnficha.HoverState.Parent = this.btnficha;
            this.btnficha.Location = new System.Drawing.Point(323, 235);
            this.btnficha.Name = "btnficha";
            this.btnficha.ShadowDecoration.Parent = this.btnficha;
            this.btnficha.Size = new System.Drawing.Size(180, 45);
            this.btnficha.TabIndex = 0;
            this.btnficha.Text = "Obter Ficha";
            this.btnficha.Click += new System.EventHandler(this.btnficha_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.Location = new System.Drawing.Point(377, 109);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(0, 25);
            this.lblTempo.TabIndex = 1;
            // 
            // ObterFicha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.btnficha);
            this.Name = "ObterFicha";
            this.Size = new System.Drawing.Size(966, 450);
            this.Load += new System.EventHandler(this.ObterFicha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnficha;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblTempo;
    }
}
