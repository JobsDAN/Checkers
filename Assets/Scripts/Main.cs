using System.Collections;
using System.Collections.Generic;
using BoardGameEngine;
using UnityEngine;

public class Main : MonoBehaviour {

	// TODO: Remove
	private class GameController {
		public GameController(Board b) { }
	}

	private interface IUnit {
	}

	private class Unit {
	}

	public GameObject boardObj;

	private GameController gameController;
	private UnitFactory unitFactory;
	private CheckerBoard board;

	// Use this for initialization
	void Start () {
		unitFactory = new UnitFactory();
		board = new CheckerBoard(unitFactory);

		BoardView boardView = boardObj.GetComponent<BoardView>();
		boardView.setBoard(board);

		gameController = new GameController(board);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
