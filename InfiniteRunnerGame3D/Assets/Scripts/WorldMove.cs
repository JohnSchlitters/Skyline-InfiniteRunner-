using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldMove : MonoBehaviour
{
    public float speedModifier = 1f;

    public int levelcont = 0;
    // Start is called before the first frame update
    void Start()
    {
        print("starting world movement");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, 0f,50f * Time.deltaTime * speedModifier);
    }
}
