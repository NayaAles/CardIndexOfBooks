using System;

namespace СпецификацияМеню
{
    internal class Program
    {
        class Books
        {
            private string id;
            private string name;
            private string autor;
            public Books()
            {
                id = "id";
                name = "name";
                autor = "autor";
            }
            public Books (string id, string name, string autor)
            {
                this.id = id;
                this.name = name;
                this.autor = autor;
            }
            public void print()
            {
                Console.WriteLine(id);
                Console.WriteLine("Наименование: " + name);
                Console.WriteLine("Автор: " + autor);
                Console.WriteLine();
            }
            public string write_data()
            {
                string item = id + ";" + name + "," + autor + ",";
                return item;
            }
        }

        static void Main(string[] args)
        {
            int input = 0;
            string info = " ";
            string data = " ";

            Menu();
            input = Convert.ToInt32(Console.ReadLine());

            void Menu()
            {
                Console.Clear();
                string[] a = { "Книги", "Пользователи" };
                for (int i = 0; i < a.Length; i++)
                    Console.WriteLine("\n{0}. {1}", i, a[i]);
                Menu2(Convert.ToInt32(Console.ReadLine()));
            }
            void Menu2(int input)
            {
                switch (input)
                {
                    case 0:
                        string[] b = { "Название", "Жанр" };
                        for (int i = 0; i < b.Length; i++)
                            Console.WriteLine("{0}. {1}", i, b[i]);
                        Menu_Books();
                        break;
                    case 1:
                        string[] c = { "dsfsdsfsf" };
                        for (int i = 0; i < c.Length; i++)
                            Console.WriteLine("{0}. {1}", i, c[i]);
                        break;
                        Exit();
                        void Exit() => Console.WriteLine("Для выхода нажмите любую клавишу");
                        break;
                    default:
                        Console.WriteLine("Ошибка ввода");
                        break;

                        void Menu_Books()
                        {
                            //Наполенение в точности как выше
                        }

                        void Books_Info() //Запись в ...
                        {
                            Console.Clear();
                            Console.Write("Введите данные: ");
                            info = Convert.ToString(Console.ReadLine());
                            Console.Write("Дата: ");
                            data = Convert.ToString(Console.ReadLine());
                            if (info.Length>3) Console.Write("Запись совершена");
                            else Console.WriteLine("Записи нет");
                            Menu();
                        }
                }
            }
        }
    }
}
