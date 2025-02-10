using System;
class Ex3 {
    public static void Rodar () {
        Console.WriteLine("Digite três números inteiros e positivos");
        if (int.TryParse(Console.ReadLine(), out int n1)&& int.TryParse(Console.ReadLine(), out int n2) && int.TryParse(Console.ReadLine(), out int n3)) {
            if (n1 <= 0 || n2 <=0 || n3 <= 0) {
                Console.WriteLine("Entrada inválida. Os números devem ser inteiros e positivos.");
                return;
            }
            if (n1 == n2 && n2 == n3) {
                Console.WriteLine("Triângulo equilátero");
            }
            else if (n1 == 90 || n2 == 90 || n3 == 90)
            Console.WriteLine("Triângulo retângulo");
            else if (n1 != n2 && n2 != n3 && n3 != n1)
            Console.WriteLine("Triângulo escaleno");
            else if (n1 == n2 || n1 == n3 || n2 == n3)
            Console.WriteLine("Triângulo isósceles");
        }
        else
        Console.WriteLine("Entrada inválida. Os números devem ser inteiros e positivos.");
    }
}