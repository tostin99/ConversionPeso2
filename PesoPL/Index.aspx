<%@ Page Language="C#" Async ="true" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="PesoPL.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
  <title>Conversor de Peso</title>
  <link href="https://stackpath.bootstrapcdn.com/bootstrap/5.0.0-alpha1/css/bootstrap.min.css" rel="stylesheet" />
  <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
  <script src="https://stackpath.bootstrapcdn.com/bootstrap/5.0.0-alpha1/js/bootstrap.bundle.min.js"></script>
  <style>
      
      html, body {
    height: 100%;
    margin: 0;
    font-family: Arial, sans-serif;
    background-color: #f8f8f8; 

#form1 {
    min-height: 100%;
    display: flex;
    flex-direction: column;
    justify-content: center; 
}

.content {
    flex: 1;
    display: flex;
    flex-direction: column;
    justify-content: center; 
    align-items: center; 
    padding: 50px; 
    background-color: #e6e6fa; 
    border-radius: 10px; 
    margin-top: 50px; 
}

h1 {
    font-size: 20px;
    margin-bottom: 10px; 
}

.footer {
    margin-top: auto; 
    background-color: #ffa500; 
    color: #fff; 
    text-align: center;
    padding: 20px 0;
    border-top: 2px solid #ff6347; 
}



    /*  html, body {
          height: 100%;
          margin: 0;
      }

      #form1 {
          min-height: 100%;
          display: flex;
          flex-direction: column;
      }

      .content {
          flex: 1;
          display: flex;
          flex-direction: column;
          justify-content: center; 
      }

      .footer {
          margin-top: auto; 
          background-color: #f5f5f5;
          text-align: center;
          padding: 20px 0;
      }*/
  </style>

</head>

<body>
    <form id="form1" runat="server">
        <nav class="navbar navbar-expand-lg navbar-dark bg-dark fixed-top">
            <div class="container">
                <a class="navbar-brand" href="#">Conversor de Peso</a>
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarResponsive">
                    <ul class="navbar-nav ml-auto">
                        <li class="nav-item active">
                            <a class="nav-link" href="#">Inicio
                                <span class="sr-only">(current)</span>
                            </a>
                        </li>
                        
                    </ul>
                </div>
            </div>
        </nav>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div class="content container mt-4">
                    <h2>Convertidor de Peso</h2>
                    <asp:TextBox ID="txtPeso" runat="server" CssClass="form-control mt-2" placeholder="Ingresa el Peso" />
                    <asp:DropDownList ID="ddlFrom" runat="server" CssClass="form-control mt-2">
                        <asp:ListItem Text="Kilogramos" Value="K" />
                        <asp:ListItem Text="Libra" Value="L" />
                        <asp:ListItem Text="Onzas" Value="O" />
                        <asp:ListItem Text="Toneladas" Value="T" />
                        <asp:ListItem Text="Tonelada USA" Value="TU" />
                         <asp:ListItem Text="Toneladas UK" Value="TK" />

                    </asp:DropDownList>
                    <asp:DropDownList ID="ddlTo" runat="server" CssClass="form-control mt-2">
                        <asp:ListItem Text="Kilogramos" Value="K" />
                        <asp:ListItem Text="Libra" Value="L" />
                        <asp:ListItem Text="Onzas" Value="O" />
                        <asp:ListItem Text="Toneladas" Value="T" />
                        <asp:ListItem Text="Tonelada USA" Value="TU" />
                        <asp:ListItem Text="Toneladas UK" Value="TK" />
                    </asp:DropDownList>
                    <asp:Button ID="btnConvert" runat="server" Text="Convertir" CssClass="btn btn-primary mt-2" OnClick="btnConvert_Click" />
                    <asp:Label ID="lblResult" runat="server" CssClass="alert alert-info mt-2" Visible="false" />
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>

        <footer class="footer">
            <div class="container">
                <span>&copy; 2024 Jostin Mora</span>
            </div>
        </footer>
    </form>
</body>
</html>
