public class Documento
{
    public string NomeDoArquivo { get; set; }
    public string ExtensaoDoArquivo { get; set; }
    public int TamanhoDoArquivo { get; set; }

    public Documento(string nome, string extensao, int tamanho)
    {
        NomeDoArquivo = nome;
        ExtensaoDoArquivo = extensao;
        TamanhoDoArquivo = tamanho;
    }
}
