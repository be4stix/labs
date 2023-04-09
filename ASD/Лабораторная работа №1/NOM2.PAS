Program Sochetania_2; { generate subsets  n elements from m elements }
                      { m>=n>0 }
Uses
   Crt;

Const
  max_m=100;

Type
  mas=array[1..max_m] of byte;
Var
 A:mas;
 m,n:Byte;

 Procedure Init_mas(var A:mas; m:byte);
  var i:byte;
 begin
   For i:=1 to m do A[i]:=i                 //O(n)
 end;

 Procedure Display_mas(var A:mas; n:byte);
  var i:byte;
 begin
   For i:=1 to n do                         //O(n)
     Write(A[i]:4);
   Writeln
 end;

 Procedure Generator(var A:mas; m,n:byte);
  var i,k:byte;
 begin
   if m=n then                               //O(1)   
     Display_mas(A,n)
   else
   begin
     k:=n; { number first element of A, which will be changed }
     While k>=1 do                                                    //O(n)
     begin
       Display_mas(A,n);
       if A[n]=m then { on last place element from beginning A[1..m] } //O(1)
        k:=k-1
       else
         k:=n;  { return to last element A[1..n] }
       if k>=1 then                                         //O(1)
         for i:=n downto k do                               //O(n)
          A[i]:=A[k]+i-k+1;             
     end
   end
 end;

Begin
  Write('m='); Readln(m);
  Write('n (n<=m) ='); Readln(n);
  if n<=m then                //O(1)
  begin
    Init_mas(A,m);
    Generator(A,m,n);
  end;
End.