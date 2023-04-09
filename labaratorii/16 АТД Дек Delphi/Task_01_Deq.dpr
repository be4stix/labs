program Task_01_Deq;

{$APPTYPE CONSOLE}
{
          ƒан текстовый файл Inlet.in, целых чисел из промежутка [a, b], и числа c и d, такие,
    что a < c < d < b.
    —формировать дек из троек элементов этого файла следующим образом:
       Ц первый элемент тройки Ц элемент файла, принадлежащий [a, c);
       Ц второй Ц элемент файла, принадлежащий [c, d);
       Ц третий Ц элемент файла, принадлежащий [d, b].
         ≈сли какие-нибудь компоненты будут отсутствовать, вместо них в дек записывать -100,
    0 или 100 , соответственно. ќдин и тот же элемент файла может быть включен в дек только
    один раз.
        —формированный дек вывести в текстовый файл Outlet.out.

    Ќапример:
       ¬вод:
          -10 14 0 5
           7 4 8 10 -5
       –езультат
           -5 4 7 -100 0 8 -100 0 10
.
     —пецификаци€ ввода (файл Inlet.in):
          a b c d
          ѕоследовательность целых чисел, разделенных пробелом
     —пецификаци€ вывода (файл Outlet.out):
          Ёлементы дека Ђот его начала к концуї, разделенные пробелом
}
uses
  SysUtils, ULOP_ADT_CL;

  Type
		ArrayElem = array of integer;
		Uslovie = Function(const Bl, Br : integer; const Arr : ArrayElem; out number : integer) : boolean;
  Var
	  Dq : Deq<integer>;
  	a, b, c, d : integer;
	  Arr : ArrayElem;
  	elem : integer;
  // ќписание процедур
  function isElemBelong(const a, b : integer;
                const Arr : ArrayElem; out number : integer) : boolean;
      Var
	  	  i : integer;
    begin
	    i:=0;
  	  Result:=false;
  	  while((i < Length(Arr)) and ((Arr[i] < a) or (Arr[i] >= b)))do
	    	inc(i);
      if(i < Length(Arr))then
      begin
	    	Result:=true;
		    number:=i
  		end
    end;
    function isElemEqual(const b : integer;
                const Arr : ArrayElem; out number : integer) : boolean;
  	  Var
	  	  i : integer;
    begin
	    i:=0;
  	  Result:=false;
  	  while((i < Length(Arr)) and (Arr[i] <> b))do
      begin
	    	inc(i);
		    if(i < Length(Arr))then
    		begin
        	Result:=true;
		    	number:=i
  		  end
  	  end
    end;

	Procedure Vvod_Informacii(out a, b, c, d : integer; out Arr : ArrayElem);
	  Var
		  Fin : TextFile;
		  kolElem, elem : integer;

  	// ќписание процедур
	  Function PowerArray : integer;
	    Var
		    Schet, temp : integer;
    begin
	    Schet := 0;
  	  while(not(eof(fin)))do
      begin
		    Read(fin, temp);
  		  inc(Schet)
      end;
    	Result := Schet
    end;
  begin
	  Assign(fin, '4.in');
  	Reset(fin);
	  Readln(fin, a, b, c, d);
  	kolElem:=PowerArray;
	  SetLength(Arr, kolElem);
  	Reset(fin);
	  Readln(fin);
  	kolElem:=0;
	  while(not(eof(fin))) do
    begin
	  	Read(fin, elem);
		  Arr[kolElem]:=elem;
  		inc(kolElem)
    end;
  end;
	Procedure PostroenieDeka(Arr : ArrayElem;
            const a, b, c, d : integer; out Dq : Deq<integer>);
  	Var
	  	first, second, third,
		  i, power, number : integer;
  		Nashli : Uslovie;
	// ќписание процедур
	  Function NumberOfInterval(const a, b : integer; var Arr : ArrayElem; out number : integer; Var find : Uslovie) : integer;
    begin
	    if (find(a, b, Arr, number)) then
      begin
	  	  Result := Arr[number];
  		  Arr[number] := 200
	    end
      else
        Result := 200
    end;
  begin
	  power:=Length(Arr);
  	i:=0;
    Nashli := isElemBelong;
	  Dq:=Deq<integer>.Create;
  	while(i < power)do
    begin
      elem := NumberOfInterval(a, c, Arr, number, Nashli);
      if elem<>200 then
      begin
        Dq.PutL(elem);
        inc(i)
      end
      else
        Dq.PutL(-100);
      elem := NumberOfInterval(c, d, Arr, number, Nashli);
      if elem<>200 then
      begin
        Dq.PutL(elem);
        inc(i)
      end
      else
        Dq.PutL(0);
      elem := NumberOfInterval(d, b+1, Arr, number, Nashli);
      if elem<>200 then
      begin
        Dq.PutL(elem);
        inc(i)
      end
      else
        Dq.PutL(100)
    end;
  end;

	Procedure Show;
    var
      number : integer;
  begin
    for number in Dq do
      WriteLn(number, ' ')
  end;

	Procedure VyvodResultata(var Dq : Deq<integer>);
    Var
		  strokaVyvoda : string;
  		fout : TextFile;
  begin
	  strokaVyvoda:='';
  	Assign(fout, 'Outlet.out');
	  ReWrite(fout);
  	while(not Dq.IsEmpty)do
	  	strokaVyvoda:=strokaVyvoda+' '+IntToStr(Dq.GetF);
  	strokaVyvoda:=Copy(strokaVyvoda, 2, Length(strokaVyvoda)-1);
	  Write(fout, strokaVyvoda);
  	CloseFile(fout)
  end;

begin
	Vvod_Informacii(a, b, c, d, Arr);
	PostroenieDeka(Arr, a, b, c, d, Dq);
	Writeln('ѕосле построени€ дека :');
	Show;
	VyvodResultata(Dq);
  Readln
end.
