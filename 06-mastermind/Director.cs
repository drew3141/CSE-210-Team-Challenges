using System;

namespace _06_mastermind
{
    class Director
    {
        private bool _keepPlaying = true;
        public Director()
        {
            //Initial set-up for game
            Board b = new Board();
            UserService userIO = new UserService();
            Player player1 = new Player(userIO.GetStringInput("Enter a name for player 1: "));
            Player player2 = new Player(userIO.GetStringInput("Enter a name for player 2: "));
            Roster roster = new Roster();
            roster.AddPlayer(player1);
            roster.AddPlayer(player2);
            Mastermind codeMaster = new Mastermind();
        }
        public void StartGame()
        {
            
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
            roster.AdvanceNextPlayer();
        }
        public void DoOutputs()
        {

        }
    }
}