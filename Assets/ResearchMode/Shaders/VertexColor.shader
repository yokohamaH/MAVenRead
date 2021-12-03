﻿// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Custom/VertexColor" {
    Properties{
        _Size("PointSize", Float) = 0
    // colors や vectors などの他のプロパティーもここに置けます
    }
    SubShader {
    Pass {
        LOD 200
              
                 
        CGPROGRAM
        #pragma vertex vert
        #pragma fragment frag
  
        struct VertexInput {
            float4 v : POSITION;
            float4 color: COLOR;
        };
         
        struct VertexOutput {
            float4 pos : SV_POSITION;
            float4 col : COLOR;
            float size : PSIZE;
        };
         
        float _Size;

        VertexOutput vert(VertexInput v) {
         
            VertexOutput o;
            o.pos = UnityObjectToClipPos(v.v);
            o.col = v.color;            
            o.size = _Size;

            return o;
        }
         
        float4 frag(VertexOutput o) : COLOR {
            return o.col;
        }
 
        ENDCG
        } 
    }
 
}
