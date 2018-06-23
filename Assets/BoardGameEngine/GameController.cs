using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BoardGameEngine;

namespace BoardGameEngine
{
    class GameController
    {
        private List<IRule> rules;
        private List<IPlayer> players;
        private IBoard board;

        public GameController(IBoard board, List<IPlayer> players)
        {
            this.board = board;
            this.players = players;
            for (int i = 0; i < this.players.Count; i++)
                players[i].cellSelected += onCellSelected;
        }

        private void onCellSelected(Cell cell)
        {
            Debug.Log(cell.horizontalPos + " " + cell.verticalPos);
        }
    }
}
