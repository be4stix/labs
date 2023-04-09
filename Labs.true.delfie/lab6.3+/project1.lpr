program project1;
uses
    Math, SysUtils;

function f(x : real) : real;
begin
	result := x*x - sin(5*x);
end;
function f1(x : real) : real;
begin
	result :=2*x - 5*cos(5*x);
end;
function f2(x : real) : real;
begin
	result := 2 + 25*sin(5*x);
end;
function NP(a,b:real):real;
var x:real;
begin
        if f(a)*f2(a)>0
        then x:=a
        else x:=b;
        result :=x ;
end;
function  sk(a,b,tochost,x:real):real;

begin

       if abs(f(x))> tochost
       then
         result := sk(a,b,tochost,x-f(x)/f1(x))
       else  result:=x;

end;
function  rec(a,b,tochost,x:real):real;

begin

       if abs(x-sk(a,b,tochost,x))> tochost
       then
         result := rec(a,b,tochost,x-f(x)/f1(x))
       else  result:=x;

end;
var
  fin, fout: TextFile;
  tochost,xn,a,b:real;

begin
 AssignFile(fin, 'Inlet.txt');
 Reset(fin);
 Read(fin,a,b,tochost);
 AssignFile(fout, 'Outlet.txt');
 Rewrite(fout);
 xn:=rec(a,b,tochost,NP(a,b));
 Writeln(fout, xn:5:14);
 writeln(fout,f(xn));
 CloseFile(fin);
 CloseFile(fout);

end.
