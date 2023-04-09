Var x1,y1,x2,y2 : longint;
    p : boolean;
Begin
 p:=true;
 x1:=12;
 while p do
 begin
   x2:=4;
   while x2<>x1 do
   begin
     if ((x1*x1*x1-x2*x2*x2) mod 1000<>0)
        and ((x1*x1*x1-x2*x2*x2) mod 91=0) then begin
                                                  p:=false;
                                                  y1:=x1;
                                                  y2:=x2;
                                                end;
      x2:=x2+4;
    end;
    x1:=x1+4;
  end;
  writeln(y1,'      ',y2);
  readln;
End.