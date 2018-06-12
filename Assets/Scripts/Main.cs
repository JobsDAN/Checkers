using System.Collections;
using System.Collections.Generic;
using BoardGameEngine;
using UnityEngine;

public class Main : MonoBehaviour {

	public GameObject boardObj;

	private GameController gameController;
	private UnitFactory unitFactory;
	private CheckerBoard board;

	void Start ()
	{
		unitFactory = new UnitFactory();
		board = new CheckerBoard(unitFactory);

		BoardView boardView = boardObj.GetComponent<BoardView>();
		boardView.setBoard(board);

		gameController = new GameController(board);
	}
	
	void Update ()
	{
		
	}
}
