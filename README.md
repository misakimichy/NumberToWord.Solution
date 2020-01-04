# Number to Word

#### _C#, .NET: Number to Word, 01/04/2020_

## Description
Create a console app that translates numbers in numeric form into written words. For example, it would translate 384 into "three hundred eighty four".

## Application should have:
- The input is available up to 1 trillion.


## Spec
| User input | User input | Expected output |
| :------------- | :------------- | :------------- |
| User input is not a number | hello | Invalid input! |
| User input is one figure | 5 | Five |
| User input is two figures and less than 20 | 14 | Fourteen |
| User input is two figures and bigger than 20 | 78 | Seventy Eight |
| User input is three figures | 123 | One Hundred Twenty Three |
| User input is four figures | 9999 | Nine Thousand Nine Hundred Ninety Nine |



## Installation:
1. Clone this repo:
```
$ git clone https://github.com/misakimichy/NumberToWord.Solution.git
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
* Currently working on the number more than 10,000.

## Support and contact details
 misaki.koonce@gmail.com

## Technologies Used
_Git, GitHub, C# and MS Test


## License
Copyright © 2020 under the MIT License