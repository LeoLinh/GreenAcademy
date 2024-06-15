using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;

public class CreateACalculator : MonoBehaviour
{

    [SerializeField] InputField Input;
    [SerializeField] Text Output;
    DataTable dt;
    // Start is called before the first frame update
    void Start()
    {
        //Input = GetComponent<InputField>();
        dt = new DataTable();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void InputText(string text)
    {
        Input.text += text;
    }

    public void Clear()
    {
        Input.text = "";
        Output.text = "0";
    }

    public void Caculate()
    {
        try
        {
            var result = dt.Compute(Input.text, "");
            Output.text = result.ToString();
        }
        catch (Exception ex)
        {
            Debug.LogException(ex);
            Output.text = "Lỗi biểu thức không thể tính toán được";
        }
    }
}

