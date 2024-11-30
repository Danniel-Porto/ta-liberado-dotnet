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
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        void Bindings()
        {
            buttonEntrar.Click += (sender, e) =>
            OnButtonClickLogin(sender, e, textBoxUsuario.Text, textBoxSenha.Text);

            buttonNovoUsuario.Click += (sender, e) =>
            OnButtonClickNewUser(sender, e, textBoxUsuario.Text, textBoxSenha.Text);
        }

        public void OnButtonClickLogin(object sender, EventArgs e, string username, string password)
        {
            if (_authService.Authenticate(username, password, out User user, out string message))
            {
                Alert("Autenticado!", true);
            }
            else
            {
                Alert(message, false);
            }
        }

        public void OnButtonClickNewUser(object sender, EventArgs e, string username, string password)
        {
            if (!_authService.VerifyUser(username, password, out string message))
            {
                User user = new User(username, password);

                _userRepository.AddUser(user);
                Alert("Novo usuário criado!", true);
            }
            else
            {
                Alert(message, false);
            }
        }

        public void Alert(string message, bool success)
        {
            labelAlertaLogin.Text = message;
            labelAlertaLogin.ForeColor = success ? Color.DarkGreen : Color.Firebrick;
            this.labelAlertaLogin.Font = new System.Drawing.Font("Calibri", 8, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {
            textBoxSenha.PasswordChar = '*';
        }

        private void labelVersao_Click(object sender, EventArgs e)
        {
            
        }
    }
}
