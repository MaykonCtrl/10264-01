﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<_013_MVC_EF.Pessoa>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Delete</title>
</head>
<body>
    <h3>Are you sure you want to delete this?</h3>
    <fieldset>
        <legend>Fields</legend>
        
        <div class="display-label"><%: Html.LabelFor(model => model.Codigo) %></div>
        <div class="display-field"><%: Model.Codigo %></div>
        
        <div class="display-label"><%: Html.LabelFor(model => model.Nome) %></div>
        <div class="display-field"><%: Model.Nome %></div>
        
        <div class="display-label"><%: Html.LabelFor(model => model.Sexo) %></div>
        <div class="display-field"><%: Model.Sexo %></div>
        
    </fieldset>
    <% using (Html.BeginForm()) { %>
        <p>
		    <input type="submit" value="Delete" /> |
		    <%: Html.ActionLink("Back to List", "Index") %>
        </p>
    <% } %>

</body>
</html>

