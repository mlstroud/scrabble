# _Scrabble Word Scorer_

#### _Epicodus Project May 14, 2020_

#### By _**Matt Stroud**_

## Description

_An Epicodus individual project using C# and MSTest. This project prioritizes unit testing to validate code and logic before writing code._
_The application will take a word as input from the user, and return the total score of the word based on Scrabble letter scoring._

## Specs
| Behavior                                                 | Input             | Output           |
|:---------------------------------------------------------|:------------------|-----------------:|
| The program will accept a word from user.                | "Hello"           | N/A              |
| The program will convert the word to lower case.         | "Hello"           | "hello"          |
| The program will get the score of the first letter.      | "Hello"           | 4                |
| The program will add the score to the total score.       | "Hello"           | 0 + 4 = 4        |
| The program will do nothing if not a valid letter.       | "@#!"             | 0                |
| The program will repeat for every letter in the word.    | "Hello"           | 4+1+1+1+1= 8     |

## Setup/Installation Requirements

1. Clone this repository from GitHub.
2. Open the downloaded directory in a text editor of your choice.
  (VSCode, Atom, etc.)
3. To install the REPL dotnet script, run dotnet tool install -g dotnet-script in your terminal.
4. Run the program with the command dotnet build.

## Known Bugs

There are no known bugs at the time of this update.
 
## Support and contact details

_Have a bug or an issue with this application? [Open a new issue](https://github.com/mlstroud/scrabble/issues) here on GitHub._

## Technologies Used

* C#
* .NET Core
* MSTest
* Git

### License

This software is licensed under the MIT license.

Copyright © 2020 **_Matt Stroud_**