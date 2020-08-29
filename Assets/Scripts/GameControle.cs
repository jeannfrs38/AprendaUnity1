using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControle : MonoBehaviour
{
    [Header("Config. Player")]
    public float velocidadeMovimento = 2;

    public float alturaMaxY;
    public float alturaMinY;
    public float limiteMaxX;
    public float limiteMinX;
    public PlayerControler _playerControler;

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

    [Header("Globals")]
    public float playerXPos;
    public Text textScore;
    public int score;

    [Header("FX Source")]
    public AudioSource fxSource;
    public AudioClip fxClip;
    void Start()
    {
        _playerControler = FindObjectOfType(typeof(PlayerControler)) as PlayerControler;
        StartCoroutine("spawnBarril");
    }

    // Update is called once per frame
   
    private void LateUpdate()
    {
        playerXPos = _playerControler.transform.position.x;
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
    public void Pontuacao(int qtdpontos)
    {
        score += qtdpontos;
        textScore.text = score.ToString();
        fxSource.PlayOneShot(fxClip);
    }

    public void mudarCena(string cenaDestino)
    {
        SceneManager.LoadScene(cenaDestino);
    }
}
