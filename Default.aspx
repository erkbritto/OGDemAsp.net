<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CadastroComSql.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="Estilos.css" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Cadastro</title>
    <style>
        body{
            color:white;
            background-color:black;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="cabecalho">
            <h1>Tela de Cadastro</h1>
            <br />
            <br />
            <hr />
        </div>
        <br />
        <br />
        <div class="formulario">
            <div class="form-group">
                <asp:Label runat="server" For="Nomelabel" ID="NomeLabel" Text="Nome:"></asp:Label>
                <asp:TextBox runat="server" ID="TextBoxNome" placeholder="Digite seu nome:"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label runat="server" for="LabelEmail" Text="Email:"></asp:Label>
                <asp:TextBox runat="server" type="email" CssClass="form-control" ID="TextBoxEmail" aria-describedby="emailHelp" placeholder="Digite o email:"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label runat="server" ID="LabelPassword" for="Password">Senha:</asp:Label>
                <asp:TextBox runat="server" type="password" CssClass="form-control" ID="TextBoxSenha" placeholder="Digite a senha:"></asp:TextBox>
            </div>
            <br />
            <div class="form-check">
                <asp:CheckBox runat="server" CssClass="form-check-input" />
                <asp:Label runat="server" CssClass="form-check-label">Eu concordo e aceito os termos e segurança</asp:Label>
            </div>
            <br />
            <asp:Button runat="server" ID="EnviaButton" type="submit" CssClass="btn" OnClick="EnviaButton_Click" Text="Enviar" />
            <asp:Button runat="server" ID="CancelaButton" type="button" CssClass="btn" OnClick="CancelaButton_Click" Text="Apagar" />
        </div>
    </form>
</body>
</html>

