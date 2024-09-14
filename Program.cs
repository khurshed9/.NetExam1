//1

string path = "C:\\Users\\VICTUS\\Desktop\\Lorem\\page.txt";

Directory.CreateDirectory(path);
File.Create(path);
string strings = "Hello, World";
File.WriteAllText(path,strings);
File.Delete(path);

//3
/*string path = "C:\\Users\\VICTUS\\Desktop\\OOP";

Directory.CreateDirectory(path);
File.Create(path);
string[] files = Directory.GetFiles(path);
foreach (var VARIABLE in files)
{
    Console.WriteLine(VARIABLE);
}*/

//4
/*using System.IO.Compression;

string path = "C:\\Users\\VICTUS\\Desktop\\CRM";
string newPath = "C:\\Users\\VICTUS\\Desktop\\backup.zip";

Directory.CreateDirectory(path);
ZipFile.CreateFromDirectory(path, newPath);*/


//5
/*string path = "C:\\Users\\VICTUS\\Desktop\\OOP\\page1";

Console.WriteLine(Directory.GetParent(path));*/


//6
/*
string path1 = "C:\\Users\\VICTUS\\Desktop\\Lorem\\page.txt";
string path2 = "C:\\Users\\VICTUS\\Desktop\\Lorem\\page11.txt";

string t1 = File.ReadAllText(path1);
string t2 = File.ReadAllText(path2);

if (t1 == t2)
{
    Console.WriteLine(true);
}
else
{
    Console.WriteLine(false);
}
*/

//7

/*string path = "C:\\Users\\VICTUS\\Desktop\\OOP\\page1.txt";


using (StreamReader reader = new StreamReader(path))
{
    Console.WriteLine(reader.ReadToEnd());
}*/

//8
/*string path = "C:\\Users\\VICTUS\\Desktop\\OOP\\page1.txt";
string pat2 = "C:\\Users\\VICTUS\\Desktop\\OOP\\page5.txt";

File.Move(path, pat2);*/

//9
/*string path1 = "C:\\Users\\VICTUS\\Desktop\\OOP\\page5.txt";
string path2 = "C:\\Users\\VICTUS\\Desktop\\CRM\\page5.txt";

string[] strings = Directory.GetFiles(path1);
foreach (var VARIABLE in strings)
{
    Console.WriteLine(VARIABLE);
}
//File.Copy(path1,path2);*/

//11
/*string path = "C:\\Users\\VICTUS\\Desktop\\CRM";
if (!File.Exists(path))
{
    string[] files = Directory.GetFiles(path, "page3.txt");
    Console.WriteLine("Correct");
}*/


//12

/*string path = "C:\\Users\\VICTUS\\Desktop";

string[] getAll = Directory.GetFileSystemEntries(path);
foreach (var VARIABLE in getAll)
{
    Console.WriteLine(VARIABLE);
}*/


//13
/*string path = "C:\\Users\\VICTUS\\Desktop\\Club\\";

string[] files = Directory.GetFiles(path, "*.log");
foreach (var VARIABLE in files)
{
    Console.WriteLine(VARIABLE);
}
//File.Delete(path);*/

//14
/*string path = "C:\\Users\\VICTUS\\Desktop\\OOP\\page5.txt";
string[] strings = File.ReadAllLines(path);
foreach (var VARIABLE in strings)
{
    Console.WriteLine(VARIABLE.ToUpper());
}*/

//15

/*using System.IO.Compression;

string path = "C:\\Users\\VICTUS\\Desktop\\backup.zip";

ZipFile.ExtractToDirectory(path, "C:\\Users\\VICTUS\\Desktop\\Soft");*/

//16
/*string path = "C:\\Users\\VICTUS\\Desktop\\OOP\\page3.txt";

byte[] bytes = File.ReadAllBytes(path);
foreach (var VARIABLE in bytes)
{
    Console.WriteLine(VARIABLE);
}*/

//17
/*string path = "C:\\Users\\VICTUS\\Desktop\\OOP\\page3.txt";

Console.WriteLine(File.GetLastWriteTime(path));*/



//18
/*string path = "C:\\Users\\VICTUS\\Desktop\\OOP\\page2.txt";
string newPath = "C:\\Users\\VICTUS\\Desktop\\Lorem\\page2.txt";

File.Move(path,newPath);*/

//19

/*string path = "C:\\Users\\VICTUS\\Desktop\\OOP\\page5.txt";
string newPath = "C:\\Users\\VICTUS\\Desktop\\Lorem\\page11.txt";

using (FileStream file = new FileStream(path,FileMode.OpenOrCreate,FileAccess.Read))
{
    using (FileStream fileStream = new FileStream(newPath,FileMode.OpenOrCreate,FileAccess.Write))
    {
        file.CopyTo(fileStream);
    }
}*/

//20
/*string path = "C:\\Users\\VICTUS\\Desktop\\Lorem";

string[] files = Directory.GetFiles(path,"*.txt");
foreach (var VARIABLE in files)
{
    Console.WriteLine(VARIABLE);
}*/







