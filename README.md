# Mech-Chooser-v2

The purspose of this project is to fix some of the issues related to the first version (which you'll find in my GitHub as well, under Mech Chooser) and to further explore creating user interfaces with C# and the Windows Forms library. The primary differences between this version and the previous are, obviously, the use of C# in place of Java, but also altering the store of user owned mechs to be stored in an XML file and to allow the user to easily add new mechs and variants.

The application itself is simple, containing only a few namespaces and handful of classes. The following is a breakdown of the namespaces

* Constants: contains a handful of Enums and a StaticValues class, all containing stable information not expected to change
* Execution: Program class containing Main method as well as an ExecutionController that handles switching between the application's two available Windows Forms
* ModelMaker:contains a class that takes in basic information and transforms it into an instance of the MechModel Interface
* Models: the aforementioned MechModel interface and its four implementing classes
* UI: contains the two Windows Forms for the application
* XMLControl: contains classes that handle read and write operations for the OwnedMechs.xml file. These classes utilize XDocument and LINQ to accomplish their tasks

