// task 1  Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.
//Multipe(21);
// static void Multipe(int n)
//{
//	if (n % 3 == 0 && n % 7 == 0)
//	{
//		Console.WriteLine($"(n) 3-e ve 7-e bolunur");

//	}
//	else
//	{
//		Console.WriteLine($"n 3-e ve 7-e bolunmur");
//	}
//}
//task2 n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.
//Sum(12, 23);
//static void Sum( int n, int m)
//{
//    int sum1;
//	if (n%2==0 && m % 2 == 0)
//	{
//		sum1 = n + m;
//		Console.WriteLine(sum1);
//	}
//	else
//	{
//		Console.WriteLine("duzgun edeleri daxil edin");
//	}


//task3 Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.
//Sum(5, 13);
//static void Sum(int n,int m)
//{
//    int sum1 = 0;
//	for (int i = n; i < m; i++)
//	{
//		if (i % 2 == 1)
//		{
//			sum1 = sum1 + i;
//		}

//	}
//	Console.WriteLine(sum1);
//}

// task 4Verilmish arrayin icindeki tek ededlerin cemini tapin.
//int[] arr = { 1, 4, 5, 7, 8, 9, 10, 24 };
//Sum(arr);
//static void Sum(int[] arr)
//{
//    int sum1 = 0;
//	for (int i = 0; i < arr.Length; i++)
//	{
//		if (arr[i] % 2 == 1)
//		{
//			sum1 += arr[i];
//		}	




//	}
//    Console.WriteLine(sum1);
//}
//task5 Verilmish arrayin icindeki cut ededlerin sayini tapin.
//int[] arr = { 2, 4, 5, 7, 8, 10, 12, 15 };
//Count(arr);
//static void Count(int[] arr)
//{
//    int count1 = 0;
//	for (int i = 0; i < arr.Length; i++)
//	{
//		if (arr[i]%2 == 0)
//		{
//			count1++;	
//		}
//	}
//	Console.WriteLine(count1);
//}
//task6 Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin.


//Count(1, 9);
//static void Count(int n , int m)
//{
//	int count2 = 0;
//	for (int i = n; i < m; i++)
//	{
//		if(i % 2 == 1)
//		{
//			count2++;
//		}
//	}
//	Console.WriteLine(count2);
//}
//task7 Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin cemini tapin
//Sum2(3, 18);
//static void Sum2(int n,int m)
//{
//    int sum2 = 0;
//	for (int i = n; i < m; i++)
//	{
//		if (i % 2 == 0) 
//		{
//			sum2++;
//		}
//	}
//	Console.WriteLine(sum2);
//}
// task8 Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin sayini tapin.
//Count5(3, 24);
//static void Count5(int n, int m)
//{
//    int count5 = 0;
//	for (int i = 0; i < m; i++)
//	{
//		if (i % 2 == 0)
//		{
//			count5++;	
//		}
//	}
//	Console.WriteLine(count5);
//}  
//task9 Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin
//using System.Numerics;

//Complex(24);
//static void Complex(int n)
//{
//    int count6 = 0;
//	for (int i = 1; i <= n; i++)
//	{
//		if (n % i == 0)
//		{
//			count6++;	
//		}
//	}
//	if (count6 > 2)
//	{
//		Console.WriteLine($"{n} murekkeb ededdir");

//	}
//	else if (count6 == 2)
//	{
//		Console.WriteLine($"{n} sade ededdir");
//	}
//	else
//	{
//		Console.WriteLine($"{n} ne sadedir ne murekkebdir");
//	}


//}
//task10)n ededinin faktorialini hesablamaq.
//using System.Collections.Concurrent;

//Factorial(8);
//static void Factorial(int n)
//{
//    int result = 1;
//	for (int i = 1; i <= n; i++)
//	{
//		result += i;
//	}
//	Console.WriteLine(result);
//}
