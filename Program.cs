// Task 21
Console.Clear();
Console.WriteLine("Введите координаты первой точки: ");
int[] firstPoint = new int[]{Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())};
Console.WriteLine("Введите координаты второй точки: ");
int[] secondPoint = new int[]{Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())};

//√((x2-x1)^2 )+(y2-y1)^2+(z2-z1)^2
double firstOp = Math.Pow(secondPoint[0] - firstPoint[0], 2);
double secondOp = Math.Pow(secondPoint[1] - firstPoint[1], 2);
double thirdOp = Math.Pow(secondPoint[2] - firstPoint[2], 2);
double result = Math.Sqrt(firstOp  + secondOp + thirdOp);

Console.WriteLine(result);