 public class Program
    {
        public static int ConvertToDecimal(string value)
        {
            return Convert.ToInt32(value, 2);
        }

        public static string Plus(string s1, string s2) 
        {
            return Convert.ToString(Convert.ToInt32(s1, 2) + Convert.ToInt32(s2, 2),2);
        }
        public static string Minus(string s1, string s2)
        {
            return Convert.ToString(Convert.ToInt32(s1, 2) - Convert.ToInt32(s2, 2), 2);
        }
        public static string Proizv(string s1, string s2)
        {
            return Convert.ToString(Convert.ToInt32(s1, 2) * Convert.ToInt32(s2, 2), 2);
        }
        public static string Del(string s1, string s2)
        {
            return Convert.ToString((int)(Convert.ToInt32(s1, 2) / Convert.ToInt32(s2, 2)), 2);
        }
        static void Main(string[] args)
        {
            
            try 
            {
                while (true)
                {
                    Console.WriteLine("Введите новое число (двоичное)");
                    string number = Console.ReadLine();
                    Console.WriteLine("Выберите операцию:" +
                                                    "\n-1 Сложение " +
                                                    "\n-2 Вычитание" +
                                                    "\n-3 Умножение" +
                                                    "\n-4 Деление" +
                                                    "\n-5 Перевод в десятичную систему начального числа" +
                                                    "\n-<ESC> для выхода из программы.");
                    ConsoleKey KeyPress = Console.ReadKey(true).Key;
                    switch (KeyPress)
                    {
                        case (ConsoleKey.D1):
                            {
                                Console.WriteLine($"Первое число : {number}");
                                Console.WriteLine("Введите второе число (двоичное)");
                                string secondNumber = Console.ReadLine();
                                Console.WriteLine($"Результат сложения: {Plus(number,secondNumber)}");
                                break;
                            }
                        case (ConsoleKey.D2):
                            {
                                Console.WriteLine($"Первое число : {number}");
                                Console.WriteLine("Введите второе число (двоичное)");
                                string secondNumber = Console.ReadLine();
                                Console.WriteLine($"Результат вычитания: {Minus(number, secondNumber)}");
                                
                                break;
                            }
                        case (ConsoleKey.D3):
                            {
                                Console.WriteLine($"Первое число : {number}");
                                Console.WriteLine("Введите второе число (двоичное)");
                                string secondNumber = Console.ReadLine();
                                Console.WriteLine($"Результат произведения: {Proizv(number, secondNumber)}");
                                break;
                            }
                        case (ConsoleKey.D4):
                            {
                                Console.WriteLine($"Первое число : {number}");
                                Console.WriteLine("Введите второе число (двоичное)");
                                string secondNumber = Console.ReadLine();
                                Console.WriteLine($"Результат деления: {Del(number, secondNumber)}");

                                break;
                            }
                        case (ConsoleKey.D5):
                            {
                                Console.WriteLine($"Результат перевода: {ConvertToDecimal(number)}");
                                break;
                            }
                        case (ConsoleKey.Escape):
                            {
                                Console.Clear();
                                Environment.Exit(0);  break;
                            }
                        default:
                            Console.Clear();
                            Console.WriteLine("Такой операции нету.");
                            break;
                    }
                }
            } catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            
        }
    }