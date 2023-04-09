package lab5;

public class PassengerTranstport {	
	float speed;
	float time;
	float cost;
	public void ReplaceCost() {
		System.out.println("Zaimet vremeni: " + this.time + " Chasov"+",Stoimost: " + this.cost + "Rub");
	}
	
	public static void main(String []args){
		Plane a = new Plane(1000);
		Auto b = new Auto(120);
		Train c = new Train(400);
		a.ReplaceCost();
		b.ReplaceCost();
		c.ReplaceCost();
	}
	
}
class Plane extends PassengerTranstport{
	int speed = 900;
	int kmcost = 20;
	public Plane(float a) {
		this.time = (float)Math.floor(a / speed * 100)/100; 
		this.cost = a*kmcost;
	}
}
class Train extends PassengerTranstport{
	int speed = 150;
	int kmcost = 3;
	public Train(float a) {
		this.time = (float)Math.floor(a / speed * 100)/100;
		this.cost = a*kmcost;
	}
	
}
class Auto extends PassengerTranstport{
	int speed = 100;
	int kmcost = 5;
	public Auto(float a) {
		this.time = (float)Math.floor(a / speed * 100)/100; 
		this.cost = a*kmcost;
	}

}