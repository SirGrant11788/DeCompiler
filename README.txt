Grant Verheul
12001640
Prog3B7312 - IIE VC

//Task 1
//Dynamically loads a .NET assembly
//Displays an alphabetical list of all the external references that the assembly specifies.
//Displays a list of all the classes in the assembly, ordered by number of methods in the class
//Displays a list of all the classes in the assembly, ordered by average number of lines per method - changed to byte size
//Visually distinguishes all the classes that have an average number of lines per method higher than a user configurable number as non-compliant to company standards
//Task 2
//Display all the interfaces in the assembly in alphabetical order.
//Visually distinguishes any interfaces with no implementations as non-compliant to company standards.
//Visually distinguishes any interfaces with names that do not match a user configurable regular expression as non-compliant to company standards.
//Display all the classes that implement a user selected interface.
//Task 3
//Uses a tree data structure to represent the inheritance hierarchy of each of the classes in the assembly.
//Display the inheritance hierarchy of any selected class to the user.
//Uses recursion to export a text file that shows the classes and hierarchy of each one.
//Uses a graph data structure to represent the association and composition relationships between classes.
//Displays the relationships of any selected class to the user.
//Visually distinguishes any class with more than a user configurable number of relationships as non-complaint with company standards.

Data Structures:
datagridviews for display and sort of data
List assembly to retrieve references
Type assembly to retrieve class and method information
Method body to retrieve byte size
List string array to store class and method names
foreach loops to extract the objects information
nested if else to separate information from loops
for loops to extract a specific amount of information from an object
try catch blocks to catch errors
console output to display testing information
message show boxes to display user errors
match function to analyse the regrex input.
regex to handle search functionality and user defined expression.
tree object to handle class and inheritance nodes and relations. 
direct graph data structure to handle class hierarchy.
tree data structure to handle class hierarchy. 
tree view to display tree data structure.
rich text box to display graph data structure.
list nodes, list edges for direct graph data structure.
stream reader to read from a text file.
stream writer to write to a text file.

Open folder called Prog3BTask1 and open Prog3bTask1.sln to Open the program in Visual Studio and press the F6 key (build and run).

Press the Select Assembly File > Navigate to the dll file (dll test folder > TTestAssembly.exe)that you would like to run and press Open  
in the text box (middle right) replace the text with how many lines (byte) you don't want displayed and press the Search button.
bottom middle text box, replace the text with an interface name or regular expression for highlighting interfaces that do not match text field.
The far top right text box, enter the class you wish to highlight the hierarchy of that class. Press the search button to highlight the user defined class.
The middle right text box, enter the number of relationships of a class that should be less than for company standards.

Used various test assembly files - see test folder 
dll AssemblyTesting was used to demonstrate the capabilities of the program.
Tree Data Structure:
Class_2
ClassMain
ClassOut
---ClassIN
ClassOut2
---ClassIn2
NewClass
Program
Resources

Graph Data Structure:
Nodes:
ClassIN
ClassIn2
ClassMain
ClassOut
ClassOut2
Form1
Form2
Form3
Form4
NewClass

Edges:
ClassOut -> ClassIN
ClassOut2 -> ClassIn2

