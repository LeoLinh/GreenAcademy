using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertExample : MonoBehaviour
{
    [SerializeField] string Text = "1,5,12,76,4,9,54,19,84,63";

    // Start is called before the first frame update
    void Start()
    {
        string[] numStrs = Text.Split(',');
        int[] nums = new int[numStrs.Length];
        for(int i = 0; i < numStrs.Length; i++)
        {
            nums[i] = int.Parse(numStrs[i]);
        }

        // sắp xếp theo thứ tự tăng dần
        for(int i = 0; i < nums.Length - 1; i++)
        {
            for(int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] > nums[j])
                {
                    nums[i] += nums[j];
                    nums[j] = nums[i] - nums[j];
                    nums[i] = nums[j] - nums[j];
                }
            }
        }

        string str = "";
        for (int i = 0; i < nums.Length; i++)
        {
            str += nums[i] + " ";
        }
        Debug.Log(str);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
