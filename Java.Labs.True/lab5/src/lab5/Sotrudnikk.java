package lab5;

public abstract class Sotrudnikk {
	
	public abstract void Work();
	
	public static void main(String []args){
		 Sotrudnikk e = new Ingener();
		 Sotrudnikk s = new Rukovoditel();
		 e.Work();
		 s.Work();
	}	
}
class Ingener extends Sotrudnikk{
	public void Work() {
		System.out.println("Ingener");
	}
	}
class Rukovoditel extends Sotrudnikk{
	public void Work() {
		System.out.println("Rukovoditel");
	}
	
}
