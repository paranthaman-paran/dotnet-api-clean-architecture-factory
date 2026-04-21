# dotnet-api-clean-architecture-factory
This project demonstrates a scalable and maintainable backend system built using ASP.NET Core Web API and Clean Architecture principles. The solution is structured into multiple layers such as Domain, Application, Infrastructure, and API to enforce separation of concerns and improve testability.

The Repository Pattern is used to abstract data access logic, allowing the application to interact with the database through interfaces rather than direct implementation. This improves flexibility and makes the system easier to maintain and unit test.

The Factory Pattern is implemented to handle object creation logic, promoting reusability and reducing tight coupling between components. Dependency Injection is used extensively to manage service lifetimes and dependencies across the application.

The project also follows REST API best practices, uses asynchronous programming (async/await) for better performance, and can be easily extended with features such as authentication, logging, and caching.

Overall, this project highlights strong backend development practices aligned with enterprise-level application design.
