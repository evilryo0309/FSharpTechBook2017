// **************************************************
// Visual F# 2017 字串運算子應用
// **************************************************
let mutable thisIsAStringConstant = "這是一個字串變數"
let mutable 這是字串變數 = "This is A string"
let mutable 這是一個字串變數_01 = "ABCDEFGHIJ"
let mutable _XDataString : string = "Visual F# 2017 String Type"
let mutable combineData : string = 
    thisIsAStringConstant + "    " +
    這是字串變數 + "    " ^
    這是一個字串變數_01 ^ "    " ^
    _XDataString

System.Console.WriteLine(thisIsAStringConstant)
System.Console.WriteLine(這是字串變數)
System.Console.WriteLine(這是一個字串變數_01)
System.Console.WriteLine(_XDataString)
System.Console.WriteLine(combineData)
System.Console.WriteLine(System.Console.ReadLine())
