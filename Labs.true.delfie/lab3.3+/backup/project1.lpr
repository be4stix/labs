program project1;
uses
    SysUtils;

function f(x : double) : double;
begin
	result := cos(2/x)-2*sin(1/x)+1/x;
end;
function fProizvodnaia1(x : double) : double;
begin
	result :=1/(x*x) *(2*cos(1/x)+2*sin(2/x)-1);
end;

function nachalnoePribligenie(a, b : double) : double;
begin
	if(f(a) * fProizvodnaia(a) > 0) then
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
		x := x - f(x) /fProizvodnaia( nachalnoePribligenie(a,b) );
	end;
	result := x
end;

var
  a, b, tochnost, koren : Double;
begin
	Readln(a, b, tochnost);
	koren :=reshenieZadachi(a, b, tochnost);
	Write('Korenb' , koren:5:9);
        readln;
end.
