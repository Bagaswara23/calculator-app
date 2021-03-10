class Calculator
{
	static void Main(string[] args)
	{
		int a = 5;
		int b = 6;
		
		Console.WriteLine("Hasil Penambahan {0} + {1} = {2}", a, b, Penambahan(a, b));
		Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a,b));
		
		Console.WriteLine("\n Press Any Key To Continue");
		Console.ReadKey();
	}
	
	static int Penambahan(int a, int b)
	{
		return a + b;
	}
	
	static int Pengurangan(int a, int b)
	{
		return a - b;
	}
}