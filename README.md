## Descrição
O programa é um gerador de senhas que permite ao usuário personalizar o comprimento da senha e escolher se deseja incluir letras maiúsculas, minúsculas, números e caracteres especiais.

## Lógica
- O programa solicita ao usuário as configurações desejadas para a senha: comprimento, inclusão de letras maiúsculas, minúsculas, números e caracteres especiais.
- Com base nas escolhas do usuário, o método `geradorSenha()` é chamado para criar a senha.
- O método `geradorSenha()` utiliza arrays predefinidos de letras maiúsculas, minúsculas, números e caracteres especiais.
- A lógica do método seleciona aleatoriamente os tipos de caracteres de acordo com as escolhas do usuário e monta a senha.
- A senha gerada é exibida ao usuário, que tem a opção de gerar outra senha ou finalizar o programa.
## Métodos

### Main()
- **Descrição:** Método principal que inicia a execução do programa.
- **Funcionalidades:**
  - Solicita o comprimento da senha.
  - Pergunta se a senha terá letras maiúsculas, minúsculas, números e caracteres especiais.
  - Chama o método `geradorSenha()` para gerar a senha.
  - Exibe a senha gerada e pergunta se o usuário deseja gerar outra senha.

### GeradorSenha(int compSenha, char teraMaiuscula, char teraMinuscula, char teraNumeros, char teraCaractersEspeciais)
- **Descrição:** Método que gera a senha com base nas configurações fornecidas.
- **Parâmetros:**
  - `compSenha`: Comprimento da senha a ser gerada.
  - `teraMaiuscula`: Indica se a senha terá letras maiúsculas.
  - `teraMinuscula`: Indica se a senha terá letras minúsculas.
  - `teraNumeros`: Indica se a senha terá números.
  - `teraCaractersEspeciais`: Indica se a senha terá caracteres especiais.
- **Retorno:** Retorna a senha gerada como uma string.
