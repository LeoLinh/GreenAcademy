using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Caculate : MonoBehaviour
{
    [SerializeField] InputField Number1;
    [SerializeField] InputField Number2;
    [SerializeField] Dropdown operatorSelected;
    [SerializeField] Text output;

    public void TinhToan()
    {
        float num1 = float.Parse(Number1.text);
        float num2 = float.Parse(Number2.text);
        float num;

        switch (operatorSelected.value)
        {
            case 0:
                num = num1 + num2;
                output.text = num.ToString();
                break;
            case 1:
                num = num1 - num2;
                output.text = num.ToString();
                break;
            case 2:
                num = num1 * num2;
                output.text = num.ToString();
                break;
            case 3:
                if (num2 == 0)
                {
                    output.text = "Lỗi! hãy nhập lại";
                }
                else
                {
                    num = num1 / num2;
                    output.text = num.ToString();
                }
                break;
        }
    }
}