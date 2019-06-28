package abc;
 class b
{
      private b()
     {
          //By Default, Compile will keep super() calling statement here.
          System.out.println("First Constructor");
     }
     b(int i)
     {
          //Compiler will not keep any statement here
        super();
          System.out.println("Second Constructor");
     }
     b(int i, int j)
     {
          //Compiler will not keep any statement here
         
          System.out.println("Third Constructor");
     }
     b(int i, int j, int k)
     {
          System.out.println("Fourth Constructor");
          // super(); It will give error if you keep super() here
     }
}



public class two {
	
	public static void main(String args[])
	{
	     
		//b a1=new b();
		b a2=new b(10);
		b a3=new b(1,2);
		b a4=new b(1,2,3);

}}