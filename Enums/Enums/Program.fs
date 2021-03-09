open System

type programming_language = 
| c_sharp = 0
| javascript = 1
| python = 2

let enums() =
    let users_language = programming_language.python

    match users_language with
    | programming_language.c_sharp -> printfn "C# is your programming language!" 
    | programming_language.javascript -> printfn "JavaScript is your programming language!" 
    | programming_language.python -> printfn "Python is your programming language!" 
    | _ -> printfn "The selected programming language is not C#, JavaScript, or Python"
    
enums()

Console.ReadKey() |> ignore
