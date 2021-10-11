using System;
using System.Linq;

namespace Bootcamp.Solutions
{
    public class Lab8
    {
        public void Problem8_10()
        {
            int testcase = int.Parse(Console.ReadLine());
            while(testcase-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                var sum = Console.ReadLine()
                            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                            .Select(arg => int.Parse(arg))
                            .ToList();

                var temp = sum.Select(arg => arg).ToList();
                /* double average = (double)temp / n;
                int count = 0;
                for(int i = 0; i < n; i++)
                {
                    if(temp[i] > average)
                    {
                        count++;
                    }
                }*/
            }
        }
        public void Problem8_9()
        {
            var arr = new int[3];
            for(int i = 0; i < 3; i++)
            {
                var list = Console.ReadLine()
                                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                    .Select(arg => int.Parse(arg))
                                    .ToArray();
                // arr[i] = list.Select(arg =>)();
            }
            for(int i = 0; i < 3; i++)
            {
                
            }
        }
        public void Problem8_8()
        {
            var word = new char[,]
            {
                {'Z','E','R','O','-'},
                {'O','N','E','-','-'},
                {'T','W','O','-','-'},
                {'T','H','R','E','E'},
                {'F','O','U','R','-'},
                {'F','I','V','E','-'},
            };
            var numbers = Console.ReadLine()
                            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                            .Select(num => int.Parse(num))
                            .ToList();

            for(int i = 0; i < 3; i++)
            {
                var num = numbers[i];
                for(int j = 0; j < 5; j++)
                {
                    Console.Write($"{word[num,j]}");
                }
                System.Console.WriteLine();
            }
        }
        public void Problem8_7()
        {
            int sum = 0;
            for(int i = 0;i < 3; i++)
            {
                var temp = Console.ReadLine()
                            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                            .Select(temp => int.Parse(temp))
                            .ToList();

                sum += temp[i];
            }  
 
            System.Console.WriteLine(sum);
        }
        public void Problem8_6()
        {
            var text = Console.ReadLine().Substring(0, 5);
            var textArray = text.ToCharArray();

            for(int i = 0; i < textArray.Length; i++)
            {
                for(int j = 0, count = 5 - i; j < 5; j++, count++)
                {
                    Console.Write(textArray[count % 5]);
                }
                System.Console.WriteLine();
            }

        }
        public void Problem8_5()
        {
            var str1 = Console.ReadLine().Substring(0, 7);
            var arr = str1.ToCharArray();

            int count = 0;
            for(int i = 1; i < 7 - 1; i++)
            {
                if(arr[i - 1] == 'c' && arr[i] == 'a' && arr[i + 1] == 't')
                {
                    count++;
                }
            }
            Console.WriteLine($"{count}");
            
        }
        public void Problem8_4()
        {
            var list = Console.ReadLine()
                        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                        .Select(arg => int.Parse(arg))
                        .ToList();

            var arr = list.Select(temp => temp).ToList();

            int max1, max2;
            max1 = arr[0] > arr[1] ? arr[0] : arr[1];
            max2 = arr[0] < arr[1] ? arr[0] : arr[1];

            for(int i = 2; i < 5; i++)
            {
                max2 = arr[i] > max2 ? arr[i] : max2;
                max2 = arr[i] > max1 ? max1 : max2;
                max1 = arr[i] > max1 ? arr[i] :  max1;
            }
            if(max1 == max2)
                Console.WriteLine($"{max1}\n{max2} I don't");
            else if(max1 != max2)
                Console.WriteLine($"{max1} {max2}");
        }
        void printSt(int num, int count)
        {
            Console.Write($"{num}:");
            while(count-- > 0)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();            
        }
        public void Problem8_3()
        {
            var list = Console.ReadLine()
                        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                        .Select(temp => int.Parse(temp))
                        .ToList();
            var arr = list.Select(arg => arg).ToList();

            int one = 0, twice = 0, third = 0;
            for(int i = 0; i < 10; i++)
            {
                switch(arr[i])
                {
                    case 1: one++; break;
                    case 2: twice++; break;
                    case 3: third++; break;
                }
            }
            printSt(1, one);
            printSt(2, twice);
            printSt(3, third);
        }
        public void Problem8_2()
        {
            var numbers = Console.ReadLine()
                            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                            .Select(temp => int.Parse(temp))
                            .ToList();

            var intList = numbers.Select(arg => arg).ToList();

            for(int i = 0; i < 5 - 1; i++)
            {
                if(intList[i] > intList[i + 1])
                {
                    var temp = intList[i];
                    intList[i] = intList[i + 1];
                    intList[i + 1] = temp;
                }
            }

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{intList[i]} ");
            }
        }
        public void Problem8_1()
        {
            var arr = Console.ReadLine().
                        Split(' ', StringSplitOptions.RemoveEmptyEntries)
                        .Select(temp => int.Parse(temp))
                        .ToList();

            int sum = arr.Sum();

            float average = (float)sum / 5;

            var _ = arr.Select(temp =>
            {
                if(temp > average)
                {
                    Console.Write($"{temp} ");
                }
                return temp;
            }).ToList();
            
            System.Console.WriteLine();
        }
    }
}