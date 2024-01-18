Operações de Gerenciamento de Dados em C# usando asp.net
	
Uma página de cadastro simples com RequiredFieldValidator onde (Nome, e-mail, senha) são necessários para o Banco de dados SQL fazer a verificação e validação dos dados recebidos do usuário
Foi usado na construção do projeto: ASP.NET, C#, SQL,CSS 3.

## Como Iniciar

1. Clone o repositório.
2. Abra o projeto no Visual Studio.
3. Configure as variáveis de ambiente no arquivo.
4. Execute o aplicativo.

## Requisitos do Sistema

- framework ASP.NET atribuido a versão do seu visual studio
-possuir o Sql Sever instalado na maquina com as configurações do Banco De Dados

## para fazer a criação exatamente da forma que foi feita no meu projeto siga os passos a seguir
1.crie sua base de dados
2.crie a tabela dentro da base de dados com as informações logo abaixo
3.Faça uma consulta na tabela para verificar cada informação atribuida

        Create Database CadastroComSql;
            Create table Cadastro(
                ID          Int Primary Key Identity (1,1) Not For Replication,
                Usuario     Varchar(30),
                email       Varchar(255),
                Senha       Varchar(20)
            );
                Select * From Cadastro;

## observação

Projeto desenvolvido por mim para me ajudar e ajudar outros desenvolvedores que queiram fazer o mesmo e para própria analise
do recrutador ou desenvolvedor que pode entrar em contato comigo em
Linkdin:https://www.linkedin.com/in/erkbritto/
Instagram:https://www.instagram.com/erkbritto/
