// Learn more about F# at http://fsharp.org

open System

type Rectangle = struct
    val Length: float
    val Width: float 

    new (length, width) = 
        {Length = length; Width = width}
end

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    let area(shape: Rectangle) = 
        shape.Length * shape.Width

    let new_rectangle = new Rectangle(5.0, 6.0)

    let rect_area = area new_rectangle
    printfn "%A" new_rectangle.Length
    printfn "Area: %.2f" rect_area
    0 // return an integer exit code
