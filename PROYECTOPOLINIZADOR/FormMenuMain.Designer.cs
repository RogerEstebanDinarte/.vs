namespace PROYECTOPOLINIZADOR
{
    partial class FormMenuMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnFlores = new System.Windows.Forms.Button();
            this.btnEspecies = new System.Windows.Forms.Button();
            this.btnAgente = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.floresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnFlores);
            this.panel1.Controls.Add(this.btnEspecies);
            this.panel1.Controls.Add(this.btnAgente);
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 646);
            this.panel1.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Lavender;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalir.Location = new System.Drawing.Point(40, 526);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(204, 78);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnFlores
            // 
            this.btnFlores.BackColor = System.Drawing.Color.LightSalmon;
            this.btnFlores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFlores.Location = new System.Drawing.Point(40, 356);
            this.btnFlores.Margin = new System.Windows.Forms.Padding(4);
            this.btnFlores.Name = "btnFlores";
            this.btnFlores.Size = new System.Drawing.Size(204, 86);
            this.btnFlores.TabIndex = 2;
            this.btnFlores.Text = "Flores";
            this.btnFlores.UseVisualStyleBackColor = false;
            this.btnFlores.Click += new System.EventHandler(this.btnFlores_Click);
            // 
            // btnEspecies
            // 
            this.btnEspecies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEspecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEspecies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEspecies.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnEspecies.Location = new System.Drawing.Point(40, 192);
            this.btnEspecies.Margin = new System.Windows.Forms.Padding(4);
            this.btnEspecies.Name = "btnEspecies";
            this.btnEspecies.Size = new System.Drawing.Size(204, 81);
            this.btnEspecies.TabIndex = 2;
            this.btnEspecies.Text = "Especies";
            this.btnEspecies.UseVisualStyleBackColor = false;
            this.btnEspecies.Click += new System.EventHandler(this.btnEspecies_Click);
            // 
            // btnAgente
            // 
            this.btnAgente.BackColor = System.Drawing.Color.LightYellow;
            this.btnAgente.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAgente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgente.Location = new System.Drawing.Point(40, 31);
            this.btnAgente.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgente.Name = "btnAgente";
            this.btnAgente.Size = new System.Drawing.Size(204, 80);
            this.btnAgente.TabIndex = 2;
            this.btnAgente.Text = "Agente Polinizador";
            this.btnAgente.UseVisualStyleBackColor = false;
            this.btnAgente.Click += new System.EventHandler(this.btnAgente_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agenteToolStripMenuItem,
            this.especiesToolStripMenuItem,
            this.floresToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1099, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agenteToolStripMenuItem
            // 
            this.agenteToolStripMenuItem.Name = "agenteToolStripMenuItem";
            this.agenteToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.agenteToolStripMenuItem.Text = "Agente";
            this.agenteToolStripMenuItem.Click += new System.EventHandler(this.agenteToolStripMenuItem_Click);
            // 
            // especiesToolStripMenuItem
            // 
            this.especiesToolStripMenuItem.Name = "especiesToolStripMenuItem";
            this.especiesToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.especiesToolStripMenuItem.Text = "Especies";
            this.especiesToolStripMenuItem.Click += new System.EventHandler(this.especiesToolStripMenuItem_Click);
            // 
            // floresToolStripMenuItem
            // 
            this.floresToolStripMenuItem.Name = "floresToolStripMenuItem";
            this.floresToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.floresToolStripMenuItem.Text = "Flores";
            this.floresToolStripMenuItem.Click += new System.EventHandler(this.floresToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.acercaDeToolStripMenuItem.Text = "Acerca De";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // FormMenuMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1099, 682);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMenuMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem floresToolStripMenuItem;
        private System.Windows.Forms.Button btnFlores;
        private System.Windows.Forms.Button btnEspecies;
        private System.Windows.Forms.Button btnAgente;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button btnSalir;
    }
}