using System.Collections;
using System.Text;
using Homework6;
#region task1 Custom Contains
string text = "Bu bir custom contains methodudur";
Console.WriteLine(text.Contains("contains"));
#endregion

#region task2 Custom Split
string customSplit = "Bu bir custom slip methodudur";

string[] array = customSplit.Custsplit();


foreach (var item in array)
{

    Console.WriteLine(item);

}
#endregion