using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using BoardGameEngine;


public class RealPlayer : MonoBehaviour, IPlayer
{
    public event CellCelected cellSelected;
    private new Camera camera;

    [SerializeField]
    private BoardView boardView;

    private void Start()
    {
        camera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonUp(0)) {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit)) {
                Vector3 hitPoint = hit.point;

                Cell selectedCell = boardView.getCellAtPoint(hitPoint);
                if (selectedCell != null && cellSelected != null)
                {
                    cellSelected(selectedCell);
                }
            }
        }
    }
}
