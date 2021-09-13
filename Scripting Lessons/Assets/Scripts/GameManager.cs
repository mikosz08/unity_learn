using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField]
    private Goal red, green, blue, orange;

    private bool isGameOver = true;

    private void Update()
    {
        isGameOver = red.IsSolved && green.IsSolved && blue.IsSolved && orange.IsSolved;
    }

    private void OnGUI()
    {
        if (isGameOver)
        {
            Rect gameOver = new Rect(Screen.width / 2 - 100,
                                Screen.height / 2 - 50,
                                200, 75);

            GUI.Box(gameOver, " Game Over.");

            Rect congrats =
                new Rect(Screen.width / 2 - 30,
                        Screen.height / 2 - 25,
                        70, 50);

            GUI.Box(congrats, "Good Job!");
        }
    }

}
