# Bison.Core
 
## About
Bison.Core is a library of in-memory ORMs for building simulation tools, specifically for the Danish market, written i C#. The libraries consist of relational mapping of open-spec elements to C# classes, which can be freely ported to other platforms (such as command line tools, scripts and visual programming languages such as Revit Dynamo and Rhino Grasshopper).

## Apps
We are working on expanding our library of building performance simulation tools. The following libraries are ready to use:
- Be18 (Building energy use)

The following tools are currently under construction:
- BSim (Zonal thermal simulation of buildings)

You can request libraries for other building simulation tools by creating an issue.

## Porting
Use this repo by linking the compiled .dll's as an api for your external applications. This repo utilizes predefined default values for all classes, which you can override in your own wrappers, or create your own super classes. 

## Contribute
We are open to any contributions. 
