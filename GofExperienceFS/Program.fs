[<EntryPoint>]
let main argv = 
    State.Test.start()
    printfn "press any key."
    System.Console.ReadKey() |> ignore
    0
