const
  max=100;
Var C : array[1..max] of char;
    S : string;
    M : set of 1..max;
    i,n,j,b1 : word;
    vyh : boolean;
Begin
 writeln('������ n');
 readln(n);
 Writeln('������ ᨬ������ ⠡���� �� ',n,' ������⮢: {�� � ��ப�}');
 for i:=1 to n do   readln(C[i]);
 Writeln('������ ᫮��');
 Readln(S);
 if length(S)>n then begin writeln('No'); readln; exit end;
 b1:=0;
 M:=[];
 for i:=1 to length(s) do
 begin
   vyh:=true;
   j:=1;
   While vyh and (j<=n) do
   begin
     if (S[i]=C[j]) and not(j in M) then begin
                                            vyh:=false;
                                            M:=M+[j];
                                         end;
     j:=j+1;
   end;
   if vyh then begin writeln('No'); readln; exit end;
 end;
 Writeln('����� ��⠢��� �����');
 readln;
End.
