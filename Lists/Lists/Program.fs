open System

let loops() =
    // Output elements in a list
    let list_1 = [1; 2; 3; 4; 5]

    list_1 |> List.iter (printfn "Num %i")

    printfn "%A" list_1

    // Append to a list
    let list_2 = 5::6::7::8::[]
    printfn "%A" list_2

    // This will create a 2D list
    let list_3 = list_1::list_2::[]
    printfn "%A" list_3

    // Range
    let list_4 = [1..10]
    printfn "%A" list_4
    let list_5 = ['a'..'z']
    printfn "%A" list_5

    // Generate a List
    let list_6 = List.init 5 (fun i -> i * 2)
    printfn "%A" list_6

    // Yield
    let list_7 = [ for a in 1..5 do yield (a * a)]
    printfn "%A" list_7
    let list_8 = [ for a in 1..10 do if a % 2 = 0 then yield a*a]
    printfn "%A" list_8

    // Yield! At The Disco
    let list_9 = [ for a in 1..3 do yield! [a .. a + 2]] // This loops from 1 to 3, and each time it outputs from that number to 2 after it.
    // 1, 2, 3
    // 2, 3, 4
    // 3, 4, 5
    printfn "%A" list_9

    // Find the length
    printfn "%i" list_9.Length
    // See if the list is empty
    printfn "Empty %b" list_9.IsEmpty
    // Get an index
    printfn "Index 1 of list_9: %i" (list_9.Item(1)) 
    // Head
    printfn "Head: %i" list_9.Head
    // Tail
    printfn "Tail: %A" (list_9.Tail)

    // Just get the even numbers
    let list_10 = list_9 |> List.filter (fun x -> x % 2 = 0)
    printfn "%A" list_10

    // Loop through
    let list_11 = list_10 |> List.map (fun x -> (x * 2))
    printfn "%A" list_11

    // Sort a list
    printfn "Sorted list: %A" (List.sort([1; 10; 2]))

    // Get the sum of items in a list
    printfn "Sum: %i" (List.fold (fun sum elem -> sum + elem) 0 [1;2;3])


loops()

Console.ReadKey() |> ignore
    
