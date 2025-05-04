using ideal_barnacle;
using System.Net.Sockets;
using System.Text;

if (args.Length == 0)
{
    Utils.ShowHelp();
    return;
}
if (args[0].ToLower() == "--help")
{
    Utils.ShowHelp();
    return;
}
if (args[0].ToLower() == "--version")
{
    Console.WriteLine("Ideal Barnacle version 1.0.0.0");
    Console.WriteLine("Copyright (C) 2025 Huseyin78112\r\n\r\n    This program is free software: you can redistribute it and/or modify\r\n    it under the terms of the GNU General Public License as published by\r\n    the Free Software Foundation, either version 3 of the License, or\r\n    (at your option) any later version.\r\n\r\n    This program is distributed in the hope that it will be useful,\r\n    but WITHOUT ANY WARRANTY; without even the implied warranty of\r\n    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the\r\n    GNU General Public License for more details.\r\n\r\n    You should have received a copy of the GNU General Public License\r\n    along with this program.  If not, see <https://www.gnu.org/licenses/>.");
    return;
}
string host = args[0];
int port = 80;
if (args.Length > 1)
{
    port = int.Parse(args[1]);
}
if (host.Contains(":"))
{
    Console.WriteLine("The host is invalid");
    return;
}
TcpClient client = new TcpClient();
Console.WriteLine("Connecting to {0}:{1}...", host, port);
try
{
    client.Connect(host, port);
    Console.WriteLine("Successfully connected to {0}:{1}.", host, port);
}
catch
{
    Console.WriteLine("Error connecting to {0}:{1}", host, port);
    return;
}
StringBuilder lines = new StringBuilder();
while (true)
{
    string line = Console.ReadLine();
    if (line == null)
    {
        break;
    }
    lines.AppendLine(line);
}
Console.WriteLine("Your request has been processed. Press Ctrl+C to stop receiving response.");
string full = lines.ToString();
byte[] bytes = Encoding.UTF8.GetBytes(full);
NetworkStream ns = client.GetStream();
ns.Write(bytes, 0, bytes.Length);
while (true)
{
    if (client.Connected)
    {
        if (ns.DataAvailable)
        {
            byte[] b = new byte[client.Available];
            ns.Read(b, 0, b.Length);
            string response = Encoding.UTF8.GetString(b);
            Console.WriteLine(response);
        }
    }
    else
    {
        return;
    }
}