using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
  public GameObject bullet;
  public GameObject cube;
  public Text text;
  int speed = 0;
  public Transform shottingOffset;
    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space))
      {
        GameObject shot = Instantiate(bullet, shottingOffset.position, Quaternion.identity);
        Debug.Log("Bang!");

        Destroy(shot, 3f);
      }

      if (Input.GetKeyDown(KeyCode.Return))
      {  
        Debug.Log("Start Game!");
        Destroy(cube);
        Destroy(text);
      }

      if (Input.GetKeyDown(KeyCode.LeftArrow))
      {
          speed = -5;
      }

      if (Input.GetKeyDown(KeyCode.RightArrow))
      {
          speed = 5;
        
      }
      
      transform.position = transform.position + new Vector3((Time.deltaTime * speed), 0, 0);
    }
}
