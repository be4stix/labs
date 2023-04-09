program ExampleSolvMatrix_01;

{   Текстовый файл Inlet.in содержит целочисленные значения элементов массива
  A[0..N-1, 0..M-1].
    Переформировать его, упорядочив его строки по неубыванию их первых элементов.
    Результат решения задачи внести в файл Outlet.out.

       Примечание:
         Дополнительных массивов не использовать.

       Спецификация ввода (файл Inlet.in):
             N M
             Значения элементов массива по строкам
       Спецификация вывода (файл Outlet.out):
             Значения элементов преобразованного массива по строкам
}

{$APPTYPE CONSOLE}

uses
  SysUtils;

  const
    MaxN = 100;
    MaxM = 100;
  type
    Vector = array of integer;                    // Второй вариант решения
  var
    Fin, Fout : Text;
    A : array[0..MaxN-1, 0..MaxM-1] of integer;
//    A_Prim : array[0..MaxN-1] of Vector;        // Второй вариант решения
    N, M : integer;

  Procedure VvodDannyh;
    var i, j, elem : Integer;
  begin
    Assign(Fin, '1.in');
    ReSet(Fin);
    Readln(Fin, N, M);
    for i := 0 to N-1 do
    begin
//      SetLength(A_Prim[i], M);                 // Второй вариант решения
      for j := 0 to M-1 do
      begin
         Read(Fin, elem);
         A[i, j]:=elem;
//         A_Prim[i, j]:=elem;                  // Второй вариант решения
      end;
      Readln(Fin)
    end;
    CloseFile(Fin);
  end;
  Procedure ReOrganizationMatrix;
     Function RowMinFirst(numberFRow : integer) : integer;
       var minFirst, numberRow, i : integer;
     begin
       minFirst:= A[numberFRow, 0];
       numberRow:=numberFRow;
       for i:=numberFRow+1 to N-1 do
       begin
         if minFirst > A[i, 0] then
         begin
           minFirst  := A[i, 0];
           numberRow := i
         end;
       end;
       Result:=numberRow
     end;
     Procedure SwapRows(numberRow_1, numberRow_2 : integer);
       var j, temp : integer;
           v : Vector;
     begin
       for j := 0 to M-1 do
       begin
         temp :=A[numberRow_1, j];
         A[numberRow_1, j] := A[numberRow_2, j];
         A[numberRow_2, j] := temp
       end;
//       v:=A_Prim[numberRow_1];                    // Второй вариант решения
//       A_Prim[numberRow_1]:=A_Prim[numberRow_2];
//       A_Prim[numberRow_2]:=v
     end;
     var
       i, numberRowMinFirst : Integer;
  begin
    for i := 0 to N-2 do
    begin
      numberRowMinFirst:=RowMinFirst(i);
      if numberRowMinFirst<>i then
        SwapRows(i, numberRowMinFirst);
    end;
  end;
  Procedure OutPutResult;
    var
      i,j: Integer;
  begin
    Assign(FOut, 'Outlet.out');
    ReWrite(FOut);
    for i := 0 to N-1 do
    begin
      for j := 0 to M-1 do
        Write(fout, ' ',A[i,j]);
      Writeln(Fout)
    end;
//    Writeln(Fout);   Writeln(Fout);     // Контрольный вывод для второго варианта решения
//    for i := 0 to N-1 do
//    begin
//      for j := 0 to M-1 do
//        Write(fout, ' ',A_Prim[i,j]);
//      Writeln(Fout)
//    end;
    CloseFile(Fout)
  end;
begin
  VvodDannyh;
  ReOrganizationMatrix;
  OutPutResult
end.
