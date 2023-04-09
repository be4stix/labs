
public class Account {
    class Operation{
     
        public Operation(){}
    }
    int Summa;
    Operation[] Operations = new Operation;
    public Account(int a){ this.Summa = a;}
    
    void GetMoney(int a){
    if(this.Summa >= a){
        this.Summa-= a;
    } else{
        System.out.print("Недостаточно средств");
    }
    }
    void Perevod(Account F,int a){
        if(this.Summa >= a)
        {
           this.Summa-= a;
           F.Summa+= a;
        }else
        {
           System.out.print("Недостаточно средств");
        }           
    }
    
}

