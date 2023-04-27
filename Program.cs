Console.Write("Введите координату (X) первой точки: ");

double x1 = Convert.ToDouble(Console.ReadLine());



Console.Write("Введите координату (У) первой точки: ");

double y1 = Convert.ToDouble(Console.ReadLine());



Console.Write("Введите координату (Z) первой точки: ");

double z1 = Convert.ToDouble(Console.ReadLine());



Console.WriteLine();

Console.WriteLine();



Console.Write("Введите координату (X) второй точки: ");

double x2 = Convert.ToDouble(Console.ReadLine());



Console.Write("Введите координату (У) второй точки: ");

double y2 = Convert.ToDouble(Console.ReadLine());



Console.Write("Введите координату (Z) второй точки: ");

double z2 = Convert.ToDouble(Console.ReadLine());





 double Final = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1)*(y2 - y1)) + ((z2 - z1)*(z2 - z1)));



 Console.WriteLine("Расстояние между введенными координатами: "+Final);