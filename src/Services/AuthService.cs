using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ta_liberado
{
    public class AuthService
    {
        private readonly IUserRepository _userRepository; // Realizar injecao de dependencia

        // O DI vai injetar automaticamente o UserRepository, com o FirestoreDb já configurado
        public AuthService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // Implementar criptografia de uma via: só criptografa, nunca descriptografa.
        // Permitir usuario a utilizar o modo local, onde os dados ficam salvos no computador dele.
        // Os dados ficam salvos criptografados e a secret para decriptografar ficaria dentro do código fonte.

        public bool Authenticate(string username, string password, out User user, out string message)
        {
            message = "";
            user = null;

            try
            {
                user = _userRepository.GetUserByName(username);
                if (user == null)
                {
                    message = "Usuário ou senha inválido(s).";
                    return false;
                }

                if (user.Password == password)
                {
                    return true;
                }
                else
                {
                    message = "Usuário ou senha inválido(s).";
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool VerifyUser(string username, string password, out string message)
        {
            message = "";

            try
            {
                User user = _userRepository.GetUserByName(username);
                if (user != null)
                {
                    message = "Usuário Já existente!";
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }



        // Alternativa
        public User AuthenticateCatch(string username, string password)
        {
            User user = _userRepository.GetUserByName(username);
            if (user == null || user.Password != password) 
            {
                throw new Exception("Usuário ou senha inválido(s).");
            }
            return user;
        }
    }
}
