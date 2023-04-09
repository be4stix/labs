program project1;
  Type
    EXO= ^O;
    O = record
        Data:string;
        Next:EXO;
    end;

Var BeginO, EndO,u:EXO;
	A,i,kolvo:integer;
	word:array[1..100] of string;
        fin,fout:textfile;

procedure ochered(c:string);
	begin
	New(u);
	u^.Data:=c;
	u^.Next:= Nil;
	if BeginO = Nil
		then 
			BeginO := u
		else 
			EndO^.Next := u;
	EndO := u;
	end;

begin
  Assignfile (fin,'Inlet.txt');
  Assignfile (fout, 'Outlet.txt');
  Reset(fin);
  Rewrite(fout);
  i:=0;
  word[i]:='';
  kolvo:=0;

  read(fin, A);

  while not eof(fin) do
  begin
  	readln(fin,word[i]) ;
        ochered(word[i]);
        inc(kolvo);
        inc(i);
  end;

 for i := 1 to kolvo do
 begin

 if A < length(word[i])
 then 
 begin
 write(fout, word[i],' ', i);
 end;

 end;



closefile(fin);
closefile(fout);

end.

