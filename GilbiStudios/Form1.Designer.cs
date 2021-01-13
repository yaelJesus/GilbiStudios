
namespace GilbiStudios
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
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbTabla = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(12, 12);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(92, 48);
            this.btnConsulta.TabIndex = 0;
            this.btnConsulta.Text = "Ejecutar Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(121, 12);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(77, 48);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Ejecutar Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 280);
            this.dataGridView1.TabIndex = 2;
            // 
            // cbTabla
            // 
            this.cbTabla.FormattingEnabled = true;
            this.cbTabla.Items.AddRange(new object[] {
            "Actor",
            "Animacion",
            "Animador",
            "Animatic2D",
            "ArteConceptual",
            "Artista",
            "AsistenteAnimacion",
            "Cambio",
            "Colaboracion",
            "ColorSprit",
            "Compositing",
            "CorreccionColor",
            "DiaPresentacion",
            "Directivo",
            "Director",
            "Esqueletizacion",
            "ExhibiciónInternacional",
            "ExhibiciónNacional",
            "Fondista",
            "FXPersonaje",
            "Gerente",
            "GrabacionVoz",
            "Guion",
            "Guionista",
            "Idea",
            "Iluminacion",
            "Ingreso",
            "JuntaDirectiva",
            "Layout",
            "Masterizacion",
            "MattePainting",
            "Modelado",
            "Musica",
            "Musico",
            "Patrocinador",
            "Pelicula",
            "PostProduccion",
            "PreExhibicion",
            "Presupuesto",
            "Productor",
            "Publicidad",
            "PulidoCámara",
            "Rediseño",
            "Revision",
            "SetDressing",
            "SFX",
            "StoryBoard",
            "Tecnico",
            "TexturizadoShading",
            "VFX",
            "ActorGrabacionVoz",
            "CambioDirectivo",
            "ExhibicionInternacionalIngreso",
            "ExhibicionNacionalIngreso"});
            this.cbTabla.Location = new System.Drawing.Point(218, 27);
            this.cbTabla.Name = "cbTabla";
            this.cbTabla.Size = new System.Drawing.Size(121, 21);
            this.cbTabla.TabIndex = 3;
            this.cbTabla.Text = "-Selecione la tabla-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbTabla);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnConsulta);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbTabla;
    }
}

