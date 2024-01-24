using System;

namespace _04_hilo
{
    class Director
    {
        bool _keepPlaying = true;
        int _score = 375;
        Dealer _dealer = new Dealer();

        public void StartGame()
        {
            while (_keepPlaying)
            {
                DoUpdates();
                DoOutputs();
                if (_score > 0)
                {
                    GetInputs();
                }
                else
                {
                    Console.Write("You lost! Play again? [y/n]: ");
                    string choice = Console.ReadLine();
                    _keepPlaying = choice == "y" || choice == "Y";
                }
            }
        }

        void GetInputs()
        {
            _dealer._playerChoice = _dealer.GetPlayerInput();
        }

        void DoOutputs()
        {
            _dealer.DisplayCard();
            Console.WriteLine($"Your score is {_score}");
        }

        void DoUpdates()
        {
            _score = _score + _dealer.GetPoints();
        }
    }
}
