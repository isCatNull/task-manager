namespace TaskManager.Migrations;

public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("TaskManager.Migrations runner project.");
        Console.WriteLine("Use EF Core CLI commands from here, e.g.:");
        Console.WriteLine("  dotnet ef migrations add <Name> --project TaskManager.Migrations --startup-project TaskManager.Migrations");
        Console.WriteLine("  dotnet ef database update --project TaskManager.Migrations --startup-project TaskManager.Migrations");
    }
}