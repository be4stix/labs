package lab4;

public class Stranica 
{
	
	static void GetStr(Obzac...A)
	{
		for (Obzac c: A) {
			Obzac.GetText(c);
		}
	}
	public static void main(String []args){
		Obzac a = new Obzac("Hello world");
		Obzac b = new Obzac("Privet mir1");
		Obzac c = new Obzac("Privet mir2");
		Obzac d = new Obzac("Privet mir3");
		Obzac e = new Obzac("Privet mir4");
		GetStr(a,b,c,d,e);
	}
}

class Obzac extends Stranica
{
	String text;
	
	public Obzac(String s) {
		this.text = s;
	}
	
	static void GetText(Obzac a) {
		System.out.println(a.text);
		
	}
	
}


 