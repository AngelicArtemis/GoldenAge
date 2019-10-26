// Shader created with Shader Forge v1.38 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:3138,x:33098,y:32739,varname:node_3138,prsc:2|emission-7241-RGB,alpha-8860-OUT;n:type:ShaderForge.SFN_Color,id:7241,x:32610,y:32545,ptovrint:False,ptlb:Color,ptin:_Color,varname:node_7241,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.9982559,c2:1,c3:0.7877358,c4:1;n:type:ShaderForge.SFN_ValueProperty,id:9793,x:32320,y:32827,ptovrint:False,ptlb:opacity,ptin:_opacity,varname:node_9793,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.2;n:type:ShaderForge.SFN_SceneDepth,id:8751,x:32067,y:32506,varname:node_8751,prsc:2;n:type:ShaderForge.SFN_Multiply,id:6447,x:32685,y:32847,varname:node_6447,prsc:2|A-1758-OUT,B-5793-OUT;n:type:ShaderForge.SFN_Subtract,id:617,x:32428,y:32670,varname:node_617,prsc:2|A-8751-OUT,B-799-A;n:type:ShaderForge.SFN_ScreenPos,id:6984,x:32039,y:32670,varname:node_6984,prsc:2,sctp:0;n:type:ShaderForge.SFN_Tex2d,id:799,x:32209,y:32670,ptovrint:False,ptlb:tex,ptin:_tex,varname:node_799,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-6984-UVOUT;n:type:ShaderForge.SFN_Clamp01,id:1758,x:32610,y:32700,varname:node_1758,prsc:2|IN-617-OUT;n:type:ShaderForge.SFN_FragmentPosition,id:2169,x:31886,y:33095,varname:node_2169,prsc:2;n:type:ShaderForge.SFN_Subtract,id:5178,x:32290,y:33068,varname:node_5178,prsc:2|A-5181-OUT,B-6589-OUT;n:type:ShaderForge.SFN_ViewPosition,id:9300,x:31886,y:32971,varname:node_9300,prsc:2;n:type:ShaderForge.SFN_Vector1,id:6589,x:32076,y:33183,varname:node_6589,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Clamp01,id:2909,x:32460,y:33068,varname:node_2909,prsc:2|IN-5178-OUT;n:type:ShaderForge.SFN_Multiply,id:3363,x:32630,y:33045,varname:node_3363,prsc:2|A-6447-OUT,B-2909-OUT;n:type:ShaderForge.SFN_TexCoord,id:7991,x:32460,y:33214,varname:node_7991,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Multiply,id:9713,x:32779,y:33108,varname:node_9713,prsc:2|A-3363-OUT,B-7041-G;n:type:ShaderForge.SFN_Tex2d,id:7041,x:32630,y:33214,ptovrint:False,ptlb:MainTex,ptin:_MainTex,varname:node_7041,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-7991-UVOUT;n:type:ShaderForge.SFN_Distance,id:5181,x:32076,y:33045,varname:node_5181,prsc:2|A-9300-XYZ,B-2169-XYZ;n:type:ShaderForge.SFN_Fresnel,id:8558,x:32166,y:32851,varname:node_8558,prsc:2|EXP-5668-OUT;n:type:ShaderForge.SFN_Clamp01,id:3526,x:32320,y:32932,varname:node_3526,prsc:2|IN-8558-OUT;n:type:ShaderForge.SFN_Lerp,id:5793,x:32485,y:32847,varname:node_5793,prsc:2|A-9793-OUT,B-3746-OUT,T-3526-OUT;n:type:ShaderForge.SFN_Vector1,id:3746,x:32320,y:32881,varname:node_3746,prsc:2,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:5668,x:31982,y:32871,ptovrint:False,ptlb:edgeFalloff,ptin:_edgeFalloff,varname:node_5668,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:2;n:type:ShaderForge.SFN_Set,id:3824,x:32930,y:33108,varname:opacity_Ori,prsc:2|IN-9713-OUT;n:type:ShaderForge.SFN_Get,id:5773,x:32543,y:33832,varname:node_5773,prsc:2|IN-3824-OUT;n:type:ShaderForge.SFN_Multiply,id:8442,x:32738,y:33832,varname:node_8442,prsc:2|A-5773-OUT,B-6086-OUT;n:type:ShaderForge.SFN_Time,id:4571,x:31798,y:33823,varname:node_4571,prsc:2;n:type:ShaderForge.SFN_Multiply,id:3764,x:31983,y:33823,varname:node_3764,prsc:2|A-9873-OUT,B-4571-TSL;n:type:ShaderForge.SFN_ValueProperty,id:9873,x:31798,y:33765,ptovrint:False,ptlb:timeMultiply,ptin:_timeMultiply,varname:node_9873,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.2;n:type:ShaderForge.SFN_Tex2d,id:4693,x:32335,y:33779,ptovrint:False,ptlb:noiseTex,ptin:_noiseTex,varname:node_4693,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False|UVIN-3327-OUT;n:type:ShaderForge.SFN_TexCoord,id:2083,x:31983,y:33671,varname:node_2083,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Subtract,id:3327,x:32162,y:33796,varname:node_3327,prsc:2|A-2083-UVOUT,B-3764-OUT;n:type:ShaderForge.SFN_Multiply,id:9461,x:31983,y:33969,varname:node_9461,prsc:2|A-4571-TSL,B-8654-OUT;n:type:ShaderForge.SFN_Vector1,id:8654,x:31798,y:33987,varname:node_8654,prsc:2,v1:0.1;n:type:ShaderForge.SFN_Subtract,id:8379,x:32162,y:33969,varname:node_8379,prsc:2|A-7693-UVOUT,B-9461-OUT;n:type:ShaderForge.SFN_TexCoord,id:7693,x:31983,y:34097,varname:node_7693,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Tex2d,id:3722,x:32335,y:33969,ptovrint:False,ptlb:noiseTex2,ptin:_noiseTex2,varname:node_3722,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False|UVIN-8379-OUT;n:type:ShaderForge.SFN_Add,id:6086,x:32543,y:33892,varname:node_6086,prsc:2|A-4693-R,B-3722-R;n:type:ShaderForge.SFN_Set,id:7198,x:32898,y:33832,varname:opacity_new,prsc:2|IN-8442-OUT;n:type:ShaderForge.SFN_Get,id:8860,x:32930,y:33002,varname:node_8860,prsc:2|IN-7198-OUT;proporder:7241-9793-799-7041-5668-9873-4693-3722;pass:END;sub:END;*/

