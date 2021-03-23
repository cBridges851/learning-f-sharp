// Learn more about F# at http://fsharp.org

open System

let exception_example x y = 
    printfn "Exceptions"
    printfn "%i %i" x y

    try
        printfn "%i / %i = %A" x y (x/y)
    with 
        | :? System.DivideByZeroException as ex -> printfn "Cannot divide by 0!"
        

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    exception_example 4 0
    0 // return an integer exit code
