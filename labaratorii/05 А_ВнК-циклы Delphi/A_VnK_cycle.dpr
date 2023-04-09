Program A_VnK_cycle;
{$APPTYPE CONSOLE}

{$R *.res}

uses
  System.SysUtils;

{
|     �������� ��������� ���������� �����, ������� � ��� ������ k ���������:
|                                        2                              k
|                      ln(3)        ln  (3)     2                 ln  (3)      k
|          S = 1 +  -------*x + ---------* x    +  . . .  + ---------- * x     , ��� �������, ���
|                         1!             2!                             k!
|   ���������� �������� ������� �� ��������� ������ �������� ��������.
|   ���� �������� ������-�� �� ��������� �� ����� ������������� ����� �������,
|   �� ����������� ��������� ����� �� �����.
|
|      ������������ ����� :
|           k x ��������
|      ������������ ������:
|           S
}
var
   x, slagaemoe, summa, tochnost : double;
   k, n : integer;
begin
	Readln(k, x, tochnost);
	slagaemoe:=1.0;
	summa:=slagaemoe;
	for n:= 0 to k-1 do
      begin
		slagaemoe:=ln(3.0)*x*slagaemoe/(n+1);
		if(abs(slagaemoe) > tochnost) then
			summa:=summa+slagaemoe
		else
			break;

	end;
	if(n < k-1) then
		Write(summa,' ', n)
	else
		Write(summa,' ', k);
    Readln
end.
