﻿(*
C# kodunu F# a çevir

Integer
Yes - 2, 18, 2854, -9
No - 1.2, -5.7
*)

open System

[<EntryPoint>]
let main argv =
    let mutable age = 0
    age <- 43
    let ageInTenYears = age + 10

    (*
    Two billion +/-
    signed Int32
    unsigned - 4 billion
    bit - 0 or 1
    byte - 8 bits - 00000100
    1, 11, 111
    *)
    Console.WriteLine(age)
    Console.WriteLine(ageInTenYears)

    // Don't divide ints - Console.WriteLine(age / 2)
    0 // return an integer exit code


