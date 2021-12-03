using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using System.Runtime.InteropServices;

#if WINDOWS_UWP
using HL2UnityPlugin;
#endif

public class ResearchModeVideoStream2 : MonoBehaviour
{
#if WINDOWS_UWP
    HL2ResearchMode researchMode;
#endif
    [SerializeField] private bool renderDepthPreview = true;
    [SerializeField] private bool renderLongDepthPreview = true;
    [SerializeField] private bool renderPointCloud = true;


    public GameObject depthPreviewPlane = null;
    private Material depthMediaMaterial = null;
    private Texture2D depthMediaTexture = null;
    private byte[] depthFrameData = null;

    public GameObject longDepthPreviewPlane = null;
    private Material longDepthMediaMaterial = null;
    private Texture2D longDepthMediaTexture = null;
    private byte[] longDepthFrameData = null;
    public GameObject pointCloudRendererGo;
    private PointCloudRenderer pointCloudRenderer;

    public UInt16 pointCloudNearOffset = 200;
    public UInt16 pointCloudFarOffset = 800;

    void Start()
    {
        depthMediaMaterial = depthPreviewPlane.GetComponent<MeshRenderer>().material;
        depthMediaTexture = new Texture2D(512, 512, TextureFormat.Alpha8, false);
        depthMediaMaterial.mainTexture = depthMediaTexture;

        longDepthMediaMaterial = longDepthPreviewPlane.GetComponent<MeshRenderer>().material;
        longDepthMediaTexture = new Texture2D(320, 288, TextureFormat.Alpha8, false);
        longDepthMediaMaterial.mainTexture = longDepthMediaTexture;

        pointCloudRenderer = pointCloudRendererGo.GetComponent<PointCloudRenderer>();


#if WINDOWS_UWP
        researchMode = new HL2ResearchMode();

        if(renderDepthPreview){
            researchMode.InitializeDepthSensor();
            researchMode.StartDepthSensorLoop();
            Debug.Log("Successful initialization of the short throw sensor");
        }

        if(renderLongDepthPreview || renderPointCloud){
            researchMode.InitializeLongDepthSensor();
            researchMode.SetPointCloudDepthOffset(0);
            researchMode.SetPointCloudDepthRangeOffset(pointCloudNearOffset, pointCloudFarOffset);
            researchMode.StartLongDepthSensorLoop();
            Debug.Log("Successful initialization of the long throw sensor");
        }


#endif
    }

    bool startRealtimePreview = true;
    void LateUpdate()
    {
#if WINDOWS_UWP

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
                Debug.Log("Succeeded in updating the depth texture");
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
                Debug.Log("Succeeded in updating the long depth texture");
            }
        }
/*
        // Update point cloud
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
                Debug.Log("Succeeded in updating point cloud");
            }
        }
*/

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
