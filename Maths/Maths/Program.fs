open System

let do_maths() = 
    // Operators - same as other languages
    printfn "5 + 4 = %i" (5 + 4)
    printfn "5 - 4 = %i" (5 - 4)
    printfn "5 * 4 = %i" (5 * 4)
    printfn "5 / 4 = %i" (5 / 4)
    printfn "5 %% 4 = %i" (5 % 4)
    printfn "5 ** 4 = %.1f" (5.0 ** 4.0)

    // Get the type of a variable
    let number = 6
    printfn "Type: %A" (number.GetType())

    // Cast
    printfn "Float version: %f" (float number)

    // Other mathematical functions:
    printfn "abs -1: %i" (abs -1) // Get the absolute value of a number
    printfn "ceil 4.5: %f" (ceil 4.5) // Round up a number (ceiling up)
    printfn "floor 4.5: %f" (floor 4.5) // Round down a number (floor down)
    printfn "log 2.71828: %f" (log 2.71828) // Get the log value of a number
    printfn "log10 1000: %f" (log10 1000.0) // Get the log10 value of a number
    printfn "sqrt 25: %f" (sqrt 25.0) // Get the square root of a number

do_maths()
Console.ReadKey() |> ignore