using System;
class Ex2 {
    public static void Rodar () {
        Console.WriteLine("Digite um número");
        if (int.TryParse(Console.ReadLine(), out int num)) {
            if (EhPerfeito (num))
            Console.WriteLine("Número perfeito");
            else
            Console.WriteLine("Este número não é perfeito");
        }
        else
        Console.WriteLine("Entrada inválida. Digite um número inteiro");
    }
    public static bool EhPerfeito (int num) {
        int soma = 0;
        for (int i = 1; i <= num /2; i++) {
            if (num % i == 0)
            soma += i;
        }
        return soma == num;
    }
}