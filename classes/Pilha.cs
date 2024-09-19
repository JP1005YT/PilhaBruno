public class Pilha
{
    private Nodo topo;

    public Pilha()
    {
        topo = null;
    }

    public void Push(Documento documento)
    {
        Nodo novoNodo = new Nodo(documento);
        novoNodo.Proximo = topo;
        topo = novoNodo;
        Console.WriteLine($"Documento '{documento.NomeDoArquivo}.{documento.ExtensaoDoArquivo}' adicionado à pilha.");
    }

    public Documento Pop()
    {
        if (Vazia())
        {
            Console.WriteLine("Pilha vazia! Não é possível remover documentos.");
            return null;
        }
        Documento documentoRemovido = topo.Documento;
        topo = topo.Proximo;
        Console.WriteLine($"Documento '{documentoRemovido.NomeDoArquivo}.{documentoRemovido.ExtensaoDoArquivo}' removido da pilha.");
        return documentoRemovido;
    }

    public bool Busca(string nome, string extensao)
    {
        Nodo atual = topo;
        while (atual != null)
        {
            if (atual.Documento.NomeDoArquivo == nome && atual.Documento.ExtensaoDoArquivo == extensao)
            {
                return true;
            }
            atual = atual.Proximo;
        }
        return false;
    }

    public void Imprimir()
    {
        Nodo atual = topo;
        if (Vazia())
        {
            Console.WriteLine("Pilha vazia!");
            return;
        }
        Console.WriteLine("Documentos na pilha:");
        while (atual != null)
        {
            var doc = atual.Documento;
            Console.WriteLine($"{doc.NomeDoArquivo}.{doc.ExtensaoDoArquivo} ({doc.TamanhoDoArquivo} KB)");
            atual = atual.Proximo;
        }
    }

    public bool Vazia()
    {
        return topo == null;
    }
    public int ContarElementos()
{
    int contador = 0;
    Nodo atual = topo;
    while (atual != null)
    {
        contador++;
        atual = atual.Proximo;
    }
    return contador;
}
    public int ContarImpares()
{
    int contador = 0;
    Nodo atual = topo;
    while (atual != null)
    {
        if (atual.Documento.TamanhoDoArquivo % 2 != 0)
        {
            contador++;
        }
        atual = atual.Proximo;
    }
    return contador;
}
    public (Pilha pilhaPositivos, Pilha pilhaNegativos) SepararPositivosNegativos()
{
    Pilha pilhaPositivos = new Pilha();
    Pilha pilhaNegativos = new Pilha();
    Nodo atual = topo;

    while (atual != null)
    {
        if (atual.Documento.TamanhoDoArquivo > 0)
        {
            pilhaPositivos.Push(atual.Documento);
        }
        else
        {
            pilhaNegativos.Push(atual.Documento);
        }
        atual = atual.Proximo;
    }
    return (pilhaPositivos, pilhaNegativos);
}
    public void InverterLetras()
{
    Pilha pilhaTemp = new Pilha();
    Nodo atual = topo;

    while (atual != null)
    {
        pilhaTemp.Push(atual.Documento); // Aqui, consideramos que Documento é um caractere
        atual = atual.Proximo;
    }

    topo = pilhaTemp.topo; // Atualiza a pilha original
}
    public bool VerificarPalindromo()
{
    Pilha pilhaTemp = new Pilha();
    Nodo atual = topo;

    while (atual != null)
    {
        pilhaTemp.Push(atual.Documento);
        atual = atual.Proximo;
    }

    atual = topo;
    Nodo atualTemp = pilhaTemp.topo;

    while (atual != null)
    {
        if (atual.Documento.NomeDoArquivo != atualTemp.Documento.NomeDoArquivo)
        {
            return false;
        }
        atual = atual.Proximo;
        atualTemp = atualTemp.Proximo;
    }
    return true;
}
    public Pilha TransferirParaOutraPilha()
{
    Pilha pilhaDestino = new Pilha();
    Nodo atual = topo;
    List<Documento> elementos = new List<Documento>();

    while (atual != null)
    {
        elementos.Add(atual.Documento);
        atual = atual.Proximo;
    }

    // Adiciona na pilha destino na ordem correta
    for (int i = elementos.Count - 1; i >= 0; i--)
    {
        pilhaDestino.Push(elementos[i]);
    }

    return pilhaDestino;
}

}
