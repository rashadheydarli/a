

//int[,] arr = new int[2, 2]
//{
//    {1, 2 },
//    {3, 4 }
//};
//for (int i = 0; i < arr.GetLength(0); i++)

//{
//    for (int j = 0; j < arr.GetLength(1); j++)
//    {
//        System.Console.Write(arr[i, j] + " ");
//    }
//    System.Console.WriteLine();
//}

//int[,] arr = new int[2, 2]
//{
//    {1, 2 }, {3, 4 }

//};
//int sum = 0;
//for (int i = 0; i < arr.GetLength(0); i++)   //massivin icinde nece dene massiv odlgu gosterir
//{

//    for (int j = 0; j < arr.GetLength(1); j++) //kicikdeki massvin elementlerini gosterir
//    {
//        sum += arr[i, j];

//    }

//}
//System. Console.WriteLine(sum);


//int[,] arr = new int[2, 2]
//{
//    {1, 2 },
//    {3, 4 }
//};
//int sum = 0;
//for (int i = 0; i < arr.GetLength(0); i++)    
//{

//    sum += arr[i, 0];

//}
//System.Console.WriteLine(sum);

//int[,] arr = new int[2, 2]
//{
//    {1, -2 },
//    {-3, 4 }
//};
//for (int i = 0; i < arr.GetLength(0); i++)
//{
//    for (int j = 0; j < arr.GetLength(1); j++)
//    {
//        if( arr[i,j]<0)
//         {
//            System.Console.WriteLine( arr[i,j]);
//         }
//    }
//}

//int[,] arr = new int[2, 2]
//{
//    {1, -2 },
//    {3, -4 }
//};
//int min=arr[0, 0];
//int max=arr[0, 0];
//for (int i = 0; i < arr.GetLength(0); i++)
//{
//    for (int j = 0; j < arr.GetLength(1); j++)
//    {
//        if(min>arr[i,j])
//        {
//            min = arr[i, j];
//        }
//        if(max<arr[i,j])
//        {
//            max = arr[i, j];

//        }

//    }

//}
//System.Console.WriteLine(min);
//System.Console.WriteLine(max);

int[,] arr = new int[2, 2]
{
    {3, 8 },
    {4, 7 }
};
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if (arr[i, j] % 2 == 0)
        {
            arr[i, j] = 2;
        }
        else if (arr[i, j] % 2 == 1)
        {
            arr[i, j] = 1;
        }
        else
        {
            arr[i, j] = arr[i, j];
        }
    }
}
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        System.Console.Write(arr[i,j]+" ");
    }
    System.Console.WriteLine( );
}