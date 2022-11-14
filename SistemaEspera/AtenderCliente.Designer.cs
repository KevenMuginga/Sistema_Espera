
namespace SistemaEspera
{
    partial class AtenderCliente
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
            this.tblDados = new System.Windows.Forms.DataGridView();
            this.btnChamar = new Guna.UI2.WinForms.Guna2Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblFicha = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tblDados)).BeginInit();
            this.SuspendLayout();
            // 
            // tblDados
            // 
            this.tblDados.BackgroundColor = System.Drawing.Color.White;
            this.tblDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblDados.Location = new System.Drawing.Point(32, 46);
            this.tblDados.Name = "tblDados";
            this.tblDados.Size = new System.Drawing.Size(426, 511);
            this.tblDados.TabIndex = 0;
            // 
            // btnChamar
            // 
            this.btnChamar.BorderColor = System.Drawing.Color.Transparent;
            this.btnChamar.BorderRadius = 10;
            this.btnChamar.CheckedState.Parent = this.btnChamar;
            this.btnChamar.CustomImages.Parent = this.btnChamar;
            this.btnChamar.FillColor = System.Drawing.Color.White;
            this.btnChamar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamar.ForeColor = System.Drawing.Color.Black;
            this.btnChamar.HoverState.Parent = this.btnChamar;
            this.btnChamar.Location = new System.Drawing.Point(628, 46);
            this.btnChamar.Name = "btnChamar";
            this.btnChamar.ShadowDecoration.Parent = this.btnChamar;
            this.btnChamar.Size = new System.Drawing.Size(169, 45);
            this.btnChamar.TabIndex = 1;
            this.btnChamar.Text = "Chamar";
            this.btnChamar.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(628, 167);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 21);
            this.lblId.TabIndex = 2;
            // 
            // lblFicha
            // 
            this.lblFicha.AutoSize = true;
            this.lblFicha.BackColor = System.Drawing.Color.Transparent;
            this.lblFicha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFicha.Location = new System.Drawing.Point(624, 243);
            this.lblFicha.Name = "lblFicha";
            this.lblFicha.Size = new System.Drawing.Size(0, 21);
            this.lblFicha.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AtenderCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.lblFicha);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnChamar);
            this.Controls.Add(this.tblDados);
            this.Name = "AtenderCliente";
            this.Size = new System.Drawing.Size(966, 577);
            this.Load += new System.EventHandler(this.AtenderCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblDados;
        private Guna.UI2.WinForms.Guna2Button btnChamar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblFicha;
        private System.Windows.Forms.Timer timer1;
    }
}
