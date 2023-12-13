// класс поля
internal class Field
{
    private static Field instance;
    public static Field getInstance()
    {
        if (instance == null)
            instance = new Field();
        return instance;
    }// тут организовать синглтон и хранение ячеек в свойстве Cells

    public int[,] Cells { get; set; }

    internal bool CheckRobotEndGame(Robot robot)
    { 
        // сравнение координат робота с координатами
        // финишной точки
    }
}

