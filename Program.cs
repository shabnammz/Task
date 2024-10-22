//Task 1. Verilmiş Arrayın elementlərinin cəmini ekrana çap edin. 

//int[] numbers = { 20, 24, 43, 32, 51 };
//int sum = 0;

//for (int i = 0; i < numbers.Length; i++)
//    sum += numbers[i];
//Console.WriteLine(sum);



//Task 2. Verilmiş int Arrayın ən böyük dəyərə sahib elementini tapın. 

//int[] numbers = { 20, 24, 43, 32, 51 };
//int max = numbers[0];

//for (int i = 1; i < numbers.Length; i++)
//{
//    if (numbers[i] > max) ;
//    {
//        max = numbers[i] ;
//    }
//}
//Console.WriteLine(max);





//Task 3. Verilmiş Arrayın ilk və son elementlərinin cəmini tapın. 

//int[] numbers = { 5, 52, 13, 26, 48 };
//int sum = 0;

//sum = numbers[0] + numbers[numbers.Length-1];
//Console.WriteLine(sum);




//Task 4. Verilmiş müsbət tam n ədədinin 2-nin qüvvəti olub-olmamasını tapın. 

//int n = 28;

//while (n % 2 == 0)
//{
//        n /= 2; 
//}
//if (n == 1)
//{
//    Console.WriteLine("2-in quvvetidir.");
//}
//else
//{
//    Console.WriteLine("2-in quvveti deyil.");
//}




////Task 5. Verilmiş n tam ədədinin neçə mərtəbəli olduğunu tapın. Məs: 23452, output: 5.

//int n = 10;
//int count = 0;

//while (n > 0)
//{
//    n /= 10;
//    count++;
//}
//Console.WriteLine("Ededdin mertebesi: " + count);



//Task 6. Verilmiş artan sıra ilə düzülmüş ədədlər siyahısındaki n ədədinin yerləşdiryi indexi tapan alqoritm(meselen 50 axtaririq egər siyahıda 50 ədədi yoxdursa -1 print olsun, varsa var olduğu index)

//int[] numbers = { 14, 23, 56, 45, 86, 89, 96 };
//bool result = true;

//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] == 23)
//    {
//        Console.WriteLine(i);
//        result = true;
//    }
//}
//if (!result) ;
//{
//    Console.WriteLine("Bu eded siyahida yoxdur.");
//}