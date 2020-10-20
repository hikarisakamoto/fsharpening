module fsharpening.syntax_101

// Single line comments
(*    Multi line comments
*
*)

//    Curly braces are not used to delimit blocks of code. Instead indentation is used
//    Whitespace is used to separate parameters rather than commas

// IMMUTABLE Variables
let myInt = 5
let myFloat = 3.14
let myString = "Hello world!"

// Lists
let twoToFive = [ 2; 3; 4; 5 ]

let oneToFive = 1 :: twoToFive
let zeroToFive = [ 0; 1 ] @ twoToFive


// Function

let square x = x * x
square 3

let add x y = x + y
add 2 3

// multiple line function
let evens list =
    let isEven x = x % 2 = 0
    List.filter isEven list

evens oneToFive

let sumOfSquareTo100 = List.sum (List.map square [ 1 .. 100 ])

// pipe
let sumOfSquaresTo100piped =
    [ 1 .. 100 ] |> List.map square |> List.sum

// anonymous functions
let sumOfSquaresTo100withFun =
    [ 1 .. 100 ]
    |> List.map (fun x -> x * x)
    |> List.sum


// Pattern Matching
let simplePatternsMatch =
    let x = "a"
    match x with
    | "a" -> printfn "x is a"
    | "b" -> printfn "x is b"
    | _ -> printfn "x is something else" // underscore matches anything

// Some() and None are analogous to Nullable wrappers
let validValue = Some(99)
let invalidValue = None

let optionPatternMatch input =
    match input with
    | Some i -> printfn "input is an int=%d" i
    | None -> printfn "input is missing"

optionPatternMatch validValue
optionPatternMatch invalidValue

// Complex Data Types
// Tuples
let twoTuple = 1, 2
let threeTuple = "a", 2, true

// Record type
type Person = { First: string; Last: string }
let person1 = { First = "John"; Last = "Doe" }

// Union types
type Temp =
    | DegreesC of float
    | DegreesF of float

let temp = DegreesF 98.6


type Employee =
    | Worker of Person
    | Manager of Employee list

let jdoe = { First = "John"; Last = "Doe" }
let worker = Worker jdoe



