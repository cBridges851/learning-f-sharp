open System

let options() =
    printfn "Options"

    let divide x y = 
        match y with
        | 0 -> None
        | _ -> Some(x/y)

    printf "Input the first number: "
    let first_number = Int32.Parse(Console.ReadLine());


    printf "Input the second number: "
    let second_number = Int32.Parse(Console.ReadLine());

    let result = divide first_number second_number

    if result.IsSome then
        printfn "There was an answer: %A" result
    elif result.IsNone then 
        printfn "You cannot divide by 0 4head"
    else
        printfn "I don't think this can actually be reached!"

options()

Console.ReadKey() |> ignore