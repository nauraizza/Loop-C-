using System;
class loop01
{
	static void Main()
	{
		int a;
		a= 1; //nilai awal
		while( a <=128) //nilai akhir
		{
			Console.Write("  "+a);
			a=a*-2; //counter
		}
	}
}