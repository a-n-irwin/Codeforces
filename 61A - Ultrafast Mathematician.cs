// 176976036  Oct. 19 2022 10:51:25  Accepted -> 46ms 0kb 
string a = Console.ReadLine();
string b = Console.ReadLine();

for (int i = 0; i < a.Length; ++i)
{
    Console.Write((a[i]-48)^(b[i]-48));
}
