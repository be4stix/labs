Program A_VnK_cycle;
{$APPTYPE CONSOLE}

{$R *.res}

uses
  System.SysUtils;

{
|     Напишите программу нахождения суммы, включая в нее первые k слагаемых:
|                                        2                              k
|                      ln(3)        ln  (3)     2                 ln  (3)      k
|          S = 1 +  -------*x + ---------* x    +  . . .  + ---------- * x     , при условии, что
|                         1!             2!                             k!
|   абсолютная величина каждого из слагаемых больше значения ТОЧНОСТЬ.
|   Если значение какого-то из слагаемых не будет удовлетворять этому условию,
|   то реализовать досрочный выход из цикла.
|
|      Спецификация ввода :
|           k x точность
|      Спецификация вывода:
|           S
}
var
   x, slagaemoe, summa, tochnost : double;
   k, n : integer;
begin
	Readln(k, x, tochnost);
	slagaemoe:=1.0;
	summa:=slagaemoe;
	for n:= 0 to k-1 do
      begin
		slagaemoe:=ln(3.0)*x*slagaemoe/(n+1);
		if(abs(slagaemoe) > tochnost) then
			summa:=summa+slagaemoe
		else
			break;

	end;
	if(n < k-1) then
		Write(summa,' ', n)
	else
		Write(summa,' ', k);
    Readln
end.
