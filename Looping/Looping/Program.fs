open System

let while_loops() = 
    // Number guessing game
    let magic_num = "7"
    let mutable guess = ""

    while not (magic_num.Equals(guess)) do 
        printf "Guess the number I'm thinking of: "
        guess <- Console.ReadLine()

    printfn "Congratulations! You have guessed the number!"

let for_loops()=
    // Going up
    for i = 0 to 10 do
        printfn "%i" i

    printfn "" 

    // Going down
    for i = 10 downto 0 do
        printfn "%i" i

    printfn ""

    // In a range
    for i in [1..10] do
        printfn "%i" i

    // Pipeline
    [1..10] |> List.iter(printfn "Num: %i")

    // Get sum
    let sum = List.reduce (+) [1..10]
    printfn "Sum: %i" sum

for_loops()
while_loops()

Console.ReadKey() |> ignore