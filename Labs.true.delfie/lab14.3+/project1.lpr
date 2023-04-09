program chetirnatcat;

type
SAO = ^S;
S = record
data: integer;
next: SAO
end;

var
a: array [1..100] of integer;
z, x: SAO;
k, i,min, mesto,kolvo: integer;
f1,f2:textFile;

procedure dob(u:integer);
begin
new(x);
x^.data := u;
x^.next := z;
z:= x
end;


begin
AssignFile(f1,'Inlet.txt');
AssignFile(f2,'Outlet.txt');
reset(f1);
rewrite(f2);
Reset(f1);
min := 0;
mesto := 0;
i:=1;
kolvo:=0;

z := nil;
while not eof(f1) do
    begin
    read(f1,a[i]);
    dob(a[i]);
    inc(i);
    inc(kolvo);
    end;

writeln(f2,'stec: ');
x := z;
while x <> nil do begin    //вывод стека
write(f2,x^.data, ' ');
x := x^.next;
 end;

for i := 1 to kolvo  do
begin
min:=a[1];
for k:= 2 to kolvo do
     if a[k] < min
        then
            begin
                 min := a[k];
                 mesto := k;
            end;
end;
writeln(f2);

write(f2, min,' ',mesto);
closefile(f1);
closefile(f2);
end.
