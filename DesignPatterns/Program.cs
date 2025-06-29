
#region MementoDP
/*using DesignPatterns.Memento;

var editor = new Editor();
var history = new History();

editor.Write("Hello");
history.Save(editor.Save());

editor.Write(", World!");
history.Save(editor.Save());

editor.Write(" This is the Memento pattern.");
Console.WriteLine("Current Content: " + editor.Content);

editor.Restore(history.Undo());
Console.WriteLine("After Undo 1: " + editor.Content);

editor.Restore(history.Undo());
Console.WriteLine("After Undo 2: " + editor.Content);*/
#endregion

#region StateDP
/*using DesignPatterns.Behavioral.State;

var document = new Document(UserRoles.EDITOR);

Console.WriteLine("Current State: Draft");
document.Publish();

Console.WriteLine("Current State: Moderation");
document.CurrentUserRole = UserRoles.ADMIN;
document.Publish(); 

Console.WriteLine("Current State: Published");
document.Publish(); */
#endregion

#region Visitor
/*using DesignPatterns.Behavioral.Visitor.GoodExample;
var clients = new List<Client>() {
    new Restaurant("Resto", "resto@gmail.com"),
    new Retail("Retail", "retail@hotmail.fr"),
    new Law("law", "law@mail.com")
};
foreach (var client in clients)
{
    client.Accept(new EmailVisitor());
    client.Accept(new PDFExportVisitor());
}*/
#endregion


#region Command
/*using DesignPatterns.Behavioral.Command.GoodExample;
Light light = new Light();
ICommand turnOn = new TurnOnCommand(light);
ICommand turnOff = new TurnOffCommand(light);
RemoteControl remoteControl = new RemoteControl(turnOn);
remoteControl.PressButton();
remoteControl.SetCommand(turnOff);
remoteControl.PressButton();*/
#endregion


#region singleton
/*using DesignPatterns.Creational.FactoryMethod.LoggingSystem;
using DesignPatterns.Creational.Singleton.DataBaseConnectionManager;
void AccessDatabase(string query)
{
    var dbManager = DbManager.Instance;
    dbManager.OpenConnection();
    dbManager.ExecuteQuery(query);
    dbManager.CloseConnection();

}

Console.WriteLine("[Main] Simulating multi-threaded database access...");
Thread thread1 = new Thread(() => AccessDatabase("SELECT * FROM Users"));
Thread thread2 = new Thread(() => AccessDatabase("INSERT INTO Logs VALUES ('User logged in')"));
Thread thread3 = new Thread(() => AccessDatabase("UPDATE Orders SET Status='Completed' WHERE Id=5"));

thread1.Start();
thread2.Start();
thread3.Start();

thread1.Join();
thread2.Join();
thread3.Join();

Console.WriteLine("[Main] All database operations completed.");*/

#endregion

#region Singleton
/*using DesignPatterns.Creational.FactoryMethod.LoggingSystem;

string environment = "Development"; // This could come from config
ILogger logger = LoggerFactory.CreateLogger(environment);

logger.Log("This is a log message!");*/
#endregion

#region AbstractFacotry
/*/ Create a light-themed UI
using DesignPatterns.Creational.AbstractFactory.UIlibrary;

IGUIFactory lightFactory = new LightThemeFactory();
Client lightClient = new Client(lightFactory);
lightClient.RenderUI();

// Create a dark-themed UI
IGUIFactory darkFactory = new DarkThemeFactory();
Client darkClient = new Client(darkFactory);
darkClient.RenderUI();*/
#endregion

#region Builder
// Customer 1: Wants a full deluxe burger
using DesignPatterns.Creational.Builder;

var deluxeBurger = new BurgerBuilder()
    .SetBun("Sesame")
    .SetPatty("Beef")
    .AddCheese()
    .AddLettuce()
    .AddTomato()
    .Build();

Console.WriteLine(deluxeBurger);

// Customer 2: Wants a basic cheeseburger
var cheeseBurger = new BurgerBuilder()
    .SetBun("Regular")
    .SetPatty("Chicken")
    .AddCheese()
    .Build();

Console.WriteLine(cheeseBurger);
#endregion