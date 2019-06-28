package fib.java;
public class fib{
	

public static void main(String args[])
{
	table();
	fib();
}
	public static void table()
	{
		int i=0,j=0;
		for(i=2;i<=5;i++)
		{
			for(j=1;j<=5;j++)
			{
				int c=i*j;
				System.out.print(c+ " ");
				
			}
			System.out.print("\n");
		}
	}
	
	public static void fib()
{
		int n,a=0,b=0,c=1;
		System.out.print("Fibnocci series");

		for(int i=1; i<=100; i++)
		{
			a=b;
			b=c;
			c=a+b;
			System.out.print(c+" ");
		}
		}
}