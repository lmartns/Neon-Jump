using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{

    public GameObject player;
    public GameObject plataformPrefab;
    private GameObject myPlat;
    public GameObject boostPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(Random.Range(1, 6) > 1)
        {
            myPlat = (GameObject)Instantiate(plataformPrefab, new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (14 + Random.Range(0.5f, 1f))), Quaternion.identity);
        }
        else
        {
            myPlat = (GameObject)Instantiate(boostPrefab, new Vector2(Random.Range(-5.5f, 5.5f), player.transform.position.y + (14 + Random.Range(0.5f, 1f))), Quaternion.identity);
        }

        Destroy(collision.gameObject);

    }
}
