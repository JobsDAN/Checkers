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

        Cell selected;

        public GameController(Board board, IRule rule)
        {
            this.board = board;
            this.rule = rule;
            this.selected = null;
        }

        public void addPlayer(IPlayer p)
        {
            if (players.Count == 0) {
                currentPlayer = p;
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

            turn.perform(board);
            bool isEnd = rule.checkEnd(board);
            if (isEnd) {
                int cur = players.IndexOf(currentPlayer);
                int next = (cur + 1) % players.Count;
                currentPlayer = players[next];
            }
        }
    }
}
