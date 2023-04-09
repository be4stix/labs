program trinatcat;
var
  N,i,j,x,k:integer;
  z,f,sum:set of byte;
  f1, f2: TextFile;
begin
  AssignFile(f1, 'Inlet.txt');
  AssignFile(f2, 'Outlet.txt');
  reset(f1);
  rewrite(f2);
  readln(f1,N);
  z := [];
  f:=[];
  k:=0;

  for i:=1 to N do
  begin
    for j:=1 to N do
    begin
      Read(f1, x);
       if (x>127) or  (x<-127) then k:= 1;
       if  i=j then z := z+[x]
       else if   i+j = N+1 then f:= f + [x] ;

    end;
    readln(f1);
  end;

  sum := z + f;

  if k = 0 then
  for i:= 127 downto -127 do
  begin
    if i in sum then write (f2, i, ' ');
    end
  else
    write (f2, 'Est znacheniya ne v (-127;127)') ;





  closefile(f1);
  closefile(f2);
end.
