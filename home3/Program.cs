﻿int n = int.Parse(Console.ReadLine());
int k = (int)Math.Log10(n)-2;
Console.WriteLine(k < 0 ? "нету 3-ей цифры" : (n % (int)Math.Pow(10, k + 1) / (int)Math.Pow(10, k)).ToString());
Console.ReadLine();