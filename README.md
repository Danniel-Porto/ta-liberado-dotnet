# Taliberado - AutoLoginApp

Taliberado automatiza o processo de login com módulo, senha e código do autenticador.

Os dados de cada usuário ficarão salvos em um banco em núvem por segurança.

Opcionalmente, o usuário pode optar por salvar os dados em seu próprio computador utilizando a opção *offline*.

# Fluxo

O sistema inicia na tela de login, para inserir usuário e senha. A autenticação é extremamente simples e serve para permitir o usuário puxar os dados configurados do banco Firebase.

É feito uma consulta ao usuário e a senha é comparada.

É possível criar novo usuário, sem a necessidade de outra tela. Ele utiliza os campos de login para criar o usuário, apenas validando se já não existe.

Ao acessar o sistema, temos duas telas: A tela principal, onde a aplicação simplesmente está sendo executada, e é possível sair da conta ou clicar para acessar a tela de configurações. A tela de configurações é onde o usuário deve inserir a secret do autenticador da google e, opcionalmente, a senha do sistema para a automatização.

O looping de execução em segundo plano verifica se as informações obrigatórias foram fornecidas, do contrário, direciona para a tela de configurações e marca o campo de informação obrigatória. Só é possível salvar e ir para a execução se os campos obrigatórios estiverem preenchidos.

![TaLiberado drawio (5)](https://github.com/user-attachments/assets/b3f96d64-cda0-4cd5-a8aa-8eebb27888f9)

# Configurações

A tela de configurações permite inserir os dados para a automatização:

- Senha do sistema (opcional)
- Secret do autenticador da google

Opcionalmente, pode haver configurações adicionais para automatização do login em homologação:

- Login homologação
- Senha homolagação
- Configuração de qual banco utilizar (dropdown de enum)
- Matrícula
- Senha do sistema (a mesma da principal)

O sistema só precisa digitar o login a primeira vez em homologação, na segunda vez é possível logar utilizando a hotkey.

O menu de configurações também permite alterar hotkeys para os fluxos de login disponíveis. 

O menu de configurações tem a opção de excluir a conta e conta também com um botão para deslogar o usuário.

No modo *Online*, exclui os dados no firebase e desloga do usuário, limpando o singleton com os dados do usuário. No modo *Offline*, os dados locais do computador são apagados e se retorna para a tela de login.

# Offline Mode

Se trata de uma implementação da interface do repositório do usuário que permite que os dados sejam lidos e gravados em um arquivo local. O modo offline é acessado por um botão na tela de login que acessa o programa sem a necessidade de fornecer um usuário e senha.

## **Tecnologias Utilizadas**

- **C# (.NET)**: Linguagem principal para desenvolvimento da aplicação.
- **Windows Forms**: Framework utilizado para criar a interface gráfica do usuário.
- **Otp.NET**: Biblioteca para geração de códigos OTP (TOTP/HOTP).
- **MaterialSkin**: Para design da interface visual.
- **Microsoft Dependency Injection**: Para injeção de dependência.
- **Firebase:** Para armazenamento dos dados.

   **Armazenamento Seguro**:
   - As configurações, incluindo a chave secreta, são enviadas e armazenadas remotamente para maior segurança.

   **Execução em Segundo Plano**:
   - O programa minimiza para a bandeja do sistema e continua escutando os atalhos definidos.

## **Licença**

Este projeto está licenciado sob a licença MIT. Consulte o arquivo `LICENSE` para mais detalhes.

---

Feito com ❤️.
