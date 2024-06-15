using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderX : MonoBehaviour
{
    [SerializeField] Slider sliderX;
    [SerializeField] Slider sliderY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateX()
    {
        transform.position = new Vector3(sliderX.value, transform.position.y, transform.position.z);
    }
    public void UpdateY()
    {
        transform.position = new Vector3(transform.position.x, sliderY.value, transform.position.z);
    }
}
