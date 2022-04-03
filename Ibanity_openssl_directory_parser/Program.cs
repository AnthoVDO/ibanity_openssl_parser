// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

String rsaKey = "genrsa -aes256 -out private_key.pem 2048";


Console.WriteLine("Starting");
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
}
    if(ansRsaKey == "y")
    {
    
    Process.Start("C:/Program Files/Git/usr/bin/openssl.exe", rsaKey);
    } 







string ibanityCommand = Console.ReadLine();
Console.WriteLine("Please add the folder location: ");
string folderLaction = Console.ReadLine();


string formated;

//Console.WriteLine(formated);

//Step 1 generate the rsaKey

//Step 2 Generate the Certificate Signing Request

//Step 3 Generate the private key
