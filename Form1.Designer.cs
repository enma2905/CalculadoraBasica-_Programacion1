namespace CalculadoraBasica1
{
    partial class txtnum1
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
            this.components = new System.ComponentModel.Container();
            this.textnum1 = new System.Windows.Forms.TextBox();
            this.textnum2 = new System.Windows.Forms.TextBox();
            this.textnum3 = new System.Windows.Forms.TextBox();
            this.textnum4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_sumar = new System.Windows.Forms.Button();
            this.btn_restar = new System.Windows.Forms.Button();
            this.btn_multiplicar = new System.Windows.Forms.Button();
            this.btn_dividir = new System.Windows.Forms.Button();
            this.ErrorEncontrado = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorEncontrado)).BeginInit();
            this.SuspendLayout();
            // 
            // textnum1
            // 
            this.textnum1.Location = new System.Drawing.Point(28, 53);
            this.textnum1.Name = "textnum1";
            this.textnum1.Size = new System.Drawing.Size(148, 22);
            this.textnum1.TabIndex = 0;
            // 
            // textnum2
            // 
            this.textnum2.Location = new System.Drawing.Point(28, 133);
            this.textnum2.Name = "textnum2";
            this.textnum2.Size = new System.Drawing.Size(147, 22);
            this.textnum2.TabIndex = 1;
            // 
            // textnum3
            // 
            this.textnum3.Location = new System.Drawing.Point(28, 217);
            this.textnum3.Name = "textnum3";
            this.textnum3.Size = new System.Drawing.Size(148, 22);
            this.textnum3.TabIndex = 2;
            // 
            // textnum4
            // 
            this.textnum4.Location = new System.Drawing.Point(28, 315);
            this.textnum4.Name = "textnum4";
            this.textnum4.Size = new System.Drawing.Size(148, 22);
            this.textnum4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "1er.Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "2do.Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "3er.Numero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "4to.Numero";
            // 
            // btn_sumar
            // 
            this.btn_sumar.Location = new System.Drawing.Point(301, 33);
            this.btn_sumar.Name = "btn_sumar";
            this.btn_sumar.Size = new System.Drawing.Size(128, 42);
            this.btn_sumar.TabIndex = 8;
            this.btn_sumar.Text = "SUMAR";
            this.btn_sumar.UseVisualStyleBackColor = true;
            // 
            // btn_restar
            // 
            this.btn_restar.Location = new System.Drawing.Point(307, 114);
            this.btn_restar.Name = "btn_restar";
            this.btn_restar.Size = new System.Drawing.Size(122, 41);
            this.btn_restar.TabIndex = 9;
            this.btn_restar.Text = "RESTAR";
            this.btn_restar.UseVisualStyleBackColor = true;
            // 
            // btn_multiplicar
            // 
            this.btn_multiplicar.Location = new System.Drawing.Point(307, 198);
            this.btn_multiplicar.Name = "btn_multiplicar";
            this.btn_multiplicar.Size = new System.Drawing.Size(121, 41);
            this.btn_multiplicar.TabIndex = 10;
            this.btn_multiplicar.Text = "MULTIPLICAR";
            this.btn_multiplicar.UseVisualStyleBackColor = true;
            // 
            // btn_dividir
            // 
            this.btn_dividir.Location = new System.Drawing.Point(307, 296);
            this.btn_dividir.Name = "btn_dividir";
            this.btn_dividir.Size = new System.Drawing.Size(121, 41);
            this.btn_dividir.TabIndex = 11;
            this.btn_dividir.Text = "DIVIDIR";
            this.btn_dividir.UseVisualStyleBackColor = true;
            // 
            // ErrorEncontrado
            // 
            this.ErrorEncontrado.ContainerControl = this;
            // 
            // txtnum1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 450);
            this.Controls.Add(this.btn_dividir);
            this.Controls.Add(this.btn_multiplicar);
            this.Controls.Add(this.btn_restar);
            this.Controls.Add(this.btn_sumar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textnum4);
            this.Controls.Add(this.textnum3);
            this.Controls.Add(this.textnum2);
            this.Controls.Add(this.textnum1);
            this.Name = "txtnum1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorEncontrado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textnum1;
        private System.Windows.Forms.TextBox textnum2;
        private System.Windows.Forms.TextBox textnum3;
        private System.Windows.Forms.TextBox textnum4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_sumar;
        private System.Windows.Forms.Button btn_restar;
        private System.Windows.Forms.Button btn_multiplicar;
        private System.Windows.Forms.Button btn_dividir;
        private System.Windows.Forms.ErrorProvider ErrorEncontrado;
    }
}

