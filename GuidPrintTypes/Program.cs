var guid = Guid.NewGuid();

// 7abc2783-11d7-4e08-9d9c-0af4bdba1f92
Console.WriteLine(guid.ToString("D"));

// 7abc278311d74e089d9c0af4bdba1f92
Console.WriteLine(guid.ToString("N"));

// {7abc2783-11d7-4e08-9d9c-0af4bdba1f92}
Console.WriteLine(guid.ToString("B"));

// (7abc2783-11d7-4e08-9d9c-0af4bdba1f92)
Console.WriteLine(guid.ToString("P"));

// {0x7abc2783,0x11d7,0x4e08,{0x9d,0x9c,0x0a,0xf4,0xbd,0xba,0x1f,0x92}}
Console.WriteLine(guid.ToString("X"));