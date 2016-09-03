# lazywriter
An output stream that prints text to a console in a typewriter fashion :outbox_tray: :musical_keyboard: :flags: :computer: Inspired by various text based games :space_invader: :video_game:

[![gif with the typewriter effect][examples-link]][examples-link]

# requirements

- C# 6 :musical_note:

# sample usage

Default effects

```csharp
static void Main(string[] args)
{
  TypeWriter typewriter = new TypeWriter();
  Console.SetOut(typewriter);
  Console.Write("Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...");
  Console.Write("There is no one who loves pain itself, who seeks after it and wants to have it, simply because it is pain...");
  Console.ReadKey();
}
```

Custom effects

```csharp
static void Main(string[] args)
{
  TypeWriter typewriter = new TypeWriter(100, 100, 3);
  Console.SetOut(typewriter);
  Console.Write("Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...");
  Console.Write("There is no one who loves pain itself, who seeks after it and wants to have it, simply because it is pain...");
  Console.ReadKey();
}
```

# license

project license can be found [here](LICENSE.md)

[examples-link]:   https://github.com/joshschmelzle/lazywriter/blob/master/lazywriter.gif
