class Program
{
    static void Main(string[] args)
    {
        Pilha pilhaNumeros = new Pilha();
        pilhaNumeros.Push(new Documento("1", "", 1));
        pilhaNumeros.Push(new Documento("-2", "", -2));
        pilhaNumeros.Push(new Documento("7", "", 7));
        pilhaNumeros.Push(new Documento("-15", "", -15));
        pilhaNumeros.Push(new Documento("51", "", 51));
        pilhaNumeros.Push(new Documento("-23", "", -23));

        Console.WriteLine($"Total de elementos na pilha: {pilhaNumeros.ContarElementos()}");
        Console.WriteLine($"Total de números ímpares na pilha: {pilhaNumeros.ContarImpares()}");

        var (pilhaPositivos, pilhaNegativos) = pilhaNumeros.SepararPositivosNegativos();
        Console.WriteLine("Pilha de positivos:");
        pilhaPositivos.Imprimir();
        Console.WriteLine("Pilha de negativos:");
        pilhaNegativos.Imprimir();

        Pilha pilhaLetras = new Pilha();
        pilhaLetras.Push(new Documento("E", "", 0));
        pilhaLetras.Push(new Documento("U", "", 0));
        pilhaLetras.Push(new Documento("A", "", 0));
        pilhaLetras.Push(new Documento("M", "", 0));
        pilhaLetras.Push(new Documento("O", "", 0));
        pilhaLetras.Push(new Documento("P", "", 0));
        pilhaLetras.Push(new Documento("R", "", 0));
        pilhaLetras.Push(new Documento("O", "", 0));
        pilhaLetras.Push(new Documento("G", "", 0));
        pilhaLetras.Push(new Documento("R", "", 0));
        pilhaLetras.Push(new Documento("A", "", 0));
        pilhaLetras.Push(new Documento("M", "", 0));
        pilhaLetras.Push(new Documento("A", "", 0));
        pilhaLetras.Push(new Documento("R", "", 0));

        pilhaLetras.InverterLetras();
        Console.WriteLine("Pilha após inversão das letras:");
        pilhaLetras.Imprimir();

        Console.WriteLine("Verificando se 'RADAR' é palíndromo:");
        Console.WriteLine(pilhaLetras.VerificarPalindromo() ? "É PALÍNDROMO" : "NÃO É PALÍNDROMO");

        Pilha pilhaDestino = pilhaNumeros.TransferirParaOutraPilha();
        Console.WriteLine("Pilha de destino após a transferência:");
        pilhaDestino.Imprimir();
    }
}