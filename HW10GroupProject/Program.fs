(* HW10 - F# Task Manager with Queue
 * Nico Andrade
 * Edgar Fong
 * Saul Romero
 *)
open System

let create_job_list jobCount resultLis =
    let rnd = Random()
    List.init jobCount (fun _ -> rnd.Next(1, 100))