using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    [Tooltip("Object to be instantiate")]
    public GameObject prefabObject;
    [Range(0, 20)]
    public int objectNumber;

    public Vector3 maxPosition;


    // Start is called before the first frame update
    void Start()
    {
        GenerateObjects();
    }

    /// <summary>
    /// Create Randomly objects in the game
    /// </summary>
    private void GenerateObjects()
    {
        //array of scales
        float[] scales = { 0.25f, 0.5f, 1f, 1.5f, 3f };

        //loop iterates creating new Game Objects in the game
        for (int i = 0; i < objectNumber; i++)
        {
            //take a number between 0 and the last array position 
            int randomScalePos = Random.Range(0, scales.Length - 1);
            //create an initial Position changing x,y,z 
            Vector3 initialPosition = new Vector3(
                Random.Range(0, maxPosition.x),
                Random.Range(0, maxPosition.y),
                Random.Range(0, maxPosition.z)
            );

            //add an object to the game
            Instantiate(prefabObject, initialPosition, Quaternion.identity).transform.localScale = new Vector3(scales[randomScalePos], scales[randomScalePos], scales[randomScalePos]);
        }
    }
}