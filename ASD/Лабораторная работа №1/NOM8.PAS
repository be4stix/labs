Var
    S,s1         : string[80];
    i,sr,n,t     : word;
Begin
 Writeln('Введите предложение ->');
 Readln(S);
 while S[1]=' ' do delete(S,1,1);
 while S[length(s)]=' ' do delete(S,length(s),1);
 s1:=S;
 N:=0;
  For i:=1 to length(s) do
   if S[i]=' ' then n:=n+1;
 n:=n+1;
 for i:=1 to length(s1) do
 if S1[i]=' ' then delete(s1,i,1);
 sr:=trunc(length(s1)/n);
 writeln('Средняя длинна слова =',sr);
 Writeln('Слова, по размеру больше среднего:');
 s:=s+' ';
 for i:=1 to length(s) do
 if S[i] in [',', ':', ';', '.', '!', '?'] then delete(s,i,1);
 while length(s)<>0 do
 Begin
  t:=pos(' ',s);
  if (t-1)>sr then  begin
                     for i:=1 to (t-1) do write(S[i]);
                     writeln;
                    end;
  delete(S,1,t);
 End;
 readln;
End.
