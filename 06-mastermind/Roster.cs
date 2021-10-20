using System;
using System.Collections.Generic;

namespace _06_mastermind
{
    class Roster
    {
        private int _currentPlayerIndex = 0;
        private List<Player> _players = new List<Player>();

        public void AddPlayer(Player player)
        {
            _players.Add(player);
        }

        public Player GetCurrentPlayer()
        {
            return _players[_currentPlayerIndex];
        }

        public void AdvanceNextPlayer()
        {
            _currentPlayerIndex = (_currentPlayerIndex + 1) % _players.Count;
        }
    }
}