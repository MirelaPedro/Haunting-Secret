using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fantasma : MonoBehaviour
{
    public float moveSpeed = 0.3f;
    public Transform[] pointsToMove; // Array de pontos de movimento
    public int startingPoint;
    public SpriteRenderer sprite;

    void Start()
    {
        // Verifica se os pontos de movimento foram configurados
        if (pointsToMove == null || pointsToMove.Length == 0)
        {
            Debug.LogError("O array 'pointsToMove' est� vazio ou n�o foi configurado.");
        }

        // Verifica se o SpriteRenderer foi atribu�do
        if (sprite == null)
        {
            Debug.LogError("O componente 'SpriteRenderer' n�o foi atribu�do ao script.");
        }
    }

    void FixedUpdate()
    {
        if (pointsToMove != null && pointsToMove.Length > 0)
        {
            Move();
        }
    }

    void Update()
    {
        // Ajusta a dire��o do sprite com base no ponto atual
        if (sprite != null)
        {
            sprite.flipX = startingPoint == 0;
        }
    }

    private void Move()
    {
        if (pointsToMove == null || pointsToMove.Length == 0) return;

        Vector2 targetPosition = pointsToMove[startingPoint].position;

        transform.position = new Vector2(
            Mathf.MoveTowards(transform.position.x, targetPosition.x, moveSpeed * Time.deltaTime),
            transform.position.y
        );

        // Verifica se o fantasma alcan�ou o ponto atual
        if (Mathf.Approximately(transform.position.x, targetPosition.x))
        {
            startingPoint++;

            if (startingPoint >= pointsToMove.Length)
            {
                startingPoint = 0; // Volta ao primeiro ponto
            }
        }
    }
}
