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
        private Board board;
    }

    public GameController(Board board)
    {
        this.board = board;
    }
}
