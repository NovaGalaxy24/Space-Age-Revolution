using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMove : MonoBehaviour
{
    public SlidingPuzzle puzzle;

    [ContextMenu("Move")]
    public void Move()
    {
        Vector2 currentPosition = new Vector2((int)transform.localPosition.x, (int)transform.localPosition.z);
        Vector2 checkPosition = currentPosition + new Vector2(0, 1);
        bool canMove = puzzle.CheckTile(checkPosition);
        if(canMove == true)
        {
            transform.localPosition = new Vector3(checkPosition.x, 0, checkPosition.y);
            puzzle.RemoveTile(currentPosition);
            puzzle.AddTile(checkPosition, gameObject);
            return; //Exits out of the function
        }

        checkPosition = currentPosition + new Vector2(0, -1);
        canMove = puzzle.CheckTile(checkPosition);
        if (canMove == true)
        {
            transform.localPosition = new Vector3(checkPosition.x, 0, checkPosition.y);
            puzzle.RemoveTile(currentPosition);
            puzzle.AddTile(checkPosition, gameObject);
            return; //Exits out of the function
        }

        checkPosition = currentPosition + new Vector2(1, 0);
        canMove = puzzle.CheckTile(checkPosition);
        if (canMove == true)
        {
            transform.localPosition = new Vector3(checkPosition.x, 0, checkPosition.y);
            puzzle.RemoveTile(currentPosition);
            puzzle.AddTile(checkPosition, gameObject);
            return; //Exits out of the function
        }

        checkPosition = currentPosition + new Vector2(-1, 0);
        canMove = puzzle.CheckTile(checkPosition);
        if (canMove == true)
        {
            transform.localPosition = new Vector3(checkPosition.x, 0, checkPosition.y);
            puzzle.RemoveTile(currentPosition);
            puzzle.AddTile(checkPosition, gameObject);
            return; //Exits out of the function
        }
    }
}
