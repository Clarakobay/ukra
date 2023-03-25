namespace ukrabar_projeto
{
    partial class Formcadastro
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formcadastro));
            this.button1 = new System.Windows.Forms.Button();
            this.entrarcliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(396, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 77);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // entrarcliente
            // 
            this.entrarcliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("entrarcliente.BackgroundImage")));
            this.entrarcliente.Location = new System.Drawing.Point(894, 201);
            this.entrarcliente.Name = "entrarcliente";
            this.entrarcliente.Size = new System.Drawing.Size(222, 81);
            this.entrarcliente.TabIndex = 1;
            this.entrarcliente.UseVisualStyleBackColor = true;
            this.entrarcliente.Click += new System.EventHandler(this.entrarcliente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ukrabar_projeto.Properties.Resources.WhatsApp_Image_2023_03_25_at_09_44_01;
            this.ClientSize = new System.Drawing.Size(1238, 734);
            this.Controls.Add(this.entrarcliente);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button entrarcliente;
    }
}

