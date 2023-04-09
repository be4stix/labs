Uses
  CRT;
Const
  maxN=100;
Var
  A  : array[1..maxN] of integer;
  n,i,max,min  : integer;
  S  : real;

  Procedure Vvod;
  Begin
   CLRSCR;
    Write('Введите n: ');
    Readln(n);
    randomize;
    for i:=1 to n do
    begin
      a[i]:=0;
      while a[i]=0 do A[i]:=random(100)-80;
    end;
    writeln('Massiv A->');
    for I:=1 to n do write(A[i]:4);
    readln;
  end;
BEGIN
  Vvod;
  max:=A[1];
  min:=A[1];
  for i:=2 to n do
  begin
    if A[i]>max then max:=A[i];
    if A[i]<min then min:=A[i]
  end;
  S:=0;
  for i:=1 to n do S:=S+(1/A[i]);
  S:=n/s;
  writeln('max=',max,';  min=',min,' ;   S=',s:5:5);
  if abs(s-min)<abs(max-s) then
   writeln('min=',min,' меньше удален от среднего гармонического');
  if abs(s-min)>abs(max-s) then
   writeln('max=',max,' меньше удален от среднего гармонического');
  if  abs(s-min)=abs(max-s) then
    writeln('max и min одинаково удалены от среднего гармонического');
  readln;
END.

