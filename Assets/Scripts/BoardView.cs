using System.Collections;
using System.Collections.Generic;
using BoardGameEngine;
using UnityEngine;

public class BoardView : MonoBehaviour {
	private IBoard board;

    [SerializeField]
    private GameObject whiteChecker;
    [SerializeField]
    private GameObject blackChecker;

	public void setBoard(IBoard board) {
		this.board = board;
        board.boardRecreated += onBoardRecreated;
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public Cell getCellAtPoint(Vector3 point)
    {
        Collider collider = GetComponent<Collider>();
        Vector3 boardSize = collider.bounds.size;
        float invCellSize = 8 / boardSize.x;
        int horPos = (int)((point.x - collider.bounds.min.x) * invCellSize);
        int vertPos = (int)((point.z - collider.bounds.min.z) * invCellSize);

        if (horPos < 0 || 7 < horPos)
            return null;
        if (vertPos < 0 || 7 < vertPos)
            return null;
        
        return board.Cells[vertPos, horPos];
    }

    private void onBoardRecreated(Cell[,] cells)
    {
        Collider collider = GetComponent<Collider>();
        Vector3 boardSize = collider.bounds.size;
        Vector3 offset = collider.bounds.min;
        float cellSize = boardSize.x / 8;
        float halfCellSize = cellSize / 2;

        for (int i = 0; i < cells.GetLength(0); i++)
        {
            for (int j = 0; j < cells.GetLength(1); j++)
            {
                if (cells[i, j].unit == null)
                    continue;

                Vector3 worldPos = new Vector3(cells[i, j].horizontalPos * cellSize + halfCellSize,
                                               0.25f,
                                               cells[i, j].verticalPos * cellSize + halfCellSize);
                worldPos += offset;

                if (cells[i, j].unit.unitType == Unit.UnitType.WhiteMen)
                    Instantiate(whiteChecker, worldPos, Quaternion.Euler(90, 0, 0));
                else
                    Instantiate(blackChecker, worldPos, Quaternion.Euler(90, 0, 0));
            }
        }
    }
}
