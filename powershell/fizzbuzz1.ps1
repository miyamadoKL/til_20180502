class Test1 {
    [string] fizzBuzz($a) {
        if ($a % 3 -eq 0 -And $a % 5 -eq 0) {
            return "FizzBuzz"
        } elseif ($a % 3 -eq 0) {
            return "Fizz"
        } elseif ($a % 5 -eq 0) {
            return "Buzz"
        } else {
            return [string]$a
        }
    }
}

$class = New-Object Test1
1..100 | ForEach-Object -Process {$class.fizzBuzz($_)}
