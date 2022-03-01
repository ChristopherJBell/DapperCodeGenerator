Dapper Code Generator

This code generator for producing SQL stored procedures, and C# code for model, service and interface files for a Blazor Server application is based on Alan Simpson's original code (with Alan's full permission), but amended both to run in Visual Studio 2022 and .Net 6.0 and to create the code for an application that is developed in Visual Studio and .Net 6.0.

One further modification has been made to handle SQL table primary keys of [uniqueidentifier] type i.e. Guid types

It does not include all the stored procedures and service options in Alan Simpson's original, neither does it include any Razor pages.

Alan Simpson's code can be found here: https://github.com/AlanSimpsonMe/Blazor-Dapper-Code-Generator
