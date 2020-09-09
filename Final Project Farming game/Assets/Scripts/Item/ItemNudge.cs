
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemNudge : MonoBehaviour
{
    private WaitForSeconds pause;
    private bool isAnimeting = false;

    private void Awake()
    {
        pause = new WaitForSeconds(0.04f);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isAnimeting == false)
        {
            if (gameObject.transform.position.x < collision.gameObject.transform.position.x)
            {
                StartCoroutine(RotateAntiClock());
            }
            else
            {
                StartCoroutine(RotateClock());
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
        if (isAnimeting == false)
        {
            if (gameObject.transform.position.x < collision.gameObject.transform.position.x)
            {
                StartCoroutine(RotateAntiClock());
            }
            else
            {
                StartCoroutine(RotateClock());
            }
        }
    }

    private IEnumerator RotateAntiClock()
    {
        isAnimeting = true;

        for (int i=0;i<4;i++)
        {
            gameObject.transform.GetChild(0).Rotate(00f,0f,2f);
            yield return pause;
        }


        for (int i = 0; i < 5; i++)
        {
            gameObject.transform.GetChild(0).Rotate(0f, 0f, -2f);
            yield return pause;
        }
        gameObject.transform.GetChild(0).Rotate(0f, 0f, 2f);
        yield return pause;

        isAnimeting = false;

    }

    private IEnumerator RotateClock()
    {
        isAnimeting = true;

        for (int i = 0; i < 4; i++)
        {
            gameObject.transform.GetChild(0).Rotate(0f, 0f,- 2f);
            yield return pause;
        }


        for (int i = 0; i < 5; i++)
        {
            gameObject.transform.GetChild(0).Rotate(0f, 0f, 2f);
            yield return pause;
        }
        gameObject.transform.GetChild(0).Rotate(0f, 0f, -2f);
        yield return pause;

        isAnimeting = false;

    }
}
