# Be18

## About
This library contains a mapping of C# classes to .beXml formattet elements corresponding to those used in Be18.   
The class library is intended to be used as a runtime in-memory hierarchical model for reading an writing .bexml files in C#.
This library is written in C# and is platform/framework independent, meant for porting to other wrappers such as command line programs, scripts or visual programming languages.    

Please note that running calculations requires a Be18 installation with a valid licence.

## Features
Current 
- Write .beXml files.
- Serializers for Be18 elements to C# classes.
- Run whole-year calculations.
- Run overheating calculation.

Under construction:
- Read .beXml files.
- Utility functions/classes to swap attributes for multi-variant optimization. 

## Getting started
Create a new project:
```
using Bison.Core.BE18;

# Create a project
Project project = new Project(<output file>, <Be18 folder path>);

# Export the project to file (using the output file path in the initializer).
project.WriteToXml();

# Run the calculation
project.RunCalculation();
```

## Limitations
- The Be18 engine only runs on 32-bit. Platform target must be set to x86!

## Notes
- The Rid field which is used to denote the primary key of an element can be formatted arbitrarily (max 10 characters long). This library uses by default randomly generate uuid's that are generated runtime (for each computation).    
- This library uses in-memory storage rather than stored data. This is done to speed up calculations and to better integrate with in-memory visual programming languages such as Dynamo and Grasshopper. 
- The Be18 calculation engine has a strict interpretation of comma (,) and period (.). It's required to use period when serializing floating numbers to strings.
