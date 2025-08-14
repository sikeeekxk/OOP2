Act 5 – SRP (Single Responsibility Principle)

Before (bad code):
One class (ReportGenerator) does everything → generate, save, and send reports.

After (good code):
Each class has one job only:

ReportGenerator → only generates the report

FileSaver → only saves

EmailSender → only sends email

✅ Why better? If you want to change how reports are sent, you don’t need to touch the generator class.

Act 6 – OCP (Open/Closed Principle)

Before (bad code):
If you add a new shape (like Triangle) for area calculation, you need to modify existing code.

After (good code):
You create a new class (e.g., Triangle) without changing the old code.

✅ Why better? Your code is open for extension, closed for modification.

Act 7 – LSP (Liskov Substitution Principle)

Before (bad code):
A Bird class has a Fly() method, but not all birds fly (like penguins). If you substitute a Penguin, it breaks.

After (good code):
Split into IFlyable and ISwimmable.

Eagle implements IFlyable

Penguin implements ISwimmable

✅ Why better? Subclasses can replace their parent class without breaking the program.

Act 8 – ISP (Interface Segregation Principle)

Before (bad code):
One big interface IMachine with too many functions → Printer and Scanner are forced to implement things they don’t need.

After (good code):
Split into smaller interfaces:

IPrinter

IScanner

IFax

✅ Why better? Classes only implement what they actually use.

Act 9 – DIP (Dependency Inversion Principle)

Before (bad code):
Report directly depends on a concrete FileSaver.

After (good code):
Report depends on an interface IStorage instead. Then we can plug in FileSaver, DatabaseSaver, etc.

✅ Why better? High-level modules don’t depend on low-level details. Both depend on abstractions.
