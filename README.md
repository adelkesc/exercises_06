# DNP Exercises 06 - Unit Testing and TDD


## Exercise 1 - Unit testing in .NET

In this exercise you are provided a project in [./exercise_01/](./exercise_1) to start out with. Take a look at the classes in `GameModel` and implement the empty tests in `GameModel.Tests`. Try to figure out what you should test from the names of the test methods.

Follow the principles from [Unit Testing Best Pracices](https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices#best-practices).


## Exercise 2 - Fact and Theory

Rewrite as many tests in `HeroTest` as possible using [`Theory` and `InlineData`](https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-dotnet-test#adding-more-features)


## Exercise 3 - Project Setup

Create a new solution with a `classlib` project and a `xunit` project. Extract the code that are counting words and finding the longest word of a string from Exercise 1 in week 4, and create unit tests for them (recall the **Z**ero **O**ne **M**any **B**oundaries **I**nterfaces **E**xceptions **S**imple principles from SWE).


Use [Unit testing C# in .NET Core using dotnet test and xUnit](https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-dotnet-test) as a reference for setting up the solution, and the [ASP.Net Engineering Guidelines](https://github.com/aspnet/Home/wiki/Engineering-guidelines#unit-tests-and-functional-tests) for naming guidelines.


## Unit Test and Refactor

idea: provide a class that contains functionality that should be extracted into an other class. First create unit tests for the class, then extract the functionality and create tests for this as well.


## Fakes, Stubs and Mocks

idea: provide som sort of Combat class that simulates combats between two Heroes. The class uses a random number generator making it hard to test. Refactor the class so that you are able to provide a Stub for the random number generator (dependency injection), and then unit test the class.

[reference](https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices#lets-speak-the-same-language)


## Test Driven Development

Implement the system (in some folder) by un-commenting the tests one by one. The code you write to make a test succeed should only be the bare minimum required in order to make it (and the previous tests) succeed.
