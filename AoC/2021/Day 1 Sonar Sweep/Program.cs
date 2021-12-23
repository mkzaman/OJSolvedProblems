// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


string[] lines = File.ReadAllLines("input.txt");
List<int> depth = new List<int>();
int count = 0;
foreach (string line in lines)
{
    depth.Add(int.Parse(line));
}

for(int i = 1; i < depth.Count; i++)
{
    if(depth[i] > depth[i-1])
    {
        count++;
    }
}

count = 0;
for (int i = 0; i < depth.Count; i++)
{
    if(i+3 >= depth.Count)
    {
        break;
    }
    if(depth[i] + depth[i+1] + depth[i+2] < depth[i+1] + depth[i + 2] + depth[i + 3])
    {
        count++;
    }
}

Console.WriteLine(count);
    
