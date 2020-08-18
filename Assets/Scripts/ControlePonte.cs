using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlePonte : MonoBehaviour
{
    private GameControle _GameControle;
    private Rigidbody2D ponteRb;


    private bool instancia;
    void Start()
    {
        _GameControle = FindObjectOfType(typeof(GameControle)) as GameControle;

        ponteRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        ponteRb.velocity = new Vector2(_GameControle.velocidadeObjeto, 0);


        if (instancia == false)
        {

            if (transform.position.x <= 0)
            {

                instancia = true;
                GameObject temp = Instantiate(_GameControle.pontePrefab);
                float posX = transform.position.x + _GameControle.tamanhoPonte;
                float posY = transform.position.y;

                temp.transform.position = new Vector3(posX, posY, 0);

            }
        }
        if (transform.position.x < _GameControle.distanciaDestruir)
        {
            Destroy(this.gameObject);

        }
    }
}
