// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let string = Console.ReadLine().ToLower().ToCharArray() |> List.ofArray
    let rec newString acc =
        function
            | a::ac when a = 'a' -> newString (acc+"@") ac
            | a::ac when a = 'b' -> newString (acc+"8") ac
            | a::ac when a = 'c' -> newString (acc+"(") ac
            | a::ac when a = 'd' -> newString (acc+"|)") ac
            | a::ac when a = 'e' -> newString (acc+"3") ac
            | a::ac when a = 'f' -> newString (acc+"#") ac
            | a::ac when a = 'g' -> newString (acc+"6") ac
            | a::ac when a = 'h' -> newString (acc+"[-]") ac
            | a::ac when a = 'i' -> newString (acc+"|") ac
            | a::ac when a = 'j' -> newString (acc+"_|") ac
            | a::ac when a = 'k' -> newString (acc+"|<") ac
            | a::ac when a = 'l' -> newString (acc+"1") ac
            | a::ac when a = 'm' -> newString (acc+"[]\/[]") ac
            | a::ac when a = 'n' -> newString (acc+"[]\[]") ac
            | a::ac when a = 'o' -> newString (acc+"0") ac
            | a::ac when a = 'p' -> newString (acc+"|D") ac
            | a::ac when a = 'q' -> newString (acc+"(,)") ac
            | a::ac when a = 'r' -> newString (acc+"|Z") ac
            | a::ac when a = 's' -> newString (acc+"$") ac
            | a::ac when a = 't' -> newString (acc+"']['") ac
            | a::ac when a = 'u' -> newString (acc+"|_|") ac
            | a::ac when a = 'v' -> newString (acc+"\/") ac
            | a::ac when a = 'w' -> newString (acc+"\/\/") ac
            | a::ac when a = 'x' -> newString (acc+"}{") ac
            | a::ac when a = 'y' -> newString (acc+"`/") ac
            | a::ac when a = 'z' -> newString (acc+"2") ac
            | [] -> acc
            | a::ac -> newString (acc+a.ToString()) ac
    printfn "%s" (newString "" string)
    0 // return an integer exit code
