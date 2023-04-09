package lab2;
import java.util.Scanner;

public class lab2 {
	public static void main(String[] args ) {	
		
			Scanner scan = new Scanner(System.in);
			
			System.out.println("Vvedite kol-vo strok: ");
			int n = scan.nextInt();
			
			String[] stroki = new String[n];
			
			for(int i = 0 ; i < n ; i++) {
				stroki[i] = scan.next();
			} 
			String a;
			for (int i = 0 ; i < n-1 ; i++ ) {
				for(int j= 0; j < n-1;j++ )
				{
				if (stroki[j].length() > stroki[j+1].length())
				{
					
					a = stroki[j];
					stroki[j] = stroki[j+1];
					stroki[j+1] = a;
				}
				}
			}
			
			
			for(String elem: stroki) {
				System.out.println(elem + " " +  elem.length() );
			}
	} 
}
