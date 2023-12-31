﻿// класс для рисования поля
using System.Drawing;
using System.Net.Sockets;
using System.Text.Json.Nodes;

internal class FieldCommander : ICommander
{
    Robot robot = Robot.GetInstance();
    SolidBrush one = new(Color.White);
    SolidBrush two = new(Color.Black);
    SolidBrush three = new(Color.Red);
    SolidBrush four = new(Color.Green);
    private MainCommander mainCommander;
    public FieldCommander()
    {
    }

    public void Execute(int[] value)
    {
        Paint paint = Paint.GetInstance();// получение ссылки на Graphics для рисования

        // происходит рисование поля, цифры заносятся
        // в объект Field заносятся цифры (одномерный массив
        int a = 0;
        int[,] array1 = new int[5, 5];
        for (int i = 0; i < 5; i++)
            for (int j = 0; j < 5; j++)
            {
                array1[i, j] = value[a] - 48;
                a++;
            }// в 25 ячеек преобразовываем в двумерный массив 5х5)
        for (int i = 0; i < 5; i++)
            for (int j = 0; j < 5; j++)
                switch(array1[i, j])
                {
                    case 1: break;
                    case 2: break;
                    case 3: break;
                    case 4: break;
                }

        Field.GetInstance().Cells = array1;

        Console.WriteLine();
        int[] rc = new int[2];
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
                Console.Write(array1[i, j] + " ");
            Console.WriteLine();
        }
        // в объект Robot заносятся координаты
        for (int i = 0; i < 5; i++)
            for (int j = 0; j < 5; j++)
                if (array1[i, j] == 3)
                {
                    rc[0] = i;
                    rc[1] = j;
                    robot.robotCoordinates = rc;
                }
    }
}
