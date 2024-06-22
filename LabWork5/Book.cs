namespace LabWork5
{
    class Book
    {
        //Task1
        private string _name;
        private string _author;
        private int _price;

        public Book()
             : this("Неизвестно", "Неизвестно", 0)
        {
        }

        public Book(string name, string author, int price)
        {
            _name = name;
            _author = author;
            _price = price;
        }

        //Task2
        public void Print()
        {
            Console.WriteLine($"Название: {_name}, Автор: {_author}, Цена: {_price}");
        }

        //Task3
        public string GetTitle
        {
            get { return _name; }
            set
            {
                if (_name.Length < 0)
                {
                    throw new ArgumentException("Название не может быть пустым");
                }
            }
        }

        public string GetAuthor
        {
            get { return _author; }
            set
            {
                if (_author.Length < 0)
                {
                    throw new ArgumentException("Автор не может быть пустым.");
                }
            }
        }

        public int GetPrice
        {
            get { return _price; }
            set
            {
                if (_price < 0)
                {
                    throw new ArgumentException("Цена не может быть меньше 0.");
                }
            }
        }
    }
}


