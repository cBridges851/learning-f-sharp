// Learn more about F# at http://fsharp.org

open System

let add<'T> x y= 
    printfn "We are going to add 2 things together! We have no idea whether they will be integers or floats"
    printfn "%A + %A = %A" x y (x+y)

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    add<float> 3.14 6.28
    
    // add<int> 1 2
    0 // return an integer exit code

