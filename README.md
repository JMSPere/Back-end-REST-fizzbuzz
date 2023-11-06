Name: Pere Joan
Surname: Mateu Salvà

# Back-End-Exam-1
.NET Vueling University  06/11/2023 exam

In this project I show my solution to the problem proposed by this first exam of the .NET Vueling University in november 2023 edition.

## Recommended steps for execution

I strongly recommend to rebuild the solution before its execution and testing. This is due to the fact that some packages - later specified - may need to be installed. I also recommend to test the functionality of the application with postman or any other REST test suite.

## Stack

- .NET Framework 4.8
- WCF (Windows Communication Foundation)
- MSTestV2

## Testing

This project has unit and integration testing. The unit testing purpose is to evaluate the proper behavior of each layer and class regardless of its dependencies. The main technique used in this part of the testing has been mocking, which consists on creating a "fake" class of a dependency the class needs to work properly. Its purpose is to enable the testing of a layer or class without the need for its dependencies (which are being mocked).

Integration testing ensures that the application implementations as a whole work as they are supposed when tested with diffrerent data.

## Libraries

- Autofac
- log4net
- MethodBoundaryAspect
- System.IO.Abstractions

## Roadmap

- [x] Distributed web services Contracts
- [x] Distributed web services Unit Tests
- [x] Distributed web services implementation
- [x] Distributed web services integration Tests
- [x] Application Service layer contracts
- [x] Application Service layer Unit Tests
- [x] Domain Entities
- [ ] Infrastructure layer
- [ ] Infrastructure unit tests
- [ ] Infrastructure integration tests
- [ ] CrossCutting Custom exceptions
- [ ] CrossCutting Utils
- [ ] CrossCutting Aspects
- [ ] CrossCutting TestHelper
- [ ] CrossCutting Logging
- [ ] CrossCutting Configuration
- [ ] API Rest configuration

## Solid Principles

In the development process of this project Solid Principles are put into practice. Here we show some examples of its use:

- Single Responsability
Class and methods only have one separate concept as responsability.

        public class Student
        {
        [DataMember]
        public long Id { get; set; }

        [DataMember]
        public string Guid { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Surname { get; set; }

        [DataMember]
        public DateTime Birthdate { get; set; }

        [DataMember]
        public string FullName;

        [DataMember]
        public int Age;
        }

- Open/Closed
Example of class that is open for extension, but closed for modification is the StudentApplicationService, which implements de IStudentApplicationService as a form of extension of it. At the same time the interface works as a closed entity that is still expansible.

- Liskov Substitution
Objects may be replaced by a sub-object that are extensions of it without breaking the program. In this project we can find that in the implementation of the custom exceptions, since they extend web extensions and the default extension classes in C#.

- Interface Segregation
This principle states that large interfaces should be split into smaller more specific ones allowing the clients to know only of the methods they need. An example of this principle ocurring in this project is given in the Infrastructure domain, in which we can find 2 separate interfaces: IStudentRepository and IFileManager.

## DDD architechture

/
|-- src
|   |-- DistributedWebServices
|   |-- ApplicationServices
|   |-- DomainEntities
|   |-- Infrastructure
|   |-- CrossCuttingLayer

It is important to remark that the implementation of DDD in this project is not pure due to size reasons. It has been estimated overengineering to create DTOs and Data Models for the application and infrastructure layer respectively. Therefore, Domain Entities has been treated like it was a transversal/cross cutting member of the project.

