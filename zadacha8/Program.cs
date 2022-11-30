Console.Write("Введите число ");

int until = int.Parse(Console.ReadLine());

for (int i = 2; i <= until; i = i + 2) {
    Console.Write("{0} ", i);
}