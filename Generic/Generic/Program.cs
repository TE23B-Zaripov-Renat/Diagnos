Enemy e1 = new();
List<string> enemies = new();

//Queue
Queue<string> customers = new();
customers.Enqueue("Micke");
customers.Enqueue("Hussein");
customers.Enqueue("Elis");
customers.Enqueue("Leon");

string next = customers.Dequeue();

// Stack
Stack<string> names = new();
names.Push("Micke");
names.Push("Alexander");
names.Push("Lukas");
names.Push("Renat");

string n = names.Pop();

Dictionary<string, string> words = new();

words["Skibidi"] = "Nonsensord, från början från en replåt";
words["6-7"] = "Nonsensord, från början från en replåt";
words["gyat"] = "Svärord";

Console.WriteLine(words["gyat"]);

Dictionary<string, int> stats = new();
stats["strenght"] = 34;
stats["lenght"] = 42;

Dictionary<Enemy, Enemy> loves = new();

Enemy e2 = new();
Enemy e3 = new();

loves[e2] = e3;

Dictionary<string, Action> actions = new();

actions["walk"] = () => { Console.WriteLine("WALK!"); };
actions["stand"] = () => { Console.WriteLine("STAND!"); };
actions["hello"] = Hello;

// foreach (string key in actions.Keys)
// {
//     Console.WriteLine(key);
// }

string doThing = Console.ReadLine();
if (actions.ContainsKey(doThing))
{
    actions[doThing]();
}

static void Hello()
{
    Console.WriteLine("HELLO!");
}
class Enemy
{
    public string Name;
}