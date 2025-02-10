using System;
using System.Globalization;
class Ex1 {
    public static void Rodar () {
        Console.WriteLine("Digite dois números:");
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        if (SaoAmigos(n1, n2))
        Console.WriteLine($"Os números {n1} e {n2} são amigos");
    }
    public static bool SaoAmigos (int n1, int n2) {
        int soma1 = 0, soma2 = 0;
        for (int i = 1; i <= n1 / 2; i++) {
            if (n1 % i == 0) //encontrou um divisor
            soma1 += i;
        }
        for (int i = 1; i <= n2 / 2; i++) {
            if (n2 % i ==0)
            soma2 += i;
        }
        if (soma1 == n2 && soma2 == n1)
            return true;
        return false;
    }
}