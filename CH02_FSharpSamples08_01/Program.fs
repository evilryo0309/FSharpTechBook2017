// **************************************
// Visual F# 2017 遞迴函數設計
// **************************************
open System

// **************************************
// 使用遞迴函數計算費伯納西數列
// **************************************
let rec Fibonacci index : int32 = 
    if index <= 2 then
        // 當計算項數為第一與第二時，停止遞迴，傳回 1
        1
    else
        // 當計算項數不為第一與第二時，執行遞迴呼叫
        Fibonacci (index - 2) + 
        Fibonacci (index - 1)

// 1 1 2 3 5 8 13 21 34 55
Console.WriteLine(
    "費伯納西數列第 10 項為 " + Convert.ToString(Fibonacci(10)))

Console.WriteLine(Console.ReadLine())