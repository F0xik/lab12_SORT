using System.Security.Cryptography.X509Certificates;


Console.WriteLine("Выбор задания: \n 1 - Сортировка Пузырьком на 3 \n 2 - Быстрая сортировка на 4");
int vibor = Convert.ToInt32(Console.ReadLine());
switch (vibor)
{
    case 1:  
        int[] BubbleSort(int[] mass)

        {
            int temp;

            for (int i = 0; i < mass.Length; i++)

            {

                for (int i1 = i + 1; i1 < mass.Length; i1++)

                {

                    if (mass[i] > mass[i1])
                    {
                        temp = mass[i];
                        mass[i] = mass[i1];
                        mass[i1] = temp;
                    }
                }
            }
            return mass;
        }

        Console.WriteLine("Введите количество чисел для сортировки");
        int N = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите числа через ENTER:");
        int[] mass = new int[N];
        for (int i = 0; i < mass.Length; i++)
        {
            mass[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Сортировка завершена:");
        BubbleSort(mass);
        for (int i = 0; i < mass.Length; i++)
        {
            Console.WriteLine(mass[i]);
        }
        Console.ReadLine();
        break;

    case 2:
        Console.WriteLine("");
        Console.WriteLine("Быстрая сортировка на 4");
        Console.WriteLine("");
        int[] numbers = { 4, 2, 5, 6, 7, 9, 8, -30, 50, -100, -1337, 1488, 777, 666, 1234 };
        numbers = FastSort(numbers, 0, numbers.Length - 1);
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
        static int FindPivot(int[] numbers, int minInd, int maxInd)
        {

            int pivot = minInd - 1; //  опора
            int temp = 0;
            for (int i = minInd; i < maxInd; i++)
            {
                if (numbers[i] < numbers[maxInd])
                {
                    pivot++;
                    temp = numbers[pivot];
                    numbers[pivot] = numbers[i];
                    numbers[i] = temp;
                }
            }
            pivot++;
            temp = numbers[pivot];
            numbers[pivot] = numbers[maxInd];
            numbers[maxInd] = temp;

            return pivot;
        }
        static int[] FastSort(int[] numbers, int minInd, int maxInd)
        {
            if (minInd >= maxInd)
            {
                return numbers;
            }

            int pivot = FindPivot(numbers, minInd, maxInd);
            FastSort(numbers, minInd, pivot - 1);
            FastSort(numbers, pivot + 1, maxInd);
            return numbers;
        }
        break;
}