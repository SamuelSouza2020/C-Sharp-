using UnityEngine;

public class TestDelegate : MonoBehaviour
{
    delegate void teste();
    teste exemplo;

    public Sprite car;

    void Start()
    {
        exemplo = ataque;
        exemplo += defesa;
        exemplo += apoio;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.B))
        {
            exemplo -= apoio;
            exemplo();
        }
    }
    void ataque()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = car;
    }
    void defesa()
    {
        gameObject.GetComponent<SpriteRenderer>().color = Color.black;
    }
    void apoio()
    {
        gameObject.transform.localScale = new Vector2(0.3f,0.3f);
    }
}
