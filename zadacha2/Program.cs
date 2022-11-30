Console.Write("Введите два числа через пробел и я покажу что больше, а что меньше: ");

var input = Console.ReadLine();
var space = input.Split(" ");
int a = int.Parse(space[0]);
int b = int.Parse(space[1]);
int min = a;
int max = b;

if (max < min) {
    min = b;
    max = a;
}

Console.WriteLine("min это — {0}, а max это — {1}", min, max);