(* single byte integer *)
let x = 268.97f
let y = 312.58f
let z = x + y

printfn "x: %f" x
printfn "y: %f" y
printfn "z: %f" z

(* unsigned 8-bit natural number *)

let p = 2uy
let q = 4uy
let r = p + q

printfn "p: %i" p
printfn "q: %i" q
printfn "r: %i" r

(* signed 16-bit integer *)

let a = 12s
let b = 24s
let c = a + b

printfn "a: %i" a
printfn "b: %i" b
printfn "c: %i" c

(* signed 32-bit integer *)

let d = 212l
let e = 504l
let f = d + e

printfn "d: %i" d
printfn "e: %i" e
printfn "f: %i" f

(* 32-bit signed floating point number *)
(* 7 significant digits *)

let j = 212.098f
let k = 504.768f
let l = j + k

printfn "j: %f" j
printfn "k: %f" k
printfn "l: %f" l

(* 64-bit signed floating point number *)
(* 15-16 significant digits *)
let aa = 21290.098
let bb = 50446.768
let cc = aa + bb

printfn "aa: %g" aa
printfn "bb: %g" bb
printfn "cc: %g" cc

let choice = 'y'
let name = "Zara Ali"
let org = "Tutorials Point"

printfn "Choice: %c" choice
printfn "Name: %s" name
printfn "Organisation: %s" org

let trueVal = true
let falseVal = false

printfn "True Value: %b" (trueVal)
printfn "False Value: %b" (falseVal)