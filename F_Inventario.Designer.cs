namespace Proyecto_Final_Base_De_Datos
{
    partial class F_Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Inventario));
            label1 = new Label();
            btn_Principal = new Button();
            IDENTIFICACION = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txt_Producto_Inventario = new TextBox();
            txt_Descripcion_Inventario = new TextBox();
            txt_Stock_Inicial_Inventario = new TextBox();
            txt_Entrada_Producto_Inventario = new TextBox();
            txt_Stock_Total_Inventario = new TextBox();
            txt_Salida_Inventario = new TextBox();
            txt_Precio_Inventario = new TextBox();
            txt_Fecha_Entrada_Inventario = new TextBox();
            txt_Fecha_Salida_Inventario = new TextBox();
            btn_Selet = new Button();
            txt_Id_Inventario = new TextBox();
            panel1 = new Panel();
            btn_Eliminar = new Button();
            btn_Actualizar = new Button();
            btn_Guardar = new Button();
            panel2 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            pictureBox6 = new PictureBox();
            label11 = new Label();
            dgv_principal = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_principal).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(49, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(337, 40);
            label1.TabIndex = 0;
            label1.Text = "Registro Inventario";
            label1.Click += label1_Click;
            // 
            // btn_Principal
            // 
            btn_Principal.BackColor = SystemColors.MenuHighlight;
            btn_Principal.Font = new Font("Stencil", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Principal.ForeColor = SystemColors.ButtonHighlight;
            btn_Principal.Location = new Point(264, 527);
            btn_Principal.Margin = new Padding(4, 5, 4, 5);
            btn_Principal.Name = "btn_Principal";
            btn_Principal.Size = new Size(263, 47);
            btn_Principal.TabIndex = 5;
            btn_Principal.Text = "PRINCIPAL";
            btn_Principal.UseVisualStyleBackColor = false;
            btn_Principal.Click += btn_Principal_Click;
            // 
            // IDENTIFICACION
            // 
            IDENTIFICACION.AutoSize = true;
            IDENTIFICACION.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            IDENTIFICACION.Location = new Point(8, 17);
            IDENTIFICACION.Margin = new Padding(4, 0, 4, 0);
            IDENTIFICACION.Name = "IDENTIFICACION";
            IDENTIFICACION.Size = new Size(46, 33);
            IDENTIFICACION.TabIndex = 37;
            IDENTIFICACION.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(8, 123);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(190, 33);
            label2.TabIndex = 38;
            label2.Text = "PRODUCTO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(8, 232);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(227, 33);
            label3.TabIndex = 39;
            label3.Text = "DESCRIPCIÓN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(8, 328);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(245, 33);
            label4.TabIndex = 40;
            label4.Text = "STOCK_INICIAL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(294, 17);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(352, 33);
            label5.TabIndex = 41;
            label5.Text = "ENTRADA_PRODUCTO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(304, 123);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(315, 33);
            label6.TabIndex = 42;
            label6.Text = "SALIDA_PRODUCTO";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(390, 232);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(132, 33);
            label7.TabIndex = 43;
            label7.Text = "PRECIO";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(314, 328);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(280, 33);
            label8.TabIndex = 44;
            label8.Text = "FECHA_ENTRADA";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(314, 432);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(243, 33);
            label9.TabIndex = 45;
            label9.Text = "FECHA_SALIDA";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(324, 527);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(207, 33);
            label10.TabIndex = 46;
            label10.Text = "STOCK_Total";
            // 
            // txt_Producto_Inventario
            // 
            txt_Producto_Inventario.Location = new Point(10, 173);
            txt_Producto_Inventario.Margin = new Padding(4, 5, 4, 5);
            txt_Producto_Inventario.Name = "txt_Producto_Inventario";
            txt_Producto_Inventario.Size = new Size(203, 31);
            txt_Producto_Inventario.TabIndex = 50;
            // 
            // txt_Descripcion_Inventario
            // 
            txt_Descripcion_Inventario.Location = new Point(4, 282);
            txt_Descripcion_Inventario.Margin = new Padding(4, 5, 4, 5);
            txt_Descripcion_Inventario.Name = "txt_Descripcion_Inventario";
            txt_Descripcion_Inventario.Size = new Size(208, 31);
            txt_Descripcion_Inventario.TabIndex = 51;
            // 
            // txt_Stock_Inicial_Inventario
            // 
            txt_Stock_Inicial_Inventario.Location = new Point(10, 378);
            txt_Stock_Inicial_Inventario.Margin = new Padding(4, 5, 4, 5);
            txt_Stock_Inicial_Inventario.Name = "txt_Stock_Inicial_Inventario";
            txt_Stock_Inicial_Inventario.Size = new Size(203, 31);
            txt_Stock_Inicial_Inventario.TabIndex = 52;
            // 
            // txt_Entrada_Producto_Inventario
            // 
            txt_Entrada_Producto_Inventario.Location = new Point(324, 67);
            txt_Entrada_Producto_Inventario.Margin = new Padding(4, 5, 4, 5);
            txt_Entrada_Producto_Inventario.Name = "txt_Entrada_Producto_Inventario";
            txt_Entrada_Producto_Inventario.Size = new Size(214, 31);
            txt_Entrada_Producto_Inventario.TabIndex = 53;
            // 
            // txt_Stock_Total_Inventario
            // 
            txt_Stock_Total_Inventario.Location = new Point(324, 575);
            txt_Stock_Total_Inventario.Margin = new Padding(4, 5, 4, 5);
            txt_Stock_Total_Inventario.Name = "txt_Stock_Total_Inventario";
            txt_Stock_Total_Inventario.Size = new Size(214, 31);
            txt_Stock_Total_Inventario.TabIndex = 54;
            // 
            // txt_Salida_Inventario
            // 
            txt_Salida_Inventario.Location = new Point(324, 173);
            txt_Salida_Inventario.Margin = new Padding(4, 5, 4, 5);
            txt_Salida_Inventario.Name = "txt_Salida_Inventario";
            txt_Salida_Inventario.Size = new Size(214, 31);
            txt_Salida_Inventario.TabIndex = 55;
            // 
            // txt_Precio_Inventario
            // 
            txt_Precio_Inventario.Location = new Point(324, 282);
            txt_Precio_Inventario.Margin = new Padding(4, 5, 4, 5);
            txt_Precio_Inventario.Name = "txt_Precio_Inventario";
            txt_Precio_Inventario.Size = new Size(214, 31);
            txt_Precio_Inventario.TabIndex = 56;
            // 
            // txt_Fecha_Entrada_Inventario
            // 
            txt_Fecha_Entrada_Inventario.Location = new Point(324, 378);
            txt_Fecha_Entrada_Inventario.Margin = new Padding(4, 5, 4, 5);
            txt_Fecha_Entrada_Inventario.Name = "txt_Fecha_Entrada_Inventario";
            txt_Fecha_Entrada_Inventario.Size = new Size(214, 31);
            txt_Fecha_Entrada_Inventario.TabIndex = 57;
            // 
            // txt_Fecha_Salida_Inventario
            // 
            txt_Fecha_Salida_Inventario.Location = new Point(324, 482);
            txt_Fecha_Salida_Inventario.Margin = new Padding(4, 5, 4, 5);
            txt_Fecha_Salida_Inventario.Name = "txt_Fecha_Salida_Inventario";
            txt_Fecha_Salida_Inventario.Size = new Size(214, 31);
            txt_Fecha_Salida_Inventario.TabIndex = 59;
            // 
            // btn_Selet
            // 
            btn_Selet.BackColor = SystemColors.MenuHighlight;
            btn_Selet.Font = new Font("Stencil", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Selet.ForeColor = SystemColors.ButtonHighlight;
            btn_Selet.Location = new Point(10, 432);
            btn_Selet.Margin = new Padding(4, 5, 4, 5);
            btn_Selet.Name = "btn_Selet";
            btn_Selet.Size = new Size(263, 47);
            btn_Selet.TabIndex = 60;
            btn_Selet.Text = "LISTAR";
            btn_Selet.UseVisualStyleBackColor = false;
            btn_Selet.Click += btn_Selet_Click;
            // 
            // txt_Id_Inventario
            // 
            txt_Id_Inventario.Location = new Point(10, 67);
            txt_Id_Inventario.Margin = new Padding(4, 5, 4, 5);
            txt_Id_Inventario.Name = "txt_Id_Inventario";
            txt_Id_Inventario.Size = new Size(203, 31);
            txt_Id_Inventario.TabIndex = 61;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(btn_Eliminar);
            panel1.Controls.Add(btn_Actualizar);
            panel1.Controls.Add(txt_Stock_Total_Inventario);
            panel1.Controls.Add(txt_Fecha_Salida_Inventario);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txt_Id_Inventario);
            panel1.Controls.Add(txt_Fecha_Entrada_Inventario);
            panel1.Controls.Add(btn_Selet);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txt_Precio_Inventario);
            panel1.Controls.Add(txt_Salida_Inventario);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(btn_Guardar);
            panel1.Controls.Add(IDENTIFICACION);
            panel1.Controls.Add(txt_Entrada_Producto_Inventario);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_Stock_Inicial_Inventario);
            panel1.Controls.Add(txt_Producto_Inventario);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txt_Descripcion_Inventario);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(13, 83);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 687);
            panel1.TabIndex = 63;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.BackColor = SystemColors.MenuHighlight;
            btn_Eliminar.Font = new Font("Stencil", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Eliminar.ForeColor = SystemColors.ButtonHighlight;
            btn_Eliminar.Location = new Point(356, 635);
            btn_Eliminar.Margin = new Padding(4, 5, 4, 5);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(263, 47);
            btn_Eliminar.TabIndex = 68;
            btn_Eliminar.Text = "ELIMINAR";
            btn_Eliminar.UseVisualStyleBackColor = false;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // btn_Actualizar
            // 
            btn_Actualizar.BackColor = SystemColors.MenuHighlight;
            btn_Actualizar.Font = new Font("Stencil", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Actualizar.ForeColor = SystemColors.ButtonHighlight;
            btn_Actualizar.Location = new Point(26, 635);
            btn_Actualizar.Margin = new Padding(4, 5, 4, 5);
            btn_Actualizar.Name = "btn_Actualizar";
            btn_Actualizar.Size = new Size(263, 47);
            btn_Actualizar.TabIndex = 67;
            btn_Actualizar.Text = "ACTUALIZAR";
            btn_Actualizar.UseVisualStyleBackColor = false;
            btn_Actualizar.Click += btn_Actualizar_Click;
            // 
            // btn_Guardar
            // 
            btn_Guardar.BackColor = SystemColors.MenuHighlight;
            btn_Guardar.Font = new Font("Stencil", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Guardar.ForeColor = SystemColors.ButtonHighlight;
            btn_Guardar.Location = new Point(10, 488);
            btn_Guardar.Margin = new Padding(4, 5, 4, 5);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(263, 47);
            btn_Guardar.TabIndex = 25;
            btn_Guardar.Text = "GUARDAR";
            btn_Guardar.UseVisualStyleBackColor = false;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightBlue;
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(btn_Principal);
            panel2.Controls.Add(dgv_principal);
            panel2.Location = new Point(713, 45);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(801, 725);
            panel2.TabIndex = 64;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(241, 26);
            dateTimePicker1.Margin = new Padding(4, 5, 4, 5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(324, 31);
            dateTimePicker1.TabIndex = 66;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImageLayout = ImageLayout.None;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(658, 26);
            pictureBox6.Margin = new Padding(4, 5, 4, 5);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(126, 105);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 65;
            pictureBox6.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(299, 87);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(177, 40);
            label11.TabIndex = 8;
            label11.Text = "LISTADO";
            // 
            // dgv_principal
            // 
            dgv_principal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_principal.Location = new Point(11, 158);
            dgv_principal.Margin = new Padding(4, 5, 4, 5);
            dgv_principal.Name = "dgv_principal";
            dgv_principal.RowHeadersWidth = 62;
            dgv_principal.RowTemplate.Height = 25;
            dgv_principal.Size = new Size(773, 275);
            dgv_principal.TabIndex = 16;
            dgv_principal.CellClick += dgv_principal_CellClick;
            // 
            // F_Inventario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1551, 792);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "F_Inventario";
            Text = "F_Inventario";
            Load += F_Inventario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_principal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_Principal;
        private Label IDENTIFICACION;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label12;
        private TextBox txt_Id_Empleado;
        private TextBox txt_Producto_Inventario;
        private TextBox txt_Descripcion_Inventario;
        private TextBox txt_Stock_Inicial_Inventario;
        private TextBox txt_Entrada_Producto_Inventario;
        private TextBox txt_Salida_Producto_Inventario;
        private TextBox txt_Precio_Inventario;
        private TextBox txt_Fecha_Entrada_Inventario;
        private TextBox txt_Fecha_Salida_Inventario;
        private TextBox textBox9;
        private TextBox txt_Stock_Total_Inventario;
        private Button btn_Selet;
        private TextBox textBox11;
        private TextBox txt_Id_Inventario;
        private Panel panel1;
        private Label label11;
        private Label label13;
        private Button btn_Guardar;
        private Label label14;
        private TextBox txt_Id_Cliente;
        private TextBox txt_Apellido_Cliente;
        private TextBox txt_Nombre_Cliente;
        private TextBox txt_Cedula_Cliente;
        private Label label15;
        private Panel panel2;
        private DataGridView dgv_principal;
        private PictureBox pictureBox6;
        private DateTimePicker dateTimePicker1;
        private Button btn_Eliminar;
        private Button btn_Actualizar;
        private TextBox txt_Salida_Inventario;
    }
}