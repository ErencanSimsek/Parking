using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeftRightCam : MonoBehaviour
{
    [SerializeField] GameObject Left, Right;
    [SerializeField] Image LeftPanel, RightPanel;
    Vector3 SolAyna, SagAyna; 
    private void Start()
    {
        SolAyna = Left.transform.position;
        SagAyna = Right.transform.position;
        LeftPanel.fillAmount = 0;
        RightPanel.fillAmount = 0;
    }
    private void Update()
    {
        if (move.Vites == "R")
        {
            Left.transform.position = new Vector3(SagAyna.x , SagAyna.y);
            Right.transform.position = new Vector3(SolAyna.x, SolAyna.y);
            LeftPanel.transform.position= new Vector3(SagAyna.x, SagAyna.y);
            RightPanel.transform.position = new Vector3(SolAyna.x, SolAyna.y);
        }
        else if(move.Vites == "D" || move.Vites == "N" || move.Vites == "P")
        {
            Left.transform.position = new Vector3(SolAyna.x, SolAyna.y);
            Right.transform.position = new Vector3(SagAyna.x, SagAyna.y);
            LeftPanel.transform.position = new Vector3(SolAyna.x, SolAyna.y);
            RightPanel.transform.position = new Vector3(SagAyna.x, SagAyna.y);
        }
    }
    public void LeftActive()
    {
        if(Left.activeSelf == true)
        {
            Left.SetActive(false);
        }
        else
        {
            Left.SetActive(true);
        }
    }
    public void RightActive()
    {
        if (Right.activeSelf == true)
        {
            Right.SetActive(false);
        }
        else
        {
            Right.SetActive(true);
        }
    }
}
