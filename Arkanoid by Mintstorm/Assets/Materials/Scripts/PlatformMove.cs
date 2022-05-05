using UnityEngine;
//Platform moving, start position, speed and speed boost
//Created by Mintstorm April 2022
public class PlatformMove : MonoBehaviour
{
    private Vector2 direction;
   
    [SerializeField] float speed = 10f;
    private Vector2 startPosition;
    void Start()
    {
       startPosition = new Vector2(0, -4);
    }
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        direction = new Vector2(moveHorizontal, 0);
        direction = transform.TransformDirection(direction) * speed;
        transform.Translate(direction * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
           speed = 30f;
        }
         if (Input.GetKeyUp(KeyCode.LeftShift))
        {
           speed = 10f;
        }

    }
}
