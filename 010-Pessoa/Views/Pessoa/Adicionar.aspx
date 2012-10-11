<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<_010_Pessoa.Models.Pessoa>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Adicionar</title>
</head>
<body>
    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Codigo) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Codigo) %>
                <%: Html.ValidationMessageFor(model => model.Codigo) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Nome) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Nome) %>
                <%: Html.ValidationMessageFor(model => model.Nome) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.SobreNome) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.SobreNome) %>
                <%: Html.ValidationMessageFor(model => model.SobreNome) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Idade) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Idade) %>
                <%: Html.ValidationMessageFor(model => model.Idade) %>
            </div>
            
            <p>
                <input type="submit" value="Adicionar" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Voltar", "Index") %>
    </div>

</body>
</html>

