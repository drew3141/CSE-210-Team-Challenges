using System;

namespace _04_hilo
{
    class Dealer
    {
        public int _Card = 0;
        public string _playerChoice = "";
        public int PushCard()
        {
            Random randomGenerator = new Random();
            _Card = randomGenerator.Next(1, 14);
            return _Card;
        }

        public void DisplayCard()
        {
            if (_Card == 0)
            {
                PushCard();
            }

            if (_Card <= 10 && _Card != 1)
            {
                Console.WriteLine($"The card is {_Card}.");
            }
            else
            {
                switch (_Card)
                {
                    case 11:
                        Console.WriteLine("The card is a Jack.");
                        break;
                    case 12:
                        Console.WriteLine("The card is a Queen.");
                        break;
                    case 13:
                        Console.WriteLine("The card is a King.");
                        break;
                    case 1:
                        Console.WriteLine("The card is an Ace.");
                        break;
                    default:
                        break;
                }
            }
        }

        public string GetPlayerInput()
        {
            Console.Write("Is card higher or lower (h/l)?: ");
            _playerChoice = Console.ReadLine().ToLower();
            return _playerChoice;
        }

        public int GetPoints()
        {
            int lastCard = _Card;
            PushCard();
            if (_playerChoice == "h")
            {
                if (_Card > lastCard)
                {
                    return 100;
                }
                else
                {
                    return -75;
                }
            }
            else if (_playerChoice == "l")
            {
                if (_Card < lastCard)
                {
                    return 100;
                }
                else
                {
                    return -75;
                }
            }
            return -75;
        }
    }
}