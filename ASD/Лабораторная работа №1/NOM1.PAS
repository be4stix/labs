Program Sochetania;  { сочетания из N элементов по М }
  Type
     st10=string[10];
  Var
    N,M : Byte;
    C   : Char;
    S   : st10;
    F   :Boolean;

 Procedure Sochet(var S:st10; N,M:Byte; var Flag:Boolean);
   Var
      i,j:Byte;

   Procedure Poisk(var ii:Byte; Var Flag:Boolean);
     Var
         i:Byte;
   Begin
     Flag:=True;
     For i:=M downto 1 do
      if not (S[i]=chr(N-M+i+49)) then
       Begin
         ii:=i;
         Exit;
       End;
     Flag:=False
   End;

 Begin
   Poisk(i,Flag);
   If flag then
   Begin
     S[i]:=succ(S[i]);
     For j:=i+1 to M do
       S[j]:=succ(S[j-1])
   End
 End;

 Begin
   Write('N -->>>'); Readln(N);
   Write('M<=N -->>>'); Readln(M);
   S:='';
   For C:=chr(49) to chr(48+M) do
     S:=S+C;
   Repeat
     Write(S:5);
     Sochet(S,N-1,M,F)
   Until not F

 End.