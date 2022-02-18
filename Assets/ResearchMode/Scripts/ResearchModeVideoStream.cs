using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using System.Runtime.InteropServices;

#if WINDOWS_UWP
using HL2UnityPlugin;
#endif

public class ResearchModeVideoStream : MonoBehaviour
{
#if WINDOWS_UWP
    HL2ResearchMode researchMode;
#endif

    [SerializeField] private bool renderColorPreview = true;
    [SerializeField] private bool renderDepthPreview = true;
    [SerializeField] private bool renderLongDepthPreview = true;
    [SerializeField] private bool renderLFPreview = true;
    [SerializeField] private bool renderRFPreview = true;
    [SerializeField] public bool renderPointCloud = false;


    public GameObject depthPreviewPlane = null;
    private Material depthMediaMaterial = null;
    private Texture2D depthMediaTexture = null;
    private byte[] depthFrameData = null;

    public GameObject shortAbImagePreviewPlane = null;
    private Material shortAbImageMediaMaterial = null;
    private Texture2D shortAbImageMediaTexture = null;
    private byte[] shortAbImageFrameData = null;

    public GameObject longDepthPreviewPlane = null;
    private Material longDepthMediaMaterial = null;
    private Texture2D longDepthMediaTexture = null;
    private byte[] longDepthFrameData = null;

    public GameObject LFPreviewPlane = null;
    private Material LFMediaMaterial = null;
    private Texture2D LFMediaTexture = null;
    private byte[] LFFrameData = null;

    public GameObject RFPreviewPlane = null;
    private Material RFMediaMaterial = null;
    private Texture2D RFMediaTexture = null;
    private byte[] RFFrameData = null;

    public GameObject colorPreviewPlane = null;
    private Material colorMediaMaterial = null;
    private Texture2D colorMediaTexture = null;
    private byte[] colorFrameData = null;

    public GameObject maskPreviewPlane = null;
    private Material maskMapMaterial = null;
    private Texture2D maskMapTexture = null;
    private byte[] maskMapData = null;    

    public GameObject pointCloudRendererGo;    
    private PointCloudRenderer pointCloudRenderer;    

    public UInt16 pointCloudNearOffset = 200;
    public UInt16 pointCloudFarOffset = 800;
    [Range(0, 5)] public UInt16 cutoffLevel = 3;

