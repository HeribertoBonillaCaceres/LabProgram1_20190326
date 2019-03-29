namespace WindowsFormsApplication1
{
    partial class frmOperaciones
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbGrupoA = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblValA = new System.Windows.Forms.Label();
            this.lblValB = new System.Windows.Forms.Label();
            this.lblResul = new System.Windows.Forms.Label();
            this.txtValB = new System.Windows.Forms.TextBox();
            this.txtValA = new System.Windows.Forms.TextBox();
            this.txtResul = new System.Windows.Forms.TextBox();
            this.grbGrupoA.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbGrupoA
            // 
            this.grbGrupoA.Controls.Add(this.txtResul);
            this.grbGrupoA.Controls.Add(this.txtValA);
            this.grbGrupoA.Controls.Add(this.txtValB);
            this.grbGrupoA.Controls.Add(this.lblResul);
            this.grbGrupoA.Controls.Add(this.lblValB);
            this.grbGrupoA.Controls.Add(this.lblValA);
            this.grbGrupoA.Controls.Add(this.btnCalcular);
            this.grbGrupoA.Location = new System.Drawing.Point(146, 46);
            this.grbGrupoA.Name = "grbGrupoA";
            this.grbGrupoA.Size = new System.Drawing.Size(225, 227);
            this.grbGrupoA.TabIndex = 0;
            this.grbGrupoA.TabStop = false;
            this.grbGrupoA.Text = "groupBox1";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(74, 141);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblValA
            // 
            this.lblValA.AutoSize = true;
            this.lblValA.Location = new System.Drawing.Point(35, 41);
            this.lblValA.Name = "lblValA";
            this.lblValA.Size = new System.Drawing.Size(41, 13);
            this.lblValA.TabIndex = 1;
            this.lblValA.Text = "Valor A";
            // 
            // lblValB
            // 
            this.lblValB.AutoSize = true;
            this.lblValB.Location = new System.Drawing.Point(35, 70);
            this.lblValB.Name = "lblValB";
            this.lblValB.Size = new System.Drawing.Size(41, 13);
            this.lblValB.TabIndex = 2;
            this.lblValB.Text = "Valor B";
            // 
            // lblResul
            // 
            this.lblResul.AutoSize = true;
            this.lblResul.Location = new System.Drawing.Point(35, 106);
            this.lblResul.Name = "lblResul";
            this.lblResul.Size = new System.Drawing.Size(55, 13);
            this.lblResul.TabIndex = 3;
            this.lblResul.Text = "Resultado";
            // 
            // txtValB
            // 
            this.txtValB.Location = new System.Drawing.Point(96, 68);
            this.txtValB.Name = "txtValB";
            this.txtValB.Size = new System.Drawing.Size(100, 20);
            this.txtValB.TabIndex = 4;
            // 
            // txtValA
            // 
            this.txtValA.Location = new System.Drawing.Point(96, 36);
            this.txtValA.Name = "txtValA";
            this.txtValA.Size = new System.Drawing.Size(100, 20);
            this.txtValA.TabIndex = 5;
            // 
            // txtResul
            // 
            this.txtResul.Location = new System.Drawing.Point(96, 103);
            this.txtResul.Name = "txtResul";
            this.txtResul.Size = new System.Drawing.Size(100, 20);
            this.txtResul.TabIndex = 6;
            // 
            // frmOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 331);
            this.Controls.Add(this.grbGrupoA);
            this.Name = "frmOperaciones";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmOperaciones_Load);
            this.grbGrupoA.ResumeLayout(false);
            this.grbGrupoA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbGrupoA;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblValB;
        private System.Windows.Forms.Label lblValA;
        private System.Windows.Forms.Label lblResul;
        private System.Windows.Forms.TextBox txtResul;
        private System.Windows.Forms.TextBox txtValA;
        private System.Windows.Forms.TextBox txtValB;
    }
}

