// Learn more about F# at http://fsharp.org

open System

type Cat = {
    Name: string;
    Age: int
}

let records() = 
    printfn "This is the records function"
    let newCat = {
        Name = "Bob";
        Age = 5
    }

    printfn "This is my new cat! Its name is %s and they are %i years old" newCat.Name newCat.Age

records()

Console.ReadKey() |> ignore
