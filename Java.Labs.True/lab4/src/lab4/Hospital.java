package lab4;

public class Hospital 
{
	public Hospital() {
		
	}
	static void SetDoctor(Patient A, Doctor B) {
		A.Doctor = B;
	}
	public static void main(String []args){
		Patient A = new Patient("Tolya");
		Doctor B = new Doctor();
		SetDoctor(A,B);
		B.SetDiagnoz(A, "FFFF");
		B.SetHeal(A, "Otdix");
		B.DoHeal(A);
		B.MojetOtpustit(A);
		A.GetDiag();
	}
}
class Patient extends Hospital{
	String Diagnoz;
	Doctor Doctor;
	String Heal;
	Boolean Healed;
	int Narusheniya = 0;
	String Name;
	
	public Patient(String name) {
		this.Name = name;
	}
	void GetDiag() {
		System.out.print(this.Diagnoz);;
	}
	void GetDoctor(){
		System.out.print(this.Doctor);
	}
	void GetHeal() {
		System.out.print(this.Heal);
	}
}
class Doctor extends Hospital{
	void SetDiagnoz(Patient A, String B) {
		A.Diagnoz = B;
	}
	void SetHeal(Patient A, String B) {
		A.Heal = B;
	}
	void DoHeal(Patient A) {
		A.Healed = true;
	}
	void AddNarushenie(Patient A) {
		A.Narusheniya += 1;
	}
	boolean MojetOtpustit(Patient A) {
		if (A.Healed || A.Narusheniya > 1) {
			return true;
		}
		return false;
	}
}
class Nurse extends Hospital {
	void nDoHeal(Patient A) {
		A.Healed = true;
	}
}
	


