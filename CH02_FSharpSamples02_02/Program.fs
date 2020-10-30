// Learn more about F# at http://fsharp.org

//* ********************************
//* 函數應用範例:
//* ********************************
open System

//* 宣告函數 Multiple_Values_Plus()
//* ********************************
let Multiple_Values_Plus(v1:int, v2:int, v3:int, v4:int, v5:int) = 
    let r = v1 + v2 + v3 + v4 + v5;
    r;;     //* 函數回傳值    //* 函數結束
//* ********************************

Console.Write("呼叫函數 1, 計算 100 + 300 + 500 + 700 + 900 = ")
Console.WriteLine(
    Convert.ToString(
        Multiple_Values_Plus(100, 300, 500, 700, 900)));
Console.WriteLine(Console.ReadLine());;
