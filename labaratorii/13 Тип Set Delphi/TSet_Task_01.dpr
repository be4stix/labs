program TSet_Task_01;

{$APPTYPE CONSOLE}

uses
  SysUtils;

{
     � ��������� ����� Inlet.in �������� �������� ������� A[1..N, 1..N] ��������� ������ ���� �� ��������� �� -127 �� 127.
     �� ��������� ��������������� �������� � �� ������� ������� ����������  ��������� � ������� A ����������,
  ��������� �������� ���� Set, ���������� ��������� ��������� � ������ ������ �������.
   ��������� �������� � ��������� ���� Outlet.out.

      ������������ ����� (���� Inlet.in):
         N
         �������� ��������� ������� �� ������� ����� ������
      ������������ ������ (���� Outlet.out):
         ����������1
         ����������2
         . . . . . . . . . . . . . . . . . .
         ����������N
}
  Type
     TypeVal = -127..127;
     Matrix = array of array of TypeVal;
     Vector = array of integer;
  var
     A : Matrix;
     NumbElem : Vector;

Procedure VvodDannyh(out A : Matrix);
  var
     N, i, j : integer;
     fin : TextFile;
begin
	Assign(fin, 'Inlet.in');
	ReSet(fin);
	Readln(fin, N);
	SetLength(A, N);
	for i:=0 to N-1 do
		SetLength(A[i], N);
	for i:=0 to N-1 do
  begin
		for j:=0 to N-1 do
			Read(fin, A[i,j]);
		Readln(fin)
  end;
	CloseFile(fin)
end;

Procedure ReshenieZadachi(const A : Matrix; out Number : Vector);
  var
    S : Set of byte;
    IndRow, IndCol, CountEl : integer;
begin
	SetLength(Number, Length(A));
	for IndRow := 0 to Length(A)-1 do
  begin
		S :=[A[IndRow, 1]+127];
		CountEl:=1;
		for IndCol := 0 to Length(A)-1 do
			if(not(A[IndRow, IndCol]+127 in S)) then
      begin
				inc(CountEl);
				S:=S+[A[IndRow, IndCol]+127];
      end;
		Number[IndRow]:=CountEl;
  end;
end;

Procedure VyvodRezultata(const Number : Vector);
  var
     i : integer;
     fout : TextFile;
begin
	Assign(fout, 'Outlet.out');
	ReWrite(fout);
	for i := 0 to Length(Number)-2 do
		Writeln(fout, Number[i]);
	Write(fout, Number[Length(Number)-1]);
	CloseFile(fout)
end;

begin
	VvodDannyh(A);
	ReshenieZadachi(A, NumbElem);
	VyvodRezultata(NumbElem);
end.





