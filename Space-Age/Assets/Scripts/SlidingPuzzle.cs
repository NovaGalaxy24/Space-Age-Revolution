using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;

public class SlidingPuzzle : MonoBehaviour
{
    public List<TileInfo> tileInfo = new List<TileInfo>();
    int height = 5;
    int width = 5;

    public GameObject prefab;

    public bool CheckTile(Vector2 tilePos)
    {
        bool canMove = false;

        foreach(TileInfo tile in tileInfo)
        {
            if(tile.x == tilePos.x && tile.z == tilePos.y)
            {
                if(tile.tile == null) //Check if there is no tile
                {
                    canMove = true; //Safe to move to
                }
                break; //exits out of loop
            }
        }

        return canMove;
    }

    public void RemoveTile(Vector2 tilePos)
    {
        foreach (TileInfo tile in tileInfo)
        {
            if (tile.x == tilePos.x && tile.z == tilePos.y)
            {
                tile.tile = null;
                break; //exits out of loop
            }
        }
    }
    public void AddTile(Vector2 tilePos, GameObject obj)
    {
        foreach (TileInfo tile in tileInfo)
        {
            if (tile.x == tilePos.x && tile.z == tilePos.y)
            {
                tile.tile = obj;
                break; //exits out of loop
            }
        }
    }

    [ContextMenu("CreateList")]
    public void CreateList()
    {
        for (int x = 0; x < width; x++)
        {
            for (int z = 0; z < height; z++)
            {
                TileInfo newTile = new TileInfo();
                newTile.x = x;
                newTile.z = z;

                GameObject placeholder = Instantiate(prefab, transform);
                newTile.tile = placeholder;

                placeholder.transform.localRotation = Quaternion.identity;
                placeholder.transform.localPosition = new Vector3(x, 0, z);

                tileInfo.Add(newTile);
            }
        }
    }
}

[System.Serializable]
public class TileInfo
{
    public int x; //Horizontal
    public int z; //Vertical
    public GameObject tile;
}
