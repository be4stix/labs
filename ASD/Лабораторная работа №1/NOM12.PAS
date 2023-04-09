Var i:word;  Vn,Qn:EXTENDED;
  Function Vn_t(n:word):extended;
  var j:word; z:-2..2; x,S:extended;
  Begin
   S:=1;
   z:=-1;
   for j:=2 to n do
   begin
     x:=1/(j*j)*z;
     S:=S+x;
     z:=-z;
   end;
   Vn_t:=2*sqrt(3*S);
  end;

  Function Qn_t(n:word):extended;
  var j,z:word;  s,x:extended;
  Begin
   S:=1;
   z:=1;
   for j:=2 to n do
   begin
     z:=z+2;
     x:=1/(z*z);
     s:=s+x;
   end;
   Qn_t:=2*sqrt(2*s);
  end;

Begin
 i:=0;
 Vn:=100;
 Qn:=50;
 While abs(Vn-Qn)>=0.0001 do
 begin
   i:=i+1;
   Vn:=Vn_t(i);
   Qn:=Qn_t(i);
 end;
 Writeln('нужно взять ',i,' слагаемых, а пи равно приблизительно ',Vn);
 Readln;
End.

