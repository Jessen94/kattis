// Learn more about F# at http://fsharp.org

open System

let PaG =
    let input = Console.ReadLine().Split(" ")
    let Gold = (6,3)
    let Silver = (3,2)
    let Copper = (0,1)
    
    let Province = (8,6)
    let Duchy = (5,3)
    let Estate = (2,1)
    
    let totalAmount = ((input.[0] |> int)*(snd Gold))+((input.[1] |> int)*(snd Silver))+((input.[2] |> int)*(snd Copper))
    
    let selectVicCard  =
        function
            | a when a >= fst Province -> ("Province") 
            | a when a >= fst Duchy -> ("Duchy")
            | a when a >= fst Estate -> ("Estate")
            | _ -> ("")
    let selectTreCard  =
        function
            | a when a >= fst Gold -> "Gold" 
            | a when a >= fst Silver -> "Silver"
            | a when a >= fst Copper -> "Copper"
            | _ -> ""
    let buildString = 
        let VicCard = selectVicCard totalAmount
        let TreCard = selectTreCard totalAmount
        if (not(VicCard = "")) then printfn "%s or %s" VicCard TreCard
        else printfn "%s" TreCard
    buildString