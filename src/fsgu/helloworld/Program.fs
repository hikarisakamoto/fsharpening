open System

let sayHello person =
    printfn "Hello %s from my F# program" person

let isValid person = not (String.IsNullOrWhiteSpace person)

[<EntryPoint>]
let main argv =
    argv
    |> Array.filter isValid
    |> Array.iter sayHello

    printfn "Nice to meet you."

    0 // return an integer exit code
