class Program
{
    static void Main(string[] args)
    {
        Console.Title = "NeonBoot by NeonStudios => .gg/a5R5guFV";
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(@" /$$   /$$                               /$$$$$$$                        /$$    
| $$$ | $$                              | $$__  $$                      | $$    
| $$$$| $$  /$$$$$$   /$$$$$$  /$$$$$$$ | $$  \ $$  /$$$$$$   /$$$$$$  /$$$$$$  
| $$ $$ $$ /$$__  $$ /$$__  $$| $$__  $$| $$$$$$$  /$$__  $$ /$$__  $$|_  $$_/  
| $$  $$$$| $$$$$$$$| $$  \ $$| $$  \ $$| $$__  $$| $$  \ $$| $$  \ $$  | $$    
| $$\  $$$| $$_____/| $$  | $$| $$  | $$| $$  \ $$| $$  | $$| $$  | $$  | $$ /$$
| $$ \  $$|  $$$$$$$|  $$$$$$/| $$  | $$| $$$$$$$/|  $$$$$$/|  $$$$$$/  |  $$$$/
|__/  \__/ \_______/ \______/ |__/  |__/|_______/  \______/  \______/    \___/  
");

    Console.ForegroundColor= ConsoleColor.Cyan;
        Console.WriteLine(@"       
        ╔═══════════════════════╗
        ║Choose an Option       ║
        ║   1. Boot Into Bios   ║
        ║   2. Exit             ║
        ╚═══════════════════════╝ ");
        string OP = Console.ReadLine();
        Console.WriteLine("Where do you want to boot?");
        if (OP == "exit") { 
        Environment.Exit(0);
        } else if (OP == "1")
        {
            Console.Clear();
            Console.WriteLine("Getting perms...");
            Thread.Sleep(5000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Success! Rebooting to Bios");
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = "./RBoots/Boots/Excuteables/R2FW.exe";
            proc.Start();
        }
    }
}