program A_cycle;

{$APPTYPE CONSOLE}

{$R *.res}

uses
  System.SysUtils;

{
|     Напишите программу нахождения суммы, включая в нее первые k слагаемых:
|                                   2                            k
|                    ln(3)        ln (3)     2                 ln(3)      k
|          S = 1 +  -------*x + ---------* x    +  . . .  + ---------- * x
|                     1!            2!                          k!
|
|      Спецификация ввода :
|           k x
|      Спецификация вывода:
|
|           S
}
var
   x, slagaemoe, summa : double;
   k, n : integer;
begin
	Readln(k, x);
	slagaemoe:=1.0;
	summa:=slagaemoe;
	for n:= 0 to k-1 do
  begin
		slagaemoe:=ln(3.0)*x*slagaemoe/(n+1);
		summa:=summa+slagaemoe
	end;
	Write(summa);
end.
