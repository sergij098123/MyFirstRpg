
creator();
Console.WriteLine("              --Привіт--                 ");

player();
Console.WriteLine("      > Привіт, а ти хто такий?          ");
var in1 = Console.ReadKey(true).Key;

creator();
Console.WriteLine("--Я розробник цієї програми, а ти хто?--");

player();
var your_name = Console.ReadLine();

creator();
Console.WriteLine("--А мене можеш називати творцем, " + your_name + "--");
in1 = Console.ReadKey(true).Key;

Console.WriteLine("--Існує пророчество, що прийде ангел,-- ");
in1 = Console.ReadKey(true).Key;
    
Console.WriteLine("--який спасе світ від знищення--      ");
in1 = Console.ReadKey(true).Key;

Console.WriteLine("--Сподіваюсь, що в ньому писалось про тебе," + your_name+"--");
in1 = Console.ReadKey(true).Key;

Console.WriteLine("--А я всього лише спостерігаю за цим світом--");
Console.WriteLine("-- =) --");
in1 = Console.ReadKey(true).Key;

Console.WriteLine("--До зустрічі," + your_name+"--");
in1 = Console.ReadKey(true).Key;

player();
Console.WriteLine(your_name +", як ви важаєте, чи це ви ");
Console.WriteLine("   ангел, який спасе весь світ?      ");
Console.WriteLine("  >так             .ні               ");
in1 = Console.ReadKey(true).Key;

var choose = true;

while (in1 !=ConsoleKey.Enter)
{ 
    chooseF(choose, in1);
    in1 = Console.ReadKey(true).Key;
}

static void chooseF(bool  choose,ConsoleKey in1)
{
    if (in1 == ConsoleKey.RightArrow)
    {
        choose = false;
        Console.WriteLine("  .так             >ні               ");
    }
    if (in1 == ConsoleKey.LeftArrow)
    {
        choose = false;
        Console.WriteLine("  >так             .ні               ");
    }
};
Console.Clear();
static void player()
{
    Console.BackgroundColor = ConsoleColor.Cyan;
    Console.ForegroundColor = ConsoleColor.Black;
}
static void creator()
{
    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.White;
}