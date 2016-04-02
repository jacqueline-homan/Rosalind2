open System
open System.IO

let showLetter (inputFromFile:string) (letter:char) =
   inputFromFile
   |> Seq.map(fun x -> 
       match x with
       | 'T' -> 'U'
       | _ -> x)
   |> Seq.iter(printfn "%c")
  

let newDnaSequence (dna:string) =    
    showLetter 
    |> printf "%c" newDnaSequence 

[<EntryPoint>]
let main argv = 
    let path = @"/home/jacque/Downloads/rosalind_dna (4).txt"
 