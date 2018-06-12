using System.Collections;
using System.Collections.Generic;
using BoardGameEngine;
using UnityEngine;

public class Main : MonoBehaviour {

	public GameObject boardObj;
	public GameObject firstPlayer;
	public GameObject secondPlayer;

	private GameController gameController;
	private CheckerRule checkerRule;
	private UnitFactory unitFactory;
	private CheckerBoard board;

	void Start ()
	{
		unitFactory = new UnitFactory();
		board = new CheckerBoard(unitFactory);
		checkerRule = new CheckerRule();

		BoardView boardView = boardObj.GetComponent<BoardView>();
		boardView.setBoard(board);

		gameController = new GameController(board, checkerRule);
		gameController.AddPlayer(firstPlayer.GetComponent<RealPlayer>());
		gameController.AddPlayer(secondPlayer.GetComponent<RealPlayer>());
	}
	
	void Update ()
	{
		
	}
}
