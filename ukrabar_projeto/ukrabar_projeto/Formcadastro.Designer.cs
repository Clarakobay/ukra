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
            this.button1 = new System.Windows.Forms.Button();
            this.entrarcliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(396, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 77);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // entrarcliente
            // 
            this.entrarcliente.BackColor = System.Drawing.Color.Transparent;
            this.entrarcliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.entrarcliente.FlatAppearance.BorderSize = 0;
            this.entrarcliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.entrarcliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.entrarcliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entrarcliente.ForeColor = System.Drawing.Color.Transparent;
            this.entrarcliente.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.entrarcliente.Location = new System.Drawing.Point(890, 204);
            this.entrarcliente.Name = "entrarcliente";
            this.entrarcliente.Size = new System.Drawing.Size(222, 81);
            this.entrarcliente.TabIndex = 1;
            this.entrarcliente.UseVisualStyleBackColor = false;
            this.entrarcliente.Click += new System.EventHandler(this.entrarcliente_Click);
            // 
            // Formcadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ukrabar_projeto.Properties.Resources.WhatsApp_Image_2023_03_25_at_09_44_01;
            this.ClientSize = new System.Drawing.Size(1238, 734);
            this.Controls.Add(this.entrarcliente);
            this.Controls.Add(this.button1);
            this.Name = "Formcadastro";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button entrarcliente;
    }
}

