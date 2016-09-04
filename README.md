# lazywriter
An output stream that prints text to a console in a typewriter fashion :outbox_tray: :musical_keyboard: :flags: :computer: Inspired by various text based games :space_invader: :video_game:

[![gif with the typewriter effect][example]][example]

# requirements

- C# 6 :musical_note:

# sample usage

Default effects

[![gif with the typewriter effect][example]][example]

```csharp
static void Main(string[] args)
{
  LazyWriter.TypeWriter typewriter = new LazyWriter.TypeWriter();
  Console.SetOut(typewriter);
  Console.Write("Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...");
  Console.Write("There is no one who loves pain itself, who seeks after it and wants to have it, simply because it is pain...");
  Console.ReadKey();
}
```

Custom effects

[![gif with a custom typewriter effect][example-custom]][example-custom]

```csharp
static void Main(string[] args)
{
  LazyWriter.TypeWriter typewriter = new LazyWriter.TypeWriter(20, 50, 7);
  Console.SetOut(typewriter);
  Console.Write("Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...");
  Console.Write("There is no one who loves pain itself, who seeks after it and wants to have it, simply because it is pain...");
  Console.ReadKey();
}
```

Multiple effects

[![gif with a multiple typewriter effects][example-multiple]][example-multiple]

```csharp
static void Main(string[] args)
{
  LazyWriter.TypeWriter fast = new LazyWriter.TypeWriter(20, 50, 5);
  LazyWriter.TypeWriter slow = new LazyWriter.TypeWriter(60, 50, 5);
  Console.SetOut(fast);
  Console.Write("Neque porro quisquam est qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit...");
  Console.SetOut(slow);
  Console.Write("There is no one who loves pain itself, who seeks after it and wants to have it, simply because it is pain...");
  Console.ReadKey();
}
```

# license

project license can be found [here](LICENSE.md)

[example]:   https://github.com/joshschmelzle/lazywriter/blob/master/lazywriter.gif
[example-custom]:   https://github.com/joshschmelzle/lazywriter/blob/master/lazywriter-custom.gif
[example-multiple]:   https://github.com/joshschmelzle/lazywriter/blob/master/lazywriter-multiple.gif
