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


(* 1. Create a List of random Numbers
 * 2. Add these numbers to a Queue
 * 3. <third thing here>
 *)
let main =
    let length = 10
    let q = { front = []; back = [] }
    let lis = create_job_list length 0
    //let lis = [3; 4; 6; 1; 9; 2; 5; 6;]   //used for testing
    printfn "Generated List: %A" lis
    for i in 0 .. (length - 1) do
        if lis[i] % 2 = 1 then
            q.enqueue lis[i]
            printf "Added task No. %d into the job queue" lis[i]
            printf "   Remaining List:" 
            for x in (i+1) .. (length - 1) do
                printf "%d " lis[x]
            printf "\n"
        else
            //if q.dequeue() != None then
            match q.dequeue() with
            | Some job ->
                printf "Do job %A now" job
                printf "   Remaining List:" 
                for x in (i+1) .. (length - 1) do
                    printf "%d " lis[x]
                printf "\n"
            | None ->
                printf "no more jobs to do right now"
                printf "\n"
            

   