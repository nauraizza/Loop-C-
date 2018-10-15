using System;
class loop04
{
	static void Main()
	{
		int a;
		a= 10; //nilai awal
		do
		{
			Console.Write("  "+a);
			a=a-2; //counter
		} while(a >=2); //nilai akhir
	}
}