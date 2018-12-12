using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MyPieGraph : MonoBehaviour
{

    public WMG_Pie_Graph pieGraphPrefab;

    // Use this for initialization
    void Start()
    {
        GameObject pieGraphObj = Instantiate<WMG_Pie_Graph>(pieGraphPrefab).gameObject;
        pieGraphObj.transform.SetParent(GameObject.Find("Canvas").transform, worldPositionStays: false);
        pieGraphObj.GetComponent<RectTransform>().sizeDelta = pieGraphObj.transform.parent.GetComponent<RectTransform>().rect.size*0.3f; //全屏
        pieGraphObj.GetComponent<RectTransform>().localPosition = new Vector2(-604.6f,119f);
        WMG_Pie_Graph pieGraph = pieGraphObj.GetComponent<WMG_Pie_Graph>();

        pieGraph.Init();

        //Debug.Log(pieGraph.gameObject.name);
        WMG_List<float> pieValues = new WMG_List<float>() { 60f, 80f, 75f, 90f, 100f, 85f, 95f };
        WMG_List<string> pieLabels = new WMG_List<string>() { "One", "Two", "Three", "Four", "Five", "Six", "Seven" };
        WMG_List<Color> pieColor = new WMG_List<Color>() { Color.red, Color.yellow, Color.green, Color.blue, Color.cyan, Color.black };
        //pieGraph.resizeEnabled = true;

        ///////pieGraph.sliceValues = pieValues;  Debug.Log("草泥马有几个：" + pieGraph.sliceValues.Count);
        ////////pieGraph.sliceLabels = pieLabels;  //不能直接改变量，要用内置函数去改
        ////////pieGraph.sliceColors = pieColor;
        pieGraph.sliceValues.SetList(pieValues);
        pieGraph.sliceLabels.SetList(pieLabels);
        pieGraph.sliceColors.SetList(pieColor);

        pieGraph.sliceLabelExplodeLength = -10f;
        pieGraph.autoCenter = false;
        //pieGraph.autoCenterMinPadding = 10f;
        //pieGraph.bgCircleOffset = 80f;
        pieGraph.sortBy = WMG_Pie_Graph.sortMethod.None;
        pieGraph.explodeLength = 1f;
        //pieGraph.explodeSymmetrical = false;
        pieGraph.sliceLabelFontSize = 10;
        pieGraph.numberDecimalsInPercents = 1;


        pieGraph.interactivityEnabled = true;
        pieGraph.WMG_Pie_Slice_Click += SliceClickEvent;
        pieGraph.WMG_Pie_Legend_Entry_Click += SliceLegendEntryClickEvent;
        pieGraph.WMG_Pie_Slice_MouseEnter += TooltipLegendLinkMouseEnter;
       
        //pieGraph.Refresh();
    }


    void SliceClickEvent(WMG_Pie_Graph pieGraph, WMG_Pie_Graph_Slice aSlice)
    {
        Debug.Log("== ： " + aSlice.name);
        WMG_Anim.animScale(aSlice.gameObject, 0.5f,Ease.Linear, Vector3.one*0.8f, 0);
    }
    void SliceLegendEntryClickEvent(WMG_Pie_Graph pieGraph, WMG_Legend_Entry legendEntry)
    {
        Debug.Log("====");
    }
    void TooltipLegendLinkMouseEnter(WMG_Pie_Graph pieGraph, WMG_Pie_Graph_Slice aSlice,bool state)
    {
        Debug.Log("========= : " + state);
        if (state)
        {
            WMG_Anim.animScale(aSlice.gameObject, 0.5f, Ease.Linear, Vector3.one * 1.2f, 0);

        }
        else
        {
            WMG_Anim.animScale(aSlice.gameObject, 0.5f, Ease.Linear, Vector3.one, 0);

        }

    }

    // Update is called once per frame
    //void Update () {

    //}
}

