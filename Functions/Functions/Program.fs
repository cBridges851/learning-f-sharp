open System

let do_funcs() = 
    // function that gets the sum of 2 numbers
    let get_sum (x: int, y: int) : int = x + y

    // getting the numbers from the user
    printf "enter a number: "
    let first_number = Console.ReadLine()

    printf "enter another number: "
    let second_number = Console.ReadLine()

    printfn "%s + %s = %i" first_number second_number (get_sum(int first_number, int second_number))

    let rec factorial num = 
        if num < 1 then 1
        else num * factorial (num - 1)

    printf "what number do you want to find the factorial of: "
    let factorial_number = Console.ReadLine()

    printfn "the factorial for %s is %i" factorial_number (factorial(int factorial_number))

    // Doubling the numbers in a list
    let first_list = [1; 2; 3]
    let second_list = List.map (fun number -> number * 2) first_list

    // Only outputting the even numbers that are in a list
    printfn "The new list: %A" second_list
    [1; 2; 3; 4; 5; 6; 7; 8; 9; 10]
    |> List.filter(fun num -> (num % 2) = 0)
    |> printfn "A list of even numbers %A"

    let multiply_numbers x = x * 3
    let add_numbers a = a + 4

    let multiply_then_add = multiply_numbers >> add_numbers
    let add_then_multiply = multiply_numbers << add_numbers

    printf "Enter a number: "
    let number = Console.ReadLine()

    printfn "multiply_then_add: %i" (multiply_then_add(int number))
    printfn "add_then_multiply: %i" (add_then_multiply(int number))



do_funcs()

Console.ReadKey() |> ignore
