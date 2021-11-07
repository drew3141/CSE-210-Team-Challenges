using System;

namespace _07_speed
{
    public class Director
    {
        OutputService _outputService = new OutputService();
        InputService _inputService = new InputService();
        
        private bool _keepPlaying = true;
        Word word1 = new Word();
        Word word2 = new Word();
        Word word3 = new Word();

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
            word1.MoveWord();
            word2.MoveWord();
            word3.MoveWord();
        }

        public void DoOutputs()
        {
            _outputService.StartDrawing();
            _outputService.DrawText(word1.GetX(), word1.GetY(), word1.GetText(), true);
            _outputService.DrawText(word2.GetX(), word2.GetY(), word2.GetText(), true);
            _outputService.DrawText(word3.GetX(), word3.GetY(), word3.GetText(), true);

            _outputService.EndDrawing();
        }
    }
}