namespace StudentsScore

type TestResult =
    | Absent
    | Excused
    | Voided
    | Scored of float

module TestResult =

    let fromString str =
        if str = "A" then
            Absent
        elif str = "E" then
            Excused
        elif str = "V" then
            Voided
        else
            let value = str |> float
            Scored value

    let tryEffectiveScore (testResult: TestResult) =
        match testResult with
        | Absent -> Some 0.0
        | Excused
        | Voided -> None
        | Scored score -> Some score
