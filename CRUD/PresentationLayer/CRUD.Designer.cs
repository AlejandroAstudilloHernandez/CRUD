namespace CRUD
{
    partial class CRUD
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbUserId = new TextBox();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            tbPhone = new TextBox();
            tbEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnBuscar = new Button();
            btnalta = new Button();
            btnActualizar = new Button();
            btnBorrar = new Button();
            dgvUsuario = new DataGridView();
            UserId = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).BeginInit();
            SuspendLayout();
            // 
            // tbUserId
            // 
            tbUserId.Location = new Point(229, 38);
            tbUserId.Name = "tbUserId";
            tbUserId.Size = new Size(362, 23);
            tbUserId.TabIndex = 0;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(229, 67);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(362, 23);
            tbUsername.TabIndex = 1;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(229, 96);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(362, 23);
            tbPassword.TabIndex = 2;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(229, 125);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(362, 23);
            tbPhone.TabIndex = 3;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(229, 154);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(362, 23);
            tbEmail.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 38);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 5;
            label1.Text = "UserId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 67);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 6;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(148, 96);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 7;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(148, 125);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 8;
            label4.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(148, 154);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 9;
            label5.Text = "Email";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(624, 38);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnalta
            // 
            btnalta.Location = new Point(229, 183);
            btnalta.Name = "btnalta";
            btnalta.Size = new Size(75, 23);
            btnalta.TabIndex = 11;
            btnalta.Text = "Alta";
            btnalta.UseVisualStyleBackColor = true;
            btnalta.Click += btnalta_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(370, 183);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 12;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(516, 183);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 13;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // dgvUsuario
            // 
            dgvUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuario.Columns.AddRange(new DataGridViewColumn[] { UserId, Username, Password, Phone, Email });
            dgvUsuario.Location = new Point(79, 212);
            dgvUsuario.Name = "dgvUsuario";
            dgvUsuario.RowTemplate.Height = 25;
            dgvUsuario.Size = new Size(645, 208);
            dgvUsuario.TabIndex = 14;
            // 
            // UserId
            // 
            UserId.HeaderText = "UserId";
            UserId.Name = "UserId";
            UserId.ReadOnly = true;
            // 
            // Username
            // 
            Username.HeaderText = "Username";
            Username.Name = "Username";
            Username.ReadOnly = true;
            // 
            // Password
            // 
            Password.HeaderText = "Password";
            Password.Name = "Password";
            Password.ReadOnly = true;
            // 
            // Phone
            // 
            Phone.HeaderText = "Phone";
            Phone.Name = "Phone";
            Phone.ReadOnly = true;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 200;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(730, 397);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(56, 23);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // CRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpiar);
            Controls.Add(dgvUsuario);
            Controls.Add(btnBorrar);
            Controls.Add(btnActualizar);
            Controls.Add(btnalta);
            Controls.Add(btnBuscar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbEmail);
            Controls.Add(tbPhone);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(tbUserId);
            Name = "CRUD";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbUserId;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private TextBox tbPhone;
        private TextBox tbEmail;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnBuscar;
        private Button btnalta;
        private Button btnActualizar;
        private Button btnBorrar;
        private DataGridView dgvUsuario;
        private Button btnLimpiar;
        private DataGridViewTextBoxColumn UserId;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Email;
    }
}
