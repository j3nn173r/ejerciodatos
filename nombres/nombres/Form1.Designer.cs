
namespace nombres
{
    partial class name1resultado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(name1resultado));
            this.buttonArreglosss = new System.Windows.Forms.Button();
            this.buttonCargarArchivos = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.button2PROMEDIO = new System.Windows.Forms.Button();
            this.button2general = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonArreglosss
            // 
            this.buttonArreglosss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonArreglosss.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonArreglosss.Location = new System.Drawing.Point(25, 407);
            this.buttonArreglosss.Name = "buttonArreglosss";
            this.buttonArreglosss.Size = new System.Drawing.Size(116, 41);
            this.buttonArreglosss.TabIndex = 0;
            this.buttonArreglosss.Text = "ARREGLOS";
            this.buttonArreglosss.UseVisualStyleBackColor = false;
            this.buttonArreglosss.Click += new System.EventHandler(this.buttonArreglosss_Click);
            // 
            // buttonCargarArchivos
            // 
            this.buttonCargarArchivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonCargarArchivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCargarArchivos.ForeColor = System.Drawing.Color.Black;
            this.buttonCargarArchivos.Location = new System.Drawing.Point(12, 49);
            this.buttonCargarArchivos.Name = "buttonCargarArchivos";
            this.buttonCargarArchivos.Size = new System.Drawing.Size(109, 61);
            this.buttonCargarArchivos.TabIndex = 2;
            this.buttonCargarArchivos.Text = "Cargar archivos";
            this.buttonCargarArchivos.UseVisualStyleBackColor = false;
            this.buttonCargarArchivos.Click += new System.EventHandler(this.buttonCargarArchivos_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(353, 352);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.Location = new System.Drawing.Point(535, 21);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(510, 329);
            this.listBoxResultado.TabIndex = 4;
            // 
            // button2PROMEDIO
            // 
            this.button2PROMEDIO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2PROMEDIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2PROMEDIO.ForeColor = System.Drawing.Color.Black;
            this.button2PROMEDIO.Location = new System.Drawing.Point(5, 116);
            this.button2PROMEDIO.Name = "button2PROMEDIO";
            this.button2PROMEDIO.Size = new System.Drawing.Size(116, 91);
            this.button2PROMEDIO.TabIndex = 5;
            this.button2PROMEDIO.Text = "promedio por alumno";
            this.button2PROMEDIO.UseVisualStyleBackColor = false;
            this.button2PROMEDIO.Click += new System.EventHandler(this.button2PROMEDIO_Click);
            // 
            // button2general
            // 
            this.button2general.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2general.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2general.ForeColor = System.Drawing.Color.Black;
            this.button2general.Location = new System.Drawing.Point(9, 213);
            this.button2general.Name = "button2general";
            this.button2general.Size = new System.Drawing.Size(112, 64);
            this.button2general.TabIndex = 6;
            this.button2general.Text = "general promedio";
            this.button2general.UseVisualStyleBackColor = false;
            this.button2general.Click += new System.EventHandler(this.button2general_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(9, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 102);
            this.button2.TabIndex = 7;
            this.button2.Text = "maximo  y minimo";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // name1resultado
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1057, 476);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button2general);
            this.Controls.Add(this.button2PROMEDIO);
            this.Controls.Add(this.listBoxResultado);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonCargarArchivos);
            this.Controls.Add(this.buttonArreglosss);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "name1resultado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1resultado;
        private System.Windows.Forms.TextBox textBox1resultado;
        private System.Windows.Forms.Button button2cargararchivo;
        private System.Windows.Forms.Button buttonArreglosss;
        private System.Windows.Forms.Button buttonCargarArchivos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBoxResultado;
        private System.Windows.Forms.Button button2PROMEDIO;
        private System.Windows.Forms.Button button2general;
        private System.Windows.Forms.Button button2;
    }
}

