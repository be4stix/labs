Var nashli:Boolean;
    a1,b1,a2,b2,a,b:real;
    c:real;
    Function f(x:real):real;
    begin
      F:=0.8896*x*x*x-2.813*x*x-3.6929*x+11.2;
    end;

Begin
  nashli:=False;
  a1:=-6;
  a2:=-5;
  b1:=-5;
  b2:=-4;
  While not nashli do
  Begin
  if F(a1)*F(a2)<0   then begin
                         nashli:=True;
                         a:=a1;
                         b:=a2
                        end;
  if F(b1)*F(b2)<0   then begin
                         nashli:=True;
                         a:=b1;
                         b:=b2
                        end;

   a1:=a1-1;  a2:=a2-1;
   b1:=b1+1;  b2:=b2+1;
  End;
  if f(a)*f(b)>0 then begin writeln('корней на участке нет'); readln; exit end;
  if f(a)=0 then begin writeln('корень-> ',a); readln; exit end;
  if f(b)=0 then begin writeln('корень-> ',b); readln; exit end;
  c:=(a+b)/2;
  while abs(f(c))>0.0001 do
  begin
    if f(c)*f(b)>0 then b:=c else a:=c;
      c:=(a+b)/2;
  end;
 Writeln(c:8:8);
 Readln;
End.