using Delegate;

label:Console.WriteLine("1-basic  2-pro  3-expert");
Console.Write("Enter key:");
string key=Console.ReadLine();
DocumentProgram documentProgram;
if (key=="1")
{
    documentProgram = new DocumentProgram();
}
else if (key == "2")
{
    documentProgram = new ProDocumentProgram();

}
else if(key == "3")
{
    documentProgram = new ExpertDocument();

}
else
{
    Console.WriteLine("Your choice is wrong!");
    goto label;
}
documentProgram.OpenDocument();
documentProgram.EditDocument();
documentProgram.SaveDocument();