External Refrence: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
External Refrence: System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
External Refrence: System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
External Refrence: System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
File Name: TestAssembly, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
Has interface: Class: Class_2 Interface Name: InterfaceBBB is compliant
Has interface: Class: Class_2 Interface Name: interface1 is compliant
Class Name: Class_2 Method Name: get_Color Method Size: 7
Class Name: Class_2 Method Name: set_Color Method Size: 8
Class Name: Class_2 Method Name: Close Method Size: 30
Class Name: Class_2 Method Name: Open Method Size: 30
Class Name: Class_2 Method Name: Write Method Size: 29
File Name: TestAssembly, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
Class Name: ClassIN Method Name: display Method Size: 16
File Name: TestAssembly, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
Class Name: ClassIn2 Method Name: display Method Size: 16
File Name: TestAssembly, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
File Name: TestAssembly, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
Class Name: ClassOut Method Name: Cin Method Size: 7
File Name: TestAssembly, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
Class Name: ClassOut2 Method Name: Cin2 Method Size: 7
File Name: TestAssembly, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
Has interface: Class: Form1 Interface Name: IComponent is compliant
Has interface: Class: Form1 Interface Name: IDisposable is compliant
Has no interface: Class: Form1 Interface Name: IOleControl is non-compliant
Has no interface: Class: Form1 Interface Name: IOleObject is non-compliant
Has no interface: Class: Form1 Interface Name: IOleInPlaceObject is non-compliant
Has no interface: Class: Form1 Interface Name: IOleInPlaceActiveObject is non-compliant
Has no interface: Class: Form1 Interface Name: IOleWindow is non-compliant
Has no interface: Class: Form1 Interface Name: IViewObject is non-compliant
Has no interface: Class: Form1 Interface Name: IViewObject2 is non-compliant
Has no interface: Class: Form1 Interface Name: IPersist is non-compliant
Has no interface: Class: Form1 Interface Name: IPersistStreamInit is non-compliant
Has no interface: Class: Form1 Interface Name: IPersistPropertyBag is non-compliant
Has no interface: Class: Form1 Interface Name: IPersistStorage is non-compliant
Has no interface: Class: Form1 Interface Name: IQuickActivate is non-compliant
Has interface: Class: Form1 Interface Name: ISupportOleDropSource is compliant
Has interface: Class: Form1 Interface Name: IDropTarget is compliant
Has interface: Class: Form1 Interface Name: ISynchronizeInvoke is compliant
Has interface: Class: Form1 Interface Name: IWin32Window is compliant
Has interface: Class: Form1 Interface Name: IArrangedElement is compliant
Has interface: Class: Form1 Interface Name: IBindableComponent is compliant
Has interface: Class: Form1 Interface Name: IKeyboardToolTip is compliant
Has interface: Class: Form1 Interface Name: IContainerControl is compliant
Class Name: Form1 Method Name: btnCnt10_Click Method Size: 41
Class Name: Form1 Method Name: btnCnt20_Click Method Size: 15
Class Name: Form1 Method Name: btnCnt30_Click Method Size: 15
Class Name: Form1 Method Name: Dispose Method Size: 43
Class Name: Form1 Method Name: InitializeComponent Method Size: 582
File Name: TestAssembly, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
Has interface: Class: Form2 Interface Name: IComponent is compliant
Has interface: Class: Form2 Interface Name: IDisposable is compliant
Has no interface: Class: Form2 Interface Name: IOleControl is non-compliant
Has no interface: Class: Form2 Interface Name: IOleObject is non-compliant
Has no interface: Class: Form2 Interface Name: IOleInPlaceObject is non-compliant
Has no interface: Class: Form2 Interface Name: IOleInPlaceActiveObject is non-compliant
Has no interface: Class: Form2 Interface Name: IOleWindow is non-compliant
Has no interface: Class: Form2 Interface Name: IViewObject is non-compliant
Has no interface: Class: Form2 Interface Name: IViewObject2 is non-compliant
Has no interface: Class: Form2 Interface Name: IPersist is non-compliant
Has no interface: Class: Form2 Interface Name: IPersistStreamInit is non-compliant
Has no interface: Class: Form2 Interface Name: IPersistPropertyBag is non-compliant
Has no interface: Class: Form2 Interface Name: IPersistStorage is non-compliant
Has no interface: Class: Form2 Interface Name: IQuickActivate is non-compliant
Has interface: Class: Form2 Interface Name: ISupportOleDropSource is compliant
Has interface: Class: Form2 Interface Name: IDropTarget is compliant
Has interface: Class: Form2 Interface Name: ISynchronizeInvoke is compliant
Has interface: Class: Form2 Interface Name: IWin32Window is compliant
Has interface: Class: Form2 Interface Name: IArrangedElement is compliant
Has interface: Class: Form2 Interface Name: IBindableComponent is compliant
Has interface: Class: Form2 Interface Name: IKeyboardToolTip is compliant
Has interface: Class: Form2 Interface Name: IContainerControl is compliant
Class Name: Form2 Method Name: method1 Method Size: 19
Class Name: Form2 Method Name: method2 Method Size: 19
Class Name: Form2 Method Name: Dispose Method Size: 43
Class Name: Form2 Method Name: InitializeComponent Method Size: 434
File Name: TestAssembly, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
Has interface: Class: Form3 Interface Name: IComponent is compliant
Has interface: Class: Form3 Interface Name: IDisposable is compliant
Has no interface: Class: Form3 Interface Name: IOleControl is non-compliant
Has no interface: Class: Form3 Interface Name: IOleObject is non-compliant
Has no interface: Class: Form3 Interface Name: IOleInPlaceObject is non-compliant
Has no interface: Class: Form3 Interface Name: IOleInPlaceActiveObject is non-compliant
Has no interface: Class: Form3 Interface Name: IOleWindow is non-compliant
Has no interface: Class: Form3 Interface Name: IViewObject is non-compliant
Has no interface: Class: Form3 Interface Name: IViewObject2 is non-compliant
Has no interface: Class: Form3 Interface Name: IPersist is non-compliant
Has no interface: Class: Form3 Interface Name: IPersistStreamInit is non-compliant
Has no interface: Class: Form3 Interface Name: IPersistPropertyBag is non-compliant
Has no interface: Class: Form3 Interface Name: IPersistStorage is non-compliant
Has no interface: Class: Form3 Interface Name: IQuickActivate is non-compliant
Has interface: Class: Form3 Interface Name: ISupportOleDropSource is compliant
Has interface: Class: Form3 Interface Name: IDropTarget is compliant
Has interface: Class: Form3 Interface Name: ISynchronizeInvoke is compliant
Has interface: Class: Form3 Interface Name: IWin32Window is compliant
Has interface: Class: Form3 Interface Name: IArrangedElement is compliant
Has interface: Class: Form3 Interface Name: IBindableComponent is compliant
Has interface: Class: Form3 Interface Name: IKeyboardToolTip is compliant
Has interface: Class: Form3 Interface Name: IContainerControl is compliant
Class Name: Form3 Method Name: method1 Method Size: 19
Class Name: Form3 Method Name: method2 Method Size: 19
Class Name: Form3 Method Name: method3 Method Size: 19
Class Name: Form3 Method Name: Dispose Method Size: 43
Class Name: Form3 Method Name: InitializeComponent Method Size: 598
File Name: TestAssembly, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
Has interface: Class: Form4 Interface Name: IComponent is compliant
Has interface: Class: Form4 Interface Name: IDisposable is compliant
Has no interface: Class: Form4 Interface Name: IOleControl is non-compliant
Has no interface: Class: Form4 Interface Name: IOleObject is non-compliant
Has no interface: Class: Form4 Interface Name: IOleInPlaceObject is non-compliant
Has no interface: Class: Form4 Interface Name: IOleInPlaceActiveObject is non-compliant
Has no interface: Class: Form4 Interface Name: IOleWindow is non-compliant
Has no interface: Class: Form4 Interface Name: IViewObject is non-compliant
Has no interface: Class: Form4 Interface Name: IViewObject2 is non-compliant
Has no interface: Class: Form4 Interface Name: IPersist is non-compliant
Has no interface: Class: Form4 Interface Name: IPersistStreamInit is non-compliant
Has no interface: Class: Form4 Interface Name: IPersistPropertyBag is non-compliant
Has no interface: Class: Form4 Interface Name: IPersistStorage is non-compliant
Has no interface: Class: Form4 Interface Name: IQuickActivate is non-compliant
Has interface: Class: Form4 Interface Name: ISupportOleDropSource is compliant
Has interface: Class: Form4 Interface Name: IDropTarget is compliant
Has interface: Class: Form4 Interface Name: ISynchronizeInvoke is compliant
Has interface: Class: Form4 Interface Name: IWin32Window is compliant
Has interface: Class: Form4 Interface Name: IArrangedElement is compliant
Has interface: Class: Form4 Interface Name: IBindableComponent is compliant
Has interface: Class: Form4 Interface Name: IKeyboardToolTip is compliant
Has interface: Class: Form4 Interface Name: IContainerControl is compliant
Class Name: Form4 Method Name: label1_Click Method Size: 2
Class Name: Form4 Method Name: method1 Method Size: 19
Class Name: Form4 Method Name: method2 Method Size: 19
Class Name: Form4 Method Name: method3 Method Size: 19
Class Name: Form4 Method Name: method4 Method Size: 19
Class Name: Form4 Method Name: method5 Method Size: 19
Class Name: Form4 Method Name: Dispose Method Size: 43
Class Name: Form4 Method Name: InitializeComponent Method Size: 953
File Name: TestAssembly, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
File Name: TestAssembly, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
Class Name: InterfaceAAA Method Name: get_Color Method Size: 0
Class Name: InterfaceAAA Method Name: set_Color Method Size: 0
Class Name: InterfaceAAA Method Name: Open Method Size: 0
Class Name: InterfaceAAA Method Name: Close Method Size: 0
Class Name: InterfaceAAA Method Name: Write Method Size: 0
File Name: TestAssembly, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
Class Name: InterfaceBBB Method Name: get_Color Method Size: 0
Class Name: InterfaceBBB Method Name: set_Color Method Size: 0
Class Name: InterfaceBBB Method Name: Open Method Size: 0
Class Name: InterfaceBBB Method Name: Close Method Size: 0
Class Name: InterfaceBBB Method Name: Write Method Size: 0
File Name: TestAssembly, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
File Name: TestAssembly, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
Has interface: Class: NewClass Interface Name: interface1 is compliant
Class Name: NewClass Method Name: get_Color Method Size: 7
Class Name: NewClass Method Name: set_Color Method Size: 8
Class Name: NewClass Method Name: Close Method Size: 30
Class Name: NewClass Method Name: Open Method Size: 30
Class Name: NewClass Method Name: Write Method Size: 29
File Name: TestAssembly, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
File Name: TestAssembly, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
File Name: TestAssembly, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
Has interface: Class: Settings Interface Name: INotifyPropertyChanged is compliant
Class Name: Class_2 Method Name: 5
Class Name: ClassIN Method Name: 1
Class Name: ClassIn2 Method Name: 1
Class Name: ClassMain Method Name: 0
Class Name: ClassOut Method Name: 1
Class Name: ClassOut2 Method Name: 1
Class Name: Form1 Method Name: 5
Class Name: Form2 Method Name: 4
Class Name: Form3 Method Name: 5
Class Name: Form4 Method Name: 8
Class Name: interface1 Method Name: 0
Class Name: InterfaceAAA Method Name: 5
Class Name: InterfaceBBB Method Name: 5
Class Name: InterfaceCCC Method Name: 0
Class Name: NewClass Method Name: 5
Class Name: Program Method Name: 0
Class Name: Resources Method Name: 0
Class Name: Settings Method Name: 0

