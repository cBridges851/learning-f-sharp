open System

let sequences() =
    let one_to_thousand = {1 .. 1000}
    let even_to_fifty = {0 .. 2 .. 50}
    let fifty_to_one = {50 .. 1}

    printfn "%A" one_to_thousand

    printfn "\nHere are the even numbers up to 50:"
    Seq.toList even_to_fifty |> List.iter (printfn "Num: %i")

    let is_prime n =
        let rec check i =
            i > n/2 || (n % i <> 0 && check (i + 1))
        check 2

    let prime_seq = seq { for n in 1..50 do if is_prime n then yield n}

    printfn "\nPrime Numbers:"
    Seq.toList prime_seq |> List.iter (printfn "Num: %i")

sequences()

Console.ReadKey() |> ignore