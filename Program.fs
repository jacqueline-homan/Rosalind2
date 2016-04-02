open System
open System.IO

// this replaces showLetter
let convertToRNA (inputFromFile:string) =
   inputFromFile
   |> Seq.map(fun x -> 
       match x with
       | 'T' -> 'U'
       | _ -> x)
   |> Seq.map string
   |> String.Concat
     
 
   
   

[<EntryPoint>]
let main argv = 
    let path = @"/home/jacque/Downloads/rosalind_rna.txt"

    let inputFromFile = File.ReadAllText(path) 
    inputFromFile 
    |> convertToRNA
    |> printfn "%s"
    //|> Seq.iter(printfn "%c") 
    0 // return an integer exit code

