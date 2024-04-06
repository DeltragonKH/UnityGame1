using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    [Header("Player")]
    public Rigidbody2D playerRigidBody;
    public Transform playerTransform;

    [Header("Speed")]
    public float maxSpeedX;
    public float maxSpeedY;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float movX = Input.GetAxis("Horizontal");
        float movY = Input.GetAxis("Vertical");

        playerRigidBody.velocity = new Vector3(movX * maxSpeedX, movY * maxSpeedY);
        //adicionando velocidade ao personagem (como é 2d não é necessario adicionar eixo z;
        // para Y cima positivo; para baixo negativo;  X para esquerda positivo, para direita positivo
        
        if (movX > 0)
        {
            playerTransform.localScale = new Vector3(36, 36, 36);
        }
        else
        {
            playerTransform.localScale = new Vector3(18, 18, 18);
        }
    }
}
