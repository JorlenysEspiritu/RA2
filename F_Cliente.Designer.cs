namespace Proyecto_Final_Base_De_Datos
{
    partial class F_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Cliente));
            panel2 = new Panel();
            label11 = new Label();
            dateTimePicker1 = new DateTimePicker();
            pictureBox4 = new PictureBox();
            dgv_principal = new DataGridView();
            btn_Principal = new Button();
            label4 = new Label();
            IDENTIFICACION = new Label();
            txt_Id_Cliente = new TextBox();
            btn_Selet = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_Cedula_Cliente = new TextBox();
            txt_Apellido_Cliente = new TextBox();
            txt_Nombre_Cliente = new TextBox();
            panel1 = new Panel();
            btn_Eliminar = new Button();
            btn_Actualizar = new Button();
            btn_Guardar = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_principal).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightBlue;
            panel2.Controls.Add(label11);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(dgv_principal);
            panel2.Controls.Add(btn_Principal);
            panel2.Location = new Point(341, 5);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(801, 725);
            panel2.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(326, 95);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(177, 40);
            label11.TabIndex = 18;
            label11.Text = "LISTADO";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(219, 17);
            dateTimePicker1.Margin = new Padding(4, 5, 4, 5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(353, 31);
            dateTimePicker1.TabIndex = 17;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = ImageLayout.None;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(649, 15);
            pictureBox4.Margin = new Padding(4, 5, 4, 5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(123, 110);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
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
            dgv_principal.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btn_Principal
            // 
            btn_Principal.BackColor = SystemColors.MenuHighlight;
            btn_Principal.Font = new Font("Stencil", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Principal.ForeColor = SystemColors.ButtonHighlight;
            btn_Principal.Location = new Point(264, 515);
            btn_Principal.Margin = new Padding(4, 5, 4, 5);
            btn_Principal.Name = "btn_Principal";
            btn_Principal.Size = new Size(263, 47);
            btn_Principal.TabIndex = 15;
            btn_Principal.Text = "PRINCIPAL";
            btn_Principal.UseVisualStyleBackColor = false;
            btn_Principal.Click += btn_Principal_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(19, 5);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(289, 40);
            label4.TabIndex = 4;
            label4.Text = "Registro Cliente";
            // 
            // IDENTIFICACION
            // 
            IDENTIFICACION.AutoSize = true;
            IDENTIFICACION.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            IDENTIFICACION.Location = new Point(10, 12);
            IDENTIFICACION.Margin = new Padding(4, 0, 4, 0);
            IDENTIFICACION.Name = "IDENTIFICACION";
            IDENTIFICACION.Size = new Size(46, 33);
            IDENTIFICACION.TabIndex = 24;
            IDENTIFICACION.Text = "ID";
            // 
            // txt_Id_Cliente
            // 
            txt_Id_Cliente.Location = new Point(10, 62);
            txt_Id_Cliente.Margin = new Padding(4, 5, 4, 5);
            txt_Id_Cliente.Name = "txt_Id_Cliente";
            txt_Id_Cliente.Size = new Size(281, 31);
            txt_Id_Cliente.TabIndex = 23;
            // 
            // btn_Selet
            // 
            btn_Selet.BackColor = SystemColors.MenuHighlight;
            btn_Selet.Font = new Font("Stencil", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Selet.ForeColor = SystemColors.ButtonHighlight;
            btn_Selet.Location = new Point(30, 423);
            btn_Selet.Margin = new Padding(4, 5, 4, 5);
            btn_Selet.Name = "btn_Selet";
            btn_Selet.Size = new Size(263, 47);
            btn_Selet.TabIndex = 22;
            btn_Selet.Text = "LISTAR";
            btn_Selet.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(4, 315);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(138, 33);
            label3.TabIndex = 21;
            label3.Text = "CÉDULA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(4, 218);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(164, 33);
            label2.TabIndex = 20;
            label2.Text = "APELLIDO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 105);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(148, 33);
            label1.TabIndex = 19;
            label1.Text = "NOMBRE";
            // 
            // txt_Cedula_Cliente
            // 
            txt_Cedula_Cliente.Location = new Point(10, 365);
            txt_Cedula_Cliente.Margin = new Padding(4, 5, 4, 5);
            txt_Cedula_Cliente.Name = "txt_Cedula_Cliente";
            txt_Cedula_Cliente.Size = new Size(291, 31);
            txt_Cedula_Cliente.TabIndex = 18;
            // 
            // txt_Apellido_Cliente
            // 
            txt_Apellido_Cliente.Location = new Point(10, 268);
            txt_Apellido_Cliente.Margin = new Padding(4, 5, 4, 5);
            txt_Apellido_Cliente.Name = "txt_Apellido_Cliente";
            txt_Apellido_Cliente.Size = new Size(287, 31);
            txt_Apellido_Cliente.TabIndex = 17;
            // 
            // txt_Nombre_Cliente
            // 
            txt_Nombre_Cliente.Location = new Point(10, 155);
            txt_Nombre_Cliente.Margin = new Padding(4, 5, 4, 5);
            txt_Nombre_Cliente.Name = "txt_Nombre_Cliente";
            txt_Nombre_Cliente.Size = new Size(287, 31);
            txt_Nombre_Cliente.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(btn_Eliminar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_Actualizar);
            panel1.Controls.Add(btn_Guardar);
            panel1.Controls.Add(IDENTIFICACION);
            panel1.Controls.Add(btn_Selet);
            panel1.Controls.Add(txt_Id_Cliente);
            panel1.Controls.Add(txt_Apellido_Cliente);
            panel1.Controls.Add(txt_Nombre_Cliente);
            panel1.Controls.Add(txt_Cedula_Cliente);
            panel1.Location = new Point(7, 58);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 687);
            panel1.TabIndex = 7;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.BackColor = SystemColors.MenuHighlight;
            btn_Eliminar.Font = new Font("Stencil", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Eliminar.ForeColor = SystemColors.ButtonHighlight;
            btn_Eliminar.Location = new Point(30, 593);
            btn_Eliminar.Margin = new Padding(4, 5, 4, 5);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(263, 47);
            btn_Eliminar.TabIndex = 27;
            btn_Eliminar.Text = "ELIMINAR";
            btn_Eliminar.UseVisualStyleBackColor = false;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // btn_Actualizar
            // 
            btn_Actualizar.BackColor = SystemColors.MenuHighlight;
            btn_Actualizar.Font = new Font("Stencil", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Actualizar.ForeColor = SystemColors.ButtonHighlight;
            btn_Actualizar.Location = new Point(30, 537);
            btn_Actualizar.Margin = new Padding(4, 5, 4, 5);
            btn_Actualizar.Name = "btn_Actualizar";
            btn_Actualizar.Size = new Size(263, 47);
            btn_Actualizar.TabIndex = 26;
            btn_Actualizar.Text = "ACTUALIZAR";
            btn_Actualizar.UseVisualStyleBackColor = false;
            btn_Actualizar.Click += btn_Actualizar_Click_1;
            // 
            // btn_Guardar
            // 
            btn_Guardar.BackColor = SystemColors.MenuHighlight;
            btn_Guardar.Font = new Font("Stencil", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Guardar.ForeColor = SystemColors.ButtonHighlight;
            btn_Guardar.Location = new Point(30, 480);
            btn_Guardar.Margin = new Padding(4, 5, 4, 5);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(263, 47);
            btn_Guardar.TabIndex = 25;
            btn_Guardar.Text = "GUARDAR";
            btn_Guardar.UseVisualStyleBackColor = false;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // F_Cliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1143, 750);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(panel2);
            Margin = new Padding(4, 5, 4, 5);
            Name = "F_Cliente";
            Text = "F_Cliente";
            Load += F_Cliente_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_principal).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button btn_Principal;
        private Label label4;
        private Label IDENTIFICACION;
        private TextBox txt_Id_Cliente;
        private Button btn_Selet;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_Cedula_Cliente;
        private TextBox txt_Apellido_Cliente;
        private TextBox txt_Nombre_Cliente;
        private Panel panel1;
        private DataGridView dgv_principal;
        private Button btn_Eliminar;
        private Button btn_Actualizar;
        private Button button1;
        private Button btn_Guardar;
        private PictureBox pictureBox4;
        private DateTimePicker dateTimePicker1;
        private Label label11;
    }
}