    void Start()
    {
        depthMediaMaterial = depthPreviewPlane.GetComponent<MeshRenderer>().material;
        depthMediaTexture = new Texture2D(512, 512, TextureFormat.Alpha8, false);
        depthMediaMaterial.mainTexture = depthMediaTexture;

        shortAbImageMediaMaterial = shortAbImagePreviewPlane.GetComponent<MeshRenderer>().material;
        shortAbImageMediaTexture = new Texture2D(512, 512, TextureFormat.Alpha8, false);
        shortAbImageMediaMaterial.mainTexture = shortAbImageMediaTexture;

        longDepthMediaMaterial = longDepthPreviewPlane.GetComponent<MeshRenderer>().material;
        longDepthMediaTexture = new Texture2D(320, 288, TextureFormat.Alpha8, false);
        longDepthMediaMaterial.mainTexture = longDepthMediaTexture;
        
        LFMediaMaterial = LFPreviewPlane.GetComponent<MeshRenderer>().material;
        LFMediaTexture = new Texture2D(640, 480, TextureFormat.Alpha8, false);
        LFMediaMaterial.mainTexture = LFMediaTexture;

        RFMediaMaterial = RFPreviewPlane.GetComponent<MeshRenderer>().material;
        RFMediaTexture = new Texture2D(640, 480, TextureFormat.Alpha8, false);
        RFMediaMaterial.mainTexture = RFMediaTexture;

        colorMediaMaterial = colorPreviewPlane.GetComponent<MeshRenderer>().material;
        colorMediaTexture = new Texture2D(760, 428, TextureFormat.BGRA32, false);
        colorMediaMaterial.mainTexture = colorMediaTexture;
        
        maskMapMaterial = maskPreviewPlane.GetComponent<MeshRenderer>().material;
        maskMapTexture = new Texture2D(760, 428, TextureFormat.BGRA32, false);
        maskMapMaterial.mainTexture = maskMapTexture;        

        pointCloudRenderer = pointCloudRendererGo.GetComponent<PointCloudRenderer>();



#if WINDOWS_UWP
        researchMode = new HL2ResearchMode();

        if(renderColorPreview){
            researchMode.InitializeColorCamera();
            Debug.Log("Successful initialization of the color camera");
        }

        if(renderDepthPreview){
            researchMode.InitializeDepthSensor();
            researchMode.StartDepthSensorLoop();
            researchMode.SetMaskCutoffOffset(cutoffLevel);
            Debug.Log("Successful initialization of the short throw sensor");
        }

        if(renderLongDepthPreview || renderPointCloud){
            researchMode.InitializeLongDepthSensor();
            researchMode.SetPointCloudDepthOffset(0);
            researchMode.SetPointCloudDepthRangeOffset(pointCloudNearOffset, pointCloudFarOffset);
            researchMode.StartLongDepthSensorLoop();
            Debug.Log("Successful initialization of the long throw sensor");
        }

        if(renderLFPreview || renderRFPreview){
            researchMode.InitializeSpatialCamerasFront();
            researchMode.StartSpatialCamerasFrontLoop();
            Debug.Log("Successful initialization of spatial cameras");
        }
                        
        
#endif
    }

