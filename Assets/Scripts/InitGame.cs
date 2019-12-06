using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitGame : MonoBehaviour
{
    public GameObject wall;
    public int columns = 32;
    public int rows = 32;

  // Start is called before the first frame update
  void Start()
    {
        for(int x=0; x<columns; x++) {
            for(int y=0; y<rows; y++) {
                //At each index add a new Vector3 to our list with the x and y coordinates of that position.
                GameObject instance = Instantiate(wall, new Vector3(x, y, 0f), Quaternion.identity) as GameObject;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
