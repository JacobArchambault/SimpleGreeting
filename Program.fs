let getGreeting name = 
    sprintf "Hello %s, isn't F# great?" name

[<EntryPoint>]
let main _ =
    let names = ["Don"; "Julia"; "Xi"]

    names
    |> List.map getGreeting
    |> List.iter (fun greeting -> printfn "%s" greeting)

    printfn "Hello World from F#!"
    0 // return an integer exit code
