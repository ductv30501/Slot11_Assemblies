using System;

namespace MyLibrary
{
    public static class MyClass
    {
        public static int add(this int a, int b) => a + b;
        public static int sub(this int a, int b) => a - b;
    }
}
