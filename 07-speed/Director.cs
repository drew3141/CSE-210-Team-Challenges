using System;

namespace _07_speed
{
    public class Director
    {
        OutputService _outputService = new OutputService();
        InputService _inputService = new InputService();
        WordBank _words = new WordBank();
        private bool _keepPlaying = true;
        public void StartGame()
        {
            Setup();
            while (_keepPlaying)
            {
                DoOutputs();
                GetInputs();
                DoUpdates();
            }
        }

        public void Setup()
        {
            _outputService.OpenWindow(Constants.MAX_X, Constants.MAX_Y, "Speed Game", Constants.FRAME_RATE);
            _words.SelectRandomWord();
            
        }

        public void GetInputs()
        {
            if (_inputService.IsWindowClosing())
            {
                _keepPlaying = false;
            }
        }

        public void DoUpdates()
        {

        }

        public void DoOutputs()
        {
            _outputService.StartDrawing();
            _outputService.DrawText(Constants.MAX_X/2,Constants.MAX_Y/2,_words.GetWord(), true);
            _outputService.EndDrawing();
        }
    }
}