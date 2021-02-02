open System

let bind_stuff() = 
    let mutable weight = 175
    printfn "Starting Weight: %i" weight
    weight <- 170
    printfn "New Weight: %i" weight

    let a = ref 10
    let b = a
    b := 15
    // They will both be 15 because it is changing a value a and b reference
    printfn "This is the value of a: %i" ! a
    printfn "This is the value of b: %i" ! b

    let mutable c = 10
    let mutable d = c
    d <- 15
    // c will be 10 and d will be 15 because they are created as variables on the stack, so are separate from each other
    printfn "This is the value of c: %i" c
    printfn "This is the value of d: %i" d


bind_stuff()
Console.ReadKey() |> ignore