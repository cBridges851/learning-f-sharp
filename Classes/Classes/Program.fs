// Learn more about F# at http://fsharp.org

open System

type Animal = class
    val Name: string
    val Age: int
    val FavouriteFood: string

    new (name, age, favouriteFood) = 
        {
            Name = name;
            Age = age;
            FavouriteFood = favouriteFood;
        }

        member x.Run = 
            printfn "%s Runs" x.Name
end

type Cat(name, age, favouriteFood) = 
    inherit Animal(name, age, favouriteFood)

    member x.Meow = 
        printfn "\"Meow\" says %s" x.Name

[<EntryPoint>]
let main argv =
    let deena = new Animal("Deena", 7, "peaches")
    printfn "Profile of Deena the Duck:"
    printfn "%s" deena.Name
    printfn "%i" deena.Age
    printfn "%s" deena.FavouriteFood
    deena.Run

    printfn ""

    let bob = new Cat("Bob", 5, "Chocolate pie")
    printfn "Profile of Bob the Cat:"
    printfn "%s" bob.Name
    printfn "%i" bob.Age
    printfn "%s" bob.FavouriteFood
    bob.Run
    bob.Meow
    0 // return an integer exit code
