package lab7;

public class Text {

	public static void main(String []args){
		StringBuffer sBuffer = new StringBuffer("ddafdc oasap fdasd as fdppd sda ");
		System.out.print(sBuffer);
		int index = -1;
		for(int i =0; i < sBuffer.length()-1;i++) {
			if((sBuffer.charAt(i) == 'p' || sBuffer.charAt(i) == 'P') && sBuffer.charAt(i+1)!= ' ') {
				 index = i;
				
				 break;
			}
		}
		if (index != -1) {
			for(int i =index; i < sBuffer.length();i++) {
				if(sBuffer.charAt(i) == 'A' ) {
					sBuffer.setCharAt(i, 'O');
				}
				else if (sBuffer.charAt(i) == 'a') {
					sBuffer.setCharAt(i, 'o');
				}
			}		
		}
		else {
			System.out.print("V stroke net 'P' ");
		}
		System.out.println();
		System.out.print(sBuffer);
	}
}
