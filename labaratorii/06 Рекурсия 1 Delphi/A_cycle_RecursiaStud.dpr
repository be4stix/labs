Program A_cycle_RecursiaStud;
{$APPTYPE CONSOLE}

{$R *.res}

uses
  System.SysUtils;

{
|     �������� ����������� �������� ���������� ����� ���� :
|                                                k
|                 1 + 1/2 + 1/4 + 1/8 + ... + 1/2
|          S = -----------------------------------------------
|                                                k
|                 1 + 1/3 + 1/9 + 1/27 + ... +1/3
|
|      ������������ ����� (���� Inlet.in):
|           k
|      ������������ ������  (���� Outlet.out):
|           S
}
  function Summa(n, k : integer; base, slag : double) : double;
  begin
   	if(n <= k) then
  		Result := slag + Summa(n+1, k, base, slag/base)
	  else
		Result := 0
  end;
  var
    fin, fout : TextFile;
    S : double;
    k : integer;
begin
	AssignFile(fin, 'Inlet.in');
	Reset(fin);
 	Readln(fin, k);
	S := Summa(0, k, 2, 1)/Summa(0, k, 3, 1);
	AssignFile(fout, 'Outlet.out');
	Rewrite(fout);
	Write(fout, S);
	CloseFile(fout)
end.
