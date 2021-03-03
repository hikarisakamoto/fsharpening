open System

[<EntryPoint>]
let main argv =
    if argv.Length = 1 then
        let filePath = argv.[0]

        if System.IO.File.Exists filePath then
            printfn "Processing %s" filePath
            let rows = System.IO.File.ReadAllLines filePath
            let studentCount = (rows |> Array.length) - 1
            printfn "Student count %i" studentCount
            0
        else
            printfn "File not found: %s" filePath
            2
    else
        printfn "Please specify a file"
        1
