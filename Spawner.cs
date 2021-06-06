using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject PebbleR32;
    

    private float min_X = -2.7f;
    private float max_X = 2.7f;
    //onPress start button

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawning());
    }
    IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(Random.Range(0.5f, 1f));

        GameObject k = Instantiate(PebbleR32);

        float x = Random.Range(min_X, max_X);

        k.transform.position = new Vector2(x, transform.position.y);

        StartCoroutine(StartSpawning());
    }


    // Update is called once per frame
    void Update()
    {

    }
}
