open System

// Let creates a function
let hello() = 
    // Outputs to the screen
    printf "Enter your name: "

    // Read a value from the user and store it in name
    let name = Console.ReadLine()

    // Output with string placeholder and new line
    printfn "Hello %s" name

// Calls the function
hello()

// Keeps the window open
Console.ReadKey() |> ignore