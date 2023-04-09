program TaskLongArithm_01;
{
     В текстовом файле Inlet.in хранится значение целочисленной величины M.
   Получить последовательность Dk;Dk-1; . . . ;D0 десятичных цифр числа 2^M,
   то есть, такую целочисленную последовательность, в которой каждый член Di
   является цифрой и дополнительно,
                  < Десятичное представление числа 2^M>
     Выходную информацию – последовательность цифр результата разместить
   в текстовый файл Outlet.out.

           Спецификация ввода (файл Inlet.in):
              M
           Спецификация вывода (файл Outlet.out):
              Последовательность цифр результата (в виде строки без пробелов)
}

{$APPTYPE CONSOLE}

uses
  SysUtils;

	Type
	    { В задаче строится линейный односвязный список,
	      причем моделируемое "длинное" число в нем
	      (списке) представляется  последовательностью
	      его (числа) цифр, начиная с цифры разряда елиниц(!!!),
	      т.е. число-результат получается записанным
	      "от конца" D0, D1, ... Dn-1, Dn }
	List  = ^Digit;
  Digit = record
	  Value   : integer;
	  Address : List
	end;

	var
		M : integer;
		Number : List;
		F      : text;
	//  Описание процедур
	Procedure Degr2;
	  var
		  Temp : List;
  		Degr : Integer;
	  Procedure BeginWork;
    begin
    	New(Number);
    	Number^.Value:=1;
    	Number^.Address:=nil
    end;
    Procedure Multipl;
    	var
		    Prod, EdPer : integer;
    		DigitP, LastD : List;
    begin
    	DigitP:=Number;
    	EdPer :=0;
    	while DigitP<>nil do
      begin
		    Prod:=DigitP^.Value*2+EdPer;
    		DigitP^.Value:=Prod mod 10;
		    EdPer       :=Prod div 10;
    		LastD :=DigitP;
		    DigitP:=DigitP^.Address
    	end;
    	if EdPer<>0 then
      begin
		    New(DigitP);
    		DigitP^.Value  :=EdPer;
		    DigitP^.Address:=nil;
    		LastD^.Address :=DigitP
    	end
    end;
  begin
  	// Инициализация "длинного" числа
	  // для накопления произведения
  	BeginWork;
  	For Degr:=1 to M do	// Умножение "длинного" числа на 2
	  	Multipl
  end;
	Procedure Result;
  	var
	  	DigitP : List;
    	// "Обратитель" числа
    Procedure Revers(DigitP : List);
    begin
    	if DigitP^.Address<>nil then
      begin
		    Revers(DigitP^.Address);
    		Write(f, DigitP^.Value)
      end
    	else
		    Write(f, DigitP^.Value)
    end;
  begin
	  DigitP:=Number;
  	Revers(DigitP)
  end;
begin
	Assign(f, 'Inlet.in');
	Reset(f);
	Readln(f, M);
	Close(f);
	Degr2;
	Assign(f, 'Outlet.out');
	Rewrite(f);
	Result;
	Close(f)
end.







