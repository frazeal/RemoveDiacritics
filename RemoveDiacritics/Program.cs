using System;

namespace RemoveDiacritics
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "Código é Muito difícil de escrever. Por isso é imporantíssimo fazer muitos exercícios. Faça! Faça! Hoje e amanhã.";
            string texto2 = "Testando um código que contém caracteres \t\t\tnuméricos e outros: 109808| 098\\ 041?82/0128-=+*&¨94 091";
            Console.WriteLine(texto.RemoveDiacritics());
            Console.WriteLine(texto2.RemoveDiacritics2());
            Console.ReadKey();
        }
    }
}
