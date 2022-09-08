using static System.Console;

string[] names = new[] {
    "Michael", "Pam", "Jimmy", "Dwight", "Angela", "Kevin", "Toby", "Creed"
};

WriteLine("Deferred execution");

var query1 = names.Where(name => name.EndsWith("m"));

string[] result = query1.ToArray();
foreach (string name in query1) {
    WriteLine(name);
}
