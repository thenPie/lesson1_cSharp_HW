Console.Write("Введите число ");

int isEven = int.Parse(Console.ReadLine());

if (isEven % 2 == 0) {
    Console.Write("Число {0} является чётным", isEven);
} else {
    Console.Write("Число не является чётным");
}