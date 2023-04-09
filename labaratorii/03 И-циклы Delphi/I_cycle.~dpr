Program I_cycle;
{$APPTYPE CONSOLE}

{$R *.res}

uses
  System.SysUtils;

{
|    Написать программу решения уравнения:
|                  __
|         3 sin\|x  + 0.35x - 3.8 = 0;
|
|          используя метод Ньютона:
|                                  f(x_n)
|          x_(n+1) = x_n - ---------
|                                  f'(x_n)
|         Корень уравнения находится на отрезке [2; 3]. Контроль за окончанием просчетов
|      проводить по малости невязки.
|
|         Спецификация ввода :
|                 a b точтость
|         Спецификация вывода:
|                значение решения
}
function f(х : double) : double;
begin
	result := 3 * sin(sqrt(х)) + 0.35 * х - 3.8
end;
function fProizvodnaia(х : double) : double;
begin
	result := 1.5 * cos(sqrt(х)) / sqrt(х) + 0.35
end;
function f2Proizvodnaia(х : double) : double;
begin
	result := -0.75 * (sqrt(х) * sin(sqrt(х)) + cos(sqrt(х))) / (х * sqrt(х))
end;
function nachalnoePribligenie(a, b : double) : double;
begin
	if(f(a) * f2Proizvodnaia(a) > 0) then
		result := a
	else
		result := b
end;
function reshenieZadachi(a, b, tochnost : double) : double;
   var x : double;
begin
	x := nachalnoePribligenie(a, b);
	while( abs(f(x)) > tochnost) do
  begin
		x := x - f(x) / fProizvodnaia(x)
	end;
	result := x
end;

var
  a, b, tochnost, koren : Double;
begin
	Readln(a, b, tochnost);
	koren :=reshenieZadachi(a, b, tochnost);
	Write(koren)
end.
