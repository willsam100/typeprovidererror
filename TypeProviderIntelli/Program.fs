// Learn more about F# at http://fsharp.org
open System
open FSharp.Data
open System.IO

let [<Literal>] path = "food-price-index-apr19-seasonally-adjusted-csv-tables.csv"

type CSV = CsvProvider<path>

[<EntryPoint>]
let main argv =
    printfn "soruce %s " __SOURCE_DIRECTORY__

    let data = File.ReadAllText (__SOURCE_DIRECTORY__ + "/" + path)

    let food = CSV.Parse data

    food.Rows |> Seq.iter (fun x -> printfn "%A" x.)
    
    0 // return an integer exit code
