// Learn more about F# at http://fsharp.org
// **********************************
// 運算子應用程式
// **********************************
open System

// **********************************
let mutable n1 : int = 1000
let mutable n2 : int = 2000
let mutable n3 : int = 3000
let mutable n4 : int = 4000
let mutable n5 : int = 5000
let mutable result01 : int = 0
result01 <- n1 + n2 + n3

// **************************************
// 宣告定義函數 AddNumbers (注意程式縮排)
// **************************************
let AddNumbers n1 n2 n3 = 
    n1 * 2 + n2 * 3 + n3 * 4

// **************************************
// 宣告定義函數 CalcNumber (注意程式縮排)
// **************************************
let CalcNumber n1 n2 n3 = 
    n1 - n2 - n3

// **************************************
// 宣告定義函數 MaxNumber (注意程式縮排)
// **************************************
let MaxNumber (n1 : int, n2 : int) : bool = 
    n1 > n2

// 運算式裡，加上函數運算式
let mutable result02 = 
    AddNumbers n1 n2 n4 +
    AddNumbers n2 n3 n5;;

let mutable result03 : int = 
    AddNumbers n1 n2 n3 + 
    CalcNumber n5 n1 n1;;

Console.WriteLine(result01);;
Console.WriteLine(result02);;
Console.WriteLine(result03);;

// ******************************
// 物件方法裡，崁入函數運算式
// ******************************
Console.WriteLine(
    MaxNumber(n3, n1));;
Console.WriteLine(Console.ReadLine());;