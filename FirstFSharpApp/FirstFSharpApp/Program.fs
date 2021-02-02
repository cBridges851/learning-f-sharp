open System

// Let creates a function
let hello() = 
    // Outputs to the screen
    printf "Enter your name: "

    // Read a value from the user and store it in name
    let name = Console.ReadLine()

    // Output with string placeholder and new line
    printfn "Hello %s" name

let float_format() = 
    let pi = 3.141592652589793238462643383
    let big_pi = 3.141592652589793238462643383M
    printfn "Pi %.4f" pi
    printfn "Pi %M" big_pi
    printfn "%-5s %5s" "a" "b"
    printfn "%*s" 10 "Hi"

// Calls the function
hello()
float_format()

// Keeps the window open
Console.ReadKey() |> ignore