using System.Collections;
using System.Collections.Generic;
using BoardGameEngine;

namespace BoardGameEngine
{
    class GameController
    {
        private IRule rule;
        private List<IPlayer> players;
        private IPlayer currentPlayer;
        private Board board;
        private Cell selected;

        public GameController(Board board, IRule rule)
        {
            this.rule = rule;
            this.players = new List<IPlayer>();
            this.currentPlayer = null;
            this.board = board;
            this.selected = null;
        }

        public void AddPlayer(IPlayer p)
        {
            if (players.Count == 0) {
                currentPlayer = p;
                currentPlayer.Active = true;
            }

            players.Add(p);
            p.CellSelected += onSelect;
            p.DoEvent += onDo;
        }

        private void onSelect(Cell cell)
        {
            if (cell.unit == null) {
                cell = null;
            }

            selected = cell;
        }

        private void onDo(Cell to)
        {
            ITurn turn = rule.checkTurn(board, selected, to);
            if (turn == null) {
                selected = null;
                return;
            }

            turn.Perform(board);
            bool isEnd = rule.checkEnd(board);
            if (isEnd) {
                int cur = players.IndexOf(currentPlayer);
                int next = (cur + 1) % players.Count;
                currentPlayer.Active = false;
                currentPlayer = players[next];
                currentPlayer.Active = true;
            }
        }
    }
}