dll Task3Testing was used to demonstrate the capabilities of the program.

Tree Data Structure:
AnimalClass
---CatClass
---DogClass
----ChewawaDog
----CollieClass
Program

Graph Data Structure:
Nodes:
AnimalClass
CatClass
ChewawaDog
CollieClass
DogClass
Program

Edges:
AnimalClass -> CatClass
AnimalClass -> ChewawaDog
AnimalClass -> CollieClass
AnimalClass -> DogClass
DogClass -> ChewawaDog
DogClass -> CollieClass

External Refrence: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
File Name: Task3Test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
File Name: Task3Test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
File Name: Task3Test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
File Name: Task3Test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
File Name: Task3Test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
File Name: Task3Test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
Class Name: AnimalClass Method Name: 0
Class Name: CatClass Method Name: 0
Class Name: ChewawaDog Method Name: 0
Class Name: CollieClass Method Name: 0
Class Name: DogClass Method Name: 0
Class Name: Program Method Name: 0

dll TestingDllv2 was used to demonstrate the capabilities of the program.
File Name: TestingDllv2, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
External Reference: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
External Reference: ClassLibrary2AssemblyTesting, Version=2.0.0.3, Culture=neutral, PublicKeyToken=null
Class Name: ButtonClass Method Name: Execute Method Size: 26
Class Name: ButtonClass Method Name: Undo Method Size: 26
Class Name: ICommand Method Name: Execute Method Size: 0
Class Name: ICommand Method Name: Undo Method Size: 0
Class Name: IDrivable Method Name: get_Wheels Method Size: 0
Class Name: IDrivable Method Name: set_Wheels Method Size: 0
Class Name: IDrivable Method Name: get_Speed Method Size: 0
Class Name: IDrivable Method Name: set_Speed Method Size: 0
Class Name: IDrivable Method Name: Move Method Size: 0
Class Name: IDrivable Method Name: Stop Method Size: 0
Class Name: IElectronicDevice Method Name: Type Method Size: 0
Class Name: IElectronicDevice Method Name: On Method Size: 0
Class Name: IElectronicDevice Method Name: Off Method Size: 0
Class Name: IElectronicDevice Method Name: VolumeUp Method Size: 0
Class Name: IElectronicDevice Method Name: VolumeDown Method Size: 0
Class Name: Television Method Name: get_Volume Method Size: 7
Class Name: Television Method Name: set_Volume Method Size: 8
Class Name: Television Method Name: get_Device Method Size: 7
Class Name: Television Method Name: set_Device Method Size: 8
Class Name: Television Method Name: Off Method Size: 13
Class Name: Television Method Name: On Method Size: 13
Class Name: Television Method Name: Type Method Size: 24
Class Name: Television Method Name: VolumeDown Method Size: 61
Class Name: Television Method Name: VolumeUp Method Size: 65
Class Name: Vehicle Method Name: get_Brand Method Size: 7
Class Name: Vehicle Method Name: set_Brand Method Size: 8
Class Name: Vehicle Method Name: get_Wheels Method Size: 7
Class Name: Vehicle Method Name: set_Wheels Method Size: 8
Class Name: Vehicle Method Name: get_Speed Method Size: 7
Class Name: Vehicle Method Name: set_Speed Method Size: 8
Class Name: Vehicle Method Name: Move Method Size: 35
Class Name: Vehicle Method Name: Stop Method Size: 45
Class Name: ButtonClass Method Name: 2
Class Name: ICommand Method Name: 2
Class Name: IDrivable Method Name: 6
Class Name: IElectronicDevice Method Name: 5
Class Name: Program Method Name: 0
Class Name: Remote Method Name: 0
Class Name: Television Method Name: 9
Class Name: Vehicle Method Name: 8

