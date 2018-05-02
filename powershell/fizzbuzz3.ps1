switch (1..100) {
    {$_ % 15 -eq 0} {'FizzBuzz'; continue}
    {$_ %  3 -eq 0} {'Fizz';     continue}
    {$_ %  5 -eq 0} {'Buzz';     continue}
    default         {$_}
}