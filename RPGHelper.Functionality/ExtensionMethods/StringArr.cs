namespace RPGHelper.Functionality.ExtensionMethods;

public static class StringArr
{
    public static void TrimAll(this string[] stringList)
    {
        for (int i = 0; i < stringList.Length; i++)
        {
            stringList[i] = stringList[i].Trim(); //warning: do not change this to lambda expression (.ForEach() uses a copy)
        }
    }
}