Has no interface: Class: ButtonClass Interface Name: ButtonClass is non-compliant
Has interface: Class: ButtonClass Interface Name: ICommand is compliant
Has interface: Class: ButtonClass Interface Name: IDrivable is compliant
Has interface: Class: ButtonClass Interface Name: IElectronicDevice is compliant
Has no interface: Class: ButtonClass Interface Name: Program is non-compliant
Has no interface: Class: ButtonClass Interface Name: Remote is non-compliant
Has no interface: Class: ButtonClass Interface Name: Television is non-compliant
Has no interface: Class: ButtonClass Interface Name: Vehicle is non-compliant
Has no interface: Class: ICommand Interface Name: ButtonClass is non-compliant
Has interface: Class: ICommand Interface Name: ICommand is compliant
Has interface: Class: ICommand Interface Name: IDrivable is compliant
Has interface: Class: ICommand Interface Name: IElectronicDevice is compliant
Has no interface: Class: ICommand Interface Name: Program is non-compliant
Has no interface: Class: ICommand Interface Name: Remote is non-compliant
Has no interface: Class: ICommand Interface Name: Television is non-compliant
Has no interface: Class: ICommand Interface Name: Vehicle is non-compliant
Has no interface: Class: IDrivable Interface Name: ButtonClass is non-compliant
Has interface: Class: IDrivable Interface Name: ICommand is compliant
Has interface: Class: IDrivable Interface Name: IDrivable is compliant
Has interface: Class: IDrivable Interface Name: IElectronicDevice is compliant
Has no interface: Class: IDrivable Interface Name: Program is non-compliant
Has no interface: Class: IDrivable Interface Name: Remote is non-compliant
Has no interface: Class: IDrivable Interface Name: Television is non-compliant
Has no interface: Class: IDrivable Interface Name: Vehicle is non-compliant
Has no interface: Class: IElectronicDevice Interface Name: ButtonClass is non-compliant
Has interface: Class: IElectronicDevice Interface Name: ICommand is compliant
Has interface: Class: IElectronicDevice Interface Name: IDrivable is compliant
Has interface: Class: IElectronicDevice Interface Name: IElectronicDevice is compliant
Has no interface: Class: IElectronicDevice Interface Name: Program is non-compliant
Has no interface: Class: IElectronicDevice Interface Name: Remote is non-compliant
Has no interface: Class: IElectronicDevice Interface Name: Television is non-compliant
Has no interface: Class: IElectronicDevice Interface Name: Vehicle is non-compliant
Has no interface: Class: Program Interface Name: ButtonClass is non-compliant
Has interface: Class: Program Interface Name: ICommand is compliant
Has interface: Class: Program Interface Name: IDrivable is compliant
Has interface: Class: Program Interface Name: IElectronicDevice is compliant
Has no interface: Class: Program Interface Name: Program is non-compliant
Has no interface: Class: Program Interface Name: Remote is non-compliant
Has no interface: Class: Program Interface Name: Television is non-compliant
Has no interface: Class: Program Interface Name: Vehicle is non-compliant
Has no interface: Class: Remote Interface Name: ButtonClass is non-compliant
Has interface: Class: Remote Interface Name: ICommand is compliant
Has interface: Class: Remote Interface Name: IDrivable is compliant
Has interface: Class: Remote Interface Name: IElectronicDevice is compliant
Has no interface: Class: Remote Interface Name: Program is non-compliant
Has no interface: Class: Remote Interface Name: Remote is non-compliant
Has no interface: Class: Remote Interface Name: Television is non-compliant
Has no interface: Class: Remote Interface Name: Vehicle is non-compliant
Has no interface: Class: Television Interface Name: ButtonClass is non-compliant
Has interface: Class: Television Interface Name: ICommand is compliant
Has interface: Class: Television Interface Name: IDrivable is compliant
Has interface: Class: Television Interface Name: IElectronicDevice is compliant
Has no interface: Class: Television Interface Name: Program is non-compliant
Has no interface: Class: Television Interface Name: Remote is non-compliant
Has no interface: Class: Television Interface Name: Television is non-compliant
Has no interface: Class: Television Interface Name: Vehicle is non-compliant
Has no interface: Class: Vehicle Interface Name: ButtonClass is non-compliant
Has interface: Class: Vehicle Interface Name: ICommand is compliant
Has interface: Class: Vehicle Interface Name: IDrivable is compliant
Has interface: Class: Vehicle Interface Name: IElectronicDevice is compliant
Has no interface: Class: Vehicle Interface Name: Program is non-compliant
Has no interface: Class: Vehicle Interface Name: Remote is non-compliant
Has no interface: Class: Vehicle Interface Name: Television is non-compliant
Has no interface: Class: Vehicle Interface Name: Vehicle is non-compliant

