Program VectorRecursia;
{$APPTYPE CONSOLE}

{$R *.res}

uses
  System.SysUtils;
{
 * Дан линейный массив A[1..N], содержащий целые числа.
 * Выделить те элементы этого массива в массив B, индексы которых являются степенями числа C.
 *    Спецификация ввода	:
 *      N С
 *  	Значения элементов массива А по одному в строке
 *    Спецификация вывода	:
 *      Значения элементов массива В в строку через пробел
 *
 }

type
   vector = array of integer;
var
  N, C : integer;
  A, B : vector;

procedure vvodDannyh(out N, C : integer; out A : vector);
   var
     fin : TextFile;
   procedure readArray(i, N : integer; var A : vector);
   begin
   	if(i<N) then
    begin
      Readln(fin, A[i]);
      readArray(i+1, N, A)
    end;
   end;
begin
	Assign(fin, 'Inlet.in');
	Reset(fin);
	Readln(fin, N, C);
  SetLength(A, N);
	readArray(0, N, A);
  CloseFile(fin)
end;

procedure formirovanieMassiva(C : integer; A : vector; out B : vector);
   var
      k : integer;
      r : double;
   procedure zapolnenieVektora(i, k, index : integer; A : vector; var B : vector);
     var
       j : integer;
   begin
     if(i< k) then
     begin
	    	j:= index;
    		B[i] := A[index-1];
		    zapolnenieVektora(i+1, k, index*C, A, B)
     end;
   end;
   function raschetRazmernostiB(stepenC, C, N : integer):integer;
   begin
   	 if(stepenC > N) then
		   Result:= 0
	   else
		   Result:= 1+raschetRazmernostiB(stepenC*C, C, N)
   end;

begin
 	k := raschetRazmernostiB(1, C, N);
 	SetLength(B, k);
 	zapolnenieVektora(0, k, 1, A, B)
end;

procedure vyvodResultata(B : vector);
   var
      strokaOtveta : string;
      fout : TextFile;
   procedure formirovanieStroki(i : integer; var strokaOtveta : string; B : vector);
   begin
     if(i < Length(B)) then
     begin
   		strokaOtveta:=strokaOtveta+' '+intToStr(B[i]);
	  	formirovanieStroki(i+1, strokaOtveta, B)
     end;
   end;
begin
  strokaOtveta:= intToStr(B[0]);
	formirovanieStroki(1, strokaOtveta, B);
	AssignFile(fout, 'Outlet.out');
	Rewrite(fout);
	Write(fout, strokaOtveta);
	CloseFile(fout)
end;
begin
	vvodDannyh(N, C, A);
	formirovanieMassiva(C, A, B);
	vyvodResultata(B);
end.
