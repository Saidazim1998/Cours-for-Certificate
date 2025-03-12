using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [System.Serializable]
    public struct Stats
    {
        public float speed;
        public float jumpForce;
        public float rotateSpeed;
    }
    public Stats playerStats; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            if (transform.rotation.eulerAngles.y >= 90)
            {
                transform.Rotate(transform.up, -playerStats.rotateSpeed * Time.deltaTime);
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            if (transform.rotation.eulerAngles.y <= 270)
            {
                transform.Rotate(transform.up, playerStats.rotateSpeed * Time.deltaTime);
            }
        }
    }
}
