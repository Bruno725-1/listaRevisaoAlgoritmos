using System;
class Ex6 {
    public static void Rodar () {
        Console.WriteLine("Digite dois números inteiros e positivos");
        if (int.TryParse(Console.ReadLine(), out int a) && int.TryParse(Console.ReadLine(), out int b)) {
            if (a <= 0 || b <= 0) {
                Console.WriteLine("Entrada inválida. Digite dois números inteiros e positivos.");
                return;
            }
            int mmc = a * b;
            int mdc = CalcularMDC (a, b);
            mmc = mmc / mdc;
            Console.WriteLine("MMC: " + mmc);
            Console.WriteLine("MDC: " + mdc);
        }
        else
        Console.WriteLine("Entrada inválida. Digite dois números inteiros e positivos.");
    }
    public static int CalcularMDC (int a, int b) {
        int resto;
        while (b != 0) {
            resto = a % b;
            a = b;
            b = resto;
        }
        return a;
    }
}