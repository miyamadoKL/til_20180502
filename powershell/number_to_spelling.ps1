function Get-Spelling {

    param (
        [Parameter(Mandatory, Position = 0, ValueFromPipeline)][int[]]$val
    )

    begin {
        Write-Host "****Begin function processing.****"
    }

    process {
        @($val) | % {
            #digit1
            $d1 = [int]$_ % 10
            
            #digit2
            $d2 = [Math]::Floor([int]$_ / 10)

            #getting a word from $d1
            $t1 = switch($d1){1{"one"}2{"two"}3{"three"}4{"four"}5{"five"}6{"six"}7{"seven"}8{"eight"}9{"nine"}default{""}}

            # if $val is 0, between 10 and 19 or 100 getting a word
            $t1 = switch($_){0{"zero"}10{"ten"}11{"eleven"}12{"twelve"}13{"thirteen"}14{"fourteen"}15{"fifteen"}16{"sixteen"}17{"seventeen"}18{"eighteen"}19{"nineteen"}100{"one hundred"}default{$t1}}

            #getting a word from $d2
            $t2 = switch($d2){2{"twenty"}3{"thirty"}4{"forty"}5{"fifty"}6{"sixty"}7{"seventy"}8{"eighty"}9{"ninety"}default{""}}

            if ($t1 -ne "" -And $t2 -ne ""){
                $t1 = "-" + $t1
            }
            Write-Host $t2$t1
        }
    }

    end {
        Write-Host "****End function processing.****"
    }
}

0..100 | Get-Spelling