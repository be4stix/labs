program Task_01_Deq;

{$APPTYPE CONSOLE}
{
          ��� ��������� ���� Inlet.in, ����� ����� �� ���������� [a, b], � ����� c � d, �����,
    ��� a < c < d < b.
    ������������ ��� �� ����� ��������� ����� ����� ��������� �������:
       � ������ ������� ������ � ������� �����, ������������� [a, c);
       � ������ � ������� �����, ������������� [c, d);
       � ������ � ������� �����, ������������� [d, b].
         ���� �����-������ ���������� ����� �������������, ������ ��� � ��� ���������� -100,
    0 ��� 100 , ��������������. ���� � ��� �� ������� ����� ����� ���� ������� � ��� ������
    ���� ���.
        �������������� ��� ������� � ��������� ���� Outlet.out.

    ��������:
       ����:
          -10 14 0 5
           7 4 8 10 -5
       ���������
           -5 4 7 -100 0 8 -100 0 10
.
     ������������ ����� (���� Inlet.in):
          a b c d
          ������������������ ����� �����, ����������� ��������
     ������������ ������ (���� Outlet.out):
          �������� ���� ��� ��� ������ � �����, ����������� ��������
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
  // �������� ��������
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

  	// �������� ��������
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
	// �������� ��������
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
	Writeln('����� ���������� ���� :');
	Show;
	VyvodResultata(Dq);
  Readln
end.
