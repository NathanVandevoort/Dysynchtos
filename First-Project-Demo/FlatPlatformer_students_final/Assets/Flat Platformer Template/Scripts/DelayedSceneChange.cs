﻿/* By: Ryan Scheppler
* Date: 10/9/19
* Description: Add this to objects you need a scene changing function for with a delay
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DelayedSceneChange : MonoBehaviour
{
    public float Delay = 0.0f;
    //name of level to load
    public string NextScene = "GameOver";


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //run any extra effects
            OnHit.Invoke();
            StartCoroutine(ChangeSceneAfterDelay());
        }
    }

    IEnumerator ChangeSceneAfterDelay()
    {
        //pause for the delay
        yield return new WaitForSeconds(changeDelay);
        //finally change level
        SceneManager.LoadScene(NextScene);
    }



}
