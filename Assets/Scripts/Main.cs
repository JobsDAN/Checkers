using System.Collections;
using System.Collections.Generic;
using BoardGameEngine;
using UnityEngine;

public class Main : MonoBehaviour {

	public GameObject boardObj;

	private GameController gameController;
	private UnitFactory unitFactory;
	private CheckerBoard board;

    private BoardView boardView;

    [SerializeField]
    private RealPlayer player1;
    [SerializeField]
    private GameObject selectedCellSprite;

    private GameObject selectedCell;



	void Start ()
	{
		unitFactory = new UnitFactory();
		board = new CheckerBoard(unitFactory);

		boardView = boardObj.GetComponent<BoardView>();
		boardView.setBoard(board);
        board.recreate();

        player1.cellSelected += onCellSelected;

		gameController = new GameController(board, new List<IPlayer>() { player1 });
	}
	
	void Update ()
	{
		
	}

    private void onCellSelected(Cell cell)
    {
        if (cell.unit == null)
        {
            if (selectedCell != null)
                Destroy(selectedCell);
            return;
        }

        Collider collider = boardView.GetComponent<Collider>();
        Vector3 boardSize = collider.bounds.size;
        Vector3 offset = collider.bounds.min;
        float cellSize = boardSize.x / 8;
        float halfCellSize = cellSize / 2;

        Vector3 worldPos = new Vector3(cell.horizontalPos * cellSize + halfCellSize,
                                       0.2f,
                                       cell.verticalPos * cellSize + halfCellSize);
        worldPos += offset;

        if (selectedCell != null)
            Destroy(selectedCell);
        selectedCell = Instantiate(selectedCellSprite, worldPos, Quaternion.Euler(90, 0, 0));
    }
}
