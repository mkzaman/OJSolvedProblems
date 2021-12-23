string[] lines = File.ReadAllLines("input.txt");

Int64 horizontal = 0;
Int64 vertical = 0;

string command =  string.Empty;
int value;
Int64 aim = 0;

//first part
foreach (string line in lines)
{
    var input = line.Split(' ');
    command = input[0];
    value = Convert.ToInt32(input[1]);

    if (string.Equals(command, "forward"))
    {
        horizontal += value;
    }
    else if (string.Equals(command, "up"))
    {
        vertical -= value;
    }
    else
    {
        vertical += value;
    }
}

Console.WriteLine(horizontal * vertical);

horizontal = 0;
vertical = 0;

//second part
foreach (string line in lines)
{
    var input = line.Split(' ');
    command = input[0];
    value = Convert.ToInt32(input[1]);
    if (string.Equals(command, "forward"))
    {
        horizontal += value;
        vertical += aim * value;
    }
    else if (string.Equals(command, "up"))
    {
        aim -= value;
    }
    else
    {
        aim += value;
    }
}

Console.WriteLine(horizontal*vertical);


