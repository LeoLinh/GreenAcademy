using System.Threading;
using UnityEngine;
using UnityEngine.UI;
public class MovingCamera : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10.0f;
    //[SerializeField] Text myText;

    // Start is called before the first frame update
    void Start()
    {
        //myText.text = "Hello, my name is Linh";
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        transform.Translate(new Vector3(vertical * moveSpeed * Time.deltaTime,
            horizontal * moveSpeed * Time.deltaTime));
    }

    //int count = 1;
    public void ButtonClick()
    {
        Debug.Log("Button was pressed");
        //myText.text = $"Số lần click : {count++}";
    }
}
