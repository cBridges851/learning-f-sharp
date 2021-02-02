open System

let do_funcs() = 
    let get_sum (x: int, y: int) : int = x + y

    printf "Enter A Number: "
    let first_number = Console.ReadLine()

    printf "Enter Another Number: "
    let second_number = Console.ReadLine()

    printfn "%s + %s = %i" first_number second_number (get_sum(int first_number, int second_number))

do_funcs()

Console.ReadKey() |> ignore
