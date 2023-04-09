Var S,t : string[81];
    i,j,n : word;
    B : set of 1..81;
Begin
  Writeln('Введите строку');
  Readln(S);
  t:='';
  n:=length(s);
  if n mod 2=0 then
  begin
   B:=[];
   for i:=1 to n do
   begin
     for j:=1 to n do
       begin
       if (j<>i) and (not(j in B)) and (not(i in B)) and (S[i]=S[j]) then
                                                       begin
                                                          B:=B+[i]+[j];
                                                          T:=S[i]+T+S[i];
                                                        end;
       end;
    end;
   if length(T)<n then writeln('No') else writeln(T);
   readln;
   end
   else
    begin
    B:=[];
    for i:=1 to n do
    begin
      for j:=1 to n do
        begin
        if (j<>i) and (not(j in B)) and (not(i in B)) and (S[i]=S[j]) then
                                                       begin
                                                          B:=B+[i]+[j];
                                                          T:=S[i]+T+S[i];
                                                        end;
        end;
     end;
     if length(T)<>(n-1) then begin write('No'); readln; exit end;
     for i:=1 to n do if not(i in B) then j:=i;
     for i:=1 to (length(t) div 2) do write(T[i]);
     write(S[j]);
     for i:=(length(t) div 2+1) to length(t) do write(T[i]);
     readln;
    end;
End.