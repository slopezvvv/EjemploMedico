<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="EjemploMedico.index" %>
<%@ Import Namespace="EjemploMedico" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registro médico de pacientes</title>
</head>
<body>
    <form id="FormularioPacientes" runat="server">
    <% //FORM_PACIENTE %>
        <asp:Label ID="lblPNombre" runat="server"><% Response.Write(StringsEstaticos.P_NOMBRE); %> :</asp:Label><asp:TextBox ID="TxtPrimerNombre" runat="server"></asp:TextBox><br />
        <asp:Label ID="lblSNombre" runat="server"><% Response.Write(StringsEstaticos.S_NOMBRE); %> :</asp:Label><asp:TextBox ID="TxtSegundoNombre" runat="server"></asp:TextBox><br />
        <asp:Label ID="lblPApellido" runat="server"><% Response.Write(StringsEstaticos.P_APELLIDO); %> :</asp:Label><asp:TextBox ID="TxtPrimerApellido" runat="server"></asp:TextBox><br />
        <asp:Label ID="lblSApellido" runat="server"><% Response.Write(StringsEstaticos.S_APELLIDO); %> :</asp:Label><asp:TextBox ID="TxtSegundoApellido" runat="server"></asp:TextBox><br />
        <asp:Label ID="lblEdad" runat="server"><% Response.Write(StringsEstaticos.P_EDAD); %> :</asp:Label><asp:TextBox ID="TxtEdad" runat="server"></asp:TextBox><br />
        <asp:DropDownList ID="LTipoSangre" runat="server">
        </asp:DropDownList>
        <br />
        <asp:Button ID="FormularioPacienteSubmit" runat="server" OnClick="FormularioPacienteSubmit_Click" />
        
    <% //GRID_VIEW_PACIENTES %>
        <asp:GridView ID="GVPacientes" runat="server" Width="80%">
        </asp:GridView>
    </form>
</body>
</html>
