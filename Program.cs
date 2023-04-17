using System;

class Program {
    static void Main(string[] args) {
        int[,,] array = new int[2, 2, 2]; // создаем трехмерный массив размером 2x2x2

        Random random = new Random(); // создаем объект для генерации случайных чисел

        // заполняем массив неповторяющимися двузначными числами
        for (int i = 0; i < array.GetLength(0); i++) {
            for (int j = 0; j < array.GetLength(1); j++) {
                for (int k = 0; k < array.GetLength(2); k++) {
                    int number;
                    do {
                        number = random.Next(10, 100); // генерируем случайное двузначное число
                    } while (Contains(array, number)); // проверяем, не содержится ли число уже в массиве
                    array[i, j, k] = number; // записываем число в массив
                }
            }
        }

        // выводим массив построчно с указанием индексов каждого элемента
        for (int i = 0; i < array.GetLength(0); i++) {
            for (int j = 0; j < array.GetLength(1); j++) {
                for (int k = 0; k < array.GetLength(2); k++) {
                    Console.Write($"{array[i, j, k]}({i},{j},{k})\t"); // выводим элемент массива и его индексы
                }
                Console.WriteLine(); // переходим на новую строку
            }
            Console.WriteLine(); // добавляем пустую строку между слоями массива
        }
    }

    // метод, проверяющий, содержится ли число в трехмерном массиве
    static bool Contains(int[,,] array, int number) {
        for (int i = 0; i < array.GetLength(0); i++) {
            for (int j = 0; j < array.GetLength(1); j++) {
                for (int k = 0; k < array.GetLength(2); k++) {
                    if (array[i, j, k] == number) {
                        return true; // число уже содержится в массиве
                    }
                }
            }
        }
        return false; // число не содержится в массиве
    }
}
