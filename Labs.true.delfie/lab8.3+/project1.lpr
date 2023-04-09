program project1;
var  kelx,kely,s,i,summ,k:integer;
     a:array[0..99] of integer;
     fin,fout:textfile;
     sz,znach:real;
begin
  k:=0;
  s:=0;
  assignfile (fin, 'Inlet.txt');
  assignfile (fout, 'Outlet.txt');
  reset (fin);
  read(fin, kely,kelx,znach);
  rewrite(fout);
for s := 1 to kely do
         begin
          summ:=0;
          sz:=0;
          i:=0;
                  for i := 1 to kelx do
                           begin
                           read(fin,a[i]);
                           summ:= summ+a[i];
                         end ;
          sz := summ/kelx ;
          if sz < znach then k := k + 1;
          end;

write(fout,k);
closefile (fin);
closefile (fout);
end.
