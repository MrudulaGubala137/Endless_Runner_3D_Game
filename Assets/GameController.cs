using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerMovement player;
   public Camera cam;
    public GameObject[] platformPrefab;
   public  Vector3 offSet;
    public float spawnPoint=0;
   // public GameObject currentPlatform;
    public float safeMargin;
    void Start()
    {
        
      //currentPlatform=  Instantiate(platformPrefab[0], transform.position+offSet,Quaternion.identity);
       // GameObject tempBlock= Instantiate(platformPrefab[k],transform.position+new Vector3(5f,0,0),Quaternion.identity);
       
      

    }

    // Update is called once per frame
    void Update()
    {

       
        if(player!=null)
        {
            cam.transform.position = new Vector3(player.transform.position.x, cam.transform.position.y, cam.transform.position.z);
        }
        while(spawnPoint<player.transform.position.x+safeMargin)
        {
            int k = Random.Range(0, platformPrefab.Length);
           GameObject currentPlatform = Instantiate(platformPrefab[k], transform.position , Quaternion.identity);
            PlatformController platform= currentPlatform.GetComponent<PlatformController>();
            currentPlatform.transform.position = new Vector3(spawnPoint + platform.platformSize / 2, 0, 0);
            spawnPoint = 35f;

        }
    }
}
