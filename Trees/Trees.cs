
namespace trees
{
    public class Trees
    {
        public string? Name;
        public double Pay { get; set; }
        public Trees? Left { get; set; }
        public Trees? Right { get; set; }

        public void Traverse(Trees root)
        {
            if (root.Left != null)
            {
                Traverse(root.Left);
            }
            Console.WriteLine($" Имя - {root.Name}, Зарплата - {root.Pay}");
            if (root.Right != null)
            {
                Traverse(root.Right);
            }
        }

        public Trees FindNode(Trees root, double number)
        {
            if (number < root.Pay)
            {
                if (root.Left != null)
                {
                    return FindNode(root.Left, number);
                }
                return null;
            }
            if (number > root.Pay)
            {
                if (root.Right != null)
                {
                    return FindNode(root.Right, number);
                }
                return null;
            }
            return root;
        }

        public void AddNode(Trees root, Trees toAdd)
        {
            if (toAdd.Pay < root.Pay)
            {
                if (root.Left != null)
                {
                    AddNode(root.Left, toAdd);
                }
                else
                {
                    root.Left = toAdd;
                }
            }
            else
            {
                if (root.Right != null)
                {
                    AddNode(root.Right, toAdd);
                }
                else
                {
                    root.Right = toAdd;
                }
            }
        }

        public void Search(Trees root)
        {
            Console.WriteLine("Введите ЗП для поиска");
            var input = Console.ReadLine();
            var search = double.Parse(input);
            var node = FindNode(root, search);
            if (node == null)
            {
                Console.WriteLine("Не найдено");
            }
            else
            {
                Console.WriteLine($"Find {node.Pay}, Имя: {node.Name}");
            }
        }
    }
}