TestingDllv2, Version=1.2.0.0, Culture=neutral, PublicKeyToken=null
 ICommand
 ---ButtonClass
 IElectronicDevice
 ---Television
 IDrivable
 ---Vehicle




Testing Other dll files:

name:Antlr3.Runtime
class, methods, bytes: (ANTLRStringStream, get_Index, 7), (ANTLRStringStream, get_Line, 7), (ANTLRStringStream, set_Line, 8), (ANTLRStringStream, get_CharPositionInLine, 7), (ANTLRStringStream, set_CharPositionInLine, 8), (ANTLRStringStream, Reset, 29), (ANTLRStringStream, Consume, 81), (ANTLRStringStream, LA, 67), (ANTLRStringStream, LT, 8), (ANTLRStringStream, get_Count, 7), (ANTLRStringStream, Mark, 159), (ANTLRStringStream, Rewind, 67), (ANTLRStringStream, Rewind, 13), (ANTLRStringStream, Release, 22), (ANTLRStringStream, Seek, 33), (ANTLRStringStream, Substring, 62), (ANTLRStringStream, get_SourceName, 7), (ANTLRStringStream, ToString, 12), (ANTLRFileStream, Load, 51), (ANTLRFileStream, get_SourceName, 7), (ANTLRReaderStream, Load, 67), (ParserRuleReturnScope`1, get_Start, 7), (ParserRuleReturnScope`1, set_Start, 8), (ParserRuleReturnScope`1, get_Stop, 7), (ParserRuleReturnScope`1, set_Stop, 8), (ParserRuleReturnScope`1, Antlr.Runtime.IRuleReturnScope.get_Start, 12), (ParserRuleReturnScope`1, Antlr.Runtime.IRuleReturnScope.get_Stop, 12), (AstParserRuleReturnScope`2, get_Tree, 7), (AstParserRuleReturnScope`2, set_Tree, 8), (AstParserRuleReturnScope`2, Antlr.Runtime.IAstRuleReturnScope.get_Tree, 12), (BitSet, Or, 26), (BitSet, Add, 56), (BitSet, GrowToInclude, 30), (BitSet, OrInPlace, 105), (BitSet, SetSize, 13), (BitSet, Clone, 22), (BitSet, Size, 69), (BitSet, GetHashCode, 6), (BitSet, Equals, 175), (BitSet, Member, 49), (BitSet, Remove, 50), (BitSet, IsNil, 37), (BitSet, NumBits, 11), (BitSet, LengthInLongWords, 9), (BitSet, ToArray, 54), (BitSet, ToString, 8), (BitSet, ToString, 109), (BufferedTokenStream, get_TokenSource, 7), (BufferedTokenStream, set_TokenSource, 26), (BufferedTokenStream, get_Index, 7), (BufferedTokenStream, get_Range, 7), (BufferedTokenStream, set_Range, 8), (BufferedTokenStream, get_Count, 12), (BufferedTokenStream, get_SourceName, 12), (BufferedTokenStream, get_LastToken, 8), (BufferedTokenStream, get_LastRealToken, 28), (BufferedTokenStream, get_MaxLookBehind, 6), (BufferedTokenStream, Mark, 34), (BufferedTokenStream, Release, 1), (BufferedTokenStream, Rewind, 8), (BufferedTokenStream, Rewind, 13), (BufferedTokenStream, Reset, 15), (BufferedTokenStream, Seek, 8), (BufferedTokenStream, Consume, 42), (BufferedTokenStream, Sync, 28), (BufferedTokenStream, Fetch, 64), (BufferedTokenStream, Get, 96), (BufferedTokenStream, LA, 13), (BufferedTokenStream, LB, 33), (BufferedTokenStream, LT, 128), (BufferedTokenStream, Setup, 15), (BufferedTokenStream, GetTokens, 7), (BufferedTokenStream, GetTokens, 10), (BufferedTokenStream, GetTokens, 124), (BufferedTokenStream, GetTokens, 15), (BufferedTokenStream, GetTokens, 15), (BufferedTokenStream, ToString, 42), (BufferedTokenStream, ToString, 114), (BufferedTokenStream, ToString, 27), (BufferedTokenStream, Fill, 91), (ClassicToken, get_Text, 7), (ClassicToken, set_Text, 8), (ClassicToken, get_Type, 7), (ClassicToken, set_Type, 8), (ClassicToken, get_Line, 7), (ClassicToken, set_Line, 8), (ClassicToken, get_CharPositionInLine, 7), (ClassicToken, set_CharPositionInLine, 8), (ClassicToken, get_Channel, 7), (ClassicToken, set_Channel, 8), (ClassicToken, get_StartIndex, 2), (ClassicToken, set_StartIndex, 1), (ClassicToken, get_StopIndex, 2), (ClassicToken, set_StopIndex, 1), (ClassicToken, get_TokenIndex, 7), (ClassicToken, set_TokenIndex, 8), (ClassicToken, get_InputStream, 2), (ClassicToken, set_InputStream, 1), (ClassicToken, ToString, 245), (CommonToken, get_Text, 97), (CommonToken, set_Text, 8), (CommonToken, get_Type, 7), (CommonToken, set_Type, 8), (CommonToken, get_Line, 7), (CommonToken, set_Line, 8), (CommonToken, get_CharPositionInLine, 7), (CommonToken, set_CharPositionInLine, 8), (CommonToken, get_Channel, 7), (CommonToken, set_Channel, 8), (CommonToken, get_StartIndex, 7), (CommonToken, set_StartIndex, 8), (CommonToken, get_StopIndex, 7), (CommonToken, set_StopIndex, 8), (CommonToken, get_TokenIndex, 7), (CommonToken, set_TokenIndex, 8), (CommonToken, get_InputStream, 7), (CommonToken, set_InputStream, 8), (CommonToken, ToString, 293), (CommonToken, OnSerializing, 21), (CommonTokenStream, get_Channel, 7), (CommonTokenStream, get_TokenSource, 7), (CommonTokenStream, set_TokenSource, 15), (CommonTokenStream, Consume, 48), (CommonTokenStream, LB, 64), (CommonTokenStream, LT, 91), (CommonTokenStream, SkipOffTokenChannels, 48), (CommonTokenStream, SkipOffTokenChannelsReverse, 38), (CommonTokenStream, Reset, 20), (CommonTokenStream, Setup, 26), (DFA, get_Description, 6), (DFA, Predict, 313), (DFA, DfaDebugMessage, 13), (DFA, DfaDebugInvalidSymbol, 203), (DFA, NoViableAlt, 66), (DFA, Error, 1), (DFA, get_SpecialStateTransition, 7), (DFA, set_SpecialStateTransition, 8), (DFA, DebugRecognitionException, 23), (RecognitionException, get_UnexpectedType, 67), (RecognitionException, get_ApproximateLineInfo, 7), (RecognitionException, set_ApproximateLineInfo, 8), (RecognitionException, get_Input, 7), (RecognitionException, set_Input, 8), (RecognitionException, get_Lookahead, 7), (RecognitionException, get_Token, 7), (RecognitionException, set_Token, 8), (RecognitionException, get_Node, 7), (RecognitionException, set_Node, 8), (RecognitionException, get_Character, 7), (RecognitionException, set_Character, 8), (RecognitionException, get_Index, 7), (RecognitionException, set_Index, 8), (RecognitionException, get_Line, 7), (RecognitionException, set_Line, 8), (RecognitionException, get_CharPositionInLine, 7), (RecognitionException, set_CharPositionInLine, 8), (RecognitionException, GetObjectData, 108), (RecognitionException, ExtractInformationFromTreeNodeStream, 460), (RecognitionException, ExtractInformationFromTreeNodeStream, 45), (EarlyExitException, get_DecisionNumber, 7), (EarlyExitException, GetObjectData, 40), (FailedPredicateException, get_RuleName, 7), (FailedPredicateException, get_PredicateText, 7), (FailedPredicateException, GetObjectData, 57), (FailedPredicateException, ToString, 56), (GrammarRuleAttribute, get_Name, 7), (LegacyCommonTokenStream, get_Index, 7), (LegacyCommonTokenStream, get_Range, 7), (LegacyCommonTokenStream, set_Range, 8), (LegacyCommonTokenStream, SetTokenSource, 33), (LegacyCommonTokenStream, FillBuffer, 201), (LegacyCommonTokenStream, Consume, 52), (LegacyCommonTokenStream, SkipOffTokenChannels, 50), (LegacyCommonTokenStream, SkipOffTokenChannelsReverse, 38), (LegacyCommonTokenStream, SetTokenTypeChannel, 33), (LegacyCommonTokenStream, DiscardTokenType, 32), (LegacyCommonTokenStream, SetDiscardOffChannelTokens, 8), (LegacyCommonTokenStream, GetTokens, 22), (LegacyCommonTokenStream, GetTokens, 10), (LegacyCommonTokenStream, GetTokens, 124), (LegacyCommonTokenStream, GetTokens, 15), (LegacyCommonTokenStream, GetTokens, 15), (LegacyCommonTokenStream, LT, 178), (LegacyCommonTokenStream, LB, 81), (LegacyCommonTokenStream, Get, 13), (LegacyCommonTokenStream, LA, 13), (LegacyCommonTokenStream, Mark, 34), (LegacyCommonTokenStream, Release, 1), (LegacyCommonTokenStream, get_Count, 12), (LegacyCommonTokenStream, Rewind, 8), (LegacyCommonTokenStream, Rewind, 13), (LegacyCommonTokenStream, Reset, 15), (LegacyCommonTokenStream, Seek, 8), (LegacyCommonTokenStream, get_TokenSource, 7), (LegacyCommonTokenStream, get_SourceName, 12), (LegacyCommonTokenStream, ToString, 41), (LegacyCommonTokenStream, ToString, 110), (LegacyCommonTokenStream, ToString, 27), (FastQueue`1, get_Count, 19), (FastQueue`1, get_Range, 7), (FastQueue`1, set_Range, 8), (FastQueue`1, get_Item, 118), (FastQueue`1, Dequeue, 63), (FastQueue`1, Enqueue, 13), (FastQueue`1, Peek, 8), (FastQueue`1, Clear, 19), (FastQueue`1, ToString, 69)
external references: mscorlib, System

