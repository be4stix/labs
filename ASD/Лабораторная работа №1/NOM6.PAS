Var i       : integer;
    Vyh     : boolean;
    s1,s2,h : real;
       Function S(k:word):real;
       var j:word;  s1:real;
          Function F(k1:real):real;
             begin
                F:=1/(1+k1*k1*k1);
             end;
       begin
         S1:=0;
         for j:=1 to (k-1) do begin S1:=S1+F(j*h); end;
         S:=2*s1;
       end;
BEGIN
  i:=1;
  Vyh:=true;
  While Vyh do
  begin
    i:=i+1;
    h:=1/i;
    s1:=0.5*h*(1+S(i)+0.5);
    h:=h*0.5;
    s2:=0.5*h*(1+S(2*i)+0.5);
    if abs(s1-s2)<0.001 then vyh:=false;
    writeln(i);
  end;
    writeln('________________________________________________________');
    Writeln('N=',i,' s=',s2);
    readln;
End.



