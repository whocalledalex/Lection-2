// first programm

// int a1 = 5;
// int b1 = 6584;
// int c1 = 587;

// int a2 = 66;
// int b2 = 43;
// int c2 = 666;

// int a3 = 9;
// int b3 = 52;
// int c3 = 3;

// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }

// int result = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

// Console.WriteLine(result);




// Second programm

// int[] array = { 21, 4543, 645, 1234, 75, 234556, 74, 23, 126};

// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }

// int result = Max(
//     Max(array[0], array[1], array[2]), 
//     Max(array[3], array[4], array[5]), 
//     Max(array[6], array[7], array[8]));

// Console.WriteLine(result);




// Third programm

// int[] array = { 12, 57, 976, 234, 85432, 234, 2, 145, 2, 34 };

// int length = array.Length;
// int find = 2;

// int index = 0;

// while (index < length)
// {
//     if (array[index] == find)
//     {
//         Console.WriteLine(index);
//         break;
//     }
//     index++;
// }




// Fourth programm
// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(1, 10);

//         index++;
//     }
// }

// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.WriteLine(col[position]);
//         position++;
//     }
// }

// int IndexOf(int[] collection, int find)
// {
//     int count = collection.Length;
//     int index = 0;
//     int position = -1; // если не найдет значение - покажет -1, тогда мы будем знать, 
//     //что элемент не найден, потому что 0 - стартовая позиция в массиве

//     while (index < count)
//     {
//         if (collection[index] == find)
//         {
//             position = index;
//             break;
//         }
//         index++;
//     }
//     return position;
// }

// int[] array = new int[10]; //создай новый массив, в котором 10 элементов(по умолчания заполнен нулями)

// FillArray(array);
// PrintArray(array);
// Console.WriteLine();

// int pos = IndexOf(array, 455);
// Console.WriteLine(pos);
