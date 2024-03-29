Name: Pere Joan
Surname: Mateu Salvà

# Back-End REST API fizzbuzz with WCF
Used as a practice exercise

## Recommended steps for execution

The path for opening the solution of the present project is  "Fizzbuzz.DistributedServices\Fizzbuzz.DistributedServices.sln". The project has been coded using Visual Studio Community 2022.
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
- Autofac.Wcf.Integration
- log4net
- System.IO.Abstractions

## Roadmap

- [x] Distributed web services Contracts
- [x] Distributed web services Unit Tests
- [x] Distributed web services implementation
- [ ] Distributed web services integration Tests
- [x] Application Service layer contracts
- [x] Application Service layer Unit Tests
- [x] Domain Entities
- [x] Infrastructure layer
- [x] Infrastructure unit tests
- [ ] Infrastructure integration tests
- [ ] CrossCutting Custom exceptions
- [ ] CrossCutting Aspects
- [ ] CrossCutting TestHelper
- [x] CrossCutting Logging
- [x] CrossCutting Configuration
- [x] API Rest configuration
- [ ] Global exception testing
- [ ] Logging

## Solid Principles

In the development process of this project Solid Principles are put into practice. Here we show some examples of its use:

- Single Responsability
Class and methods only have one separate concept as responsability.

An example of it is the method in application services calles ParseNumber, which converts the given string as a parameter into an integer (Int32).

- Open/Closed
Example of class that is open for extension, but closed for modification is the FizzbuzzAppService, which implements de IStudentApplicationService as a form of extension of it. At the same time the interface works as a closed entity that is still expansible.

- Liskov Substitution
Objects may be replaced by a sub-object that are extensions of it without breaking the program. In this project we can find that in the implementation of the custom exceptions, since they extend web extensions and the default extension classes in C#.

- Interface Segregation
This principle states that large interfaces should be split into smaller more specific ones allowing the clients to know only of the methods they need. An example of this principle ocurring in this project is given in the Infrastructure domain, in which we can find 2 separate interfaces: IFizzbuzzRepository and IFileManager.

## DDD architechture

- DistributedWebServices
- ApplicationServices
- DomainEntities
- Infrastructure
- CrossCuttingLayer

It is important to remark that the implementation of DDD in this project is not pure due to size reasons. It has been estimated overengineering to create DTOs and Data Models for the application and infrastructure layer respectively. Therefore, Domain Entities has been treated like it was a transversal/cross cutting member of the project.

# General comments on the current state of the project

The project lacks most of its integration tests due to problems configuring autofac Libary for its proper use. Also, unit testing is superficial due to time. If given continuity this project needs finishing and polishing in both integration and unit testin, specially integration. It also needs custom exceptions implementations, aspect oriented programming and some wrappers for the static methods of utils still to be developed.

Finally I must say that even following a home made template by me, I started this project from scratch.

Thanks for your time!


