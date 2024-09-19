public class Nodo
{
    public Documento Documento { get; set; }
    public Nodo Proximo { get; set; }

    public Nodo(Documento documento)
    {
        Documento = documento;
        Proximo = null;
    }
}
