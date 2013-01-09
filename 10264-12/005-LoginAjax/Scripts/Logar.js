function Logar(nome, senha) {
    Seguranca.Logar(nome, senha, ProcessarResultado, null, null);
}

function ProcessarResultado(resultado) {
    location.href("WebForm1.aspx");
}
