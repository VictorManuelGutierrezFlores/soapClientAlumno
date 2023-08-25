namespace soapClientAlumno
{
    partial class AlumnosSW
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
            this.btnBienvenida = new System.Windows.Forms.Button();
            this.btnBuscarAlumno = new System.Windows.Forms.Button();
            this.BtnEvaluarAlumno = new System.Windows.Forms.Button();
            this.InputUsuario = new System.Windows.Forms.TextBox();
            this.InputContraseña = new System.Windows.Forms.TextBox();
            this.InputMatricula = new System.Windows.Forms.TextBox();
            this.EtqBienvenida = new System.Windows.Forms.Label();
            this.EtqMatricula = new System.Windows.Forms.Label();
            this.EtqContraseña = new System.Windows.Forms.Label();
            this.EtqUsuario = new System.Windows.Forms.Label();
            this.DisplayStatus = new System.Windows.Forms.TextBox();
            this.EtqStatus = new System.Windows.Forms.Label();
            this.EtqSemestre = new System.Windows.Forms.Label();
            this.InputSemestre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBienvenida
            // 
            this.btnBienvenida.Location = new System.Drawing.Point(393, 127);
            this.btnBienvenida.Name = "btnBienvenida";
            this.btnBienvenida.Size = new System.Drawing.Size(119, 45);
            this.btnBienvenida.TabIndex = 0;
            this.btnBienvenida.Text = "Bienvenida";
            this.btnBienvenida.UseVisualStyleBackColor = true;
            this.btnBienvenida.Click += new System.EventHandler(this.BtnBienvenida_Click);
            // 
            // btnBuscarAlumno
            // 
            this.btnBuscarAlumno.Location = new System.Drawing.Point(393, 184);
            this.btnBuscarAlumno.Name = "btnBuscarAlumno";
            this.btnBuscarAlumno.Size = new System.Drawing.Size(119, 45);
            this.btnBuscarAlumno.TabIndex = 1;
            this.btnBuscarAlumno.Text = "Buscar Alumno";
            this.btnBuscarAlumno.UseVisualStyleBackColor = true;
            // 
            // BtnEvaluarAlumno
            // 
            this.BtnEvaluarAlumno.Location = new System.Drawing.Point(393, 245);
            this.BtnEvaluarAlumno.Name = "BtnEvaluarAlumno";
            this.BtnEvaluarAlumno.Size = new System.Drawing.Size(119, 47);
            this.BtnEvaluarAlumno.TabIndex = 2;
            this.BtnEvaluarAlumno.Text = "Evaluar Alumno";
            this.BtnEvaluarAlumno.UseVisualStyleBackColor = true;
            this.BtnEvaluarAlumno.Click += new System.EventHandler(this.button1_Click);
            // 
            // InputUsuario
            // 
            this.InputUsuario.Location = new System.Drawing.Point(91, 111);
            this.InputUsuario.Name = "InputUsuario";
            this.InputUsuario.Size = new System.Drawing.Size(146, 20);
            this.InputUsuario.TabIndex = 3;
            // 
            // InputContraseña
            // 
            this.InputContraseña.Location = new System.Drawing.Point(91, 162);
            this.InputContraseña.Name = "InputContraseña";
            this.InputContraseña.Size = new System.Drawing.Size(146, 20);
            this.InputContraseña.TabIndex = 4;
            // 
            // InputMatricula
            // 
            this.InputMatricula.Location = new System.Drawing.Point(91, 219);
            this.InputMatricula.Name = "InputMatricula";
            this.InputMatricula.Size = new System.Drawing.Size(146, 20);
            this.InputMatricula.TabIndex = 5;
            // 
            // EtqBienvenida
            // 
            this.EtqBienvenida.AutoSize = true;
            this.EtqBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtqBienvenida.Location = new System.Drawing.Point(237, 35);
            this.EtqBienvenida.Name = "EtqBienvenida";
            this.EtqBienvenida.Size = new System.Drawing.Size(173, 37);
            this.EtqBienvenida.TabIndex = 6;
            this.EtqBienvenida.Text = "Bienvenido";
            this.EtqBienvenida.Click += new System.EventHandler(this.Label1_Click);
            // 
            // EtqMatricula
            // 
            this.EtqMatricula.AutoSize = true;
            this.EtqMatricula.Location = new System.Drawing.Point(91, 200);
            this.EtqMatricula.Name = "EtqMatricula";
            this.EtqMatricula.Size = new System.Drawing.Size(50, 13);
            this.EtqMatricula.TabIndex = 7;
            this.EtqMatricula.Text = "Matricula";
            this.EtqMatricula.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // EtqContraseña
            // 
            this.EtqContraseña.AutoSize = true;
            this.EtqContraseña.Location = new System.Drawing.Point(91, 143);
            this.EtqContraseña.Name = "EtqContraseña";
            this.EtqContraseña.Size = new System.Drawing.Size(61, 13);
            this.EtqContraseña.TabIndex = 8;
            this.EtqContraseña.Text = "Contraseña";
            // 
            // EtqUsuario
            // 
            this.EtqUsuario.AutoSize = true;
            this.EtqUsuario.Location = new System.Drawing.Point(94, 92);
            this.EtqUsuario.Name = "EtqUsuario";
            this.EtqUsuario.Size = new System.Drawing.Size(43, 13);
            this.EtqUsuario.TabIndex = 9;
            this.EtqUsuario.Text = "Usuario";
            // 
            // DisplayStatus
            // 
            this.DisplayStatus.Location = new System.Drawing.Point(154, 410);
            this.DisplayStatus.Multiline = true;
            this.DisplayStatus.Name = "DisplayStatus";
            this.DisplayStatus.ReadOnly = true;
            this.DisplayStatus.Size = new System.Drawing.Size(256, 129);
            this.DisplayStatus.TabIndex = 10;
            // 
            // EtqStatus
            // 
            this.EtqStatus.AutoSize = true;
            this.EtqStatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EtqStatus.Location = new System.Drawing.Point(162, 379);
            this.EtqStatus.Name = "EtqStatus";
            this.EtqStatus.Size = new System.Drawing.Size(60, 18);
            this.EtqStatus.TabIndex = 11;
            this.EtqStatus.Text = "Status";
            this.EtqStatus.Click += new System.EventHandler(this.EtqStatus_Click);
            // 
            // EtqSemestre
            // 
            this.EtqSemestre.AutoSize = true;
            this.EtqSemestre.Location = new System.Drawing.Point(94, 257);
            this.EtqSemestre.Name = "EtqSemestre";
            this.EtqSemestre.Size = new System.Drawing.Size(51, 13);
            this.EtqSemestre.TabIndex = 12;
            this.EtqSemestre.Text = "Semestre";
            this.EtqSemestre.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // InputSemestre
            // 
            this.InputSemestre.Location = new System.Drawing.Point(91, 284);
            this.InputSemestre.Name = "InputSemestre";
            this.InputSemestre.Size = new System.Drawing.Size(146, 20);
            this.InputSemestre.TabIndex = 13;
            // 
            // AlumnosSW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 624);
            this.Controls.Add(this.InputSemestre);
            this.Controls.Add(this.EtqSemestre);
            this.Controls.Add(this.EtqStatus);
            this.Controls.Add(this.DisplayStatus);
            this.Controls.Add(this.EtqUsuario);
            this.Controls.Add(this.EtqContraseña);
            this.Controls.Add(this.EtqMatricula);
            this.Controls.Add(this.EtqBienvenida);
            this.Controls.Add(this.InputMatricula);
            this.Controls.Add(this.InputContraseña);
            this.Controls.Add(this.InputUsuario);
            this.Controls.Add(this.BtnEvaluarAlumno);
            this.Controls.Add(this.btnBuscarAlumno);
            this.Controls.Add(this.btnBienvenida);
            this.Name = "AlumnosSW";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBienvenida;
        private System.Windows.Forms.Button btnBuscarAlumno;
        private System.Windows.Forms.Button BtnEvaluarAlumno;
        private System.Windows.Forms.TextBox InputUsuario;
        private System.Windows.Forms.TextBox InputContraseña;
        private System.Windows.Forms.TextBox InputMatricula;
        private System.Windows.Forms.Label EtqBienvenida;
        private System.Windows.Forms.Label EtqMatricula;
        private System.Windows.Forms.Label EtqContraseña;
        private System.Windows.Forms.Label EtqUsuario;
        private System.Windows.Forms.TextBox DisplayStatus;
        private System.Windows.Forms.Label EtqStatus;
        private System.Windows.Forms.Label EtqSemestre;
        private System.Windows.Forms.TextBox InputSemestre;
    }
}

