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
        private Player player1 = new Player();
        private Player player2 = new Player();

        public void StartGame()
        {
            player1.SetName(userIO.GetStringInput("Enter a name for player 1: "));
            player2.SetName(userIO.GetStringInput("Enter a name for player 2: "));
            playerRoster.AddPlayer(player1);
            playerRoster.AddPlayer(player2);
            codeMaster.setCode();
            DoOutputs();
            while (_keepPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
            Console.WriteLine($"{playerRoster.GetCurrentPlayer().GetName()} wins!");
        }

        public void GetInputs()
        {
            codeMaster.setGuess(userIO.GetStringInput($"{playerRoster.GetCurrentPlayer().GetName()}, please enter your guess: "));
        }
        public void DoUpdates()
        {
            playerRoster.GetCurrentPlayer().SetGuess(codeMaster.getGuess());
            codeMaster.setHint();
            _keepPlaying = !(codeMaster.hasWon());
            playerRoster.AdvanceNextPlayer();
        }
        public void DoOutputs()
        {
            if (playerRoster.GetCurrentPlayer() == player2)
            {
                b.displayBoard(player1, player2, codeMaster);
            }
            else
            {
                b.displayBoard(player2, player1, codeMaster);
            }
        }
    }
}