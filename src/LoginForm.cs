using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ta_liberado
{
    public partial class LoginForm : MaterialForm
    {
        private readonly AuthService _authService;
        private readonly IUserRepository _userRepository;

        public LoginForm(AuthService authService, IUserRepository userRepository)
        {
            _authService = authService;
            _userRepository = userRepository;

            InitializeComponent();
            Bindings();

            labelVersao.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            _userRepository = userRepository;
        }

        void Bindings()
        {
            buttonEntrar.Click += (sender, e) =>
            OnLoginButtonClick(sender, e, textBoxUsuario.Text, textBoxSenha.Text);

            buttonNovoUsuario.Click += (sender, e) =>
            OnButtonNovoUsuarioClick(sender, e, textBoxUsuario.Text, textBoxSenha.Text);
        }

        public void OnLoginButtonClick(object sender, EventArgs e, string username, string password)
        {
            if (_authService.Authenticate(username, password, out User user, out string message))
            {
                LoginAlert("Autenticado!", true);
            }
            else
            {
                LoginAlert(message, false);
            }

            // Solucao alternativa
            // Bem mais pratico, mas o try não me parece adequado.
            try
            {
                _authService.AuthenticateCatch(username, password);
            }
            catch (Exception ex)
            {
                LoginAlert(ex.Message, false);
            }
        }

        public void OnButtonNovoUsuarioClick(object sender, EventArgs e, string username, string password)
        {
            //MessageBox.Show(this, "Novo Usuário!", "Título", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoginAlert("Usuário criado com sucesso!", true);
        }

        public void LoginAlert(string message, bool success)
        {
            labelAlertaLogin.Text = message;
            labelAlertaLogin.ForeColor = success ? Color.DarkGreen : Color.Firebrick;
            this.labelAlertaLogin.Font = new System.Drawing.Font("Calibri", 8, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
