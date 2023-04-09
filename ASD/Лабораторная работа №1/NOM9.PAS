const
  maxN=100;
Var
  A   : array[1..maxN] of word;
  i,n,p,t,j : word;
  Procedure Vvod;
  begin
    writeln('Введите n');
    readln(n);
    randomize;
    for i:=1 to n do A[i]:=random(50);
    for i:=1 to n do write(A[i]:5);
  end;
BEGIN
  Vvod;
  for i:=2 to n do
  begin
    if A[i]<A[1] then
    begin
      t:=A[i];
      for p:=(i-1) downto 1 do A[p+1]:=A[p];
      A[1]:=t;
    end
    else
     begin
         for p:=1 to (i-2) do
         begin
           if (A[i]>=A[p]) and (A[i]<=A[p+1]) then
           begin
             t:=A[i];
             for j:=(i-1) downto (P+1) do A[j+1]:=A[j];
             A[p+1]:=t;
           end;
         end;
     end;
   end;
   writeln;
   for i:=1 to n do write(A[i]:5);
   readln;
End.


