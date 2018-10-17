using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    [SerializeField]
    private GameObject tempPlatformPrefab;

	void SpawnTempPlatform()
    {
        Rigidbody2D rigid = GetComponent<Rigidbody2D>();
        Vector2 spawnPoint = new Vector2();
        spawnPoint.x = rigid.position.x;
        spawnPoint.y = rigid.position.y * Physics2D.gravity.y * Time.deltaTime;
        Instantiate(tempPlatformPrefab, spawnPoint, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
