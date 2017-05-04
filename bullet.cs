using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {

    public GameObject bullet_prefab;
    public float bulletimpulse;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Fire1"))
        { 
            Camera cam = Camera.main;
            GameObject thebullet = (GameObject)Instantiate(bullet_prefab, cam.transform.position, cam.transform.rotation);
            thebullet.GetComponent<Rigidbody>().AddForce(cam.transform.forward * bulletimpulse, ForceMode.Impulse);
            
        }
	}
}
