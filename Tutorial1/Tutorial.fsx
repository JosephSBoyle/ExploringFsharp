module Array2d

let one_dim = [|for i in 0..10 -> i|]

// printfn "A string: %s. An int: %i. A float: %f. A bool: %b" "hello" 42 3.14 
one_dim |> Seq.iter (printf "%i\n")

// Array.zeroCreate N is similar to numpy.zeros(N)
let (myArray: int array) = Array.zeroCreate 100
printfn "Length of myArray: %d \n\n" myArray.Length

let endOfLine a b =
    if a = b then 
        "\n"
    else 
        ""

let printIdentityMatrix nrows mcols =
    // Print to console an n by m identity matrix
    for i in 0..nrows do
        for j in 0..mcols do
            let _isEndOfLine = endOfLine j mcols

            let _val = if i = j then
                                    1
                                else
                                    0

            printf "%i %s" _val _isEndOfLine

let a = printIdentityMatrix 3 3


let makeIdentityMatrix nrows mcols = 
    let _matrix = Array2D.zeroCreate nrows mcols
    for i in 0..nrows - 1 do
        for j in 0..mcols - 1 do
            if i = j then
                _matrix.[i, j] <- 1

    _matrix

    
printf "##### Array Based: #####\n\n\n"

let dim = 7
let zeroStartDim = dim - 1 
let b = makeIdentityMatrix dim dim

for i in 0..dim - 1 do
    for j in 0..dim - 1 do
        let _isEndOfLine = endOfLine j zeroStartDim
        printf "%i %s" b.[i, j] _isEndOfLine
