package lab3;

public class Patient {
	int ID;
	String FIO;
	String Adress;
	String Number;
	int NumberMedCard;
	String Diagnoz;
	public Patient(int id, String fio,String adress,String number,int numbermedcard,String diagnoz) {
		this.ID = id;
		this.FIO = fio;
		this.Adress = adress;
		this.Number = number;
		this.NumberMedCard = numbermedcard;
		this.Diagnoz = diagnoz;
	}
	public void  WritePatient() {
		System.out.print("FIO:"+this.FIO+"| ID:"+this.ID+"| ADRESS:"+this.Adress+"| NUMBER:"+this.Number+"| NumberOfMedCard:"+this.NumberMedCard+"| DIAGNOZ:"+this.Diagnoz);
	}
	
	public static void WriteAllPatients(Patient[] a) {
		for (Patient s:a )
		{
			System.out.println("FIO:"+s.FIO+"| ID:"+s.ID+"| ADRESS:"+s.Adress+"| NUMBER:"+s.Number+"| NumberOfMedCard:"+s.NumberMedCard+"| DIAGNOZ:"+s.Diagnoz);
		}
	}
	
	public static void PatientsWithDiagnoz(Patient[] a, String diagnoz) {
		for (Patient s:a ) {
			if (s.Diagnoz == diagnoz) {
				System.out.println("FIO:"+s.FIO+"| ID:"+s.ID+"| ADRESS:"+s.Adress+"| NUMBER:"+s.Number+"| NumberOfMedCard:"+s.NumberMedCard+"| DIAGNOZ:"+s.Diagnoz);
			}
		}
	}
	
	public static void PatientsMDCRange(Patient[] q,int a,int b) {
		for (Patient s:q ) {
			if (s.NumberMedCard >= a && s.NumberMedCard <= b) {
				System.out.println("FIO:"+s.FIO+"| ID:"+s.ID+"| ADRESS:"+s.Adress+"| NUMBER:"+s.Number+"| NumberOfMedCard:"+s.NumberMedCard+"| DIAGNOZ:"+s.Diagnoz);
			}
		}
	}
	
	public static void main(String args[]) {
		Patient[] s = new Patient[3]; 
		s[0] = new Patient(1,"Sergey Kondereshko","Colnexv 8"," +375324324423",1,"Nety");
		s[1] = new Patient(2,"Sergey Kondereshko","Colnexv 8"," +375324324423",2,"Nety");
		s[2] = new Patient(3,"Sergey Kondereshko","Colnexv 8"," +375324324423",3,"Netnny");
		
		PatientsWithDiagnoz(s,"Nety");
		
	}
}
