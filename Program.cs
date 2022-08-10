string [] array = new string [5];
Console.WriteLine("Введите элементы массива: ");
for (int i = 0; i< array.Length; i++)
{
    array[i]= Console.ReadLine();
}
Console.Write("Задали массив: [' " +string.Join("', ' ", array) + "']" +"-> [ ");

for (int i = 0; i < array.Length; i++)
{
    int lenght = 3;
    if (array[i].Length <lenght) Console.Write( array[i] +" ");
    if (array[i].Length == lenght) Console.Write( array[i] +" ");
}
Console.Write( "]");