﻿// Задайте массив вещественных(дробных) чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();
Console.WriteLine("Найдите разницу между максимальным и минимальным элементов массива из вещественных чисел" );

double[] arrayRealNumbers = new double[10];
  for (int i = 0; i < arrayRealNumbers.Length; i++ )
  {
    arrayRealNumbers[i] = new Random().NextDouble() *10;
    Console.Write(arrayRealNumbers[i] + " ");
  }

double maxNumber = arrayRealNumbers[0];
double minNumber = arrayRealNumbers[0];

  for (int i = 1; i < arrayRealNumbers.Length; i++)
  {
    if (maxNumber < arrayRealNumbers[i])
    {
      maxNumber = arrayRealNumbers[i];
    }
        if (minNumber > arrayRealNumbers[i])
    {
      minNumber = arrayRealNumbers[i];
    }
  }

  double decision = maxNumber - minNumber;

  Console.WriteLine($"разница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {decision}");
