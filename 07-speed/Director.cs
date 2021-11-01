using System;

namespace _07_speed
{
    class Director
    {
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