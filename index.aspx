<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="EjemploMedico.index" %>
<%@ Import Namespace="EjemploMedico" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registro médico de pacientes</title>
</head>
<body>
    <form id="FormularioPaciente" runat="server">
        <input type="text" id="TxtPrimerNombre" placeholder='<% Response.Write(StringsEstaticos.P_NOMBRE); %>'/><br />
        <input type="text" id="TxtSegundoNombre" placeholder='<% Response.Write(StringsEstaticos.S_NOMBRE); %>'/><br />
        <input type="text" id="TxtPrimerApellido" placeholder='<% Response.Write(StringsEstaticos.P_APELLIDO); %>'/><br />
        <input type="text" id="TxtSegundoApellido" placeholder='<% Response.Write(StringsEstaticos.S_APELLIDO); %>'/><br />
        <input id="FormularioPacienteSubmit" type="submit" value="Registrar paciente" />
    </form>
</body>
</html>
