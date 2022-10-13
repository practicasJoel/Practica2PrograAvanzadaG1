<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Incluir_Empleado.aspx.cs" Inherits="g5_practica_programada_2.Empleado.Incluir_Empleado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Codigo<asp:TextBox ID="TxtCodigo" runat="server"></asp:TextBox><br />
            Nombre<asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox><br />
            Horas<asp:TextBox ID="TxtHoras" runat="server"></asp:TextBox><br />
            SalarioHora<asp:TextBox ID="TxtSal_Hora" runat="server"></asp:TextBox><br />
            SalarioBruto<asp:TextBox ID="TxtSal_Bruto" runat="server"></asp:TextBox><br />
            <asp:Button ID="btn_Incluir" runat="server" Text="Incluir" OnClick="btn_Incluir_Click" />
        </div>
    </form>
</body>
</html>
