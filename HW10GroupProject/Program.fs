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

//Queue that keeps track of the front for dequeue and the back for queue calls
type Queue<'a> =
    { mutable front: 'a list
      mutable back: 'a list }

    member q.enqueue item =
        q.back <- item :: q.back

    member q.dequeue () =
        match q.front with
        | [] ->
            let reversed = List.rev q.back
            q.back <- []
            match reversed with
            | [] -> None
            | hd :: tl ->
                q.front <- tl
                Some hd
        | hd :: tl ->
            q.front <- tl
            Some hd

let q = { front = []; back = [] }
q.enqueue 23
q.enqueue 1
q.enqueue 7
printfn "%A" (q.dequeue())
printfn "%A" (q.dequeue())
printfn "%A" (q.dequeue())
//printfn "%d" (Option.defaultValue 0 (q.dequeue()))
//printfn "%d" (Option.defaultValue 0 (q.dequeue()))
//printfn "%d" (Option.defaultValue 0 (q.dequeue()))





let main =
    let lis = create_job_list 10 0
    printfn "Remaining List: %A" lis








//Test commit. Saul

// compare_lists is not currently being used, I have attached it for reference purposes -Nico
(* Compares two inputted lists to see if they are equal
 * If both lists are empty, evaluates true
 * If one list is longer than the other, evaluates true
 * If both lists have an element for the index, check if they are equal and if each subsequent eval is true. *)
let rec compare_lists l1 l2 =
    match l1, l2 with
    | [] , [] -> true
    | [] , _  -> false
    | _ , []  -> false
    | x::xs, y::ys -> x = y && compare_lists xs ys





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