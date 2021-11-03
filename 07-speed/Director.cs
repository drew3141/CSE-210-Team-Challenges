using System;

namespace _07_speed
{
    class Director
    {
        OutputService _outputService = new OutputService();
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
             _outputService.OpenWindow(Constants.MAX_X, Constants.MAX_Y, "Hello", Constants.FRAME_RATE);
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