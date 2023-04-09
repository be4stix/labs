program project1;
  Type
    EXO1= ^O;
    O = record
        Data:char;
        Next:EXO1;
   end;
    EXO2= ^P;
    p = record
    Data:char;
    Next:EXO2;
 end;

Var u,z:EXO1;
    x,k:EXO2;
   i,f,kolvo:integer;
   a:array[1..100] of char;
        fin,fout:textfile;

procedure stec1(c:char);
  begin
  New(u);
 u^.data := c;
 u^.next := z;
 z:= u ;
  end;

procedure stec2(c:char);
  begin
  New(x);
  x^.data := c;
  x^.next := k;
  k:= x ;
  end;

begin
  Assignfile (fin,'Inlet.txt');
  Assignfile (fout, 'Outlet.txt');
  Reset(fin);
  Rewrite(fout);
  i:=1;
  kolvo:=0;
  f:=0;
  z:=nil;
  k:=nil;

  while not eof(fin) do
  begin
    read(fin,a[i]) ;
        inc(kolvo);
        inc(i);
  end;

  for i := 1 to (kolvo div 2)  do
  begin
  stec1(a[i]);
  end;

  for i := (kolvo div 2)to kolvo do
  stec2(a[i]);

while u<> nil do
  begin
  write(fout,u^.data, ' ');
  u := u^.next;
  end;

  //writeln(fout);

  while x<> nil do
  begin
  write(fout,x^.data, ' ');
  x := x^.next;
  end;





closefile(fin);
closefile(fout);

end.

