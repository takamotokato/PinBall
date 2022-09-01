using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public int score;
    public GameObject scoreText;
    // Start is called before the first frame update
    void Start()
    {
        this.scoreText = GameObject.Find("ScoreText");
        score = 0;
        this.scoreText.GetComponent<Text>().text = "Score:" + score.ToString();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "SmallStarTag")
        {
            score += 5;
            this.scoreText.GetComponent<Text>().text = "Score:" + score.ToString();
        }
        else if (collision.gameObject.tag == "LargeStarTag")
        {
            score += 10;
            this.scoreText.GetComponent<Text>().text = "Score:" + score.ToString();
        }
        else if (collision.gameObject.tag == "SmallCloudTag")
        {
            score += 15;
            this.scoreText.GetComponent<Text>().text = "Score:" + score.ToString();
        }
        else if (collision.gameObject.tag == "LargeCloudTag")
        {
            score += 20;
            this.scoreText.GetComponent<Text>().text = "Score:" + score.ToString();
        }
        else
        {
        }
    }
}
