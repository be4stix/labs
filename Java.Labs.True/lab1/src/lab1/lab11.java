package lab1;
import java.util.Scanner;

public class lab11 {

	public static void main(String[] args ) {	
		Scanner scan = new Scanner(System.in);
		
		System.out.println("Vvedite skol`ko chisel");
		int N = scan.nextInt();
		int[] A = new int[N]  ;
		
		System.out.println("Vvodite chisla po 1 v stroke");
		for(int i = 0; i < N ; i++) {
			A[i] = scan.nextInt();
		}
		
		for(int i = 0; i < N; i++) {
			if(A[i] % 5 == 0 || A[i]% 10 == 0)
			{
				System.out.print(A[i] + " ");
			}
		}
			
	}
	
}
