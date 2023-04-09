program project1;
  Type
    EXO1= ^O;
    O = record
        Data:char;
        Next:EXO1;
   end;


Var u,z:EXO1;
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


begin
  Assignfile (fin,'Inlet.txt');
  Assignfile (fout, 'Outlet.txt');
  Reset(fin);
  Rewrite(fout);
  i:=1;
  kolvo:=0;
  f:=0;
  z:=nil;

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



while u<> nil do
  begin
  write(fout,u^.data, ' ');
  u := u^.next;
  end;


closefile(fin);
closefile(fout);

end.

