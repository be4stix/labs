package lab1;
import java.util.Scanner;

public class lab1 {

	public static void main(String[] args ) {	
		Scanner scan = new Scanner(System.in);
		
		System.out.println("Vvedite skol`ko chisel");
		int N = scan.nextInt();
		int[] A = new int[N]  ;
		
		System.out.println("Vvodite chisla po 1 v stroke");
		for(int i = 0; i < N ; i++) {
			A[i] = scan.nextInt();
		}
		
		int Sum = 0;
		int Proiz = 1;
		
		for (int i = 0; i < N; i++) {
			Sum+= A[i];
		}
		
		for(int i = 0; i < N ; i++)
		{
			Proiz *= A[i];
		}
		
		System.out.println("Summa " + Sum);
		System.out.println("Proizvedenie " + Proiz);
	 
			
	}
	
}
