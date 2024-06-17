namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine();
            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void DrawScreen()
        {
            DrawLine();

            for (int lines = 0; lines <= 11; lines++)
            {
                Console.Write("|");

                for (int i = 0; i <= 30; i++)
                {
                    Console.Write(" ");
                }

                Console.Write("|");
                Console.Write("\n");
            }

            DrawLine();
        }

        public static void DrawLine()
        {
            Console.Write("+");

            for (int i = 0; i <= 30; i++)
            {
                Console.Write("-");
            }

            Console.Write("+");
            Console.Write("\n");
        }
    
        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("============");
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 10);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 12);
            Console.Write("Opção: ");
        }
    
        public static void HandleMenuOption(short option) // Handle = manipular
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Editor.Abrir(); break;
                case 0: {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
                default: Show(); break;
            }
        }
    }
}