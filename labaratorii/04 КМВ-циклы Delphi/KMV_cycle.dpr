program KMV_cycle;

{$APPTYPE CONSOLE}

{$R *.res}

uses
  System.SysUtils;

{
|     ����� �����, �������� ��������, ��� ������ ���������� �������� ����������
|   ������ ������ �������� ���������� "��������":
|                                 5*x^4      7*x^6
|         S = 1 + 3x^2 + ---------- + ---------- + ...
|                                    2             6
|        ������������ ����� :
|             x ��������
|        ������������ ������:
|             �������� �����
}
var
   x, tochnost, slagaemoe, summa : double;
   k : integer;
begin
	Readln(x, tochnost);
	slagaemoe := 1.0;
	summa := 0;
	k := 0;
	while(abs((2*k+1)*slagaemoe) > tochnost) do
      begin
		summa := summa+(2*k +1)*slagaemoe;
		k := k +1;
		slagaemoe := slagaemoe*x*x/k;
	end;
	Write(summa)
end.
