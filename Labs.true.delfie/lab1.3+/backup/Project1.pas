program Project1;
var x,y:real;
begin
 writeln('Vvedite x: ');
 readln(x);
 y:=0;
  if (x >= -4) and (x <= -2 )
  then y:= x/2 + 1
  else if (x>=-2) and (x<0)
  then y:=sqrt(4-sqr(x))
  else if (x>=0)  and (x<2)
  then y:= -x+2
  else if (x >=2) and (x<4)
  then y:= sqr(x)-6*x +7
  else if (x>4) and (x<5)
  then y:= x-4
  else writeln('Takih znachenii net');
  if (x>=-4) and (x<=5)
  writeln('Znachenie y: ',y:5:2);



  readln;
end.

