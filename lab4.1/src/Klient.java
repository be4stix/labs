//Система Платежи. Клиент имеет Счет в банке и Кредитную Карту (КК).
// Клиент может оплатить Заказ, сделать платеж на другой Счет, заблокировать КК и аннулировать Счет.
// Администратор может заблокировать КК за превышение кредита.
public class Klient {
    public static void main(String[] args) {
    Klient a = new Klient(12,3000);
    Klient b = new Klient(13,2000);
    admin s = new admin();
    a.PerevodSummi(b,100);
    a.GetKlient();
    b.GetKlient();
    s.SetBlock(a);
    a.PerevodSummi(b,100);
    
    s.UnSetBlock(a);
    
    a.PerevodSummi(b,100);
    a.GetKlient();
    b.GetKlient();
    }
    int card;
    int schet;
    boolean block = false;
    public void GetKlient(){
        System.out.println("Счет: " + this.schet + " Карта: " + this.card );
    }

    public Klient(int a, int b){
        this.card = a;
        this.schet = b;

    }

    public void OplataZakaza(int summa){
        if(this.schet >= summa && !this.block){
            this.schet -= summa;
        }
        else{
            System.out.println("Недостаточно средств или карта заблокирована2");
        }
    }
    public void PerevodSummi(Klient a, int summa){
        if(this.schet >= summa && !this.block ){
            this.schet = schet - summa;
            a.schet += summa;
        }
        else {
            System.out.println("Недостаточно средств или карта заблокирована1");
        }
    }
}
class admin {
    public admin() {
    }
    public void SetBlock(Klient a){
        a.block = true;
    }
    public void UnSetBlock(Klient a){
        a.block=false;
    }
}

