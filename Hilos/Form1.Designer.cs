
namespace Hilos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nmrNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEsPrimo = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrNum)).BeginInit();
            this.SuspendLayout();
            // 
            // nmrNum
            // 
            this.nmrNum.Location = new System.Drawing.Point(12, 44);
            this.nmrNum.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nmrNum.Name = "nmrNum";
            this.nmrNum.Size = new System.Drawing.Size(236, 27);
            this.nmrNum.TabIndex = 0;
            this.nmrNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número";
            // 
            // btnEsPrimo
            // 
            this.btnEsPrimo.Location = new System.Drawing.Point(331, 44);
            this.btnEsPrimo.Name = "btnEsPrimo";
            this.btnEsPrimo.Size = new System.Drawing.Size(94, 29);
            this.btnEsPrimo.TabIndex = 2;
            this.btnEsPrimo.Text = "EsPrimo";
            this.btnEsPrimo.UseVisualStyleBackColor = true;
            this.btnEsPrimo.Click += new System.EventHandler(this.btnEsPrimo_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(263, 42);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(62, 29);
            this.btnMax.TabIndex = 3;
            this.btnMax.Text = "Max";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(74, 125);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(75, 20);
            this.lblMensaje.TabIndex = 4;
            this.lblMensaje.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnEsPrimo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmrNum);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nmrNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmrNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEsPrimo;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Label lblMensaje;
    }
}

