namespace StudentsScore

type TestResult =
    | Absent
    | Excuse
    | Scored of float

module TestResult =
    let fromString str =
        if str = "A" then
            Absent
        elif str = "E" then
            Excuse
        else
            let value = str |> float
            Scored value
