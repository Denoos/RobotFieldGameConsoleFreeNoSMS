// класс робота
internal class Robot
{
    private static Robot instance;

    private Robot()
    { }
    internal int[] robotCoordinates {get; set;}

    public static Robot getInstance()
    { 
        if (instance == null)
            instance = new Robot();
        return instance;
    }// организовать синглтон и хранение текущих координат
}