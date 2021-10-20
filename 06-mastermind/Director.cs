using System;

namespace _06_mastermind
{
    class Director
    {
        private bool _keepPlaying = true;
        public void StartGame()
        {
            Board b = new Board();
            Player player1 = new Player();
            Player player2 = new Player();
            Mastermind codeMaster = new Mastermind();
            while (_keepPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        public void GetInputs()
        {

        }
        public void DoUpdates()
        {

        }
        public void DoOutputs()
        {

        }
    }
}