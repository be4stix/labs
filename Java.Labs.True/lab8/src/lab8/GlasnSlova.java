package lab8;
import java.io.*;
import java.util.HashSet;

public class GlasnSlova {

	public static void main(String args[]) throws IOException
	{
			FileInputStream fin = new FileInputStream("input.txt");
			FileOutputStream fout = new FileOutputStream("output.txt");
			
			char[] s = {'А','О','У','Э','Ы','Я','Е','Ю','Ё','И'};
			
			
			fin.close();
			fout.close();
	}
}
