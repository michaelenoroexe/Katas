using System;
using System.Collections.Generic;

uint value = 4325763;
string value2 = Convert.ToString(value, 2);
int moresymbl = 32 - value2.Length;
var ints = new List<string>();

for (int i = 0; i < moresymbl; i++)
{
    value2 = "0" + value2;
}
for (int i = 0; i < 32; i += 8)
{
    ints.Add(Convert.ToInt32(value2.Substring(i, 8), 2).ToString());
}

string ip = String.Join(".", ints);

Console.WriteLine(ip);