name:ClassLibrary1
class, methods, bytes:
external references:System.Runtime, System.Console

name: ClassLibrary2AssemblyTesting
class, methods, bytes:(Class1, HelloUser, 17), (Class1, AuthCalc, 44)
external references:mscorlib

name:Cloud(1)
class, methods, bytes:(CreateCustomerQuote, btnLoad_Click, 672), (CreateCustomerQuote, lb_SelectedIndexChanged, 2), (CreateCustomerQuote, btnHome_Click, 20), (CreateEmployeeInfo, Page_Load, 2), (CreateEmployeeInfo, txtbEmpNo_TextChanged, 2), (CreateEmployeeInfo, txtbName_TextChanged, 2), (CreateEmployeeInfo, txtbSurname_TextChanged, 2), (CreateEmployeeInfo, btnCreate_Click, 315), (CreateEmployeeInfo, lb_SelectedIndexChanged, 2), (CreateEmployeeInfo, BtnHome_Click, 19), (CreateJobCard, Page_Load, 2), (CreateJobCard, txtbJobCardNo_TextChanged, 2), (CreateJobCard, txtbJobTypeNo_TextChanged, 2), (CreateJobCard, txtCustomerID_TextChanged, 2), (CreateJobCard, txtbDays_TextChanged, 2), (CreateJobCard, btnCreate_Click, 376), (CreateJobCard, ListBox1_SelectedIndexChanged, 2), (CreateJobCard, btnHome_Click, 19), (WebForm1, Page_Load, 2), (WebForm1, btnCreateJobCard_Click, 19),(WebForm1, btnRetrieveJobCard_Click, 19), (WebForm1, btnUpdateEmployeeInfo_Click, 19),(WebForm1, btnRetrieveEmployeeInfo_Click, 19), (WebForm1, btnCreateEmployeeInfo_Click, 19), (WebForm1, btnUpdateDailyRate_Click, 19), (WebForm1, btnCreateCuatomerQuote_Click, 19), (RetrieveEmployeeInfo, Page_Load, 2), (RetrieveEmployeeInfo, txtbNum_TextChanged, 2), (RetrieveEmployeeInfo, btnLoad_Click, 288), (RetrieveEmployeeInfo, lb_SelectedIndexChanged, 2), (RetrieveEmployeeInfo, btnHome_Click, 19), (RetrieveJobCard, Page_Load, 2), (RetrieveJobCard, txtbNum_TextChanged, 2), (RetrieveJobCard, btnLoad_Click, 340), (RetrieveJobCard, ListBox1_SelectedIndexChanged, 2), (RetrieveJobCard, btnHome_Click, 19), (UpdateDailyRate, Page_Load, 2), (UpdateDailyRate, txtbJobType_TextChanged, 2), (UpdateDailyRate, txtbRate_TextChanged, 2), (UpdateDailyRate, btnUpdate_Click, 260), (UpdateDailyRate, lb_SelectedIndexChanged, 2), (UpdateDailyRate, btnHome_Click, 19), (UpdateEmployeeInfo, Page_Load, 2), (UpdateEmployeeInfo, txtbNumToUpdate_TextChanged, 2), (UpdateEmployeeInfo, txtbNum_TextChanged, 2), (UpdateEmployeeInfo, txtbName_TextChanged, 2), (UpdateEmployeeInfo, txtbSurnameUpdate_TextChanged, 2), (UpdateEmployeeInfo, lb_SelectedIndexChanged, 2), (UpdateEmployeeInfo, btnUpdateNum_Click, 222), (UpdateEmployeeInfo, btnNameUpdate_Click, 222), (UpdateEmployeeInfo, btnSurnameUpdate_Click, 222), (UpdateEmployeeInfo, btnHome_Click, 20),
external references: mscorlib, System.Web, System.Data,



