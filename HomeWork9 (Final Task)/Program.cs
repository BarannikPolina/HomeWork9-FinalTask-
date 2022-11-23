string[] arr = {"555", "*", "0", "%", "39", "781", "#", "&", ":-)", "87", "9", "129", "2", "@"};

for (int i = 0; i < arr.Length; i++) 
{
Boolean c = (Char.IsDigit(arr[i], 0));
if (!c) 
{
Console.WriteLine(arr[i]);
}
}

