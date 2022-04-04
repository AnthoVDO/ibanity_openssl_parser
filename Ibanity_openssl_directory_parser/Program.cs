// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
static string cleanThePath(string path)
{
    path = path.Replace("\\", "/");
    return path+"/";
}




Console.WriteLine("Starting");

//Select folder
Console.WriteLine("Please enter a folder path: ");
string folderPath = Console.ReadLine();
folderPath = cleanThePath(folderPath);
Console.WriteLine("Folder path set on: "+ folderPath);
String rsaKey = $"genrsa -aes256 -out {folderPath}private_key.pem 2048";

//Step 1 generate the rsaKey
Console.WriteLine("Do you want to generate an rsa key (step1)? y/n: ");

string ansRsaKey = "";
bool correctAns = false;
while(!correctAns)
{
    ansRsaKey = Console.ReadLine();
    if(ansRsaKey == "y" || ansRsaKey == "n")
    {
        correctAns = true;
    }
    else
    {
        Console.WriteLine("You need to answer correctly");
    }
}
    if(ansRsaKey == "y")
    {
    Process.Start("C:/Program Files/Git/usr/bin/openssl.exe", rsaKey);
    }


//Step 2 Generate the Certificate Signing Request

Console.WriteLine("Do you want to generate signature key (step1)? y/n: ");

string signatureKey = "";
bool correctAnsSignature = false;
while (!correctAns)
{
    ansRsaKey = Console.ReadLine();
    if (signatureKey == "y" || signatureKey == "n")
    {
        correctAnsSignature = true;
    }
    else
    {
        Console.WriteLine("You need to answer correctly");
    }
}
if (signatureKey == "y")
{
    Console.WriteLine("Please enter the ibanity signature command");
    string ibanitySignatureCommand = Console.ReadLine();

    Process.Start("C:/Program Files/Git/usr/bin/openssl.exe", rsaKey);
}





//Step 3 Generate the private key
