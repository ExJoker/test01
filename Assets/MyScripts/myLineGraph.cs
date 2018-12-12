using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myLineGraph : MonoBehaviour
{

    public WMG_Axis_Graph lineGraphPrefab;

    WMG_Axis_Graph lineGraph;


    // Use this for initialization
    void Start()
    {
        GameObject lineGraphObj = Instantiate<WMG_Axis_Graph>(lineGraphPrefab).gameObject;
        lineGraphObj.transform.SetParent(GameObject.Find("Canvas").transform, worldPositionStays: false);
        lineGraphObj.transform.localPosition = Vector3.zero;
        lineGraphObj.transform.localScale = Vector3.one * 0.7f;
        lineGraphObj.GetComponent<RectTransform>().sizeDelta = lineGraphObj.transform.parent.GetComponent<RectTransform>().rect.size*0.3f; //全屏
        lineGraph = lineGraphObj.GetComponent<WMG_Axis_Graph>();
        lineGraph.Init();

        WMG_List<Vector2> pointPosGZ = new WMG_List<Vector2>() { new Vector2(1f, 3f),new Vector2(2f,20f),new Vector2(3f,4f),
            new Vector2(4f,13f),new Vector2(5f,1f),new Vector2(6f,4f),new Vector2(7f,16f),new Vector2(8f,5f),new Vector2(9f,11f),new Vector2(10,4f),
        new Vector2(11,6f),new Vector2(12,7f)};
        WMG_List<Vector2> pointPosSZ = new WMG_List<Vector2> { new Vector2(1f,16f),new Vector2(2f,5f),new Vector2(3f,11f),new Vector2(4,4f),
        new Vector2(5,6f),new Vector2(6,7f),new Vector2(7f,6),new Vector2(8f,12f),new Vector2(9f,7f),new Vector2(10,15f),
        new Vector2(11,12f),new Vector2(12,3f) };
        WMG_List<string> lineGroups = new WMG_List<string>() { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul","Aug","Sep","Oct","Nov","Dec" };
      //  WMG_List<Color> lineColor = new WMG_List<Color>() { Color.red, Color.yellow, Color.green, Color.blue, Color.cyan, Color.black };
        lineGraph.useGroups = true;
        lineGraph.groups.SetList(lineGroups);
        lineGraph.xAxis.axisLabels.SetList(lineGroups);
        //lineGraph.lineSeries = new List<GameObject>();
        lineGraph.lineSeries[0].GetComponent<WMG_Series>().pointValues = pointPosGZ;
        lineGraph.lineSeries[1].GetComponent<WMG_Series>().pointValues = pointPosSZ;
        lineGraph.lineSeries[0].GetComponent<WMG_Series>().seriesName = "广州";
        lineGraph.lineSeries[1].GetComponent<WMG_Series>().seriesName = "深圳";
        lineGraph.xAxis.LabelType = WMG_Axis.labelTypes.ticks;
        lineGraph.axisWidth = 2;
        lineGraph.xAxis.hideGrid = true;
        lineGraph.yAxis.hideGrid = true;
        
        //lineGraph.graphType = WMG_Axis_Graph.graphTypes.bar_stacked;
        //lineGraph.orientationType = WMG_Axis_Graph.orientationTypes.horizontal;
        //lineGraph.resizeEnabled = true;
        //lineGraph.resizeProperties = WMG_Axis_Graph.ResizeProperties.AxesLabelOffset;
        //lineGraph.useGroups = true;
        //lineGraph.graphType = WMG_Axis_Graph.graphTypes.bar_side;
        //lineGraph.autoUpdateBarWidth = false;
        //lineGraph.autoUpdateBarAxisValue = false;
        //lineGraph.barWidth = 1f;
        //lineGraph.barAxisValue = 15f;
        //lineGraph.autoUpdateBarWidthSpacing = 0.1f;
        //lineGraph.resizeProperties = WMG_Axis_Graph.ResizeProperties.AutofitPadding;
        //lineGraph.resizeProperties = WMG_Axis_Graph.ResizeProperties.AxesLinePadding;
        //lineGraph.paddingLeftRight = new Vector2(70f, 50f);
        //lineGraph.paddingTopBottom = new Vector2(50f, 70f);
        //lineGraph.autoFitLabels = true;
        //lineGraph.autoFitPadding = 1f;
        //lineGraph.yAxis.AxisMinValue = 2f;
        //lineGraph.yAxis.AxisMaxValue = 13f;
        //lineGraph.yAxis.AxisNumTicks = 10;
        //lineGraph.yAxis.MinAutoGrow = true;
        //lineGraph.yAxis.MaxAutoGrow = true;
        //lineGraph.yAxis.MinAutoShrink = true;
        //lineGraph.yAxis.MaxAutoShrink = true;
        //lineGraph.yAxis.AxisLinePadding = 100f;
        //lineGraph.yAxis.HideAxisArrowTopRight = true;
        //lineGraph.yAxis.hideGrid = true;
        //lineGraph.yAxis.hideTick = true;  //没卵用
        //lineGraph.yAxis.hideTicks = true;
        lineGraph.yAxis.AxisTitleString = "出口";
        //lineGraph.yAxis.AxisTitleOffset = new Vector2(30f, 30f);
        //lineGraph.yAxis.AxisTitleFontSize = 30;


        lineGraph.Refresh();
    }

    // Update is called once per frame
    //void Update () {

    //   }
}

