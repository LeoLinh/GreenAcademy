using UnityEngine;

public class StringExample : MonoBehaviour
{
    [SerializeField] new string name = "Nguyen Nhat Linh";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Tổng có " + name.Length + " ký tự");
        Debug.Log($"Kich thước chuỗi ký tự : {name.Length} " );

        Debug.Log("=> Chữ thường: " + name.ToLower());
        Debug.Log("=> Chữ hoa: " + name.ToUpper());
        Debug.Log("=> Cắt đoạn: " + name.Substring(11,5));
        Debug.Log("=> thay ký tự: " + name.Replace("Nguyen Nhat Linh", "Leo Linh"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
