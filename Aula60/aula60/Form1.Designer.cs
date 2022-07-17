namespace aula60
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
            this.button1 = new System.Windows.Forms.Button();
            this.lb_linkcanal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(12, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "CFB Cursos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_linkcanal
            // 
            this.lb_linkcanal.AutoSize = true;
            this.lb_linkcanal.Location = new System.Drawing.Point(12, 9);
            this.lb_linkcanal.Name = "lb_linkcanal";
            this.lb_linkcanal.Size = new System.Drawing.Size(134, 15);
            this.lb_linkcanal.TabIndex = 1;
            this.lb_linkcanal.Text = "youtube.com/cfbcursos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_linkcanal);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Curso de C# - CFB Cursos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label lb_linkcanal;
    }
}