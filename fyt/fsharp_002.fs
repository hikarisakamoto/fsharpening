module fsharpening.fsharp_002

open System.Data.SqlTypes

// Defining a function
// Function that take two strings and return a string, like
// string prefix(prefixStr: string, baseStr: string)
let prefix prefixStr baseStr = // Currying
    prefixStr + ", " + baseStr
//prefix "Hello" "Hikari ";

//  PIPELINE OPERATOR
let names = [ "Hikari"; "Joao"; "Matheus" ]

let prefixWithHello = prefix "Hello"

// Partial Application
names |> Seq.map (prefix "Hello")

let exclaim s = s + "!"

names
|> Seq.map prefixWithHello
|> Seq.map exclaim
|> Seq.sort


// Function Composition
let bigHello = prefixWithHello >> exclaim
names |> Seq.map bigHello |> Seq.sort

// Seqs are lazily evaluated
names
|> Seq.map (fun x ->
    printfn "Mapped over %s" x
    bigHello x)
|> Seq.sort

// Execute immediately 
names
|> Seq.map (fun x ->
    printfn "Mapped over %s" x
    bigHello x)
|> Seq.sort
|> Seq.iter (printfn "%s")
