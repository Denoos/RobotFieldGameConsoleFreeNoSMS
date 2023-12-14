// класс поля
internal class Field
{
    private static Field instance;
    public static Field GetInstance()
    {
        if (instance == null)
            instance = new Field();
        return instance;
    }// тут организовать синглтон и хранение ячеек в свойстве Cells

    public int[,] Cells { get; set; }

    internal bool CheckRobotEndGame(Robot robot)
    {
        int[] fc = new int[2];
        for (int i = 0; i < 5; i++)
            for (int j = 0; j < 5; j++)
                if (Cells[i, j] == 4)
                {
                    fc[0] = i;
                    fc[1] = j;
                    robot.robotCoordinates = fc;
                }
        if (robot.robotCoordinates == fc) //сравнение координат робота с координатами
        {
            
        }
                // финишной точки
        
    }
}

