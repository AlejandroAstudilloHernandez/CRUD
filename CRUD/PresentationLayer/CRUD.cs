using CRUD.BussinessLayer;
using CRUD.Models;
using System.Text.RegularExpressions;

namespace CRUD
{
    public partial class CRUD : Form
    {
        private readonly Bussiness _bussiness;
        public CRUD(Bussiness bussiness)
        {
            InitializeComponent();
            _bussiness = bussiness;

            tbUserId.Enabled = false;
            tbUsername.Enabled = true;
            tbPassword.Enabled = false;
            tbPhone.Enabled = false;
            tbEmail.Enabled = false;
            btnalta.Enabled = false;
            btnActualizar.Enabled = false;
            btnBorrar.Enabled = false;

            Select();
        }










        #region Metodos
        public void Select()
        {
            List<Usuario> usuarios = _bussiness.Select();
            dgvUsuario.Rows.Clear(); // Limpiar las filas existentes en caso de que se vuelva a llamar a este método
            foreach (Usuario usuario in usuarios)
            {
                int rowIndex = dgvUsuario.Rows.Add(); // Agregar una nueva fila y obtener su índice
                dgvUsuario.Rows[rowIndex].Cells["UserId"].Value = usuario.UserId;
                dgvUsuario.Rows[rowIndex].Cells["Username"].Value = usuario.Username;
                dgvUsuario.Rows[rowIndex].Cells["Password"].Value = usuario.Pass;
                dgvUsuario.Rows[rowIndex].Cells["Phone"].Value = usuario.Phone;
                dgvUsuario.Rows[rowIndex].Cells["Email"].Value = usuario.Email;
            }
        }

        public void Read(string username)
        {
            Usuario usuario = _bussiness.Read(username);
            if (usuario == null)
            {
                MessageBox.Show("Usuario no encontrado, crea uno nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbUsername.Enabled = true;
                tbPassword.Enabled = true;
                tbPhone.Enabled = true;
                tbEmail.Enabled = true;
                btnalta.Enabled = true;

            }
            else
            {
                dgvUsuario.Rows.Clear();

                tbUserId.Text = usuario.UserId.ToString();
                tbUsername.Text = usuario.Username.ToString();
                tbPassword.Text = usuario.Pass.ToString();
                tbPhone.Text = usuario.Phone.ToString();
                tbEmail.Text = usuario.Email.ToString();


                dgvUsuario.Rows[0].Cells["UserId"].Value = usuario.UserId;
                dgvUsuario.Rows[0].Cells["Username"].Value = usuario.Username;
                dgvUsuario.Rows[0].Cells["Password"].Value = usuario.Pass;
                dgvUsuario.Rows[0].Cells["Phone"].Value = usuario.Phone;
                dgvUsuario.Rows[0].Cells["Email"].Value = usuario.Email;


                tbUsername.Enabled = true;
                tbPassword.Enabled = true;
                tbPhone.Enabled = true;
                tbEmail.Enabled = true;
                btnalta.Enabled = false;
                btnBuscar.Enabled = true;
                btnActualizar.Enabled = true;
                btnBorrar.Enabled = true;
            }
        }

        public void Delete(int UserId)
        {
            var confirmacion = MessageBox.Show("¿Esta seguro de que quiere borrar este usuario permanentemente?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    _bussiness.Delete(UserId);
                    MessageBox.Show($"Usuario eliminado", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbUserId.Text = string.Empty;
                    tbUsername.Text = string.Empty;
                    tbPassword.Text = string.Empty;
                    tbPhone.Text = string.Empty;
                    tbEmail.Text = string.Empty;

                    tbUserId.Enabled = false;
                    tbUsername.Enabled = true;
                    tbPassword.Enabled = false;
                    tbPhone.Enabled = false;
                    tbEmail.Enabled = false;
                    btnalta.Enabled = false;
                    btnActualizar.Enabled = false;
                    btnBorrar.Enabled = false;
                    Select();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Usuario no encontrado {UserId}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Se Cancelo la eliminación", "Eliminación cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void Create(string username, string pass, int phone, string email)
        {
            _bussiness.Create(username, pass, phone, email);
            MessageBox.Show("Usuario creado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void Update(int userId, string username, string pass, int phone, string email)
        {
            _bussiness.Update(userId, username, pass, phone, email);
            MessageBox.Show("Usuario actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool IsValidEmail(string email)
        {
            // Patrón de expresión regular para validar el formato del correo electrónico
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Verificar si el correo electrónico coincide con el patrón
            return Regex.IsMatch(email, pattern);
        }
        #endregion

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Read(tbUsername.Text);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (tbUserId.Text == null || tbUserId.Text == "")
            {
                MessageBox.Show("El cambo UserId es obligatorio, busque un usuario valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Delete(Convert.ToInt32(tbUserId.Text));
            }

        }

        private void btnalta_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "" || tbPassword.Text == "" || tbPhone.Text == "" || tbEmail.Text == "" || !IsValidEmail(tbEmail.Text))
            {
                MessageBox.Show("Por favor llena todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Create(tbUsername.Text, tbPassword.Text, Convert.ToInt32(tbPhone.Text), tbEmail.Text);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (tbUserId.Text == "" || tbUsername.Text == "" || tbPassword.Text == "" || tbPhone.Text == "" || tbEmail.Text == "" || !IsValidEmail(tbEmail.Text))
            {
                MessageBox.Show("Por favor llena todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Update(Convert.ToInt32(tbUserId.Text), tbUsername.Text, tbPassword.Text, Convert.ToInt32(tbPhone.Text), tbEmail.Text);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Select();
            tbUserId.Text = string.Empty;
            tbUsername.Text = string.Empty;
            tbPassword.Text = string.Empty;
            tbPhone.Text = string.Empty;
            tbEmail.Text = string.Empty;
            tbUsername.Enabled = true;
            tbPassword.Enabled = false;
            tbPhone.Enabled = false;
            tbEmail.Enabled = false;
            btnActualizar.Enabled = false;
            btnBorrar.Enabled = false;
            btnalta.Enabled = false;
            btnBuscar.Enabled = true;
        }
    }
}
