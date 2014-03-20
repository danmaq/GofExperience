namespace State

module Context =
    type 'a Context =
        {
            state: (Context<'a> -> Context<'a>) option
            next: (Context<'a> -> Context<'a>) option
            counter: int
            value: 'a
        }

    let execute context =
        let result =
            match context.state with
                | None -> context
                | Some state -> context |> state
        let counter = result.counter + 1
        match result.next with
            | None -> { result with counter = counter }
            | Some next -> { result with counter = counter; state = next |> Some; next = None }

    let noop context =
        { context with state = None; next = None; }

    let isEnd context =
        context.state.IsNone && context.next.IsNone

    let init<'a> = { state = None; next = None; counter = 0; value = Unchecked.defaultof<'a> }

module State =
    open Context

    type Value = { v: int }

    let initValue = { v = 0 }

    let rec dec context =
        let result = context.value.v - 1
        let next =
            match result with
                | _ when abs(result) > 10 -> add |> Some
                | _ when context.counter > 100 -> noop |> Some
                | _ -> None
        printfn "DEC: %d" result
        { context with next = next; value = { v = result } }

    and add context =
        let result = context.value.v + 1
        let next =
            match result with
                | _ when abs(result) > 10 -> dec |> Some
                | _ when context.counter > 100 -> noop |> Some
                | _ -> None
        printfn "ADD: %d" result
        { context with next = next; value = { v = result } }

    let init = { Context.init with state = add |> Some; value = initValue }

module Test =

    let start() =
        let rec loop context =
            match context |> Context.execute with
                | context when context.state.IsNone -> ()
                | context -> context |> loop
        State.init |> loop
