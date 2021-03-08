
namespace CSharpCalculadora
{
    partial class CSharpCalculadora
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Reiniciar = new System.Windows.Forms.Button();
            this.Borrar = new System.Windows.Forms.Button();
            this.Quitar = new System.Windows.Forms.Button();
            this.Signo = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.Uno = new System.Windows.Forms.Button();
            this.Dos = new System.Windows.Forms.Button();
            this.Tres = new System.Windows.Forms.Button();
            this.Seis = new System.Windows.Forms.Button();
            this.Operar = new System.Windows.Forms.Button();
            this.Sumar = new System.Windows.Forms.Button();
            this.Cinco = new System.Windows.Forms.Button();
            this.Nueve = new System.Windows.Forms.Button();
            this.Cuatro = new System.Windows.Forms.Button();
            this.Ocho = new System.Windows.Forms.Button();
            this.Siete = new System.Windows.Forms.Button();
            this.Dividir = new System.Windows.Forms.Button();
            this.Multiplicar = new System.Windows.Forms.Button();
            this.Restar = new System.Windows.Forms.Button();
            this.Decimal = new System.Windows.Forms.Button();
            this.View = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Reiniciar);
            this.panel1.Controls.Add(this.Borrar);
            this.panel1.Controls.Add(this.Quitar);
            this.panel1.Controls.Add(this.Signo);
            this.panel1.Controls.Add(this.Zero);
            this.panel1.Controls.Add(this.Uno);
            this.panel1.Controls.Add(this.Dos);
            this.panel1.Controls.Add(this.Tres);
            this.panel1.Controls.Add(this.Seis);
            this.panel1.Controls.Add(this.Operar);
            this.panel1.Controls.Add(this.Sumar);
            this.panel1.Controls.Add(this.Cinco);
            this.panel1.Controls.Add(this.Nueve);
            this.panel1.Controls.Add(this.Cuatro);
            this.panel1.Controls.Add(this.Ocho);
            this.panel1.Controls.Add(this.Siete);
            this.panel1.Controls.Add(this.Dividir);
            this.panel1.Controls.Add(this.Multiplicar);
            this.panel1.Controls.Add(this.Restar);
            this.panel1.Controls.Add(this.Decimal);
            this.panel1.Location = new System.Drawing.Point(12, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 147);
            this.panel1.TabIndex = 1;
            // 
            // Reiniciar
            // 
            this.Reiniciar.Location = new System.Drawing.Point(5, 4);
            this.Reiniciar.Name = "Reiniciar";
            this.Reiniciar.Size = new System.Drawing.Size(75, 23);
            this.Reiniciar.TabIndex = 19;
            this.Reiniciar.Text = "CE";
            this.Reiniciar.UseVisualStyleBackColor = true;
            this.Reiniciar.Click += new System.EventHandler(this.ButtonReiniciar_Click);
            // 
            // Borrar
            // 
            this.Borrar.Location = new System.Drawing.Point(86, 3);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(75, 23);
            this.Borrar.TabIndex = 18;
            this.Borrar.Text = "C";
            this.Borrar.UseVisualStyleBackColor = true;
            this.Borrar.Click += new System.EventHandler(this.ButtonBorrar_Click);
            // 
            // Quitar
            // 
            this.Quitar.Location = new System.Drawing.Point(167, 4);
            this.Quitar.Name = "Quitar";
            this.Quitar.Size = new System.Drawing.Size(75, 23);
            this.Quitar.TabIndex = 17;
            this.Quitar.Text = "DEL";
            this.Quitar.UseVisualStyleBackColor = true;
            this.Quitar.Click += new System.EventHandler(this.ButtonQuitar_Click);
            // 
            // Signo
            // 
            this.Signo.Location = new System.Drawing.Point(5, 120);
            this.Signo.Name = "Signo";
            this.Signo.Size = new System.Drawing.Size(75, 23);
            this.Signo.TabIndex = 16;
            this.Signo.Text = "+/-";
            this.Signo.UseVisualStyleBackColor = true;
            // 
            // Zero
            // 
            this.Zero.Location = new System.Drawing.Point(86, 120);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(75, 23);
            this.Zero.TabIndex = 15;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.ButtonNumero_Click);
            // 
            // Uno
            // 
            this.Uno.Location = new System.Drawing.Point(167, 91);
            this.Uno.Name = "Uno";
            this.Uno.Size = new System.Drawing.Size(75, 23);
            this.Uno.TabIndex = 14;
            this.Uno.Text = "1";
            this.Uno.UseVisualStyleBackColor = true;
            this.Uno.Click += new System.EventHandler(this.ButtonNumero_Click);
            // 
            // Dos
            // 
            this.Dos.Location = new System.Drawing.Point(86, 91);
            this.Dos.Name = "Dos";
            this.Dos.Size = new System.Drawing.Size(75, 23);
            this.Dos.TabIndex = 13;
            this.Dos.Text = "2";
            this.Dos.UseVisualStyleBackColor = true;
            this.Dos.Click += new System.EventHandler(this.ButtonNumero_Click);
            // 
            // Tres
            // 
            this.Tres.Location = new System.Drawing.Point(5, 91);
            this.Tres.Name = "Tres";
            this.Tres.Size = new System.Drawing.Size(75, 23);
            this.Tres.TabIndex = 12;
            this.Tres.Text = "3";
            this.Tres.UseVisualStyleBackColor = true;
            this.Tres.Click += new System.EventHandler(this.ButtonNumero_Click);
            // 
            // Seis
            // 
            this.Seis.Location = new System.Drawing.Point(5, 62);
            this.Seis.Name = "Seis";
            this.Seis.Size = new System.Drawing.Size(75, 23);
            this.Seis.TabIndex = 8;
            this.Seis.Text = "6";
            this.Seis.UseVisualStyleBackColor = true;
            this.Seis.Click += new System.EventHandler(this.ButtonNumero_Click);
            // 
            // Operar
            // 
            this.Operar.Location = new System.Drawing.Point(248, 120);
            this.Operar.Name = "Operar";
            this.Operar.Size = new System.Drawing.Size(75, 23);
            this.Operar.TabIndex = 11;
            this.Operar.Text = "=";
            this.Operar.UseVisualStyleBackColor = true;
            // 
            // Sumar
            // 
            this.Sumar.Location = new System.Drawing.Point(248, 91);
            this.Sumar.Name = "Sumar";
            this.Sumar.Size = new System.Drawing.Size(75, 23);
            this.Sumar.TabIndex = 7;
            this.Sumar.Text = "+";
            this.Sumar.UseVisualStyleBackColor = true;
            // 
            // Cinco
            // 
            this.Cinco.Location = new System.Drawing.Point(86, 62);
            this.Cinco.Name = "Cinco";
            this.Cinco.Size = new System.Drawing.Size(75, 23);
            this.Cinco.TabIndex = 9;
            this.Cinco.Text = "5";
            this.Cinco.UseVisualStyleBackColor = true;
            this.Cinco.Click += new System.EventHandler(this.ButtonNumero_Click);
            // 
            // Nueve
            // 
            this.Nueve.Location = new System.Drawing.Point(167, 33);
            this.Nueve.Name = "Nueve";
            this.Nueve.Size = new System.Drawing.Size(75, 23);
            this.Nueve.TabIndex = 6;
            this.Nueve.Text = "9";
            this.Nueve.UseVisualStyleBackColor = true;
            this.Nueve.Click += new System.EventHandler(this.ButtonNumero_Click);
            // 
            // Cuatro
            // 
            this.Cuatro.Location = new System.Drawing.Point(167, 62);
            this.Cuatro.Name = "Cuatro";
            this.Cuatro.Size = new System.Drawing.Size(75, 23);
            this.Cuatro.TabIndex = 10;
            this.Cuatro.Text = "4";
            this.Cuatro.UseVisualStyleBackColor = true;
            this.Cuatro.Click += new System.EventHandler(this.ButtonNumero_Click);
            // 
            // Ocho
            // 
            this.Ocho.Location = new System.Drawing.Point(86, 33);
            this.Ocho.Name = "Ocho";
            this.Ocho.Size = new System.Drawing.Size(75, 23);
            this.Ocho.TabIndex = 5;
            this.Ocho.Text = "8";
            this.Ocho.UseVisualStyleBackColor = true;
            this.Ocho.Click += new System.EventHandler(this.ButtonNumero_Click);
            // 
            // Siete
            // 
            this.Siete.Location = new System.Drawing.Point(5, 33);
            this.Siete.Name = "Siete";
            this.Siete.Size = new System.Drawing.Size(75, 23);
            this.Siete.TabIndex = 4;
            this.Siete.Text = "7";
            this.Siete.UseVisualStyleBackColor = true;
            this.Siete.Click += new System.EventHandler(this.ButtonNumero_Click);
            // 
            // Dividir
            // 
            this.Dividir.Location = new System.Drawing.Point(248, 4);
            this.Dividir.Name = "Dividir";
            this.Dividir.Size = new System.Drawing.Size(75, 23);
            this.Dividir.TabIndex = 1;
            this.Dividir.Text = "/";
            this.Dividir.UseVisualStyleBackColor = true;
            // 
            // Multiplicar
            // 
            this.Multiplicar.Location = new System.Drawing.Point(248, 33);
            this.Multiplicar.Name = "Multiplicar";
            this.Multiplicar.Size = new System.Drawing.Size(75, 23);
            this.Multiplicar.TabIndex = 2;
            this.Multiplicar.Text = "*";
            this.Multiplicar.UseVisualStyleBackColor = true;
            // 
            // Restar
            // 
            this.Restar.Location = new System.Drawing.Point(249, 62);
            this.Restar.Name = "Restar";
            this.Restar.Size = new System.Drawing.Size(75, 23);
            this.Restar.TabIndex = 3;
            this.Restar.Text = "-";
            this.Restar.UseVisualStyleBackColor = true;
            // 
            // Decimal
            // 
            this.Decimal.Location = new System.Drawing.Point(167, 120);
            this.Decimal.Name = "Decimal";
            this.Decimal.Size = new System.Drawing.Size(75, 23);
            this.Decimal.TabIndex = 0;
            this.Decimal.Text = ",";
            this.Decimal.UseVisualStyleBackColor = true;
            // 
            // View
            // 
            this.View.Location = new System.Drawing.Point(12, 13);
            this.View.Multiline = true;
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(324, 100);
            this.View.TabIndex = 2;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 276);
            this.Controls.Add(this.View);
            this.Controls.Add(this.panel1);
            this.Name = "Calculadora";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Decimal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Operar;
        private System.Windows.Forms.Button Cuatro;
        private System.Windows.Forms.Button Cinco;
        private System.Windows.Forms.Button Seis;
        private System.Windows.Forms.Button Sumar;
        private System.Windows.Forms.Button Nueve;
        private System.Windows.Forms.Button Ocho;
        private System.Windows.Forms.Button Siete;
        private System.Windows.Forms.Button Restar;
        private System.Windows.Forms.Button Multiplicar;
        private System.Windows.Forms.Button Dividir;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.Button Quitar;
        private System.Windows.Forms.Button Signo;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button Uno;
        private System.Windows.Forms.Button Dos;
        private System.Windows.Forms.Button Tres;
        private System.Windows.Forms.Button Reiniciar;
        private System.Windows.Forms.TextBox View;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

