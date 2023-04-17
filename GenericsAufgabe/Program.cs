using GenericsAufgabe;

void TestArray()
{
    Array<int> arr = new Array<int>(3);
    arr[0] = 0;
    arr[1] = 1;
    arr[2] = 2;

    arr[0] = 5;
    Console.WriteLine(arr[0]);
    Console.WriteLine(arr.GetTypeInfo());
}

void TestListe()
{
    Liste<int> list = new Liste<int>();
    list.Add(0);
    list.Add(1);
    list.Add(2);

    list[0] = 5;

    Console.WriteLine(list[0]);
    Console.WriteLine(list.GetTypeInfo());
}

TestArray();
TestListe();