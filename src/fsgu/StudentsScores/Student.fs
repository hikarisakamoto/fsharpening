namespace StudentScores

open StudentsScore

type Student =
    {
        Surname: string
        GivenName: string
        Id: string
        MeanScore: float
        MinScore: float
        MaxScore: float
    }

module Student =

    let nameParts (s: string) =
        let elements = s.Split(',')
        let surname = elements.[0].Trim()
        let givenName = elements.[1].Trim()
        surname, givenName

    let fromString (s: string) =
        let elements = s.Split('\t')
        let name = elements.[0]
        let surname, givenName = name |> nameParts
        let id = elements.[1]

        let scores =
            elements
            |> Array.skip 2
            |> Array.map TestResult.fromString
            |> Array.choose TestResult.tryEffectiveScore

        let meanScore = scores |> Array.average
        let minScore = scores |> Array.min
        let maxScore = scores |> Array.max

        {
            Surname = surname
            GivenName = givenName
            Id = id
            MeanScore = meanScore
            MinScore = minScore
            MaxScore = maxScore
        }

    let printSummary (student: Student) =
        printfn
            "%s, %s\t%s\t%0.1f\t%0.1f\t%0.1f"
            student.Surname
            student.GivenName
            student.Id
            student.MeanScore
            student.MinScore
            student.MaxScore
