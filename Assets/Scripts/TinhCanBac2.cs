using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TinhCanBac2 : MonoBehaviour
{
    [SerializeField] InputField number1;
    [SerializeField] InputField number2;
    [SerializeField] InputField number3;
    [SerializeField] Dropdown operatorSelection;
    [SerializeField] Text output;

    public void PhuongTrinhBac2()
    {
        float a = float.Parse(number1.text);
        float b = float.Parse(number2.text);
        float c = float.Parse(number3.text);

        float delta = b * b - 4 * a * c;
        float x1, x2;

        if (delta > 0)
        {
            // Hai nghiệm phân biệt
            x1 = (-b + Mathf.Sqrt(delta)) / (2 * a);
            x2 = (-b - Mathf.Sqrt(delta)) / (2 * a);
            output.text = "Nghiệm của phương trình là: x1 = " + x1.ToString() + ", x2 = " + x2.ToString();
        }
        else if (delta == 0)
        {
            // Nghiệm kép
            x1 = x2 = -b / (2 * a);
            output.text = "Nghiệm kép của phương trình là: x1 = x2 = " + x1.ToString();
        }
        else
        {
            // Không có nghiệm thực
            output.text = "Phương trình không có nghiệm thực (nghiệm phức)";
        }
    }
}
