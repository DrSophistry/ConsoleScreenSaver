using System;

class Program
{
	static void Main(string[] args)
	{
        DvdScreenSaver dss = new DvdScreenSaver(1, 1, "Test1", 500);
        DvdScreenSaver dss2 = new DvdScreenSaver(10, 15, "2Test", 100);
        DvdScreenSaver dss3 = new DvdScreenSaver(50, 15, "3Test3", 200);
        Console.ReadLine();
	}
}
