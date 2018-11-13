namespace Semanal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lunes = new System.Windows.Forms.Button();
            this.martes = new System.Windows.Forms.Button();
            this.miercoles = new System.Windows.Forms.Button();
            this.jueves = new System.Windows.Forms.Button();
            this.viernes = new System.Windows.Forms.Button();
            this.sabado = new System.Windows.Forms.Button();
            this.domingo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dia = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lunes
            // 
            this.lunes.Location = new System.Drawing.Point(32, 30);
            this.lunes.Name = "lunes";
            this.lunes.Size = new System.Drawing.Size(116, 33);
            this.lunes.TabIndex = 0;
            this.lunes.Text = "Lunes";
            this.lunes.UseVisualStyleBackColor = true;
            this.lunes.Click += new System.EventHandler(this.button1_Click);
            // 
            // martes
            // 
            this.martes.Location = new System.Drawing.Point(32, 87);
            this.martes.Name = "martes";
            this.martes.Size = new System.Drawing.Size(116, 33);
            this.martes.TabIndex = 1;
            this.martes.Text = "Martes";
            this.martes.UseVisualStyleBackColor = true;
            this.martes.Click += new System.EventHandler(this.martes_Click);
            // 
            // miercoles
            // 
            this.miercoles.Location = new System.Drawing.Point(32, 144);
            this.miercoles.Name = "miercoles";
            this.miercoles.Size = new System.Drawing.Size(116, 33);
            this.miercoles.TabIndex = 2;
            this.miercoles.Text = "Miércoles";
            this.miercoles.UseVisualStyleBackColor = true;
            this.miercoles.Click += new System.EventHandler(this.miercoles_Click);
            // 
            // jueves
            // 
            this.jueves.Location = new System.Drawing.Point(32, 199);
            this.jueves.Name = "jueves";
            this.jueves.Size = new System.Drawing.Size(116, 33);
            this.jueves.TabIndex = 3;
            this.jueves.Text = "Jueves";
            this.jueves.UseVisualStyleBackColor = true;
            this.jueves.Click += new System.EventHandler(this.jueves_Click);
            // 
            // viernes
            // 
            this.viernes.Location = new System.Drawing.Point(32, 255);
            this.viernes.Name = "viernes";
            this.viernes.Size = new System.Drawing.Size(116, 33);
            this.viernes.TabIndex = 4;
            this.viernes.Text = "Viernes";
            this.viernes.UseVisualStyleBackColor = true;
            this.viernes.Click += new System.EventHandler(this.viernes_Click);
            // 
            // sabado
            // 
            this.sabado.Location = new System.Drawing.Point(32, 311);
            this.sabado.Name = "sabado";
            this.sabado.Size = new System.Drawing.Size(116, 33);
            this.sabado.TabIndex = 5;
            this.sabado.Text = "Sábado";
            this.sabado.UseVisualStyleBackColor = true;
            this.sabado.Click += new System.EventHandler(this.sabado_Click);
            // 
            // domingo
            // 
            this.domingo.Location = new System.Drawing.Point(32, 366);
            this.domingo.Name = "domingo";
            this.domingo.Size = new System.Drawing.Size(116, 33);
            this.domingo.TabIndex = 6;
            this.domingo.Text = "Domingo";
            this.domingo.UseVisualStyleBackColor = true;
            this.domingo.Click += new System.EventHandler(this.domingo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.dia);
            this.panel1.Location = new System.Drawing.Point(179, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 445);
            this.panel1.TabIndex = 7;
            // 
            // dia
            // 
            this.dia.AutoSize = true;
            this.dia.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.dia.Location = new System.Drawing.Point(26, 148);
            this.dia.Name = "dia";
            this.dia.Size = new System.Drawing.Size(0, 58);
            this.dia.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 439);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.domingo);
            this.Controls.Add(this.sabado);
            this.Controls.Add(this.viernes);
            this.Controls.Add(this.jueves);
            this.Controls.Add(this.miercoles);
            this.Controls.Add(this.martes);
            this.Controls.Add(this.lunes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lunes;
        private System.Windows.Forms.Button martes;
        private System.Windows.Forms.Button miercoles;
        private System.Windows.Forms.Button jueves;
        private System.Windows.Forms.Button viernes;
        private System.Windows.Forms.Button sabado;
        private System.Windows.Forms.Button domingo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label dia;
    }
}

