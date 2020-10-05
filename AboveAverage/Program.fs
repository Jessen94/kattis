// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let cases = Console.ReadLine() |> int
    let rec calculateAvg acc =
        function
            | 0 -> acc
            | a when a > 0 ->  
                let input = Console.ReadLine().Split(" ")
                let students = input.[0] |> int
                let grades = List.ofArray input |> List.tail
                let gradeAvg = List.map(fun e -> (e|>double)) grades |> List.average 
                let studentsAboveAvg = List.filter(fun e -> (e|>int) > (gradeAvg|>int)) grades |> List.length 
                let avg = Math.Round(((studentsAboveAvg|>double)/(students|>double))*100.0,3)
                calculateAvg (avg::acc) (a-1)
            | _ -> acc
    let rec print =
       function
           | [] -> ()
           | z::ac -> printfn "%.3f%s" z "%"
                      print ac
    print (List.rev (calculateAvg [] cases))
    0 // return an integer exit code
