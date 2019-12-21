# Number to Word

#### _C#, .NET: Number to Word, 12/20/2019_

## Description
Create a console app that translates numbers in numeric form into written words. For example, it would translate 384 into "three hundred eighty four".

## Application should have:
- The input is available up to 1 trillion.


## Spec
| User input | User input | Expected output |
| :------------- | :------------- | :------------- |
| User input is not a number | hello | Invalid input! |
| User input is one figure | 5 | five |
| User input is two figures and less than 20 | 14 | fourteen |
| User input is two figures and bigger than 20 | 78 | seventy eight |
| User input is three figures | 123 | one hundred twenty three |



## Installation:
1. Clone this repo:
```
$ git clone https://github.com/misakimichy/WordCounter.Solution.git
```

2. Use the following codes:

a) Command to build the WordCounter. Run this in WordCounter directory:
```
$ dotnet build && $ dotnet run
```


b) Command for unit testing. Run this in WordCounter.Tests directory:
```
$ dotnet restore && dotnet test
```


## Known Bugs
* No known bugs at this time.

## Support and contact details
 misaki.koonce@gmail.com

## Technologies Used
_Git, GitHub, C# and MS Test


## License
Copyright © 2019 under the MIT License