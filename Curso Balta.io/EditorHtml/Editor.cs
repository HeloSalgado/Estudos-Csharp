using System.Text;

namespace EditorHtml
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("-----------");

            Start();
        }

        public static void Start()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Viewer.Show(file.ToString());

            Console.WriteLine("-----------");
            Console.WriteLine(" Deseja salvar o arquivo? (y/n)");
            var escolha = Console.ReadLine();

            switch (escolha)
            {
                case "y": Salvar(file); break;
                case "n": Menu.Show(); break;
                default: Start(); break;
            }
        }

        public static void Salvar(StringBuilder file)
        {
            Console.WriteLine("Qual caminho deseja salvar?");
            var path = Console.ReadLine();
            
            using (var arquivo = new StreamWriter(path))
            {
                arquivo.Write(file);
            }

            Console.WriteLine(string.Format("O arquivo {0} foi salvo com sucesso!", path));
            Console.ReadLine();
            Menu.Show();
        }

        public static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Qual o  caminho que deseja abrir?");
            var path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                Console.WriteLine(file.ReadToEnd());
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu.Show();
        }
    }
}