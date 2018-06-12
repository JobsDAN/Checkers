using System.Collections;
using System.Collections.Generic;
using BoardGameEngine;
using UnityEngine;

public class BoardView : MonoBehaviour {
	private Board board;

	public void setBoard(Board board) {
		this.board = board;
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

        return board.Cells[horPos, vertPos];
    }
}
