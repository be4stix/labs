Program AnalizTextFile;
{$APPTYPE CONSOLE}

{$R *.res}

uses
  System.SysUtils;

{
   ��� ��������� ���� �������� ������� Inlet.in.
  ���������� ���������� ���� � ������ ����� � ������� � ��������� ���� Outlet.out.
       �����������.
            ������ ��������, ����������� ��������� (����� ��� �����������) �
            �� ���������� �������� ������ ����, ���������� �������

      ���� (���� Inlet.in):
          ������ ��������
          ������ ��������
          . . . . . . . . . . . . . . .
          ������ ��������

     ����� (���� Outlet.out):
          ���������� ����
}

var
    CountWords : Integer;

Function VvodDannyh_podschetSlov : integer;
   var
      fin : TextFile;
      Stroka : string;

   Function CountWordsInRow(Stroka : String) : Integer;
     var
       i : Integer;

     Procedure PassWhiteSpace(var i : integer);
     begin
	     while((i<=Length(Stroka)) and (Stroka[i]=' ')) do
		     inc(i)
     end;
     Procedure PassWord(var i : integer);
     begin
	     while((i<=Length(Stroka)) and (Stroka[i]<>' ')) do
     		 inc(i)
     end;
   begin {CountWordsInRow }
     Result:=0;
	   i:=1;
	   PassWhiteSpace(i);
 	   while(i<=Length(Stroka)) do
     begin
		   inc(Result);
		   PassWord(i);
		   PassWhiteSpace(i)
     end;
   end;   {CountWordsInRow }

begin {VvodDannyh_podschetSlov}
	Assign(fin, 'Inlet.in');
	ReSet(fin);
	Result:=0;
	while(Not EOF(FIn)) do
  begin
		ReadLn(FIn, Stroka);
		Result:=Result+CountWordsInRow(Stroka)
  end;
	Close(fin)
end;  {VvodDannyh_podschetSlov}

Procedure VyvodResultata(Count : integer);
  var
    fout : textfile;
begin {VyvodResultata}
	Assign(fout, 'Outlet.out');
	Rewrite(fout);
	Write(fout, Count);
	Close(fout);
end;  {VyvodResultata}

begin
  CountWords:=VvodDannyh_podschetSlov;
	VyvodResultata(CountWords)
end.



