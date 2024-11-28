using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ta_liberado
{
    internal class AuthService
    {
        static UserRepository userRepository = new UserRepository(); // Realizar injecao de dependencia

        // Implementar criptografia de uma via: só criptografa, nunca descriptografa.
        // Permitir usuario a utilizar o modo local, onde os dados ficam salvos no computador dele.
        // Os dados ficam salvos criptografados e a secret para decriptografar ficaria dentro do código fonte.

        // Remover STATIC
        public static bool Authenticate(string username, string password, out User user, out string message)
        {
            message = "";
            user = null;

            try
            {
                user = userRepository.GetUserByName(username);
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

        // Alternativa
        public static User AuthenticateCatch(string username, string password)
        {
            User user = userRepository.GetUserByName(username);
            if (user == null || user.Password != password) 
            {
                throw new Exception("Usuário ou senha inválido(s).");
            }
            return user;
        }
    }
}
