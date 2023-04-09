program project1;


var  x,a,sum:real;
     k,i:integer;

begin
   a:=1;
  sum :=0;
  writeln('Vvedite k ');
  readln(k);
  writeln('Vvedite x ');
  readln(x);

  for i := 1 to k do

begin
a := a*x/(k+1);
sum:= a +sum;
end;
  writeln('Pri k: ',k:5)  ;
  writeln ('Pri x: ',x:5:0) ;

  writeln ('Znachenie summbl: ',sum:5:2);

  readln;


end.

