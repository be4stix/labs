package com.mycompany.account;
import java.util.Stack;

public class Account {
    class Operation{
        int sum;
        String NextAccName;
        public Operation(int sum){this.sum = sum;}
        public Operation(int sum, Account b){this.sum = sum;this.NextAccName = b.Name;}
        
    }
    String Name;
    int Summa;
    Stack<Operation> GetOperations = new Stack<Operation>();
    Stack<Operation> PerevodOperations = new Stack<Operation>();
    Stack<Operation> TryOperations = new Stack<Operation>();
    public Account(String name,int a){this.Name = name; this.Summa = a;}
    
    void GetMoney(int a){
    Operation f = new Operation(a);
    if(this.Summa >= a){
        this.Summa-= a;
        this.GetOperations.add(f);
    } else{
        System.out.println("Недостаточно средств");
        this.TryOperations.add(f);
    }
    }
    void Perevod(Account F,int a){
        Operation f = new Operation(a,F);
        if(this.Summa >= a)
        {
           this.Summa-= a;
           F.Summa+= a;
           this.PerevodOperations.add(f);
        }else
        {
           System.out.println("Недостаточно средств");
           this.TryOperations.add(f);
        }           
    }
    
    void PrintAllOperations(){
        for(Operation s : this.GetOperations){
            System.out.println("С вашего счёта снято " + s.sum );
        }
        for(Operation s : this.PerevodOperations){
            System.out.println("С вашего счёта переведено " + s.sum + " На счет " + s.NextAccName );
        }
        for(Operation s : this.TryOperations){
            System.out.println("Вы пытались снять или перевести сумму " + s.sum + ", но средств было недостаточно");
        }
    }
    
    public static void main(String[] arg){
        Account a = new Account("Первый",900);
        Account b = new Account("Второй",900);

        a.GetMoney(400);
        a.Perevod(b,400);
        a.GetMoney(900);
        
        a.PrintAllOperations();
    }
    
}

