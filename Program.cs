﻿// Написать метод который, выводит на экран строку , синволы из которых состоит строка и их количество 
// вводится пользователем.
// static void PrintRaw(string simvol , int count)
// {
//    for(int i = 0 ; i<count ; i++)
//     {
//         Console.Write(simvol + " ");
//     }
// }
//    Console.WriteLine("Enter the simvol");
//    string simvol = Console.ReadLine();
//    Console.WriteLine("Enter how many times I must write it in a raw");
//    int count = Convert.ToInt32(Console.ReadLine());
//  PrintRaw(simvol ,count);

// Написать метод для поиска индекса элемента массива типа инт , метод должен вернуть индекс первого най-
// денного элемента , и обработать случай если его нет.


//     static int MyFindIndex (int value, int [] array)
//         {
            
//             for (int i = 0; i < array.Length; i++)
//             {
                
//                 if(array[i] == value)
//                 {
                    
//                     return i;
    
//                 }
               
//             }

//             return -1;
//         }
    
        
//         Console.WriteLine("Enter the size of the Array");
//         int size = Convert.ToInt32(Console.ReadLine());
//         int[] myArray = new int[size];
//         for (int i = 0; i < myArray.Length; i++)
//         {
//             Console.WriteLine($"Enter the element {i + 1}");
//             myArray[i] = Convert.ToInt32(Console.ReadLine());
//         }
//         Console.WriteLine("Enter the element you want to find");
//         int value = Convert.ToInt32(Console.ReadLine());
//         int index = MyFindIndex(value , myArray);
//         Console.WriteLine(index);
         

     internal class Program
 {

     static int[] RandomArray (uint length , int minValue , int maxValue)
  {
    Random random = new Random();
    int [] array = new int [length];
    for (int i=0 ; i<array.Length ; i++)
    {
        array[i] = random.Next(minValue,maxValue+1);
    }
    return array;
  }
 private static void Main(string[] args)
{

int [] arrayMy = RandomArray(10 , -33 , 33);
for(int i=0 ; i< arrayMy.Length ; i++)
{
    System.Console.Write(arrayMy[i] + "\t");
}

}
}