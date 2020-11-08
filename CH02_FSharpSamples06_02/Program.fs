// **************************************************
// Visual F# 2017 字串變數宣告定義
// **************************************************
let mutable thisIsAStringConstant = "這是一個字串變數"
let mutable 這是字串變數 = "This is A string"
let mutable 這是一個字串變數_01 = "ABCDEFGHIJ"
let mutable _XDataString : string = "Visual F# 2017 String Type"

// **************************************************
// Visual F# 2017 字串脫逸字元應用程式
// **************************************************
thisIsAStringConstant <- thisIsAStringConstant + "\n" + 這是字串變數
System.Console.WriteLine("1. " + thisIsAStringConstant)

thisIsAStringConstant <- thisIsAStringConstant + "\\" + 這是一個字串變數_01
System.Console.WriteLine("2. " + thisIsAStringConstant)

_XDataString <- "\t" + _XDataString
System.Console.WriteLine("3. " + _XDataString)

System.Console.WriteLine(System.Console.ReadLine())
