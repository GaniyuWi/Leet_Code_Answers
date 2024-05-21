#LeetCode Solutions
This repository is meant to document all the LeetCode questions I solve starting from May 2024. I use C# to solve all questions, and I usually run the solutions on Visual Studio, but you can also use VS Code.

#Repository Structure
Leet_Code_Testing: Each class file in this folder contains a different LeetCode question and its answer. These can be called in the Program.cs file.

#How to Use
Clone the Repository:

```bash
git clone https://github.com/Leet_Code_Answers.git
```
Open the Project:

You can open the project in Visual Studio or VS Code.
Run the Solutions:

Navigate to the Program.cs file and call the respective class/method to test the solution.
Example
Here’s an example of how to call a solution from the Program.cs file:

```C#
using Leet_Code_Testing;

class Program
{
    static void Main(string[] args)
    {
        var solution = new SolutionClass();
        var result = solution.SolutionMethod();
        Console.WriteLine(result);
    }
}
```

Replace SolutionClass and SolutionMethod with the respective class and method names from the Leet_Code_Testing folder.

#Contributing
If you have any improvements or additional solutions to contribute, feel free to open a pull request.

Thank you for visiting my repository!
