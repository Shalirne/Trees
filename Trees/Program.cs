
namespace trees
{
    class Program
    {
        static void Main()
        {
            string name;
            string pay;
            Console.WriteLine("Введите имя сотрудника и его зарплату. Для того, чтобы выйти введите пустую строку в графе 'Имя Сотрудника'");
            Trees? root = new Trees();
            root = null;
            do
            {
                Console.WriteLine("Введите имя сотрудника");
                name = Console.ReadLine();
                if (name.Length == 0)
                {
                    break;
                }
                Console.WriteLine("Введите зарплату сотрудника ");
                pay = Console.ReadLine();
                if (root == null)
                {
                    root = new Trees()
                    {
                        Name = name,
                        Pay = double.Parse(pay)
                    };
                }
                else
                {
                    root.AddNode(root, new Trees
                    {
                        Name = name,
                        Pay = double.Parse(pay)
                    });
                }
            }
            while (name != "");
            {
                root.Traverse(root);
                root.Search(root);
                while (true)
                {
                    Console.WriteLine("Введите 0, чтобы перейти к началу программы (бинарное дерево очиститься)");
                    Console.WriteLine("Введите 1, чтобы перейти к поиску зарплаты");
                    var input = Console.ReadLine();
                    if (input == "0")
                    {
                        Main();
                    }
                    else if (input == "1")
                    {
                        root.Search(root);
                    }
                }
            }
        }

    }
}