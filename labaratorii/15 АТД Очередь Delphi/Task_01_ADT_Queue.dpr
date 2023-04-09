program Task_01_ADT_Queue;

{$APPTYPE CONSOLE}
{
   Текстовый файл Inlet.in содержит параметр n и
 2n целочисленных значений массива А.
   Построить очередь элементов целого типа содержащий элементы
 в следующем порядке:
        A[0] + A[2n-1];
        A[1] + A[2n-2];
        A[2] + A[2n-3];
         : : : ;
        A[n-1] + A[n]:
  Если этого сделать нельзя, в качестве ответа выдать значение –1.
  Результат решения задачи внести в файл Outlet.out.

        Ввод (файл Inlet.in):
           n
           2n значения элементов массива в строку через пробел

        Вывод (файл Outlet.out):
           Значения элементов очереди или –1
}
{$R *.res}

uses
  System.SysUtils,
  ULOP_ADT_CL;
type
  ArrayElem = array of integer;
var
  Que  : Queue<integer>;
  A       : ArrayElem;

Procedure Vvod_Informacii(out A : ArrayElem);
  var
     F       : TextFile;
     n, i    : integer;
begin
	AssignFile(F, 'Inlet.in');
	Reset(F);
	Readln(F, n);
	SetLength(A, 2*n);
	i:=0;
	while(not EOF(f)) do
  begin
		Read(F, A[i]);
		inc(i)
  end;
	CloseFile(F)
end;

Procedure PostroenieOcheredi(const A : ArrayElem; out Que : Queue<integer>);
  var i, LastInd  : integer;
begin
	LastInd:=Length(A)-1;
	Que:=Queue<integer>.Create();
	for I := 0 to (Length(A) div 2)-1 do
  begin
		Que.PutL(A[i]+A[LastInd]);
		dec(LastInd)
  end;
end;

Procedure VyvodResultata(var Que : Queue<integer>);
  var
     F       : TextFile;
     elem    : integer;
begin
	AssignFile(F, 'Outlet.out');
	ReWrite(F);
	if(Que.IsEmpty) then
		Write(F, -1)
  else
  begin
    for elem in Que do
   		Write(F, elem, ' ');
  end;
	CloseFile(F);
end;

begin
  try
   Vvod_Informacii(A);
   PostroenieOcheredi(A, Que);                                    ;
	 VyvodResultata(Que)
  except
    on E: Exception do
      Writeln(E.ClassName, ': ', E.Message);
  end;
end.
