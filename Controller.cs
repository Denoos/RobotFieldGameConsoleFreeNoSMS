// класс для ввода данных
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
        Console.WriteLine("1 - непреадолимое для самурая препятствие, 2 - пустое место в жизни самурая , 3 - дом где растили самурая, 4 - цель жизни самурая");
        Console.WriteLine("Введите 25 символов для определения места рождения самурая");
        int[] array = new int[25];
        for (int i = 0; i < array.Length; i++)
        { 
            int.TryParse(Console.Read().ToString(), out int f);
            array[i] = f;
        }
        mainCommander.Execute(array); // первый запрос на 25 символов (рисование поля) передается mainCommander в метод Execute


        mainCommander.SetInterpretator( new RobotCommander());// смена интерпретатора у mainCommander на RobotCommander

        while (true)
        {
            Console.WriteLine("Выберите следующее действие в достижении цели Самурая");
            int.TryParse(Console.Read().ToString(), out int f);
        }// остальные запросы передаются туда же (цикл, пока робот не достигнет конечной точки)
    }
}
