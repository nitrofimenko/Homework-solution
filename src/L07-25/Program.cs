using L07_25;

static void ClassTaker(MyClass myClass)
{
    myClass.change = "changed";
}
static void StructTaker(MyStruct myStruct)
{
    myStruct.change = "changed";
}

MyStruct myStruct;
MyClass myClass = new MyClass();

myStruct.change = "non changed";
myClass.change = "non changed";

StructTaker(myStruct); // by val
ClassTaker(myClass);   // by ref

Console.WriteLine($"Struct field \"change\" value: {myStruct.change}");
Console.WriteLine($"Class field \"change\" value: {myClass.change}");
