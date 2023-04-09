program Project1;
const n = 100;
var
 fin,fout:textfile;
 a:array[1..n] of char;
 i,k:integer;
 simvol:char;
begin
Assignfile(fin,'Inlet.txt');
Assignfile(fout,'Outlet.out');
reset(fin);
rewrite(fout);
read(fin, simvol);
k:=0;
i:=1;
          while not eof(fin) do
                begin
		     read(fin, a[i]);
                   //write (fout, i,' ', a[i],' ');
                     if (a[i] = simvol) and (a[i-1]= ' ') then inc(k);
                     inc (i);
                end;
if a[3] = simvol then write(fout, k+1 ) else write(fout, k);



closefile(fin) ;
closefile(fout);
  end.
