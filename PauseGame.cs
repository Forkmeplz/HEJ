using UnityEngine;
using System.Collections;


public class PauseGame : MonoBehaviour {
    public Transform Canvas;
    public Transform player;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            if (Canvas.gameObject.activeInHierarchy == false)
            {
                Canvas.gameObject.SetActive(true);
                Time.timeScale = 0;
                Cursor.visible = true;
                player.GetComponent<controller>().enabled = false;
            }
            else 
            {
                Canvas.gameObject.SetActive(false);
                Time.timeScale = 1;
                Cursor.visible = false;
                player.GetComponent<controller>().enabled = true;
            }
        }
	}
}
