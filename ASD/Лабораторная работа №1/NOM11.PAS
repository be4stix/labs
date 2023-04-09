const
   maxN=100;
Var
  A         : array[1..maxN,1..maxN] of real;
  i,x,y,j : word;
  sr,sr1,s    : real;
 Procedure vvod;
 begin
   Writeln('Введите размеры таблицы');
   Readln(x,y);
   randomize;
   for i:=1 to y do
   for j:=1 to x do A[j,i]:=random*5;
   { вывод }
   for i:=1 to y do
   begin
     for j:=1 to (x-1) do write(A[j,i]:3:1,'     ');
     writeln(A[x,i]:3:1)
   end;
 end;
BEGIN
  Vvod;
  S:=1;
  Writeln('Все средние значения:');
  for i:=2 to (y-1) do
  begin
    for j:=2 to (x-1) do
    begin
      sr1:=A[j-1,i-1]*A[j+1,i-1]*A[j+1,i+1]*A[j-1,i+1];
      sr:=exp(ln(sr1)*0.25);
      writeln(sr);
      if A[j,i]<=sr then s:=s*A[j,i]
    end;
  end;
  Writeln('Ответ: произведение равно ',S:10:5);
  readln
END.