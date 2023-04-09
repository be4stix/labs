package lab9;

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
		 if (a == null) {
	            throw new NullPointerException("Exception: s is null!");
	        }
		for (Patient s:a )
		{
			System.out.println("FIO:"+s.FIO+"| ID:"+s.ID+"| ADRESS:"+s.Adress+"| NUMBER:"+s.Number+"| NumberOfMedCard:"+s.NumberMedCard+"| DIAGNOZ:"+s.Diagnoz);
		}
	}
	
	public static void PatientsWithDiagnoz(Patient[] a, String diagnoz) {
		if (a == null) {
            throw new NullPointerException("Exception: s is null!");
        }
		for (Patient s:a ) {
			if (s.Diagnoz == diagnoz) {
				System.out.println("FIO:"+s.FIO+"| ID:"+s.ID+"| ADRESS:"+s.Adress+"| NUMBER:"+s.Number+"| NumberOfMedCard:"+s.NumberMedCard+"| DIAGNOZ:"+s.Diagnoz);
			}
		}
	}
	
	public static void PatientsMDCRange(Patient[] q,int a,int b) {
		if (q == null) {
            throw new NullPointerException("Exception: s is null!");
        }
		for (Patient s:q ) {
			if (s.NumberMedCard >= a && s.NumberMedCard <= b) {
				System.out.println("FIO:"+s.FIO+"| ID:"+s.ID+"| ADRESS:"+s.Adress+"| NUMBER:"+s.Number+"| NumberOfMedCard:"+s.NumberMedCard+"| DIAGNOZ:"+s.Diagnoz);
			}
		}
	}
	
	public static void main(String args[]) {
		try {
		Patient[] s = new Patient[3]; 
		WriteAllPatients(s);
		
		}catch(ArrayIndexOutOfBoundsException a){
			System.out.println("Индекс вышел за границы массива ");
		} 
	}
}
