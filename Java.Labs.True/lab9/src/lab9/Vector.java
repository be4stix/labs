package lab9;
import java.util.InputMismatchException;
import java.util.Scanner;
public class Vector{
	int X,Y,Z;
	public Vector(int x,int y, int z) {
		this.X = x;
		this.Y = y;
		this.Z =z; 
	}
	public Vector() {}
	public boolean Ort(Vector b) {
		
		if (this.X*b.X+this.Y*b.Y+this.Z*b.Z==0)
		{
			return true;
		}
		
		return false;
	}
	public boolean Raven(Vector b) {
		if (this.X == b.X && this.Y == b.Y && this.Z == b.Z)
		{
			return true;
		}
		return false;
	}
	
	public boolean Peresekaet(Vector a) {
		
		if (this.X/a.X == this.Y/a.Y && this.Y/a.Y  == this.Z/a.Z) {
			return false;
		}
		else {
			return true;
		}
	}
	
	public static boolean Komplanarnost(Vector a,Vector b,Vector c) {
		int opr = a.X*b.Y*c.Z+a.Y*b.Z*c.X+a.Z*b.X*c.Y-a.Z*b.Y*c.X-a.Y*b.X*c.Z-a.X*b.Z*c.Y;
		if (opr == 0)
		{
			return true;
		}
		return false;
	}
	
	public static void main(String[] args) {
		/*Vector a = new Vector(1,2,-4);
		Vector b = new Vector(6,-1,1);
		Vector c = new Vector(1,3,5);*/
		
		try {
		Scanner scan =new Scanner(System.in);
		Vector a = new Vector();
		Vector b = new Vector();
		Vector c = new Vector();
		
		a.X = scan.nextInt();
		a.Y  = scan.nextInt();
		a.Z  = scan.nextInt();
		
		b.X  = scan.nextInt();
		b.Y =  scan.nextInt();
		b.Z  = scan.nextInt();
		
		c.X  = scan.nextInt();
		c.Y =  scan.nextInt();
		c.Z  = scan.nextInt();
		
		System.out.println(a.Ort(b));
		System.out.println(a.Raven(b));
		System.out.println(a.Peresekaet(b));
		System.out.println(Komplanarnost(a,b,c));}
		catch(InputMismatchException e){
			System.out.print("Неправильный ввод");
		}
	}	
}
