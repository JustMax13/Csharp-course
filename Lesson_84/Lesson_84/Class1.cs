namespace Lesson_84
{
    class MySwap
    {
        public static void GenericSwap<T>(ref T value1, ref T value2)
        {
            T temp = value1;
            value1 = value2;
            value2 = temp;
        }
        public static void ObjectSwap(ref object value1, ref object value2)
        {
            object temp = value1;
            value1 = value2;
            value2 = temp;
        }
    }
}
