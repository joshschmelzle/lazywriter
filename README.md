# lazywriter
An output stream that prints text to a console in a typewriter fashion :outbox_tray: :musical_keyboard: :flags: :computer:. Inspired by various text based games :space_invader: :video_game:. 

# requirements

- C#

# sample usage

```
static int Main(string[] args)
{
  TypeWriter typewriter = new TypeWriter();
  Console.SetOut(typewriter);
  Console.WriteLine("Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...");
  Console.WriteLine("There is no one who loves pain itself, who seeks after it and wants to have it, simply because it is pain...");
  Console.ReadKey();
  return 0;
}
```

# license

project license can be found [here](LICENSE.md)
