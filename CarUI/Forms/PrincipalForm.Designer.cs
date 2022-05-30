namespace CarUI
{
    partial class PrincipalForm
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnRentarVehiculo = new System.Windows.Forms.Button();
            this.btnInspeccion = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnVehiculos = new System.Windows.Forms.Button();
            this.btnModelos = new System.Windows.Forms.Button();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.btnVehicleType = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnTipoCombustible = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.panelMenu.Controls.Add(this.btnTipoCombustible);
            this.panelMenu.Controls.Add(this.btnLogOut);
            this.panelMenu.Controls.Add(this.btnRentarVehiculo);
            this.panelMenu.Controls.Add(this.btnInspeccion);
            this.panelMenu.Controls.Add(this.btnEmpleados);
            this.panelMenu.Controls.Add(this.btnClientes);
            this.panelMenu.Controls.Add(this.btnVehiculos);
            this.panelMenu.Controls.Add(this.btnModelos);
            this.panelMenu.Controls.Add(this.btnMarcas);
            this.panelMenu.Controls.Add(this.btnVehicleType);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(141)))), ((int)(((byte)(172)))));
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(263, 665);
            this.panelMenu.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogOut.Image = global::CarUI.Properties.Resources.Icons8_Windows_8_User_Interface_Logout;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 517);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnLogOut.Size = new System.Drawing.Size(263, 62);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "Salir";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnRentarVehiculo
            // 
            this.btnRentarVehiculo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRentarVehiculo.FlatAppearance.BorderSize = 0;
            this.btnRentarVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRentarVehiculo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRentarVehiculo.Image = global::CarUI.Properties.Resources.Iconsmind_Outline_Key_2;
            this.btnRentarVehiculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRentarVehiculo.Location = new System.Drawing.Point(0, 469);
            this.btnRentarVehiculo.Name = "btnRentarVehiculo";
            this.btnRentarVehiculo.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnRentarVehiculo.Size = new System.Drawing.Size(263, 48);
            this.btnRentarVehiculo.TabIndex = 8;
            this.btnRentarVehiculo.Text = "Rentar Vehiculo";
            this.btnRentarVehiculo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRentarVehiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRentarVehiculo.UseVisualStyleBackColor = true;
            // 
            // btnInspeccion
            // 
            this.btnInspeccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInspeccion.FlatAppearance.BorderSize = 0;
            this.btnInspeccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInspeccion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInspeccion.Image = global::CarUI.Properties.Resources.Icons8_Windows_8_Finance_Check_Book;
            this.btnInspeccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInspeccion.Location = new System.Drawing.Point(0, 413);
            this.btnInspeccion.Name = "btnInspeccion";
            this.btnInspeccion.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnInspeccion.Size = new System.Drawing.Size(263, 56);
            this.btnInspeccion.TabIndex = 7;
            this.btnInspeccion.Text = "Inspección";
            this.btnInspeccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInspeccion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInspeccion.UseVisualStyleBackColor = true;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEmpleados.Image = global::CarUI.Properties.Resources.Iconshock_Super_Vista_General_Administrator;
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 365);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnEmpleados.Size = new System.Drawing.Size(263, 48);
            this.btnEmpleados.TabIndex = 6;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClientes.Image = global::CarUI.Properties.Resources.Iconsmind_Outline_People_onCloud;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 297);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(263, 68);
            this.btnClientes.TabIndex = 5;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnVehiculos
            // 
            this.btnVehiculos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVehiculos.FlatAppearance.BorderSize = 0;
            this.btnVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehiculos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVehiculos.Image = global::CarUI.Properties.Resources.Iconsmind_Outline_Fuel;
            this.btnVehiculos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehiculos.Location = new System.Drawing.Point(0, 237);
            this.btnVehiculos.Name = "btnVehiculos";
            this.btnVehiculos.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnVehiculos.Size = new System.Drawing.Size(263, 60);
            this.btnVehiculos.TabIndex = 4;
            this.btnVehiculos.Text = "Vehiculos";
            this.btnVehiculos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehiculos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVehiculos.UseVisualStyleBackColor = true;
            // 
            // btnModelos
            // 
            this.btnModelos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModelos.FlatAppearance.BorderSize = 0;
            this.btnModelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModelos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModelos.Image = global::CarUI.Properties.Resources.Iconsmind_Outline_Car_2;
            this.btnModelos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModelos.Location = new System.Drawing.Point(0, 189);
            this.btnModelos.Name = "btnModelos";
            this.btnModelos.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnModelos.Size = new System.Drawing.Size(263, 48);
            this.btnModelos.TabIndex = 3;
            this.btnModelos.Text = "Modelos";
            this.btnModelos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModelos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModelos.UseVisualStyleBackColor = true;
            this.btnModelos.Click += new System.EventHandler(this.btnModelos_Click);
            // 
            // btnMarcas
            // 
            this.btnMarcas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMarcas.FlatAppearance.BorderSize = 0;
            this.btnMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMarcas.Image = global::CarUI.Properties.Resources.Iconsmind_Outline_Car_Wheel;
            this.btnMarcas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarcas.Location = new System.Drawing.Point(0, 128);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnMarcas.Size = new System.Drawing.Size(263, 61);
            this.btnMarcas.TabIndex = 2;
            this.btnMarcas.Text = "Marcas";
            this.btnMarcas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarcas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMarcas.UseVisualStyleBackColor = true;
            this.btnMarcas.Click += new System.EventHandler(this.btnMarcas_Click);
            // 
            // btnVehicleType
            // 
            this.btnVehicleType.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVehicleType.FlatAppearance.BorderSize = 0;
            this.btnVehicleType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehicleType.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVehicleType.Image = global::CarUI.Properties.Resources.Iconsmind_Outline_Car_3;
            this.btnVehicleType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehicleType.Location = new System.Drawing.Point(0, 80);
            this.btnVehicleType.Name = "btnVehicleType";
            this.btnVehicleType.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnVehicleType.Size = new System.Drawing.Size(263, 48);
            this.btnVehicleType.TabIndex = 1;
            this.btnVehicleType.Text = "Tipos de Vehiculos";
            this.btnVehicleType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehicleType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVehicleType.UseVisualStyleBackColor = true;
            this.btnVehicleType.Click += new System.EventHandler(this.btnVehicleType_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(263, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(11)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Euren\'s RentCar";
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(263, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1048, 80);
            this.panelTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(11)))), ((int)(((byte)(76)))));
            this.lblTitle.Location = new System.Drawing.Point(382, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(413, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Los Mejores Vehiculos!";
            // 
            // btnTipoCombustible
            // 
            this.btnTipoCombustible.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTipoCombustible.FlatAppearance.BorderSize = 0;
            this.btnTipoCombustible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipoCombustible.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTipoCombustible.Image = global::CarUI.Properties.Resources.Iconsmind_Outline_Car_3;
            this.btnTipoCombustible.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTipoCombustible.Location = new System.Drawing.Point(0, 579);
            this.btnTipoCombustible.Name = "btnTipoCombustible";
            this.btnTipoCombustible.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnTipoCombustible.Size = new System.Drawing.Size(263, 48);
            this.btnTipoCombustible.TabIndex = 10;
            this.btnTipoCombustible.Text = "Tipos de Combustibles";
            this.btnTipoCombustible.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTipoCombustible.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTipoCombustible.UseVisualStyleBackColor = true;
            this.btnTipoCombustible.Click += new System.EventHandler(this.btnTipoCombustible_Click);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 665);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Name = "PrincipalForm";
            this.Text = "PrincipalForm";
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private Button btnLogOut;
        private Button btnRentarVehiculo;
        private Button btnInspeccion;
        private Button btnEmpleados;
        private Button btnClientes;
        private Button btnVehiculos;
        private Button btnModelos;
        private Button btnMarcas;
        private Button btnVehicleType;
        private Panel panelLogo;
        private Panel panelTitle;
        private Label lblTitle;
        private Label label1;
        private Button btnTipoCombustible;
    }
}