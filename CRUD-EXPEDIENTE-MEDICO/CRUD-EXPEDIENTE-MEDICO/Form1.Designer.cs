namespace CRUD_EXPEDIENTE_MEDICO
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.dgvinfo = new System.Windows.Forms.DataGridView();
            this.dgvidentidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvnombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvapellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtelefono2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvfechanac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvsexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvestado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvprocedencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvocupacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvfechaex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btncrear = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtciudad = new System.Windows.Forms.TextBox();
            this.dtpfechaexpediente = new System.Windows.Forms.DateTimePicker();
            this.txtocupacion = new System.Windows.Forms.TextBox();
            this.txtprocedencia = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.dtpfechaN = new System.Windows.Forms.DateTimePicker();
            this.cmbdepartamento = new System.Windows.Forms.ComboBox();
            this.cmbestadocivil = new System.Windows.Forms.ComboBox();
            this.rbfemenino = new System.Windows.Forms.RadioButton();
            this.rbmasculino = new System.Windows.Forms.RadioButton();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txttelefono2 = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.txtidentidad = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinfo)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expediente del Paciente";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-5, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1092, 814);
            this.panel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(17, 11);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1016, 68);
            this.panel5.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.dgvinfo);
            this.panel4.Location = new System.Drawing.Point(17, 521);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1016, 268);
            this.panel4.TabIndex = 6;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(3, 17);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(212, 20);
            this.label19.TabIndex = 35;
            this.label19.Text = "Informacion del paciente:";
            // 
            // dgvinfo
            // 
            this.dgvinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvidentidad,
            this.dgvnombres,
            this.dgvapellidos,
            this.dgvtelefono,
            this.dgvtelefono2,
            this.dgvemail,
            this.dgvfechanac,
            this.dgvsexo,
            this.dgvestado,
            this.dgvdepartamento,
            this.dgvciudad,
            this.dgvdireccion,
            this.dgvprocedencia,
            this.dgvocupacion,
            this.dgvfechaex});
            this.dgvinfo.Location = new System.Drawing.Point(6, 40);
            this.dgvinfo.Name = "dgvinfo";
            this.dgvinfo.Size = new System.Drawing.Size(992, 210);
            this.dgvinfo.TabIndex = 5;
            this.dgvinfo.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvinfo_CellMouseClick);
            // 
            // dgvidentidad
            // 
            this.dgvidentidad.HeaderText = "Identidad";
            this.dgvidentidad.Name = "dgvidentidad";
            // 
            // dgvnombres
            // 
            this.dgvnombres.HeaderText = "Nombres";
            this.dgvnombres.Name = "dgvnombres";
            // 
            // dgvapellidos
            // 
            this.dgvapellidos.HeaderText = "Apellidos";
            this.dgvapellidos.Name = "dgvapellidos";
            // 
            // dgvtelefono
            // 
            this.dgvtelefono.HeaderText = "Telefono";
            this.dgvtelefono.Name = "dgvtelefono";
            // 
            // dgvtelefono2
            // 
            this.dgvtelefono2.HeaderText = "Telefono";
            this.dgvtelefono2.Name = "dgvtelefono2";
            // 
            // dgvemail
            // 
            this.dgvemail.HeaderText = "Email";
            this.dgvemail.Name = "dgvemail";
            // 
            // dgvfechanac
            // 
            this.dgvfechanac.HeaderText = "Fecha nacimiento";
            this.dgvfechanac.Name = "dgvfechanac";
            // 
            // dgvsexo
            // 
            this.dgvsexo.HeaderText = "Sexo";
            this.dgvsexo.Name = "dgvsexo";
            // 
            // dgvestado
            // 
            this.dgvestado.HeaderText = "Estado Civil";
            this.dgvestado.Name = "dgvestado";
            // 
            // dgvdepartamento
            // 
            this.dgvdepartamento.HeaderText = "Departamento";
            this.dgvdepartamento.Name = "dgvdepartamento";
            // 
            // dgvciudad
            // 
            this.dgvciudad.HeaderText = "Ciudad";
            this.dgvciudad.Name = "dgvciudad";
            // 
            // dgvdireccion
            // 
            this.dgvdireccion.HeaderText = "Direccion";
            this.dgvdireccion.Name = "dgvdireccion";
            // 
            // dgvprocedencia
            // 
            this.dgvprocedencia.HeaderText = "Procedencia";
            this.dgvprocedencia.Name = "dgvprocedencia";
            // 
            // dgvocupacion
            // 
            this.dgvocupacion.HeaderText = "Ocupacion";
            this.dgvocupacion.Name = "dgvocupacion";
            // 
            // dgvfechaex
            // 
            this.dgvfechaex.HeaderText = "Fecha Expediente";
            this.dgvfechaex.Name = "dgvfechaex";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.btnlimpiar);
            this.panel3.Controls.Add(this.btneliminar);
            this.panel3.Controls.Add(this.btnactualizar);
            this.panel3.Controls.Add(this.btncrear);
            this.panel3.Location = new System.Drawing.Point(17, 400);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1016, 100);
            this.panel3.TabIndex = 3;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(815, 14);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(183, 69);
            this.btnlimpiar.TabIndex = 3;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(556, 14);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(183, 69);
            this.btneliminar.TabIndex = 2;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(284, 14);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(183, 69);
            this.btnactualizar.TabIndex = 1;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btncrear
            // 
            this.btncrear.Location = new System.Drawing.Point(22, 14);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(183, 69);
            this.btncrear.TabIndex = 0;
            this.btncrear.Text = "Crear";
            this.btncrear.UseVisualStyleBackColor = true;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.btnbuscar);
            this.panel2.Controls.Add(this.txtbuscar);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtciudad);
            this.panel2.Controls.Add(this.dtpfechaexpediente);
            this.panel2.Controls.Add(this.txtocupacion);
            this.panel2.Controls.Add(this.txtprocedencia);
            this.panel2.Controls.Add(this.txtdireccion);
            this.panel2.Controls.Add(this.dtpfechaN);
            this.panel2.Controls.Add(this.cmbdepartamento);
            this.panel2.Controls.Add(this.cmbestadocivil);
            this.panel2.Controls.Add(this.rbfemenino);
            this.panel2.Controls.Add(this.rbmasculino);
            this.panel2.Controls.Add(this.txtemail);
            this.panel2.Controls.Add(this.txttelefono2);
            this.panel2.Controls.Add(this.txttelefono);
            this.panel2.Controls.Add(this.txtapellidos);
            this.panel2.Controls.Add(this.txtnombres);
            this.panel2.Controls.Add(this.txtidentidad);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(17, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1016, 296);
            this.panel2.TabIndex = 2;
            // 
            // txtciudad
            // 
            this.txtciudad.Location = new System.Drawing.Point(456, 199);
            this.txtciudad.Name = "txtciudad";
            this.txtciudad.Size = new System.Drawing.Size(224, 20);
            this.txtciudad.TabIndex = 35;
            this.txtciudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtciudad_KeyPress);
            // 
            // dtpfechaexpediente
            // 
            this.dtpfechaexpediente.Location = new System.Drawing.Point(736, 186);
            this.dtpfechaexpediente.Name = "dtpfechaexpediente";
            this.dtpfechaexpediente.Size = new System.Drawing.Size(200, 20);
            this.dtpfechaexpediente.TabIndex = 34;
            // 
            // txtocupacion
            // 
            this.txtocupacion.Location = new System.Drawing.Point(796, 120);
            this.txtocupacion.Name = "txtocupacion";
            this.txtocupacion.Size = new System.Drawing.Size(202, 20);
            this.txtocupacion.TabIndex = 33;
            this.txtocupacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtocupacion_KeyPress);
            // 
            // txtprocedencia
            // 
            this.txtprocedencia.Location = new System.Drawing.Point(796, 68);
            this.txtprocedencia.Name = "txtprocedencia";
            this.txtprocedencia.Size = new System.Drawing.Size(202, 20);
            this.txtprocedencia.TabIndex = 32;
            this.txtprocedencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprocedencia_KeyPress);
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(781, 23);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(217, 20);
            this.txtdireccion.TabIndex = 31;
            this.txtdireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdireccion_KeyPress);
            // 
            // dtpfechaN
            // 
            this.dtpfechaN.Location = new System.Drawing.Point(480, 20);
            this.dtpfechaN.Name = "dtpfechaN";
            this.dtpfechaN.Size = new System.Drawing.Size(200, 20);
            this.dtpfechaN.TabIndex = 30;
            // 
            // cmbdepartamento
            // 
            this.cmbdepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdepartamento.FormattingEnabled = true;
            this.cmbdepartamento.Items.AddRange(new object[] {
            "Altantida",
            "Colon",
            "Comayagua",
            "Copan",
            "Cortes",
            "Choluteca",
            "El Paraiso",
            "Francisco Morazan",
            "Gracias a Dios",
            "Intibuca",
            "Islas de la Bahia",
            "La Paz",
            "Lempira",
            "Ocotepeque",
            "Olancho",
            "Santa Barbara",
            "Valle",
            "Yoro"});
            this.cmbdepartamento.Location = new System.Drawing.Point(456, 159);
            this.cmbdepartamento.Name = "cmbdepartamento";
            this.cmbdepartamento.Size = new System.Drawing.Size(224, 21);
            this.cmbdepartamento.TabIndex = 28;
            // 
            // cmbestadocivil
            // 
            this.cmbestadocivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbestadocivil.FormattingEnabled = true;
            this.cmbestadocivil.Items.AddRange(new object[] {
            "Soltero/a",
            "Casado/a",
            "Divorciado/a",
            "Viudo/a",
            "Separado/a",
            "Union Libre"});
            this.cmbestadocivil.Location = new System.Drawing.Point(456, 115);
            this.cmbestadocivil.Name = "cmbestadocivil";
            this.cmbestadocivil.Size = new System.Drawing.Size(224, 21);
            this.cmbestadocivil.TabIndex = 27;
            // 
            // rbfemenino
            // 
            this.rbfemenino.AutoSize = true;
            this.rbfemenino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbfemenino.Location = new System.Drawing.Point(574, 68);
            this.rbfemenino.Name = "rbfemenino";
            this.rbfemenino.Size = new System.Drawing.Size(106, 24);
            this.rbfemenino.TabIndex = 26;
            this.rbfemenino.TabStop = true;
            this.rbfemenino.Text = "Femenino";
            this.rbfemenino.UseVisualStyleBackColor = true;
            // 
            // rbmasculino
            // 
            this.rbmasculino.AutoSize = true;
            this.rbmasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbmasculino.Location = new System.Drawing.Point(456, 68);
            this.rbmasculino.Name = "rbmasculino";
            this.rbmasculino.Size = new System.Drawing.Size(107, 24);
            this.rbmasculino.TabIndex = 25;
            this.rbmasculino.TabStop = true;
            this.rbmasculino.Text = "Masculino";
            this.rbmasculino.UseVisualStyleBackColor = true;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(121, 249);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(197, 20);
            this.txtemail.TabIndex = 23;
            this.txtemail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtemail_KeyPress);
            // 
            // txttelefono2
            // 
            this.txttelefono2.Location = new System.Drawing.Point(121, 208);
            this.txttelefono2.Name = "txttelefono2";
            this.txttelefono2.Size = new System.Drawing.Size(197, 20);
            this.txttelefono2.TabIndex = 22;
            this.txttelefono2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelefono2_KeyPress);
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(121, 162);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(197, 20);
            this.txttelefono.TabIndex = 21;
            this.txttelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelefono_KeyPress);
            // 
            // txtapellidos
            // 
            this.txtapellidos.Location = new System.Drawing.Point(121, 116);
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(197, 20);
            this.txtapellidos.TabIndex = 20;
            this.txtapellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellidos_KeyPress);
            // 
            // txtnombres
            // 
            this.txtnombres.Location = new System.Drawing.Point(121, 72);
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.Size = new System.Drawing.Size(197, 20);
            this.txtnombres.TabIndex = 19;
            this.txtnombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombres_KeyPress);
            // 
            // txtidentidad
            // 
            this.txtidentidad.Location = new System.Drawing.Point(121, 20);
            this.txtidentidad.Name = "txtidentidad";
            this.txtidentidad.Size = new System.Drawing.Size(197, 20);
            this.txtidentidad.TabIndex = 18;
            this.txtidentidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtidentidad_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(741, 163);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(186, 20);
            this.label18.TabIndex = 17;
            this.label18.Text = "Fecha del expediente:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(686, 118);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 20);
            this.label17.TabIndex = 16;
            this.label17.Text = "Ocupacion:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(686, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 20);
            this.label16.TabIndex = 15;
            this.label16.Text = "Procedencia:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(18, 208);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 20);
            this.label15.TabIndex = 14;
            this.label15.Text = "Telefono 2:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(606, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 20);
            this.label14.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(686, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "Direccion:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(324, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Ciudad:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Apellidos:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Telefono:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(324, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha nacimiento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(324, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sexo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(324, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estado Civil:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(324, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Departamento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identidad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(452, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Buscar:";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(528, 261);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(152, 20);
            this.txtbuscar.TabIndex = 37;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(686, 254);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(82, 33);
            this.btnbuscar.TabIndex = 38;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1058, 502);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expediente-Medico";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinfo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton rbmasculino;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txttelefono2;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtapellidos;
        private System.Windows.Forms.TextBox txtnombres;
        private System.Windows.Forms.TextBox txtidentidad;
        private System.Windows.Forms.DateTimePicker dtpfechaexpediente;
        private System.Windows.Forms.TextBox txtocupacion;
        private System.Windows.Forms.TextBox txtprocedencia;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.DateTimePicker dtpfechaN;
        private System.Windows.Forms.ComboBox cmbdepartamento;
        private System.Windows.Forms.ComboBox cmbestadocivil;
        private System.Windows.Forms.RadioButton rbfemenino;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.DataGridView dgvinfo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvidentidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvnombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvapellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtelefono2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvemail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvfechanac;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvsexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvestado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvdepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvdireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvprocedencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvocupacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvfechaex;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label8;
    }
}

