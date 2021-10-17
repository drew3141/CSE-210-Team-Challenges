using System;

namespace _05_jumper
{
    /// <summary>
    /// The director is responsible to direct the game, including to keep track of all
    /// the actors and to control the sequence of play.
    /// 
    /// Stereotype:
    ///     Controller
    /// </summary>
    public class Director
    {
        // In the future, we'll make some of these member variables/functions private,
        // but for now, we'll just make everything public, until we discuss it in more detail.
        public bool _keepPlaying;
        public Jumper _jumper;
        public WordBank _wordBank;
        public UserService _userService;

        /// <summary>
        /// Initializes the actors of the game.
        /// </summary>
        public Director()
        {
            _keepPlaying = true;
            _jumper = new Jumper();
            _wordBank = new WordBank();
            _userService = new UserService();
        }

        /// <summary>
        /// This method starts the game and continues running until it is finished.
        /// </summary>
        public void StartGame()
        {
            string message = _wordBank.SelectRandomWord();
            _jumper.initializeJumper();
            _jumper.DisplayText();

            while (_keepPlaying)
            {
                if (_wordBank.isGameWon())
                {
                    Console.WriteLine("You have safely landed!");
                    return;
                }
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
          
        }

        /// <summary>
        /// Get any input needed from the user.
        /// </summary>
        public void GetInputs()
        {
            
            _wordBank.DisplayWord();
            
            
        }

        /// <summary>
        /// Update any of the actors.
        /// </summary>
        public void DoUpdates()
        {
            string word = _userService.getUserInput();
            char letter = char.Parse(word);
            _wordBank.CheckInWord(letter);
            if (!_wordBank.CheckInWord(letter))
            {
                _jumper.IncrementGuess();
            }
            
            // Keep playing if the hider is not found (the ! symbol means not)
            _keepPlaying = _jumper.IsAlive();

        }

        /// <summary>
        /// Display the updated state of the game to the user.
        /// </summary>
        public void DoOutputs()
        {
            
            // old code
            //string hint = _hider.GetHint();
            _jumper.DisplayText();
        }
    }
}
