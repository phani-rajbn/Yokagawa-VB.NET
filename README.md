# Yokagawa-VB.NET
Training program in VB.NET

## Day 1
- Intro to .NET.
- UnderBenefits of the .NET Framework.
- The .NET Framework Components.
- Languages in the .NET Framework.
- .Net Framework Version Comparison.
- Component of .NET Framework.
- CLR.
- CTS.
- MSIL.
- AssemblyStructure of an AssemblyCross – Language SupportPrivate and Shared Assembly Managed Environment.
## Day 2
- Classes as Structured Data
- Objects
- Methods
- Constructors and Initialization
- Overloaded Constructor
- Destructor
- Static Fields and Methods
- Constant and Readonly
- Value Types
- Boxing and Unboxing
- Reference Types 
- Methods, Properties and Operators
- Methods
- Parameter Passing
- Method Overloading
- Variable-Length Parameter Lists
- Properties
- Method overriding vs. Method Shawdowing
- Abstract Classes
- Interfaces
## Day 3
- Collections in VB.NET
- List(Of T)
- HashSet(Of T)
- Dictionary(Of K, V)
- Queue(Of T)
- Stack(Of T)
- IEnumerable(Of T) vs. IEnumerator(Of T)
- IComparable(Of T) vs. IComparator(Of T)
## Day 4
- Exception Handling
- Custom Exceptions
- Delegates and Events
- Multi Threading Apps
- Using Thread Synchronization
## Day 5
- File IO.
- File Class
- StreamReader Class
- FileStream Class
- Binary Serialization
- XML Serialization
## Day 6
- ADO.NET
- Connected Model
- Layered Architecture with Connected Model
## Day 7
- Win Forms
- Common Controls of Win Forms.
## Day 8 and 9
- Disconnected Architecture
- DataGridView
- DataView
- Brief on Reflection to implement DataFactory
## Day 10
- Reflection
- GarbageCollection
- Master-Detail Example
## Day 11
- Creating and Consuming COM Components
- Interoperability.
- End to End Application.
# Day 12
- Windows services
- WCF services
## DB Code
CREATE TABLE [dbo].[MovieTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MovieTitle] [varchar](100) NOT NULL,
	[MovieDirector] [varchar](100) NOT NULL,
	[MovieLanguage] [varchar](20) NOT NULL,
	[ReleaseYear] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
