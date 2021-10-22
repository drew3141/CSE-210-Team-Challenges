using System;

namespace _06_mastermind
{
    class Director
    {
        //Creating objects/variables for director
        private bool _keepPlaying = true;
        private Board b = new Board();
        private Mastermind codeMaster = new Mastermind();
        private UserService userIO = new UserService();
        private Roster playerRoster = new Roster();
        private Player player1 = new Player("Player 1");
        private Player player2 = new Player("Player 2");
        

        public void StartGame()
        {
            player1.SetName(userIO.GetStringInput("Enter a name for player 1: "));
            player2.SetName(userIO.GetStringInput("Enter a name for player 2: "));
            playerRoster.AddPlayer(player1);
            playerRoster.AddPlayer(player2);
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
            playerRoster.AdvanceNextPlayer();
            //_keepPlaying = !(codeMaster.HasWon());
            //codeMaster.getHint();
        }
        public void DoOutputs()
        {
            //board.DisplayBoard();
            //
        }
    }
}