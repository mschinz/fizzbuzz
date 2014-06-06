#I "../../packages"
#r "Unquote.2.2.2/lib/net40/Unquote.dll"

open System
open Swensen.Unquote

let fizzBuzz (num : int) =
    ()
//    if num > 100 then
//        raise (ArgumentOutOfRangeException("num", num, "number must be less than or equal to 100"))


raises<ArgumentOutOfRangeException> <@ fizzBuzz 101 @>
