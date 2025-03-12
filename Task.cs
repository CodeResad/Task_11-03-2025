// 11.03.2025
// Task 1:
// Console.WriteLine("Eded daxil edin:");
// int num = Convert.ToInt32(Console.ReadLine());
// int mult = 1;
//
// while (num != 0)
// {
//     mult *= num % 10;
//     num /= 10;
// }
// Console.WriteLine(mult);

// Task 2:
// Console.WriteLine("Eded daxil edin:");
// int num = Convert.ToInt32(Console.ReadLine());
//
// bool isPrime = false;
//
// for (int i = 2; i*i < num; i++)
// {
//     if (num % i == 0)
//     {
//         isPrime = true;
//         break;
//     }
// }
//
// if (isPrime)
// {
//     Console.WriteLine("Not Prime");
// }
// else
// {
//     Console.WriteLine("Prime");
// }

// Task 3:
// string[] str = {"Apple", "Banana", "Cherry", "Coconut", "Pineapple"};
//
// string temp = "";
//
// for (int i = 0; i < str.Length / 2; i++)
// {
//     temp = str[i];
//     str[i] = str[str.Length - i - 1];
//     str[str.Length - i - 1] = temp;
// }
//
// for (int i = 0; i < str.Length; i++)
// {
//     Console.Write(str[i] + " ");
// }

// Task 4:
// int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
// int n = Convert.ToInt32(Console.ReadLine());
// bool isTrue = false;
//
// for (int i = 0; i < arr.Length; i++)
// {
//     if (n > arr[i])
//     {
//         isTrue = true;
//         break;
//     }
// }
//
// if(isTrue)
// {
//     Console.WriteLine("True");
// }
// else
// {
//     Console.WriteLine("False");
// }

// Task 5:
// int[] arr = { 1, 2, 3, 4, 5, 2, 7, 8, 9, 2, 4, 12, 4, 14, 3 }; // 2, 3, 4
//
// int max = 0;
//
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] > max)
//     {
//         max = arr[i];
//     }
// }
//
// bool[] indices = new bool[max + 1];
//
// for (int i = 0; i < arr.Length; i++)
// {
//     for (int j = i + 1; j < arr.Length; j++)
//     {
//         if (arr[i] == arr[j] && indices[arr[i]] != true)
//         {
//             indices[arr[i]] = true;
//             break;
//         }
//     }
// }
//
// for (int i = 0; i < indices.Length; i++)
// {
//     if (indices[i])
//     {
//         Console.Write(i + " ");
//     }
// }

// Task 6:
// Console.WriteLine("Eded daxil edin:");
// int num = Convert.ToInt32(Console.ReadLine());
//
// int a = 0;
// int b = 1;
// int sum = 0;
//
// Console.Write($"{a} {b} ");
//
// while (sum < num)
// {
//     sum = a + b;
//     
//     if (sum <= num)
//     {
//         Console.Write(sum + " ");
//     }
//     
//     a = b;
//     b = sum;
// }