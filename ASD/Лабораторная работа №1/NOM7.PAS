const
   n=90;
Var  A        : array[1..n] of record
                                 x:string[1];
                                 z:word;
                               end;
     W        : set of char;
     i,a1,j   : word;
     S        : string[n];
     p        : real;
BEGIN
  writeln('Введите строку ->');
  readln(S);
  writeln('Введите p ->');
  readln(p);
  W:=[];
  a1:=0;
  for i:=1 to n do A[i].z:=0;

  for i:=1 to length(s) do
  begin
   if not (S[i] in W) then
                      begin
                       W:=W+[s[i]];
                       a1:=a1+1;
                       A[a1].x:=S[i];
                       A[a1].z:=1;
                      end
                      else
                          begin
                            for j:=1 to a1 do
                            if A[j].x=S[i] then A[j].z:=A[j].z+1;
                          end;
  end;
  writeln('удовлетворяющие условию символы (если они есть) ->');
  for i:=1 to a1 do
  begin
   if (A[i].z/a1*100)>=p then begin
                               if A[i].x=' ' then write('  пробел  ') else
                               write(A[i].x:4);
                              end;
  end;
  readln
 End.







