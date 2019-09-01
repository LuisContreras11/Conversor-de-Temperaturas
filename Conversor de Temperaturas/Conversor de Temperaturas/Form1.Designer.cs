namespace Conversor_de_Temperaturas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCen = new System.Windows.Forms.TextBox();
            this.txtFar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grados Centigrados:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grados Farenheit:";
            // 
            // txtCen
            // 
            this.txtCen.BackColor = System.Drawing.Color.LightCyan;
            this.txtCen.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCen.ForeColor = System.Drawing.Color.Teal;
            this.txtCen.Location = new System.Drawing.Point(404, 92);
            this.txtCen.Name = "txtCen";
            this.txtCen.Size = new System.Drawing.Size(367, 34);
            this.txtCen.TabIndex = 2;
            this.txtCen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCen.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.txtCen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCen_KeyPress);
            // 
            // txtFar
            // 
            this.txtFar.BackColor = System.Drawing.Color.LightCyan;
            this.txtFar.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFar.ForeColor = System.Drawing.Color.Teal;
            this.txtFar.Location = new System.Drawing.Point(404, 235);
            this.txtFar.Name = "txtFar";
            this.txtFar.Size = new System.Drawing.Size(367, 34);
            this.txtFar.TabIndex = 3;
            this.txtFar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFar_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(404, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(367, 63);
            this.button1.TabIndex = 4;
            this.button1.Text = "CONVERTIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFar);
            this.Controls.Add(this.txtCen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "TempCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCen;
        private System.Windows.Forms.TextBox txtFar;
        private System.Windows.Forms.Button button1;
    }
}

