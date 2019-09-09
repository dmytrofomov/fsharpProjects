module DiffieHellman

open System.Numerics

let privateKey (primeP : BigInteger) =
    System.Random().Next(2, int32 primeP - 1) |> BigInteger
let publicKey primeP primeG privateKey =
    BigInteger.ModPow(primeG, privateKey, primeP)
let secret primeP publicKey privateKey =
    BigInteger.ModPow(publicKey, privateKey, primeP)
