using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public GameObject asteroidObject;
    public Vector3 pos;


    public float asteroidSpeed;
    public float asteroidStartWait;
    public float asteroidWaveWait;

    int score=0;
    public Text scoreText;
    public Text gameOverText;
    public Text restartR;
    bool gameOverControl=false;
    bool restart=false;

    void Start()
    {
        StartCoroutine(Build());
       
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && restart)
        {
            
            SceneManager.LoadScene("Level 1");
        }
    }

    IEnumerator Build()
    {
        yield return new WaitForSeconds(asteroidStartWait);
        while (true)
        {
            for (int i = 0; i < 10; i++)
            {
                yield return new WaitForSeconds(asteroidSpeed);
                Vector3 randomPos = new Vector3(Random.Range(-pos.x, pos.x), 0, pos.z);
                Instantiate(asteroidObject, randomPos, Quaternion.identity);                                   // Quarterrnion.identity   0,0,0 rotasyonunda ba�lat demek.


            }
            if (gameOverControl)
            {
                restartR.text = "Press R to Restart";
                restart = true;
                break;
            }
            yield return new WaitForSeconds(asteroidWaveWait);                                            //yield return new WaitUntil(()=>opened==false); //TRUE    Ko�ulu sa�l�yor ise �al��s�n.
                                                                                                         //yield return new Waitwhile(()=>opened==false); //FALSE   Ko�ul sa�lanmad��� i�in �al��s�n.
      
        }


    }
    public void ScoreUp(int comeingScore)
    {
        score += comeingScore;
        scoreText.text = "Score : " + score;
        
    }


    public  void GameOver()
    {
        gameOverText.text = "Game Over";
        gameOverControl = true;
    }




    
    





    //float timer,maxTime=3;
    //int counter;
    //private void Update()
    //{
    //    timer += Time.deltaTime;
    //    if(timer>=maxTime)
    //    {
    //        timer = 0;
    //        Vector3 objectPos = new Vector3(Random.Range(-Vec.x, Vec.x), 0, Vec.z);                // IEnumurator'un Update'te yaz�l���. 
    //        Instantiate(Asteroid, objectPos, Quaternion.identity);
    //        counter++;
    //        if(counter>=10)
    //        {
    //            maxTime = 4;
    //            counter = 0;
    //        }
    //        else
    //        {
    //            maxTime = 1;
    //        }
    //    }
    //}
}