Shader "Shader Forge/lightShader" {
    Properties {
        _Color ("Color", Color) = (0.9982559,1,0.7877358,1)
        _opacity ("opacity", Float ) = 0.2
        _tex ("tex", 2D) = "white" {}
        _MainTex ("MainTex", 2D) = "white" {}
        _edgeFalloff ("edgeFalloff", Float ) = 2
        _timeMultiply ("timeMultiply", Float ) = 0.2
        _noiseTex ("noiseTex", 2D) = "white" {}
        _noiseTex2 ("noiseTex2", 2D) = "white" {}
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend SrcAlpha OneMinusSrcAlpha
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _CameraDepthTexture;
            uniform float4 _Color;
            uniform float _opacity;
            uniform sampler2D _tex; uniform float4 _tex_ST;
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            uniform float _edgeFalloff;
            uniform float _timeMultiply;
            uniform sampler2D _noiseTex; uniform float4 _noiseTex_ST;
            uniform sampler2D _noiseTex2; uniform float4 _noiseTex2_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                float4 projPos : TEXCOORD3;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( v.vertex );
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float2 sceneUVs = (i.projPos.xy / i.projPos.w);
////// Lighting:
////// Emissive:
                float3 emissive = _Color.rgb;
                float3 finalColor = emissive;
                float4 _tex_var = tex2D(_tex,TRANSFORM_TEX((sceneUVs * 2 - 1).rg, _tex));
                float4 _MainTex_var = tex2D(_MainTex,TRANSFORM_TEX(i.uv0, _MainTex));
                float opacity_Ori = (((saturate((max(0, LinearEyeDepth(SAMPLE_DEPTH_TEXTURE(_CameraDepthTexture, sceneUVs)) - _ProjectionParams.g)-_tex_var.a))*lerp(_opacity,0.0,saturate(pow(1.0-max(0,dot(normalDirection, viewDirection)),_edgeFalloff))))*saturate((distance(_WorldSpaceCameraPos,i.posWorld.rgb)-0.5)))*_MainTex_var.g);
                float4 node_4571 = _Time;
                float2 node_3327 = (i.uv0-(_timeMultiply*node_4571.r));
                float4 _noiseTex_var = tex2D(_noiseTex,TRANSFORM_TEX(node_3327, _noiseTex));
                float2 node_8379 = (i.uv0-(node_4571.r*0.1));
                float4 _noiseTex2_var = tex2D(_noiseTex2,TRANSFORM_TEX(node_8379, _noiseTex2));
                float opacity_new = (opacity_Ori*(_noiseTex_var.r+_noiseTex2_var.r));
                return fixed4(finalColor,opacity_new);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
