program TskArr01Del;

{$APPTYPE CONSOLE}
{   ��������� ���� Inlet.in �������� ������������� �������� ��������� ���������
  ������� A[1..N].
    �������� �� �������� ����� ������� � ������ B, ������� �� � ���� Outlet.out,
  ������� ������� �������� ���������� ����� C.

    ������������ ����� (���� Inlet.in) :
          N �
          �������� ��������� ������� � �� ������ � ������
    ������������ ������ (���� Outlet.out) :
          �������� ��������� ������� �
}
uses
  SysUtils;
const
  MaxDim = 500;
var fin, fout : Text;
    N, C, k : integer;
    a, b : array [1..MaxDim] of integer;

Procedure Vvod_massiva;
  var i : integer;
begin
  Assign(Fin, 'Inlet.in');
  ReSet(Fin);
  Readln(Fin, N, C);
  For i:=1 to N do
    Readln(Fin, a[i]);
  CloseFile(Fin);
end;
Procedure Formir;
  var ia, ib : integer;
begin
  ia:=1;  ib:=1;
  b[1]:=a[1];
  k:=ib;
  if c>1 then
  begin
    ia:=ia*c;
    while ia<=N do
    begin
      inc(ib);
      b[ib]:=a[ia];
      ia:=ia*c
    end;
    k:=ib
  end
end;
Procedure Vyvod;
  var i : integer;
begin
  Assign(FOut, 'Outlet.out');
  ReWrite(FOut);
  For i:=1 to k do  Write(FOut, b[i],' ');
  CloseFile(FOut)
end;

begin
  Vvod_massiva;
  Formir;
  Vyvod
end.
