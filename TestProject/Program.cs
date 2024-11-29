string? readResult;
string role = "";
bool isValid = false;

Console.WriteLine("Enter a role:");

do{
    
    readResult = Console.ReadLine();
    if(readResult != null){
        role = readResult.Trim();
    }
    if (role == "admin" || role == "user" || role == "manager"){
        isValid = true;
    }else{
        Console.WriteLine("Invalid role. Please enter a valid role.");
    }
} while (!isValid);
Console.WriteLine($"You are a {role}.");
