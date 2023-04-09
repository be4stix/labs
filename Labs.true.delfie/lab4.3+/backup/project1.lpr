program project1;

var exp, summ, sl, x : real;
  n:integer;
begin
  x:=1;
  while x<>0 do
  begin
  writeln('Vvedite x: ');
  readln(x);
  writeln('Vvedite exp: ');
  readln(exp);
  n:=0;
  sl:=1;
  summ:=0;
  while (abs(sl*(((2*n+1)/(2*n+3))*(sqr((x-1)/(x+1))))) > exp)do
  begin
  summ:= summ + sl;
  n:=n+1;
  sl:= sl*(((2*n+1)/(2*n+3))*(sqr((x-1)/(x+1)))) ;

  end;


  writeln('Summa ', summ:5:4);
  readln;
   end;
end.

