program Project5;
uses
math;
Var
x,e,a1,a2,sum:real;
k,n:integer;
begin
read(k,x,e);
n:=1;
a1:=1;
a2:=a1*x/(n+1);
sum:=a1;

while ((a1>e) or (a2>e)) and (n<=k) do begin
n:=n+1;
a1:=a2;
sum:=sum+a1;
a2:=a1*x/(n+1);
end;
writeln(sum:5:3,' ',n-1);
readln;
readln;
end.
