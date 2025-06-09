using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdibleThing : MonoBehaviour
{
    public int bites;
    public GameObject Food;
    public Mesh[] foodMeshes;

    MeshFilter foodMesh;

    private void Start()
    {
        foodMesh = Food.GetComponent<MeshFilter>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Mouth")
        {
            bites++;

            if (bites >= 4)
            {
                gameObject.SetActive(false);
            }
            else
                foodMesh.mesh = foodMeshes[bites];
        }
    }
}
