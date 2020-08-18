using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aluno : MonoBehaviour
{
    public string nomeAluno;
    private bool isAprovado;
    public float mediaBimestreA;
    public float mediaBimestreB;
    public float mediaBimestreC;
    public float mediaBimestreD;
    public int frequencia;

    public int frequenciaNescessaria;
    public int mediaNescessaria;
  





    void Start()
    {
        calcularMediaFinal();
    }

    // Update is called once per frame
    void Update()
    {
       
    }


    void calcularMediaFinal() {

        float mediaFinal = (mediaBimestreA + mediaBimestreB + mediaBimestreC + mediaBimestreD) / 4;

        if (mediaFinal >= mediaNescessaria && frequencia >= frequenciaNescessaria)
        {

            print("O Aluno " + nomeAluno + " foi aprovado com media " + mediaFinal + " e com frequencia de " + frequencia + "%");
            isAprovado = true;

        }
        else
        {
            print("O Aluno " + nomeAluno + " foi reprovado ");
            isAprovado = false;
            if (mediaFinal < mediaNescessaria && frequencia < frequenciaNescessaria)
            {
                print("Media e Frequencia nao atigida");
            }
            else if (frequencia < frequenciaNescessaria)
            {
                print(" Frequencia nao atigida");
            }
            else if(mediaFinal < mediaNescessaria)
            {
                print(" Media nao atigida ");
            }
        }
    }
}
