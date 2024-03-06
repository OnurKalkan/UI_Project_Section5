using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelSwitching : MonoBehaviour
{
    public GameObject panel1, panel2, panel3;
    public void OpenPanel1()
    {
        panel1.SetActive(true);
        panel2.SetActive(false);
        panel3.SetActive(false);
    }
    public void OpenPanel2()
    {
        panel1.SetActive(false);
        panel2.SetActive(true);
        panel3.SetActive(false);
    }
    public void OpenPanel3()
    {
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(true);
    }
}
