// Рисование точками в терминале
Console.Clear();        // очищение консоли

int xa = 40, ya = 1;
int xb = 1, yb = 30;
int xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya);        // установка курсора в терминале по координатам
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);        // установка курсора в терминале по координатам
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);        // установка курсора в терминале по координатам
Console.WriteLine("+");

int x = xa, y = xb;

int count = 0;

while (count < 1000)
{
    int what = new Random().Next(0, 3);
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);        // установка курсора в терминале по координатам
    Console.WriteLine("+");
    count++;
}