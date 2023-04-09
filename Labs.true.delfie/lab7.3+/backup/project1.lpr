program project1;
uses SysUtils;
const n = 100;
var i,p,k:integer;
    a,b:array[1..n] of integer;
    fin, fout:textfile;
begin
 Assignfile(fin,'Inlet.txt');
 AssignFile(fout, 'Outlet.out');
 Reset(fin);
 readln (fin,p);
rewrite(fout);

 b[1]:= 1;                   //задал последовательности фибоначчи
 b[2]:=1;
 for i := 3 to p do
     b[i]:= b[i-1]+ b[i-2];

 for i:= 1 to p do
     readln(fin, a[i]);

 for i := 1 to p do
     for k := 1 to p do
      if( i = b[k] ) then write(fout,a[i],' ');

closefile(fin);
closefile(fout);
end.

