using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using BoardGameEngine;


public class RealPlayer : MonoBehaviour, IPlayer
{
    public bool Active { get; set; }
    public event CellSelected CellSelected;
    public event CellSelected DoEvent;
    private new Camera camera;

    [SerializeField]
    private BoardView boardView;

    private static float nextClick = 0.0f;
    private const float ClickCoolDown = 0.2f;

    private void Start()
    {
        camera = Camera.main;
    }

    private void Update()
    {
        if (!Active || Time.time < nextClick) {
            return;
        }

        Action<Cell> action;
        if (Input.GetMouseButton(0)) {
            action = (Cell cell) => { CellSelected(cell); };
        } else if (Input.GetMouseButton(1)) {
            action = (Cell cell) => { DoEvent(cell); };
        } else {
            return;
        }

        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (!Physics.Raycast(ray, out hit)) {
            return;
        }

        Vector3 hitPoint = hit.point;
        Cell selectedCell = boardView.getCellAtPoint(hitPoint);
        if (selectedCell == null) {
            return;
        }

        Debug.Log(selectedCell.horizontalPos + " " + selectedCell.verticalPos);
        if (action == null) {
            return;
        }

        action(selectedCell);
        nextClick = Time.time + ClickCoolDown;
    }
}
