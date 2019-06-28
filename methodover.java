package abc;

public class methodover {
	public static void test(int a)
	{
		System.out.println("inside main" +a);
	}
	public static void test(int a, int b)
	{
		System.out.println("two int"+a+"    "+b);

	}
	public static void test(double a, int b)
	{
		System.out.println("double"+a+" "+b);
		
	}
	public static void main(String[] args)
	{
		//methodover a= new methodover();
		test(5);
		test(6,7);
		test(4.5,3);
		
	}
}
