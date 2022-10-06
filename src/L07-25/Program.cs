using L07_25;

static void ClassTaker(MyClass myClass) => myClass.change = "changed";
static void StructTaker(MyStruct myStruct) => myStruct.change = "changed";

MyClass myClass = new MyClass();
MyStruct myStruct;

myClass.change = "non changed";
myStruct.change = "non changed";

ClassTaker(myClass);   // by ref
StructTaker(myStruct); // by val

Console.WriteLine($"Class: {myClass.change}");
Console.WriteLine($"Struct: {myStruct.change}");