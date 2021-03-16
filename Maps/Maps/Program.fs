open System

let maps() = 
    printfn "Maps"

    let cats = 
        Map.empty.
            Add("Scamp", 50).
            Add("Bob", 100).
            Add("Mitzi", 150)

    printfn "%A" cats

    printfn "%i" cats.Count

    let catFound = cats.TryFind "Scamp"
    printfn "%A" catFound
    match catFound with
    | Some x -> printfn "Balance: %A" x
    | None -> printfn "Not Found :("

    if cats.ContainsKey "Bob" then 
        printfn "Bob was found"

    let newCats = Map.remove "Mitzi" cats
    printfn "%i" newCats.Count

maps()

Console.ReadKey() |> ignore