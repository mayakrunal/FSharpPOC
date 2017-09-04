module HelloSquare
// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

let square x = x * x

[<EntryPoint>]
let main argv = 
    printfn "%d squared is: %d!" 12 (square 12)
    0 // return an integer exit code