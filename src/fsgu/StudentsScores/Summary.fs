namespace StudentsScores

open System.IO

module Summary =
    let summarize filePath =
        let rows = File.ReadAllLines filePath
        let studentCount = (rows |> Array.length) - 1

        printfn "Student count %i" studentCount

        rows
        |> Array.skip 1
        |> Array.map Student.fromString
        |> Array.sortBy (fun student -> student.Name)
        |> Array.iter Student.printSummary
