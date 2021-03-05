namespace StudentsScores

type Student =
    {
        Id: string
        Name: string
        MeanScore: float
        MinScore: float
        MaxScore: float
    }

module Student =
    let fromString (s: string) =
        let elements = s.Split('\t')
        let name = elements.[0]
        let id = elements.[1]

        let scores =
            elements
            |> Array.skip 2
            |> Array.choose Float.tryFromString

        let meanScore = scores |> Array.average
        let minScore = scores |> Array.min
        let maxScore = scores |> Array.max

        {
            Id = id
            Name = name
            MeanScore = meanScore
            MinScore = minScore
            MaxScore = maxScore
        }

    let printSummary (student: Student) =
        printfn "%s	%s	%0.1f	%0.1f	%0.1f" student.Name student.Id student.MeanScore student.MinScore student.MaxScore
