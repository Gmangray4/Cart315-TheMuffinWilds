using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EatANYONE : MonoBehaviour
{

    public GameObject ScoreText;
    public int theScore; 
    public AudioSource CakeEatSound;



    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject && col.gameObject.name != "Terrain" && col.gameObject.name != "Oven1" && col.gameObject.name != "Oven2" && col.gameObject.name != "Oven3" && col.gameObject.name != "Oven4" && col.gameObject.name != "Oven5" && col.gameObject.name != "Oven6" && col.gameObject.name != "OutSideWall" && col.gameObject.name != "GGrayHead")
        {
            Debug.Log("Collision Decected");
            CakeEatSound.Play();
            theScore += 10;
            ScoreText.GetComponent<Text>().text = "Score: " + theScore;
            Destroy(col.gameObject);
        }
        if(col.gameObject && col.gameObject.name == "GGrayHead")
        {
            theScore -= 10;
            ScoreText.GetComponent<Text>().text = "Score: " + theScore;
        }
    }
}
