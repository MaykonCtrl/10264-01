<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<_010_Pessoa.Models.Pessoa>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Index</title>
</head>
<body>
    <table>
        <tr>
            <th>Comandos</th>
            <th>
                Codigo
            </th>
            <th>
                Nome
            </th>
            <th>
                SobreNome
            </th>
            <th>
                Idade
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "Editar", new {  id=item.Codigo  }) %> |
                <%: Html.ActionLink("Detalhes", "Detalhes", new {  id=item.Codigo  })%> |
                <%: Html.ActionLink("Excluir", "Excluir", new { id = item.Codigo })%>
            </td>
            <td>
                <%: item.Codigo %>
            </td>
            <td>
                <%: item.Nome %>
            </td>
            <td>
                <%: item.SobreNome %>
            </td>
            <td>
                <%: item.Idade %>
            </td>
            
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Novo", "Adicionar")%>
    </p>

</body>
</html>

