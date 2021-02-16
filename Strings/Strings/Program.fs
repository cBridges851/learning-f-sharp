open System

let string_stuff() = 
    let string_1 = "This is a random string"

    let string_2 = @"\\\\ These are ignored"

    let string_3 = """ Double quotes and backslashes ignored " \ """

    let string_4 = string_1 + " " + string_2

    printfn "%s" string_1
    printfn "%s" string_2
    printfn "The length of string_1(%s) is %i" string_1 (String.length string_1)
    printfn "%c" string_1.[1]
    printfn "First Word: %s" (string_1.[0..3])

    // Gets all characters from the word and puts a comma after them
    let comma_insert = String.collect(fun c -> sprintf"%c, " c) "Christa"
    printfn "Insert commas: %s" comma_insert

    printfn "Any upper: %b" (String.exists(fun c -> Char.IsUpper(c)) string_1)

    printfn "All are digits: %b" (String.forall(fun c -> Char.IsDigit(c)) "123")

    let init_string = String.init 10 (fun i -> i.ToString())
    printfn "Numbers: %s" init_string

    String.iter(fun c -> printfn "%c" c) "Hello"

 
string_stuff()
Console.ReadKey() |> ignore