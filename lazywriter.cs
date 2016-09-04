namespace LazyWriter
{
    using System;
    using System.IO;
    using System.Text;
    using System.Threading;

    /// <summary>
    /// A class based on System.IO.TextWriter for a TypeWriter type effect for Console text output. 
    /// </summary>
    public class TypeWriter : System.IO.TextWriter
    {
        /// <summary>
        /// The typewriter output stream.
        /// </summary>
        private TextWriter originalOut;

        /// <summary>
        /// Initializes a new instance of the <see cref="TypeWriter"/> class. This instance has the default TypeWriter effects.
        /// </summary>
        public TypeWriter()
        {
            this.originalOut = Console.Out;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypeWriter"/> class. 
        /// </summary>
        /// <param name="typingSpeed">Sets the typewriter speed</param>
        /// <param name="spinnerSpeed">Sets the spinner speed</param>
        /// <param name="spins">Sets the number of spins</param>
        public TypeWriter(int typingSpeed, int spinnerSpeed, int spins)
        {
            this.TypingSpeed = typingSpeed;
            this.SpinnerSpeed = spinnerSpeed;
            this.Spins = spins;
            this.originalOut = Console.Out;
        }

        /// <summary>
        /// A read-only property for the default encoding.
        /// </summary>
        public override Encoding Encoding
        {
            get { return Encoding.Default; }
        }

        /// <summary>
        /// Gets or sets the typewriter speed in milliseconds
        /// </summary>
        private int TypingSpeed { get; set; } = 25;

        /// <summary>
        /// Gets or sets the speed of the spinner animation in milliseconds
        /// </summary>
        private int SpinnerSpeed { get; set; } = 75;

        /// <summary>
        /// Gets or sets the number of spins for the spinner animation
        /// </summary>
        private int Spins { get; set; } = 5;
        
        /// <summary>
        /// Overrides the default Console.Write to provide a typewriter type effect.
        /// </summary>
        /// <param name="message">The text to output to the console.</param>
        public override void Write(string message)
        {
            foreach (char c in message)
            {
                this.originalOut.Write(c);

                if (!Console.KeyAvailable)
                {
                    Thread.Sleep(this.TypingSpeed);
                }
            }

            if (Console.KeyAvailable)
            {
                Console.ReadKey();
            }

            this.Spin();

            if (Console.KeyAvailable)
            {
                Console.ReadKey();
            }

            this.originalOut.WriteLine();
        }

        /// <summary>
        /// Overrides the default Console.WriteLine to provide a typewriter type effect.
        /// </summary>
        /// <param name="message">The text to output to the console.</param>
        public override void WriteLine(string message)
        {
            foreach (char c in message)
            {
                this.originalOut.Write(c);

                if (!Console.KeyAvailable)
                {
                    Thread.Sleep(this.TypingSpeed);
                }
            }

            if (Console.KeyAvailable)
            {
                Console.ReadKey();
            }

            this.Spin();

            if (Console.KeyAvailable)
            {
                Console.ReadKey();
            }

            this.originalOut.WriteLine();
        }

        /// <summary>
        /// Creates the spinning animation at the end of a line.
        /// </summary>
        private void Spin()
        {
            Console.CursorVisible = false;

            for (int i = 0; i < this.Spins; i++)
            {
                this.originalOut.Write(@"-");
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                if (this.SpinInterrupted())
                {
                    break;
                }

                this.originalOut.Write(@"\");
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                if (this.SpinInterrupted())
                {
                    break;
                }

                this.originalOut.Write(@"|");
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                if (this.SpinInterrupted())
                {
                    break;
                }

                this.originalOut.Write(@"/");
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                if (this.SpinInterrupted())
                {
                    break;
                }
            }

            this.originalOut.Write(" ");
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);

            Console.CursorVisible = true;
        }

        /// <summary>
        /// Determines if a key is pressed and if so stops the typewriter effect.
        /// </summary>
        /// <returns>True or false</returns>
        private bool SpinInterrupted()
        {
            if (!Console.KeyAvailable)
            {
                Thread.Sleep(this.SpinnerSpeed);
                return false;
            }
            else
            {
                this.originalOut.Write(" ");
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                return true;
            }
        }
    }
}
