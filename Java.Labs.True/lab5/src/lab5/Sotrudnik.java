package lab5;

public interface Sotrudnik {
	class Ingener{
		String Place;
		int Salary;
		int KolvoRabDays;
		public Ingener(String A,int B,int C) { 
			this.Place = A;
			this.Salary = B;
			this.KolvoRabDays = C;
		}
		void GetIngener() {
			System.out.println("Salary: " + this.Salary + ",Place: " + this.Place + ",Kolichestvo dney: " + this.KolvoRabDays);
		}
	}
	class Rukovoditel extends Ingener{
		public Rukovoditel(String A, int B, int C) {
			super(A, B, C);
		} 
		
	}
	public static void main(String []args){
		 Ingener A = new Ingener("Shkola",120,12);
		 Rukovoditel B = new Rukovoditel("Shkola",150,12);
		 A.GetIngener();
		 B.GetIngener();
	}
}
