module RandomApi
open System.Security.Cryptography
open System

let getrand (rng: RandomNumberGenerator) =        
    let data = Array.zeroCreate(8)
    rng.GetBytes(data)
    
    BitConverter.ToInt32(data)
        
let stream x = 
    let rng = RandomNumberGenerator.Create()
    seq {
    for _ in 1..x do  
    yield getrand rng
    }