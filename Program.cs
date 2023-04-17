using System;

class Program {
    static void Main(string[] args) {
        int[,] matrix1 = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}}; // первая матрица
        int[,] matrix2 = {{10, 11}, {12, 13}, {14, 15}}; // вторая матрица

        if (matrix1.GetLength(1) != matrix2.GetLength(0)) { // проверяем, можно ли умножить матрицы
            Console.WriteLine("Невозможно умножить матрицы");
            return;
        }

        int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)]; // результирующая матрица

        // умножаем матрицы
        for (int i = 0; i < matrix1.GetLength(0); i++) {
            for (int j = 0; j < matrix2.GetLength(1); j++) {
                int sum = 0;
                for (int k = 0; k < matrix1.GetLength(1); k++) {
                    sum += matrix1[i, k] * matrix2[k, j];
                }
                result[i, j] = sum;
            }
        }

        // выводим результат
        Console.WriteLine("Результат умножения матриц:");
        for (int i = 0; i < result.GetLength(0); i++) {
            for (int j = 0; j < result.GetLength(1); j++) {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
