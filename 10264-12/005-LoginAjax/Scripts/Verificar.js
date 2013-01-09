function Verificar() {
    Seguranca.Verificar(ProcessarResultado);
}

function ProcessarResultado(resultado) {
    if (resultado != true) location.href("/Login.aspx");
}