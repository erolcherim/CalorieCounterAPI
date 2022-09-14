# CalorieCounterAPI

Web API using .Net Framework that keeps track of foods eaten, calculating daily calroie intake and macros. It is based around logging foods, which creates an entry, editing and deleting entries.

## Team  

[Erol Cherim](https://github.com/erolcherim)  
[Robert Roman](https://github.com/robert-roman)  
[Paul Martinas](https://github.com/mxrtinax)  

## Demo  

Todo @robert-roman

## Database ER Diagram  

![DIAG(1)](https://user-images.githubusercontent.com/48221670/190151103-65895d3a-c810-4edc-ae23-244b31944585.png)

## User Stories / Backlog 

User stories can be found at this [Trello kanban board](https://trello.com/b/aeaaUX4Y/caloriecounterapi)
The project follows the agile methodology, the work has been split in the following [milestones](https://github.com/erolcherim/CalorieCounterAPI/milestones?state=closed)

## Use Case Diagram  

![uml drawio](https://user-images.githubusercontent.com/48221670/190164516-00c5fe0b-8df9-4d4e-9359-548d722a325f.png)

## Automation Testing  

For testing purpouse we have created a suite of Postman requests that reproduce a usual use case for the API. The user registers, creates a custom food, logs an entry stating that he ate X units of the created food, edits the amount, then deletes the entry.
The unit tests test the following API controllers: UsersController, AuthController, FoodsController, UserFoodsController.
After running the test suite, the number of tests passed is displayed as an output

Todo @robert-roman

## Source control  

The project uses GIT source control, hosted on github. Proof of commits, branches and merging can be found on the [project repo page](https://github.com/erolcherim/CalorieCounterAPI)

## Bug reporting

Bugs have been reported/tracked/fixed using github's issue system. The project issues can be found [here](https://github.com/erolcherim/CalorieCounterAPI/issues?q=is%3Aissue+is%3Aclosed)

## Code Standards

The project respects the [C# Coding Standards](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)

## Build Tool

The API was built using the Visual Studio MSBuild tool.

![image](https://user-images.githubusercontent.com/48221670/189987813-4a22e683-102a-452b-b58e-74a57b028f73.png)

## Design Patterns

The project uses the following design patterns:

* [Repository Pattern](https://docs.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/infrastructure-persistence-layer-design) The project uses a Repository->Service->Controller pattern  

* [Unit of Work](https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application) All repositories are encapsulated by the UnitOfWork class (and IUnitOfWork interface) to add another abstractisation level.  

* [Factory Pattern](https://www.tutorialspoint.com/design_pattern/factory_pattern.htm) for the GenericRepository class which implements basic CRUD methods which the other repositories extend.  






