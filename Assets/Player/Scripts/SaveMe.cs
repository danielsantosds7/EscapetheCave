using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveMe : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Object.FindObjectOfType<SaveMe>();
        DontDestroyOnLoad(gameObject);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
