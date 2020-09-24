// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let date = Console.ReadLine().Split(" ")
    let startDate = DateTime.Parse("2009/01/01")
    let toDate = DateTime.Parse("2009/"+date.[1]+"/"+date.[0])
    let weekday =
        match (((toDate-startDate).Days)%7)+1 with
            | 0 -> printfn "Wednesday"
            | 1 -> printfn "Thursday"
            | 2 -> printfn "Friday"
            | 3 -> printfn "Saturday"
            | 4 -> printfn "Sunday"
            | 5 -> printfn "Monday"
            | 6 -> printfn "Tuesday"
            | _ -> printfn "Wednesday"
    weekday
    0 // return an integer exit code
