using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitGame : MonoBehaviour
{
    public GameObject wall;
    public GameObject player;
    public int columns = 16;
    public int rows = 16;

    private char[,] level = {{'1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1'},
                             {'1','0','0','0','0','0','0','0','0','0','0','0','0','0','0','1'},
                             {'1','0','0','0','0','0','0','0','0','0','0','0','0','0','0','1'},
                             {'1','0','0','0','0','0','0','0','0','0','0','0','0','0','0','1'},
                             {'1','0','0','0','0','0','0','0','0','0','0','0','0','0','0','1'},
                             {'1','0','0','0','0','0','0','0','0','0','0','0','0','0','0','1'},
                             {'1','0','0','0','0','0','0','0','0','0','0','0','0','0','0','1'},
                             {'1','0','0','0','0','0','0','P','0','0','0','0','0','0','0','1'},
                             {'1','0','0','0','0','0','0','0','0','0','0','0','0','0','0','1'},
                             {'1','0','0','0','0','0','0','0','0','0','0','0','0','0','0','1'},
                             {'1','0','0','0','0','0','0','0','0','0','0','0','0','0','0','1'},
                             {'1','0','0','0','0','0','0','0','0','0','0','0','0','0','0','1'},
                             {'1','0','0','0','0','0','0','0','0','0','0','0','0','0','0','1'},
                             {'1','0','0','0','0','0','0','0','0','0','0','0','0','0','0','1'},
                             {'1','0','0','0','0','0','0','0','0','0','0','0','0','0','0','1'},
                             {'1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1'}};
                             

  // Start is called before the first frame update
  void Start()
    {
        for(int x=0; x<columns; x++) {
            for(int y=0; y<rows; y++) {
                // //At each index add a new Vector3 to our list with the x and y coordinates of that position.
                // if(x==0 || x ==columns-1 || y ==0 || y ==rows-1) {
                //     GameObject instance = Instantiate(wall, new Vector3(x, y, 0f), Quaternion.identity) as GameObject;
                // } else if(x == 6 && y == 6){
                //     GameObject instance = Instantiate(player, new Vector3(x, y, 0f), Quaternion.identity) as GameObject;
                // }
                if(level[x, y] == '1'){
                    GameObject instance = Instantiate(wall, new Vector3(x, y, 0f), Quaternion.identity) as GameObject;
                } else if(level[x,y] =='P'){
                    GameObject instance = Instantiate(player, new Vector3(x, y, 0f), Quaternion.identity) as GameObject;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
