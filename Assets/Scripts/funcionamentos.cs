using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class funcionamentos : MonoBehaviour
{
    private Rigidbody2D playerRb;
    private GameControle _GameControle;
    void Start()
    {

        QualitySettings.vSyncCount = 1;
        Application.targetFrameRate = 120;
        playerRb = GetComponent<Rigidbody2D>();

        _GameControle = FindObjectOfType(typeof(GameControle)) as GameControle;
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");


        float posY = transform.position.y;
        float posX = transform.position.x;

        playerRb.velocity = new Vector2(horizontal * _GameControle.velocidadeMovimento, vertical * _GameControle.velocidadeMovimento);

        //verifica limite y

        if (transform.position.y > _GameControle.alturaMaxY)
        {

            posY = _GameControle.alturaMaxY;
        }
        else if (transform.position.y < _GameControle.alturaMinY)
        {

            posY = _GameControle.alturaMinY;
        }

        //verifica limite x

        if (transform.position.x > _GameControle.limiteMaxX)
        {

            posX = _GameControle.limiteMaxX;
        }
        else if (transform.position.x < _GameControle.limiteMinX)
        {

            posX = _GameControle.limiteMinX;
        }


        transform.position = new Vector3(posX, posY, 0);

    }

    
}
