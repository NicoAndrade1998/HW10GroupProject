(* HW10 - F# Task Manager with Queue
 * Nico Andrade
 * Edgar Fong
 * Saul Romero
 *)
open System

//Creates a list of random numbers with length jobCount 
let create_job_list jobCount resultLis =
    let rnd = Random()
    List.init jobCount (fun _ -> rnd.Next(1, 100))


let main =
    let lis = create_job_list 10 0
    printfn "Remaining List: %A" lis
















(* //Alternate version of jobcount generator
let create_job_list2 jobCount resultLis =
    let rec create_job_list1 jobCount resultLis =
        match resultLis with
        | [] -> [System.Random().Next()]
        | head :: tail' -> head :: create_job_list1 jobCount tail'
    create_job_list1 resultLis

let newlis = create_job_list2 10 0
printfn "%A" newlis
*)