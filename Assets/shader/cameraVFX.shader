// Shader created with Shader Forge v1.38 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:3138,x:33546,y:32592,varname:node_3138,prsc:2|emission-9985-OUT;n:type:ShaderForge.SFN_ScreenPos,id:1452,x:32131,y:32700,varname:node_1452,prsc:2,sctp:0;n:type:ShaderForge.SFN_Sign,id:3383,x:32498,y:32547,varname:node_3383,prsc:2|IN-1452-UVOUT;n:type:ShaderForge.SFN_Tex2d,id:878,x:33164,y:32748,ptovrint:False,ptlb:MainTex,ptin:_MainTex,varname:node_878,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-1797-OUT;n:type:ShaderForge.SFN_Color,id:335,x:33164,y:32951,ptovrint:False,ptlb:filter,ptin:_filter,varname:node_335,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.8207547,c2:0.7420819,c3:0.3987629,c4:1;n:type:ShaderForge.SFN_Blend,id:9985,x:33367,y:32863,varname:node_9985,prsc:2,blmd:0,clmp:True|SRC-878-RGB,DST-335-RGB;n:type:ShaderForge.SFN_Abs,id:2062,x:32328,y:32779,varname:node_2062,prsc:2|IN-1452-UVOUT;n:type:ShaderForge.SFN_OneMinus,id:4018,x:32498,y:32779,varname:node_4018,prsc:2|IN-2062-OUT;n:type:ShaderForge.SFN_Power,id:8462,x:32678,y:32779,varname:node_8462,prsc:2|VAL-4018-OUT,EXP-3721-OUT;n:type:ShaderForge.SFN_Multiply,id:548,x:32854,y:32548,varname:node_548,prsc:2|A-3383-OUT,B-8423-OUT;n:type:ShaderForge.SFN_OneMinus,id:8423,x:32854,y:32776,varname:node_8423,prsc:2|IN-8462-OUT;n:type:ShaderForge.SFN_ValueProperty,id:3721,x:32498,y:32954,ptovrint:False,ptlb:power,ptin:_power,varname:node_3721,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:2;n:type:ShaderForge.SFN_RemapRange,id:1797,x:33037,y:32548,varname:node_1797,prsc:2,frmn:-1,frmx:1,tomn:0,tomx:1|IN-548-OUT;proporder:878-335-3721;pass:END;sub:END;*/

Shader "Shader Forge/cameraVFXmat" {
    Properties {
        _MainTex ("MainTex", 2D) = "white" {}
        _filter ("filter", Color) = (0.8207547,0.7420819,0.3987629,1)
        _power ("power", Float ) = 2
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            uniform float4 _filter;
            uniform float _power;
            struct VertexInput {
                float4 vertex : POSITION;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float4 projPos : TEXCOORD0;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.pos = UnityObjectToClipPos( v.vertex );
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float2 sceneUVs = (i.projPos.xy / i.projPos.w);
////// Lighting:
////// Emissive:
                float2 node_1797 = ((sign((sceneUVs * 2 - 1).rg)*(1.0 - pow((1.0 - abs((sceneUVs * 2 - 1).rg)),_power)))*0.5+0.5);
                float4 _MainTex_var = tex2D(_MainTex,TRANSFORM_TEX(node_1797, _MainTex));
                float3 emissive = saturate(min(_MainTex_var.rgb,_filter.rgb));
                float3 finalColor = emissive;
                return fixed4(finalColor,1);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
