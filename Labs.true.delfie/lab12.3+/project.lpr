program Twelve;
uses Math,SysUtils;
type
  Uk = ^S;
  s = record
    Data: integer;
    Next: Uk;
    end;
  Var head, x:Uk;
 D: array[1..1234567] of integer;
  M,i,mf,aa:integer;
  u:real;
  g:string;
  f1,f2:TextFile;
  begin
    AssignFile(f1,'Inlet.txt');
    Reset(f1);
    Read(f1,M);
    AssignFile(f2,'Outlet.txt');
    Rewrite(f2);

   mf:=1;
for i := 1 to m do
    mf := mf*i;

   g:=InttoStr(mf);
   u:=power(10,length(g)-1);
   aa:=floor(u);

   for i:=1 to length(g) do
   begin
   d[i]:=mf div aa;
   mf:=mf-d[i]*aa;
   if aa>2 then
   begin
   u:=aa/10;
   aa:=floor(u);
   end;
   end;

  New(x);
  x^.Data:=d[1];
  x^.Next:=Nil;
  Head:=x;
  Head^.Next:= x^.Next;
  Head^.Data:= x^.Data;
  Head:= x;

  if length(g)>1 then
  begin
  for i:=2 to length(g) do
  begin
  New(x^.Next);
  x:=x^.Next;
  x^.Data:=d[i];
  x^.Next:=Nil;
  end;
  end;
   x:=Head;

   while (x<>Nil) do
begin
Write(f2,x^.Data,' ');
x:=x^.Next;
End ;
   CloseFile(f1);
   CloseFile(f2);
  end.


