program TaskLongArithm_01;
{
     � ��������� ����� Inlet.in �������� �������� ������������� �������� M.
   �������� ������������������ Dk;Dk-1; . . . ;D0 ���������� ���� ����� 2^M,
   �� ����, ����� ������������� ������������������, � ������� ������ ���� Di
   �������� ������ � �������������,
                  < ���������� ������������� ����� 2^M>
     �������� ���������� � ������������������ ���� ���������� ����������
   � ��������� ���� Outlet.out.

           ������������ ����� (���� Inlet.in):
              M
           ������������ ������ (���� Outlet.out):
              ������������������ ���� ���������� (� ���� ������ ��� ��������)
}

{$APPTYPE CONSOLE}

uses
  SysUtils;

	Type
	    { � ������ �������� �������� ����������� ������,
	      ������ ������������ "�������" ����� � ���
	      (������) ��������������  �������������������
	      ��� (�����) ����, ������� � ����� ������� ������(!!!),
	      �.�. �����-��������� ���������� ����������
	      "�� �����" D0, D1, ... Dn-1, Dn }
	List  = ^Digit;
  Digit = record
	  Value   : integer;
	  Address : List
	end;

	var
		M : integer;
		Number : List;
		F      : text;
	//  �������� ��������
	Procedure Degr2;
	  var
		  Temp : List;
  		Degr : Integer;
	  Procedure BeginWork;
    begin
    	New(Number);
    	Number^.Value:=1;
    	Number^.Address:=nil
    end;
    Procedure Multipl;
    	var
		    Prod, EdPer : integer;
    		DigitP, LastD : List;
    begin
    	DigitP:=Number;
    	EdPer :=0;
    	while DigitP<>nil do
      begin
		    Prod:=DigitP^.Value*2+EdPer;
    		DigitP^.Value:=Prod mod 10;
		    EdPer       :=Prod div 10;
    		LastD :=DigitP;
		    DigitP:=DigitP^.Address
    	end;
    	if EdPer<>0 then
      begin
		    New(DigitP);
    		DigitP^.Value  :=EdPer;
		    DigitP^.Address:=nil;
    		LastD^.Address :=DigitP
    	end
    end;
  begin
  	// ������������� "��������" �����
	  // ��� ���������� ������������
  	BeginWork;
  	For Degr:=1 to M do	// ��������� "��������" ����� �� 2
	  	Multipl
  end;
	Procedure Result;
  	var
	  	DigitP : List;
    	// "����������" �����
    Procedure Revers(DigitP : List);
    begin
    	if DigitP^.Address<>nil then
      begin
		    Revers(DigitP^.Address);
    		Write(f, DigitP^.Value)
      end
    	else
		    Write(f, DigitP^.Value)
    end;
  begin
	  DigitP:=Number;
  	Revers(DigitP)
  end;
begin
	Assign(f, 'Inlet.in');
	Reset(f);
	Readln(f, M);
	Close(f);
	Degr2;
	Assign(f, 'Outlet.out');
	Rewrite(f);
	Result;
	Close(f)
end.







