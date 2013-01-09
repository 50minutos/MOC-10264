<%@ Page Language="C#" AutoEventWireup="true" %>

<div>
    <p>
        Olá,
        <%= Request.Form["nome"] %>,
    </p>
    <p>
        Conteúdo dinâmico criado em:
        <%= DateTime.Now.ToString("T") %>
    </p>
</div>
