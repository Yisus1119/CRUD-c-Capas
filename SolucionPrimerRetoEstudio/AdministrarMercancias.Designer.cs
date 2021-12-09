
namespace SolucionPrimerRetoEstudio
{
    partial class AdministrarMercancias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrarMercancias));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscarMercancia = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.comboEliminable = new System.Windows.Forms.ComboBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblLimpiarCampos = new System.Windows.Forms.LinkLabel();
            this.txtIdMercancia = new System.Windows.Forms.TextBox();
            this.lblVolver = new System.Windows.Forms.LinkLabel();
            this.btnRefrescar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(688, 348);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Image = ((System.Drawing.Image)(resources.GetObject("btnInsertar.Image")));
            this.btnInsertar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsertar.Location = new System.Drawing.Point(12, 462);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(178, 40);
            this.btnInsertar.TabIndex = 1;
            this.btnInsertar.Text = "Insertar mercancía";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrar.Location = new System.Drawing.Point(523, 462);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(157, 40);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar mercancía";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(779, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(779, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Existencia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(779, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Comentario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(779, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(779, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "NoEliminable:";
            // 
            // btnBuscarMercancia
            // 
            this.btnBuscarMercancia.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarMercancia.Image")));
            this.btnBuscarMercancia.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnBuscarMercancia.Location = new System.Drawing.Point(510, 24);
            this.btnBuscarMercancia.Name = "btnBuscarMercancia";
            this.btnBuscarMercancia.Size = new System.Drawing.Size(98, 40);
            this.btnBuscarMercancia.TabIndex = 9;
            this.btnBuscarMercancia.Text = "Buscar    ";
            this.btnBuscarMercancia.UseVisualStyleBackColor = true;
            this.btnBuscarMercancia.Click += new System.EventHandler(this.btnBuscarMercancia_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Buscar mercancía:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(784, 112);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(225, 22);
            this.txtDescripcion.TabIndex = 12;
            // 
            // txtExistencia
            // 
            this.txtExistencia.Location = new System.Drawing.Point(784, 189);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(225, 22);
            this.txtExistencia.TabIndex = 13;
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(784, 265);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(225, 25);
            this.txtComentario.TabIndex = 14;
            // 
            // comboStatus
            // 
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "Activa",
            "Inactiva"});
            this.comboStatus.Location = new System.Drawing.Point(784, 339);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(150, 24);
            this.comboStatus.TabIndex = 17;
            // 
            // comboEliminable
            // 
            this.comboEliminable.FormattingEnabled = true;
            this.comboEliminable.Items.AddRange(new object[] {
            "0",
            "1"});
            this.comboEliminable.Location = new System.Drawing.Point(784, 411);
            this.comboEliminable.Name = "comboEliminable";
            this.comboEliminable.Size = new System.Drawing.Size(150, 24);
            this.comboEliminable.TabIndex = 18;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.Location = new System.Drawing.Point(272, 462);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(180, 40);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar mercancía";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblLimpiarCampos
            // 
            this.lblLimpiarCampos.AutoSize = true;
            this.lblLimpiarCampos.Location = new System.Drawing.Point(972, 523);
            this.lblLimpiarCampos.Name = "lblLimpiarCampos";
            this.lblLimpiarCampos.Size = new System.Drawing.Size(107, 17);
            this.lblLimpiarCampos.TabIndex = 21;
            this.lblLimpiarCampos.TabStop = true;
            this.lblLimpiarCampos.Text = "Limpiar campos";
            this.lblLimpiarCampos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLimpiarCampos_LinkClicked);
            // 
            // txtIdMercancia
            // 
            this.txtIdMercancia.Location = new System.Drawing.Point(201, 37);
            this.txtIdMercancia.Name = "txtIdMercancia";
            this.txtIdMercancia.Size = new System.Drawing.Size(303, 22);
            this.txtIdMercancia.TabIndex = 22;
            // 
            // lblVolver
            // 
            this.lblVolver.AutoSize = true;
            this.lblVolver.Location = new System.Drawing.Point(853, 523);
            this.lblVolver.Name = "lblVolver";
            this.lblVolver.Size = new System.Drawing.Size(99, 17);
            this.lblVolver.TabIndex = 23;
            this.lblVolver.TabStop = true;
            this.lblVolver.Text = "Volver al inicio";
            this.lblVolver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblVolver_LinkClicked);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Image")));
            this.btnRefrescar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefrescar.Location = new System.Drawing.Point(614, 24);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(86, 40);
            this.btnRefrescar.TabIndex = 24;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // AdministrarMercancias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1081, 549);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.lblVolver);
            this.Controls.Add(this.txtIdMercancia);
            this.Controls.Add(this.lblLimpiarCampos);
            this.Controls.Add(this.comboEliminable);
            this.Controls.Add(this.comboStatus);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.txtExistencia);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBuscarMercancia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdministrarMercancias";
            this.Text = "AdministrarMercancias";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdministrarMercancias_FormClosed);
            this.Load += new System.EventHandler(this.AdministrarMercancias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscarMercancia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IdMercancias;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.ComboBox comboEliminable;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.LinkLabel lblLimpiarCampos;
        private System.Windows.Forms.TextBox txtIdMercancia;
        private System.Windows.Forms.LinkLabel lblVolver;
        private System.Windows.Forms.Button btnRefrescar;
    }
}