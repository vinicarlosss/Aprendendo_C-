namespace Aula61
{
    partial class F_principal
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
            this.lb_texto = new System.Windows.Forms.Label();
            this.btn_texto = new System.Windows.Forms.Button();
            this.tb_texto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_texto
            // 
            this.lb_texto.AutoSize = true;
            this.lb_texto.Location = new System.Drawing.Point(12, 109);
            this.lb_texto.Name = "lb_texto";
            this.lb_texto.Size = new System.Drawing.Size(134, 15);
            this.lb_texto.TabIndex = 3;
            this.lb_texto.Text = "youtube.com/cfbcursos";
            this.lb_texto.Click += new System.EventHandler(this.lb_linkcanal_Click);
            // 
            // btn_texto
            // 
            this.btn_texto.BackColor = System.Drawing.Color.Black;
            this.btn_texto.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_texto.ForeColor = System.Drawing.Color.Red;
            this.btn_texto.Location = new System.Drawing.Point(12, 43);
            this.btn_texto.Name = "btn_texto";
            this.btn_texto.Size = new System.Drawing.Size(235, 48);
            this.btn_texto.TabIndex = 2;
            this.btn_texto.Text = "OK";
            this.btn_texto.UseVisualStyleBackColor = false;
            this.btn_texto.Click += new System.EventHandler(this.btn_texto_Click);
            // 
            // tb_texto
            // 
            this.tb_texto.Location = new System.Drawing.Point(12, 12);
            this.tb_texto.Name = "tb_texto";
            this.tb_texto.Size = new System.Drawing.Size(235, 23);
            this.tb_texto.TabIndex = 4;
            // 
            // F_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_texto);
            this.Controls.Add(this.lb_texto);
            this.Controls.Add(this.btn_texto);
            this.Name = "F_principal";
            this.Text = "Curso de C# - CFB Cursos";
            this.Load += new System.EventHandler(this.F_principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_texto;
        private Button btn_texto;
        private TextBox tb_texto;
    }
}