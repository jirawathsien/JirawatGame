using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxObj : Weapon
{
    public GameObject boxObjInGame;
    public void Init()
    {
     boxObjInGame = GameObject.FindObjectOfType<Box>().gameObject;
    }
    public void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Mouse1))
        //{
        //    if (boxObjInGame == null)
        //    {
        //        GameObject obj = Instantiate(boxObjPrefab, transform.parent.position + transform.parent.forward, Quaternion.identity);
        //        boxObjInGame = obj;
        //        boxObjInGame.transform.parent = null;
        //        Destroy(gameObject);
        //    } else
        //    {               
        //        boxObjInGame.transform.position = transform.parent.position + transform.parent.forward; 
        //        boxObjInGame.SetActive(true);                
        //        Destroy(gameObject);
        //    }
        //}
    }
}
