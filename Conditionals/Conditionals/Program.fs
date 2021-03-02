open System

let conditionals() = 
    // Conditional statement blocks
    let age = 8

    if age < 5 then
        printfn "Younger than 5"
    elif age = 5 then
        printfn "Exactly 5"
    else 
        printfn "Older than 5"

    if (age % 2 = 0) then
        printfn "The number is even"

    // Use of or operator
    let name = "Christa"

    if name = "Christa" || name = "David Tennant" then
        printfn "%s is awesome" name

    // match
    let output: string = 
        match age with
        |    age when age < 5 -> "Younger than 5"
        |    5 -> "Exactly 5"
        |    age when (age > 5 && age < 10) -> "Between 5 and 10 (exclusive)"
        |    _ -> "Greater than 10"
    
    printfn "%s" output
    
conditionals()

Console.ReadKey |> ignore