    bool startRealtimePreview = true;
    void LateUpdate()
    {
#if WINDOWS_UWP
        // update color map texture
        if (startRealtimePreview && researchMode.ColorMapTextureUpdated())
        {            
            byte[] frameTexture = researchMode.GetColorMapTextureBuffer();             
            
            if (frameTexture.Length > 0)
            {                
                if (colorFrameData == null)
                {
                    colorFrameData = frameTexture;
                }
                else
                {
                    System.Buffer.BlockCopy(frameTexture, 0, colorFrameData, 0, colorFrameData.Length);
                }                             
                colorMediaTexture.LoadRawTextureData(colorFrameData);        
                colorMediaTexture.Apply();
                //Debug.Log("Succeeded in updating the color texture");
            }            
        }
        
        // update depth map texture       
        if (startRealtimePreview && researchMode.DepthMapTextureUpdated())
        {
            byte[] frameTexture = researchMode.GetDepthMapTextureBuffer();
            if (frameTexture.Length > 0)
            {
                if (depthFrameData == null)
                {
                    depthFrameData = frameTexture;
                }
                else
                {
                    System.Buffer.BlockCopy(frameTexture, 0, depthFrameData, 0, depthFrameData.Length);
                }

                depthMediaTexture.LoadRawTextureData(depthFrameData);
                depthMediaTexture.Apply();
                //Debug.Log("Succeeded in updating the depth texture");
            }
        }

        // update short-throw AbImage texture        
        if (startRealtimePreview && researchMode.ShortAbImageTextureUpdated())
        {
            byte[] frameTexture = researchMode.GetShortAbImageTextureBuffer();
            if (frameTexture.Length > 0)
            {
                if (shortAbImageFrameData == null)
                {
                    shortAbImageFrameData = frameTexture;
                }
                else
                {
                    System.Buffer.BlockCopy(frameTexture, 0, shortAbImageFrameData, 0, shortAbImageFrameData.Length);
                }

                shortAbImageMediaTexture.LoadRawTextureData(shortAbImageFrameData);
                shortAbImageMediaTexture.Apply();
                //Debug.Log("Succeeded in updating the short AB texture");
            }
        }        
        
        // update long depth map texture        
        if (startRealtimePreview && researchMode.LongDepthMapTextureUpdated())
        {
            byte[] frameTexture = researchMode.GetLongDepthMapTextureBuffer();
            if (frameTexture.Length > 0)
            {
                if (longDepthFrameData == null)
                {
                    longDepthFrameData = frameTexture;
                }
                else
                {
                    System.Buffer.BlockCopy(frameTexture, 0, longDepthFrameData, 0, longDepthFrameData.Length);
                }

                longDepthMediaTexture.LoadRawTextureData(longDepthFrameData);
                longDepthMediaTexture.Apply();
                //Debug.Log("Succeeded in updating the long depth texture");
            }
        }        
                
        // update LF camera texture        
        if (startRealtimePreview && researchMode.LFImageUpdated())
        {
            byte[] frameTexture = researchMode.GetLFCameraBuffer();
            if (frameTexture.Length > 0)
            {
                if (LFFrameData == null)
                {
                    LFFrameData = frameTexture;
                }
                else
                {
                    System.Buffer.BlockCopy(frameTexture, 0, LFFrameData, 0, LFFrameData.Length);
                }

                LFMediaTexture.LoadRawTextureData(LFFrameData);
                LFMediaTexture.Apply();
                //Debug.Log("Succeeded in updating the LF texture");
            }
        }
        
        // update RF camera texture        
        if (startRealtimePreview && researchMode.RFImageUpdated())
        {
            byte[] frameTexture = researchMode.GetRFCameraBuffer();
            if (frameTexture.Length > 0)
            {
                if (RFFrameData == null)
                {
                    RFFrameData = frameTexture;
                }
                else
                {
                    System.Buffer.BlockCopy(frameTexture, 0, RFFrameData, 0, RFFrameData.Length);
                }

                RFMediaTexture.LoadRawTextureData(RFFrameData);
                RFMediaTexture.Apply();
                //Debug.Log("Succeeded in updating the RF texture");
            }
        }                                        
                
        // Update point cloud
        /*
        if (renderPointCloud)
        {
            float[] pointCloud = researchMode.GetPointCloudBuffer();
            byte[] pointCloudColor = researchMode.GetPointCloudColorBuffer();            
            if (pointCloud.Length > 0)
            {                
                int pointCloudLength = pointCloud.Length / 3;
                Vector3[] pointCloudVector3 = new Vector3[pointCloudLength];
                Color32[] pointCloudRGB = new Color32[pointCloudLength];
                
                for (int i = 0; i < pointCloudLength; i++)
                {                    
                    pointCloudVector3[i] = new Vector3(pointCloud[3 * i], pointCloud[3 * i + 1], pointCloud[3 * i + 2]);
                    pointCloudRGB[i] = new Color32(pointCloudColor[3 * i], pointCloudColor[3 * i + 1], pointCloudColor[3 * i + 2], 255);
                }                                
                pointCloudRenderer.Render(pointCloudVector3, pointCloudRGB);
                //Debug.Log("Succeeded in updating point cloud");
            }            
        }
        */
        
        // update mask map texture               
        if (startRealtimePreview && researchMode.MaskMapTextureUpdated())
        {
            byte[] frameTexture = researchMode.GetMaskMapTextureBuffer();
            if (frameTexture.Length > 0)
            {
                if (maskMapData == null)
                {
                    maskMapData = frameTexture;
                }
                else
                {
                    System.Buffer.BlockCopy(frameTexture, 0, maskMapData, 0, maskMapData.Length);
                }
                maskMapTexture.LoadRawTextureData(maskMapData);        
                maskMapTexture.Apply();
                //Debug.Log("Succeeded in updating mask map");
            }
        }           
        
#endif
    }

    public void StopSensorsEvent()
    {
#if WINDOWS_UWP
        researchMode.StopAllSensorDevice();
#endif
        startRealtimePreview = false;
    }

    private void OnApplicationFocus(bool focus)
    {
        if (!focus) StopSensorsEvent();
    }
}