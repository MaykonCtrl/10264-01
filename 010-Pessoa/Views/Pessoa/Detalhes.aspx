<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<_010_Pessoa.Models.Pessoa>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Detalhes</title>
    <style type="text/css">
        .display-field
        {
            font-weight: bold;
        }
    </style>
</head>
<body>
    <fieldset>
        <legend>Fields</legend>
        
        <div class="display-label">Codigo</div>
        <div class="display-field"><%: Model.Codigo %></div>
        
        <div class="display-label">Nome</div>
        <div class="display-field"><%: Model.Nome %></div>
        
        <div class="display-label">SobreNome</div>
        <div class="display-field"><%: Model.SobreNome %></div>
        
        <div class="display-label">Idade</div>
        <div class="display-field"><%: Model.Idade %></div>
        
    </fieldset>
    <p>
        <%: Html.ActionLink("Editar", "Editar", new { id=Model.Codigo })%> |
        <%: Html.ActionLink("Back to List", "Index") %>
    </p>

</body>
</html>

