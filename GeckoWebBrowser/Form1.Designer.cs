namespace GeckoWebBrowser
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.geckoWebBrowser1 = new Gecko.GeckoWebBrowser();
            this.BotonAtras = new System.Windows.Forms.Button();
            this.BotonAdelante = new System.Windows.Forms.Button();
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.TextUrl = new System.Windows.Forms.TextBox();
            this.BotonIr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // geckoWebBrowser1
            // 
            this.geckoWebBrowser1.DisableWmImeSetContext = false;
            this.geckoWebBrowser1.Location = new System.Drawing.Point(12, 57);
            this.geckoWebBrowser1.Name = "geckoWebBrowser1";
            this.geckoWebBrowser1.Size = new System.Drawing.Size(864, 249);
            this.geckoWebBrowser1.TabIndex = 0;
            this.geckoWebBrowser1.UseHttpActivityObserver = false;
            // 
            // BotonAtras
            // 
            this.BotonAtras.Location = new System.Drawing.Point(12, 12);
            this.BotonAtras.Name = "BotonAtras";
            this.BotonAtras.Size = new System.Drawing.Size(75, 23);
            this.BotonAtras.TabIndex = 1;
            this.BotonAtras.Text = "Atrás";
            this.BotonAtras.UseVisualStyleBackColor = true;
            this.BotonAtras.Click += new System.EventHandler(this.BotonAtras_Click);
            // 
            // BotonAdelante
            // 
            this.BotonAdelante.Location = new System.Drawing.Point(93, 12);
            this.BotonAdelante.Name = "BotonAdelante";
            this.BotonAdelante.Size = new System.Drawing.Size(75, 23);
            this.BotonAdelante.TabIndex = 2;
            this.BotonAdelante.Text = "Adelante";
            this.BotonAdelante.UseVisualStyleBackColor = true;
            this.BotonAdelante.Click += new System.EventHandler(this.BotonAdelante_Click);
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.Location = new System.Drawing.Point(175, 12);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(75, 23);
            this.BotonCancelar.TabIndex = 3;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            this.BotonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click);
            // 
            // TextUrl
            // 
            this.TextUrl.Location = new System.Drawing.Point(256, 15);
            this.TextUrl.Name = "TextUrl";
            this.TextUrl.Size = new System.Drawing.Size(570, 20);
            this.TextUrl.TabIndex = 4;
            // 
            // BotonIr
            // 
            this.BotonIr.Location = new System.Drawing.Point(842, 12);
            this.BotonIr.Name = "BotonIr";
            this.BotonIr.Size = new System.Drawing.Size(34, 23);
            this.BotonIr.TabIndex = 5;
            this.BotonIr.Text = "Ir";
            this.BotonIr.UseVisualStyleBackColor = true;
            this.BotonIr.Click += new System.EventHandler(this.BotonIr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 318);
            this.Controls.Add(this.BotonIr);
            this.Controls.Add(this.TextUrl);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonAdelante);
            this.Controls.Add(this.BotonAtras);
            this.Controls.Add(this.geckoWebBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Gecko.GeckoWebBrowser geckoWebBrowser1;
        private System.Windows.Forms.Button BotonAtras;
        private System.Windows.Forms.Button BotonAdelante;
        private System.Windows.Forms.Button BotonCancelar;
        private System.Windows.Forms.TextBox TextUrl;
        private System.Windows.Forms.Button BotonIr;
    }
}

