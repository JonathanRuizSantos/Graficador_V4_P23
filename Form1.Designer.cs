namespace GraficadorV1_P20
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxEntrada = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxfx = new System.Windows.Forms.TextBox();
            this.textBoxxf = new System.Windows.Forms.TextBox();
            this.textBoxxi = new System.Windows.Forms.TextBox();
            this.groupBoxProceso = new System.Windows.Forms.GroupBox();
            this.buttonGraficar = new System.Windows.Forms.Button();
            this.groupBoxSalida = new System.Windows.Forms.GroupBox();
            this.listBoxSalida = new System.Windows.Forms.ListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btGP = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxEntrada.SuspendLayout();
            this.groupBoxProceso.SuspendLayout();
            this.groupBoxSalida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEntrada
            // 
            this.groupBoxEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBoxEntrada.Controls.Add(this.textBox1);
            this.groupBoxEntrada.Controls.Add(this.label3);
            this.groupBoxEntrada.Controls.Add(this.label2);
            this.groupBoxEntrada.Controls.Add(this.label1);
            this.groupBoxEntrada.Controls.Add(this.textBoxfx);
            this.groupBoxEntrada.Controls.Add(this.textBoxxf);
            this.groupBoxEntrada.Controls.Add(this.textBoxxi);
            this.groupBoxEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEntrada.Location = new System.Drawing.Point(28, 59);
            this.groupBoxEntrada.Name = "groupBoxEntrada";
            this.groupBoxEntrada.Size = new System.Drawing.Size(242, 710);
            this.groupBoxEntrada.TabIndex = 0;
            this.groupBoxEntrada.TabStop = false;
            this.groupBoxEntrada.Text = "Entrada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "f(x)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Xf";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Xi";
            // 
            // textBoxfx
            // 
            this.textBoxfx.Location = new System.Drawing.Point(90, 129);
            this.textBoxfx.Name = "textBoxfx";
            this.textBoxfx.Size = new System.Drawing.Size(128, 27);
            this.textBoxfx.TabIndex = 2;
            this.textBoxfx.Text = "x";
            this.textBoxfx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxxf
            // 
            this.textBoxxf.Location = new System.Drawing.Point(90, 85);
            this.textBoxxf.Name = "textBoxxf";
            this.textBoxxf.Size = new System.Drawing.Size(128, 27);
            this.textBoxxf.TabIndex = 1;
            this.textBoxxf.Text = "0";
            this.textBoxxf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxxi
            // 
            this.textBoxxi.Location = new System.Drawing.Point(90, 40);
            this.textBoxxi.Name = "textBoxxi";
            this.textBoxxi.Size = new System.Drawing.Size(128, 27);
            this.textBoxxi.TabIndex = 0;
            this.textBoxxi.Text = "0";
            this.textBoxxi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBoxProceso
            // 
            this.groupBoxProceso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBoxProceso.Controls.Add(this.btGP);
            this.groupBoxProceso.Controls.Add(this.buttonGraficar);
            this.groupBoxProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProceso.Location = new System.Drawing.Point(286, 59);
            this.groupBoxProceso.Name = "groupBoxProceso";
            this.groupBoxProceso.Size = new System.Drawing.Size(242, 710);
            this.groupBoxProceso.TabIndex = 1;
            this.groupBoxProceso.TabStop = false;
            this.groupBoxProceso.Text = "Proceso";
            // 
            // buttonGraficar
            // 
            this.buttonGraficar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonGraficar.Location = new System.Drawing.Point(23, 40);
            this.buttonGraficar.Name = "buttonGraficar";
            this.buttonGraficar.Size = new System.Drawing.Size(185, 42);
            this.buttonGraficar.TabIndex = 0;
            this.buttonGraficar.Text = "Graficar y=f(x)";
            this.buttonGraficar.UseVisualStyleBackColor = false;
            this.buttonGraficar.Click += new System.EventHandler(this.buttonGraficar_Click);
            // 
            // groupBoxSalida
            // 
            this.groupBoxSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBoxSalida.Controls.Add(this.listBoxSalida);
            this.groupBoxSalida.Controls.Add(this.chart1);
            this.groupBoxSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSalida.Location = new System.Drawing.Point(548, 59);
            this.groupBoxSalida.Name = "groupBoxSalida";
            this.groupBoxSalida.Size = new System.Drawing.Size(750, 710);
            this.groupBoxSalida.TabIndex = 1;
            this.groupBoxSalida.TabStop = false;
            this.groupBoxSalida.Text = "Salida";
            // 
            // listBoxSalida
            // 
            this.listBoxSalida.FormattingEnabled = true;
            this.listBoxSalida.ItemHeight = 20;
            this.listBoxSalida.Items.AddRange(new object[] {
            " "});
            this.listBoxSalida.Location = new System.Drawing.Point(6, 26);
            this.listBoxSalida.Name = "listBoxSalida";
            this.listBoxSalida.Size = new System.Drawing.Size(738, 244);
            this.listBoxSalida.TabIndex = 1;
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(19, 288);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.MarkerSize = 8;
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(710, 400);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1307, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firmaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // firmaToolStripMenuItem
            // 
            this.firmaToolStripMenuItem.Name = "firmaToolStripMenuItem";
            this.firmaToolStripMenuItem.Size = new System.Drawing.Size(147, 30);
            this.firmaToolStripMenuItem.Text = "Firma";
            this.firmaToolStripMenuItem.Click += new System.EventHandler(this.firmaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(147, 30);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // btGP
            // 
            this.btGP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btGP.Location = new System.Drawing.Point(23, 97);
            this.btGP.Name = "btGP";
            this.btGP.Size = new System.Drawing.Size(185, 42);
            this.btGP.TabIndex = 1;
            this.btGP.Text = "Graficas Polares";
            this.btGP.UseVisualStyleBackColor = false;
            this.btGP.Click += new System.EventHandler(this.btGP_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Lucida Calligraphy", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox1.Location = new System.Drawing.Point(15, 608);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 96);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "JRS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = global::GraficadorV1_P20.Properties.Resources.fondosmate;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1307, 781);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxSalida);
            this.Controls.Add(this.groupBoxProceso);
            this.Controls.Add(this.groupBoxEntrada);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Graficador V4 : f(x)";
            this.groupBoxEntrada.ResumeLayout(false);
            this.groupBoxEntrada.PerformLayout();
            this.groupBoxProceso.ResumeLayout(false);
            this.groupBoxSalida.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEntrada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxfx;
        private System.Windows.Forms.TextBox textBoxxf;
        private System.Windows.Forms.TextBox textBoxxi;
        private System.Windows.Forms.GroupBox groupBoxProceso;
        private System.Windows.Forms.Button buttonGraficar;
        private System.Windows.Forms.GroupBox groupBoxSalida;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxSalida;
        private System.Windows.Forms.Button btGP;
        private System.Windows.Forms.TextBox textBox1;
    }
}

