program Project1;
const n = 100;
var
 fin,fout:textfile;
 a:array[1..n] of char;
 word:array[1..n] of string;
 i,m:integer;
begin
Assignfile(fin,'Inlet.txt');
Assignfile(fout,'Outlet.txt');
reset(fin);
rewrite(fout);
m:=1;
word[m]:='';
for m := 1 to length(a) do
     begin
     while not eof(fin) do
begin
		read(fin, a[i]);
                if a[i] = ' '  then break
                else word[m]:= word[m] + a[i];
end;
     if m mod 2 = 0 then
      write (fout, word[m],' ');
end;

closefile(fin) ;
closefile(fout);
  end.
