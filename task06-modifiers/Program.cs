using System;

using System.Diagnostics;

using System.Linq;

// ----- ДОБАВИТЬ МОДИФИКАТОРЫ И МОДИФИКАТОРЫ ДОСТУПА -----
public class BaseClass
{
    public string GetCode() { return "CODE-1"; }

    public string GetDescription() { return this.GetDefaultDescription() + this.GetClassSymbol(); }

    public string GetDefaultDescription() { return "CLASS-"; }

    public extern string GetClassSymbol();

}

internal class DerivedClassA : BaseClass
{
   new internal string GetCode() { return this.GetCurrentCode(); }

    internal string GetCurrentCode() { return "CODE-2"; }

    internal string GetClassSymbol() { return "A"; }

}

internal class DerivedClassB : DerivedClassA

{

    class DerivedClassImpl

    {
       public static string GetCode() { return "CODE-3"; }

    }

   new string GetCode() { return DerivedClassImpl.GetCode(); }

   new string GetDefaultDescription() { return string.Empty; }

    new string GetClassSymbol() { return "B"; }

}



// ----- ЗАПРЕЩЕНО ИЗМЕНЯТЬ КОД В КЛАССЕ PROGRAM -----



public class Program

{

    public static void Main()

    {

        Debug.Listeners.Clear();

        Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));



        VerifyModifiers();

        VerifyAccessibilityLevels(typeof(BaseClass), s2, typeof(DerivedClassA), s3, typeof(DerivedClassB));

    }



    private static void VerifyModifiers()

    {

        DerivedClassA class_a = new DerivedClassA();

        DerivedClassB class_b = new DerivedClassB();

        BaseClass base_a = class_a;

        BaseClass base_b = class_b;



        Debug.Assert(class_a.GetCode() == "CODE-2", "class_a.GetCode() should return CODE-2");

        Debug.Assert(class_b.GetCode() == "CODE-3", "class_b.GetCode() should return CODE-3");

        Debug.Assert(base_a.GetCode() == "CODE-1", "base_a.GetCode() should return CODE-1");

        Debug.Assert(base_b.GetCode() == "CODE-1", "base_b.GetCode() should return CODE-1");



        Debug.Assert(class_a.GetDescription() == "CLASS-A", "class_a.GetDescription() sould return CLASS-A");

        Debug.Assert(class_b.GetDescription() == "B", "class_b.GetDescription() should return B");

        Debug.Assert(base_a.GetDescription() == "CLASS-A", "base_1.GetDescription() should return CLASS-A");

        Debug.Assert(base_b.GetDescription() == "B", "base_b.GetDescription() should return B");

    }



    private static void VerifyAccessibilityLevels(Type x935, string x807, Type x742, string x458, Type x671) { TestType(x935, t => t.IsPublic, s1); TestType(x742, t => t.IsPublic == false, s1); TestType(x671, t => !t.IsPublic, s1); TestType(x935, t => t.GetMethods().FirstOrDefault(m => m.Name == x807) == null, string.Format(s4, x807)); TestType(x935, t => t.GetMethods().FirstOrDefault(m => m.Name == x458) == null, string.Format(s4, x458)); }

    private static void TestType(Type t, Func<Type, bool> f, string m) { Debug.Assert(f(t), string.Format("{0}{1}", t.Name, m)); }

    const string s1 = " has wrong accessibility modifier."; const string s2 = "GetDefaultDescription"; const string s3 = "GetClassSymbol"; const string s4 = "::{0} has wrong accessibility level";

}
