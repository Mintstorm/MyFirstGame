using UnityEngine;
using UnityEngine.UI;
using System;
//created by Mintstorm April 2022
//Ball moving, start position and speed of a ball 
public class Ball : MonoBehaviour
{
  

    [SerializeField] int blocks = 0;
    private Vector2 direction;
    private Vector2 StartPosition;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] GameObject GameOver;
    [SerializeField] GameObject Win;
    [SerializeField] GameObject Blocks;
    [SerializeField] Text ScoreText;
    [SerializeField] Text TimeText;
    float speed = 3f;
    float time = 0;
    void Start()
    {
      Time.timeScale = 1.0f;
      StartPosition = new Vector2(4,0);
      rb.velocity=new Vector2(3.5f, 3.5f)*speed;
    }
    void Update() 
    {
      if(blocks <22)
        {
            time+= Time.deltaTime;
            float seconds=(float)Math.Round(time, 2);
            TimeText.text=seconds.ToString();
        }
      else
      {
        Time.timeScale = 0.0f;
        Win.SetActive(true);
        ScoreText.gameObject.SetActive(false);
        return;
      }

   
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
      if (col.gameObject.tag=="Lose")
      {
       Debug.Log("You lose");
       Time.timeScale = 0.0f;
       GameOver.SetActive(true);
       Blocks.SetActive(false);
       ScoreText.gameObject.SetActive(false);
       TimeText.gameObject.SetActive(false);
      }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
      if (other.tag == "block")
      {
        blocks++;
        Destroy(other.gameObject);
        ScoreText.text=blocks.ToString();
      }
    }


}