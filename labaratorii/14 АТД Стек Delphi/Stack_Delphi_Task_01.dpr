program Stack_Delphi_Task_01;

{$APPTYPE CONSOLE}
  {  ��������� ���� Inlet.in �������� ������������� ��������.
     ��������� ���������� ���������� ����� ���� ������������� ���������.
     ����� ��, ��� ��� ��� �������� ��������? ��������� ������� ������ �������
   � ��������� ���� Outlet.out.
        ���������.
           � ������ ����������� ������������ ���� �������������� ���� ���������
           �������������� ����.
     ������������ ����� (���� Inlet.in):
           ������������� �������� (�� ������ � ������)
     ������������ ������ (���� Outlet.out):
           Yes ��� No
}
uses
  SysUtils, ULOP_ADT_CL;

var

		WStack : Stack<integer>;
		degit      : integer;

// �������� �����������

  procedure Vvod_i_FormirovanieSteka(out WStack : Stack<integer>) ;
	  var
		  Fin : TextFile;

    Procedure FormirovanieSteka;
	    var
		    number : integer;
    begin
	    while not EOF(fin) do
      begin
	    	Readln(fin, number);
    		WStack.PutL(number)
	    end
    end;
  begin
	  WStack:=Stack<integer>.Create;
	  Assign(Fin, '1.in');
   	ReSet(Fin);
  	FormirovanieSteka;
	  CloseFile(Fin)
  end;

	Function Analysis(const WStack : Stack<integer>) : string;
    var
  		isEquals : boolean;
	  	controlNumb, numb : Variant;
		  TempStack : Stack<integer>;
	begin
  	TempStack:=Stack<integer>.Create;
	  isEquals:=false;
  	Result:='No';
	  controlNumb := WStack.GetL;
  	while(not WStack.IsEmpty and not isEquals)do
    begin
  		while(not WStack.IsEmpty and not isEquals) do
      begin
			  numb := WStack.GetL;
			  isEquals:=controlNumb = numb;
			  if(not isEquals) then
				  TempStack.PutL(numb)
			end;
		  if(not isEquals) then
      begin
			  while(not TempStack.IsEmpty)do
        begin
				  numb := TempStack.GetL;
				  WStack.PutL(numb);
        end;
        controlNumb := WStack.GetL
      end
      else
      	Result:='Yes'
    end;
  end;
  Procedure VyvodResultata(const Otvet : string);
  	var
  		fout : TextFile;
	begin
	  assign(fout, 'Outlet.out');
 	  Rewrite(fout);
	  write(fout, Otvet);
	  CloseFile(fout)
  end;
  Procedure Show(const WStack : Stack<integer>);
	  var
		  element : integer;
	begin
	  for element in WStack do
		  Write(element, ' ');
  end;

begin
	Vvod_i_FormirovanieSteka(WStack);
	Show(WStack);
	VyvodResultata(Analysis(WStack))
end.

