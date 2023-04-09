package lab2;
import java.util.Scanner;
public class lab22 {
	public static void main(String[] args ) {
		Scanner scan = new Scanner(System.in);
		
		 System.out.print("Vvedite shirinu: ");
		int weight = scan.nextInt();		 
		 System.out.print("Vvedite visotu: ");
		int height = scan.nextInt();
		
		int[][] m = new int[weight][height];
		int[] kolvo = new int[height];
	
		
		for(int i = 0 ; i < height; i++ )
		{
			for(int j = 0 ; j < weight; j++ )
			{
				m[i][j] = scan.nextInt();
			}
		}
		
		for(int i = 0 ; i < height; i++ )
		{
			for(int j = 0 ; j < weight; j++ )
			{
				System.out.print(m[i][j] + " ");
			}
			System.out.println();
		}
		System.out.println();
		
		for (int i = 0; i < height ; i++ ) {
			for (int j = 0; j < weight-1 ;j++ ) {
				if (m[i][j]<m[i][j+1]){
					kolvo[i]++;
				}
			}
		}

		int max = kolvo[0];
		int num = 0;
		for(int i = 1; i < height; i++){
			if (kolvo[i] > max){
				max = kolvo[i];
				num = i;
			}
		}
 		for(int i = 0; i < weight; i++){
 			System.out.print(m[num][i] + " ");
 		}
	}
	
}
