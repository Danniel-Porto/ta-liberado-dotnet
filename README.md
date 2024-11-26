# Taliberado - AutoLoginApp

**Taliberado** é uma aplicação simples desenvolvida em **C#** para automatizar processos de login em sistemas. A aplicação permite configurar fluxos de login personalizados, salvar dados remotamente e definir atalhos para execução rápida.

## **Funcionalidades**

- Configuração de múltiplos fluxos de login:
  - Preenchimento automático de campos de login e senha.
  - Geração automática de códigos OTP (One-Time Password) usando o Autenticador Google.
- Suporte a atalhos configuráveis (Hotkeys).
- Interface simples para configurar e gerenciar fluxos de login.
- Execução em segundo plano com um ícone na bandeja do sistema.
- Armazenamento seguro de configurações remotamente.

## **Tecnologias Utilizadas**

- **C# (.NET)**: Linguagem principal para desenvolvimento da aplicação.
- **Windows Forms**: Framework utilizado para criar a interface gráfica do usuário.
- **Otp.NET**: Biblioteca para geração de códigos OTP (TOTP/HOTP).
- **API REST (Opcional)**: Para armazenamento remoto de configurações.

## **Como Funciona**

1. **Configuração Inicial**:
   - O usuário define seu login, senha e chave secreta do Autenticador Google (se aplicável) na interface do programa.
   - O usuário escolhe atalhos (Hotkeys) para executar cada fluxo de login.

2. **Execução do Login**:
   - O programa escuta os atalhos configurados.
   - Ao ativar uma hotkey, o programa executa o fluxo de login associado:
     1. Digita o login e a senha automaticamente.
     2. Gera o código OTP baseado na chave secreta fornecida.
     3. Preenche os campos e finaliza o login.

3. **Armazenamento Seguro**:
   - As configurações, incluindo a chave secreta, são enviadas e armazenadas remotamente para maior segurança.

4. **Execução em Segundo Plano**:
   - O programa minimiza para a bandeja do sistema e continua escutando os atalhos definidos.

## **Como Usar**

### **Requisitos**

- Windows 10 ou superior.
- .NET 6 ou superior instalado.

### **Instalação**

1. Clone este repositório:
   ```bash
   git clone https://github.com/seu-usuario/taliberado.git
   ```

2. Abra o projeto no **Visual Studio**.

3. Compile o projeto (pressione `F5` ou clique em **Build > Build Solution**).

4. Execute o aplicativo gerado na pasta `bin/Debug`.

### **Configuração**

1. Abra o programa.
2. Configure os seguintes campos:
   - **Login e senha**: Informações necessárias para o login no sistema.
   - **Chave secreta**: Código base para geração de OTP (opcional).
   - **Hotkeys**: Selecione as combinações de teclas que executarão cada fluxo de login.
3. Salve as configurações.

### **Fluxo de Login**

- Pressione o atalho configurado (Hotkey).
- O programa automaticamente preenche os campos e finaliza o login.

## **Armazenamento Remoto**

As configurações sensíveis (como a chave secreta) podem ser armazenadas remotamente:

1. Configure um servidor para receber e armazenar os dados via API REST.
2. Configure a URL do servidor no programa para sincronizar as configurações.

Exemplo de API esperada:
```json
POST /api/save
{
  "login": "seu-login",
  "senha": "sua-senha",
  "secret": "sua-chave-secreta"
}
```

## **Personalização**

- Adicione novos fluxos de login para sistemas diferentes.
- Configure novos atalhos para ações específicas.

## **Segurança**

- As senhas e segredos são transmitidos via conexão segura (HTTPS).
- Utilize métodos de autenticação na API para proteger os dados.

## **Contribuição**

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues e pull requests.

## **Licença**

Este projeto está licenciado sob a licença MIT. Consulte o arquivo `LICENSE` para mais detalhes.

---

Feito com ❤️.
