// **************************************************
// Visual F# 2017 結合 .NET Framework 物件設計功能
// **************************************************
// 引入 .NET Framework 物件類別庫
// **************************************************
open System

let mutable thisIsAStringConstant = "這是一個字串變數"
let mutable 這是字串變數 : string = "This is A string"
let mutable 這是一個字串變數_01 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
let mutable _XDataString : string = "Visual F# 2017 String Type"

_XDataString <-
    String.Concat(這是一個字串變數_01, 這是字串變數)
Console.WriteLine(_XDataString)

Console.WriteLine(
    這是一個字串變數_01.Trim().Substring(3, 10))

Console.WriteLine(
    "100 + 200 + 300 + 400 + 500 = " +
    (100 + 200 + 300 + 400 + 500).ToString().Trim())

let mutable GetDateInfo : DateTime = DateTime.Now.AddDays(1.0)
Console.WriteLine("今天是:" +
    DateTime.Now.ToString("yyyy/MM/dd").Trim() + "\n明天是:" + 
    GetDateInfo.ToString("yyyy/MM/dd").Trim())

// 宣告物件變數
// ************
let random = new Random()
let randomValueAdding(random1:int, random2:int) = 
    random1 * 2 + random2 * 3

// 函式 + 物件 運算式
// ******************
Console.WriteLine(
    randomValueAdding(random.Next(10, 99), random.Next(10, 99)))

System.Console.WriteLine(System.Console.ReadLine())
