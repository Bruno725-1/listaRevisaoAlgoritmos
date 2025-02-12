using System;
class Ex4 {
    public static void Rodar () {
        int primos = 0;
        Console.WriteLine("Digite dois números inteiros e positivos:");
        if (int.TryParse(Console.ReadLine(), out int a) && int.TryParse(Console.ReadLine(), out int b)) {
            if (a <= 0 || b <= 0) {
                Console.WriteLine("Entrada inválida. Digite dois números inteiros e positivos");
                return;
            }
            Console.WriteLine("Números primos:");
            for (int i = a; i <= b; i++) {
                if (EhPrimo (i)) {
                    Console.WriteLine(i);
                    primos++;
                }
            }
            Console.WriteLine($"O intervalo contém {primos} números primos");
        }
        else
        Console.WriteLine("Entrada inválida. Digite dois números inteiros e positivos");
    }
    public static bool EhPrimo (int num) {
        if (num <= 2)
        return false;
        for (int i = 2; i <= Math.Sqrt(num); i++) {
            if (num % i == 0)
            return false;
        }
        return true;
    }
}
