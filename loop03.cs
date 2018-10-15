using System;
class loop03
{
	static void Main()
	{
		int a;
		a=625; //nilai awal
		while( a >=1) //nilai akhir
		{
			Console.Write("  "+a);
			a=a/5;
		}
	}
}