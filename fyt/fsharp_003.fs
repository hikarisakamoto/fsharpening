module fsharpening.fsharp_003


// Record Type
// with Structural Equality
type Details = { Name: string; Description: string }

type Item = { Details: Details }

// Discriminated Unions
// * is a tuple
type Exit =
    | PassableExit of Details * destination: Room
    | LockedExit of Details * key: Item * next: Exit
    | NoExit of Details option // Optional Type

// Recursive Type Definition (and)
and Exits =
    { North: Exit
      South: Exit
      East: Exit
      West: Exit }

and Room =
    { Details: Details
      Items: Item list
      Exits: Exits }


// Defining a room
let firstRoom =
    { Details =
          { Name = "First Room"
            Description = "You're standing in a room" }
      Items = []
      Exits =
          { North = NoExit(None)
            South = NoExit(None)
            East = NoExit(None)
            West = NoExit(None) } }
