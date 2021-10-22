using System;

namespace _06_mastermind
{
    class Player
    {
        private String _name;
        private Mastermind _move;

        public Player(String name)
        {
            _name = name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetMove(Mastermind move)
        {
            _move = move;
        }

        public Mastermind GetMove()
        {
            return _move;
        }
    }
}
