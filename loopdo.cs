using System;
class loopdo
{
	static void Main()
	{
		int a;
		a= 1; //nilai awal
		do
		{
			Console.WriteLine(+a);
			a=a*2; //counter
		} while(a <=128); //nilai akhir
	}
}