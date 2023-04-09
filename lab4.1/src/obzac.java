//Создать объект класса Абзац, используя класс Строка.
import java.util.HashSet;

public class obzac {
    HashSet<stroka> stroki = new HashSet<stroka>();
    void printobz(){
        for (stroka a : stroki)
        {
            System.out.println(a.strs);
        }
    }
    public obzac(stroka... s){
        for (stroka a : s)
        {
            stroki.add(a);
        }
    }
}
class stroka extends obzac{
    String strs;

    public stroka(String s){
        this.strs = s;
    }
}