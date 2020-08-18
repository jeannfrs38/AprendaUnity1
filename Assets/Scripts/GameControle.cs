using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControle : MonoBehaviour
{
    [Header("Config. Player")]
    public float velocidadeMovimento = 2;

    public float alturaMaxY;
    public float alturaMinY;
    public float limiteMaxX;
    public float limiteMinX;

    [Header("Config. Objetos")]
    public float velocidadeObjeto;
    public float distanciaDestruir;

    public float tamanhoPonte;
    public GameObject pontePrefab;

    [Header("Config. Barril")]
    public int      orderTop;
    public int      orderDown;
    public float    posYTop;
    public float    posYDown;

    public float    tempoSpawn;
    public GameObject barrilPrefab;
    void Start()
    {
        StartCoroutine("spawnBarril");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator spawnBarril()
    {
        yield return new WaitForSeconds(tempoSpawn);
        int rad = Random.Range(0, 100);
        float posY = 0;
        int order = 0;
        if (rad < 50)
        {
            posY = posYTop;
            order = orderTop;
        }
        else
        {
            posY = posYDown;
            order = orderDown;
        }
        GameObject temp = Instantiate(barrilPrefab);
        temp.transform.position = new Vector3(temp.transform.position.x, posY, 0);
        temp.GetComponent<SpriteRenderer>().sortingOrder = order;
        StartCoroutine("spawnBarril");


    }
}
