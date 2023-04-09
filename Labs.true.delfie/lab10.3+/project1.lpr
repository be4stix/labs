program Project2;
uses
  SysUtils;

var
  t: array[1..800]of integer;
  s: string;
  d:char;
  f1,f2: TextFile;
  i, z, o,pp,k,j : integer;
procedure schit;
begin
  if not eof(f1) then
     begin
     readln(f1);
     pp:=pp+1;
     schit;      //  кол-во строчек
     end;
 end;
procedure d1;
begin
  if i<=pp then   //последний элемент
      begin
        if (i=pp) then
        readln(f1,d)
        else
          begin
          readln(f1);
          i:=i+1;
          d1;
          end;
      end;
end;

procedure d2;
begin
  if j<=length(s) then  //считывает длинну слов
        begin
          if (S[j]=' ') then
          begin
          o:=o+1;
          t[o]:=j-1-z;
          z:=j;
          end;
          j:=j+1;
          d2;
        end;
end;

procedure d3;
begin
  if j<=length(s)- t[o]-1 then //считывание посл слова
        begin
         if s[j]=d then
         k:=k+1;
         j:=j+1;
         d3;
        end;
end;

procedure d4;
begin
  if i<= pp-1 then
      begin
      readln(f1,s);
      j:=1;
      d2;
        o:=o+1;
        t[o]:=length(s)-z;//длинна последнего слова
        j:= length(s)- t[o]-t[o-1];
        d3;
        if k<>0 then            //вывод
          begin
          writeln(f2,k);
          k:=0;
          end
        else writeln(f2,'-1');
        i:=i+1;
        d4;
       end ;
end;

  begin
    AssignFile(f1, 'Inlet.txt');
    Reset(f1);
    AssignFile(f2, 'Outlet.txt');
    Rewrite(f2);
    o:=0;
    z:=0;
    pp:=0;
    k:=0;
    schit;
    Reset(f1);
    i:=1;
    d1;
    Reset(f1);
    i:=1;
    d4;
  CloseFile(f1);
  CloseFile(f2);
  end.


