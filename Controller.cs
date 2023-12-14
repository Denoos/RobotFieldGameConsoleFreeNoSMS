// класс для ввода данных
using System.Drawing.Printing;

internal class Controller
{
    private MainCommander mainCommander;
    

    public Controller(MainCommander mainCommander)
    {
        this.mainCommander = mainCommander;
        mainCommander.SetInterpretator(new FieldCommander());
    }

    // цикл по запросу команды
    internal void StartListner()
    {
        bool konecNigga = true;
        Console.WriteLine("2 - непреадолимое для самурая препятствие, 1 - пустое место в жизни самурая , 3 - дом где растили самурая, 4 - цель жизни самурая");
        Console.WriteLine("Введите 25 символов для определения места рождения самурая");
        int[] array = new int[25];
        for (int i = 0; i < array.Length; i++)
        { 
            int.TryParse(Console.Read().ToString(), out int f);
            
            array[i] = f;
        }
        mainCommander.Execute(array); // первый запрос на 25 символов (рисование поля) передается mainCommander в метод Execute

        mainCommander.SetInterpretator( new RobotCommander());// смена интерпретатора у mainCommander на RobotCommander

        while (konecNigga)
        {
            
            Console.WriteLine("Выберите следующее действие в достижении цели Самурая");
            int.TryParse(Console.ReadLine(), out int g);
            mainCommander.Execute(new int[] { g });
        }// остальные запросы передаются туда же (цикл, пока робот не достигнет конечной точки)
    }
}
