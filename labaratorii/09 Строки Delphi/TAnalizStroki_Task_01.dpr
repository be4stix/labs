Program TAnalizStroki_Task_01;
{$APPTYPE CONSOLE}

{$R *.res}

uses
  System.SysUtils;

{
/*   Дан текстовый файл Inlet.in, содержащий строковые величины S. В последней его строке
     * находится символьная величина Symbol.
     *   Подсчитать число вхождений указанного символа, в предпоследние слова введенных литерных величин.
     * Если этого сделать нельзя, значением результата положить –1.
     *
     *     Определение. Слово - это последовательность символов строковой величины, не содержащая в себе символ пробела.
     *
     *     Спецификация ввода (файл Inlet.in):
     *        Строковая величина
     *        Строковая величина
     *        . . . . . . . . . . . . . . . . . . . . .
     *        Строковая величина
     *        Символьная величина
     *     Спецификация вывода (файл Outlet.out):
     *        Количество вхождений или -1
     *
     */
}
const
  nomTesta = 'Inlet';
var
   kolVhogdenii : integer;

function vvodDannyh_s_Analizom : integer;
  type
     ArrayStr = array of string;
  var
    kolPredlogenii, i, kolSlov : integer;
    bukva : char;
    predlogenie : ArrayStr;
    fin : TextFile;
    slovo : string;
    slova : ArrayStr;

  function prosmotrFaila() : integer;
   var
      schetchikStrok : integer;
  begin
  	schetchikStrok:=0;
	  AssignFile(fin,nomTesta+'.in');
  	Reset(fin);
	  while(not EOF(fin)) do
    begin
  		schetchikStrok:= schetchikStrok + 1;
	  	Readln(fin)
    end;
  	Result:=schetchikStrok-1
  end;

  function prochtenieFaila(const kolPr : integer) : ArrayStr;
   var
     schetchikStrok : integer;
     predlogenie : ArrayStr;
  begin
  	Reset(fin);
	  SetLength(predlogenie, kolPr);
  	for schetchikStrok:=0 to kolPr-1 do
  		Readln(fin, predlogenie[schetchikStrok]);
  	Result:=predlogenie
  end;

  function vydelenieSlovaPredlogenia(const predlogenie : string) : string;
   var
      ukaz : integer;
      slovo : string;

   procedure propustitProbely(var i : integer; const predlogenie : string);
   begin
     while(i>=0) and (predlogenie[i]=' ') do
      i:=i-1
   end;
   function vydelitSlovo(var i : integer; const predlogenie : string) : string;
     var
      slovo : string;
   begin
   	 slovo:='';
	   while(i>=0) and (predlogenie[i]<>' ') do
     begin
   		 slovo:=predlogenie[i] + slovo;
		   i:=i-1
     end;
     Result:=slovo
   end;

  begin
  	ukaz:=Length(predlogenie);
	  propustitProbely(ukaz, predlogenie);
  	slovo:=vydelitSlovo(ukaz, predlogenie);
	  propustitProbely(ukaz, predlogenie);
  	slovo:=vydelitSlovo(ukaz, predlogenie);
	  if(Length(slovo)>0) then
  		Result:=slovo
	  else
		  Result:=''
  end;
  function postroenieMassivaSlov(const predlogenie : ArrayStr; out kolSlov : integer) : ArrayStr;
   var
      arrSlov : ArrayStr;
      i : integer;
      slovo : string;
  begin
  	SetLength(arrSlov, Length(predlogenie));
	  kolSlov:=-1;
  	for i:=0 to Length(predlogenie) - 1 do
    begin
  		slovo:=vydelenieSlovaPredlogenia(predlogenie[i]);
	  	if(slovo>'0') then
      begin
  			kolSlov:=kolSlov+1;
	  		arrSlov[kolSlov]:=slovo;
      end;
    end;
  	Result:=arrSlov
  end;
  function podschetVhogdeniaBukvy(const slovo : string; const bukva : char): integer;
   var
      i : integer;
  begin
  	Result:=0;
	  for i:=1 to Length(slovo) do
  		if(slovo[i]=bukva) then
  			Result:=Result+1
  end;

begin
	kolPredlogenii:= prosmotrFaila();
	predlogenie := prochtenieFaila(kolPredlogenii);
	if(Length(predlogenie)>0)then
  begin
		Readln(fin, bukva);
		CloseFile(fin);
    slova:=postroenieMassivaSlov(predlogenie,kolSlov);
		if(kolSlov=-1) then
			Result:=-1
		else
    begin
			Result:=0;
			for i:=0 to kolSlov do
      begin
				slovo:=slova[i];
				Result:= Result + podschetVhogdeniaBukvy(slovo, bukva)
      end;
    end;
	end
  else
		Result:=-1
end;

procedure vyvodRezultata(const k : integer);
   var
      fout : TextFile;
begin
	AssignFile(fout, 'Outlet.out');
	Rewrite(fout);
	Write(fout, k);
	CloseFile(fout)
end;

begin
	kolVhogdenii:= vvodDannyh_s_Analizom();
	vyvodRezultata(kolVhogdenii)
end.


