Console.Write("Введите три числа через пробел и я покажу max из них: ");

var input = Console.ReadLine();
var space = input.Split(" ");
int one = int.Parse(space[0]);
int two = int.Parse(space[1]);
int three = int.Parse(space[2]);
int max = one;

if (max < two) {
    max = two;
}
if (max < three) {
    max = three;
}

Console.WriteLine("max это — {0}", max);