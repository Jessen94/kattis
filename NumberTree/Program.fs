// Learn more about F# at http://fsharp.org

open System

type Node =
    | Leaf of int
    | InnerNode of Node * Node

let main =
    let input = Console.ReadLine().Split(" ")
    let rec numberOfNodes =
        function
            | 1.0 -> 1.0
            | n -> ((Math.Pow(2.0,n))/(n-1.0)) + numberOfNodes (n-1.0)
    Console.WriteLine(numberOfNodes (input.[0] |> float))
        
    
    
    
