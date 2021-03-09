open System

let tuples() =
    printfn "Tuples"

    printfn "First, let's calculate averages!"
    let avg (a, b, c, d) : float = 
        let sum = a + b + c + d
        sum / 4.0

    printfn "Average: %f" (avg (1.0, 2.0, 3.0, 4.0))

    let data = ("Christa", 19, 3.14)
    let (name, age, _) = data

    printfn "%s" name

tuples()

Console.ReadKey() |> ignore

