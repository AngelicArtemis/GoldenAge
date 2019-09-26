// Shader created with Shader Forge v1.38 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:3138,x:32719,y:32712,varname:node_3138,prsc:2|emission-1749-OUT;n:type:ShaderForge.SFN_Color,id:7241,x:32328,y:32698,ptovrint:False,ptlb:Tint,ptin:_Tint,varname:node_7241,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.7877358,c2:0.8820755,c3:1,c4:1;n:type:ShaderForge.SFN_Tex2d,id:233,x:32328,y:32872,ptovrint:False,ptlb:PortalTexture,ptin:_PortalTexture,varname:node_233,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:b5c5d21314efae94bbc7c3219dbd4f3b,ntxv:0,isnm:False|UVIN-665-OUT;n:type:ShaderForge.SFN_RemapRange,id:5302,x:32232,y:33113,varname:node_5302,prsc:2,frmn:-1,frmx:1,tomn:0,tomx:1|IN-7815-OUT;n:type:ShaderForge.SFN_ScreenPos,id:224,x:31882,y:33067,varname:node_224,prsc:2,sctp:0;n:type:ShaderForge.SFN_Blend,id:1749,x:32513,y:32819,varname:node_1749,prsc:2,blmd:7,clmp:True|SRC-7241-RGB,DST-233-RGB;n:type:ShaderForge.SFN_Tex2d,id:44,x:31678,y:33247,ptovrint:False,ptlb:Distort,ptin:_Distort,varname:node_44,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:470abc8e26b8b784e8b30cd70f5c0511,ntxv:0,isnm:False|UVIN-6287-UVOUT;n:type:ShaderForge.SFN_Append,id:9672,x:31882,y:33235,varname:node_9672,prsc:2|A-44-R,B-44-G;n:type:ShaderForge.SFN_Subtract,id:7815,x:32061,y:33113,varname:node_7815,prsc:2|A-224-UVOUT,B-9672-OUT;n:type:ShaderForge.SFN_TexCoord,id:7989,x:31222,y:32978,varname:node_7989,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Time,id:1659,x:31222,y:33267,varname:node_1659,prsc:2;n:type:ShaderForge.SFN_Rotator,id:6287,x:31503,y:33217,varname:node_6287,prsc:2|UVIN-7989-UVOUT,PIV-6664-OUT,ANG-1659-T,SPD-5309-OUT;n:type:ShaderForge.SFN_Vector2,id:6664,x:31222,y:33149,varname:node_6664,prsc:2,v1:0.5,v2:0.5;n:type:ShaderForge.SFN_TexCoord,id:8717,x:31964,y:32814,varname:node_8717,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Multiply,id:665,x:32162,y:32872,varname:node_665,prsc:2|A-8717-UVOUT,B-5302-OUT;n:type:ShaderForge.SFN_ValueProperty,id:5309,x:31222,y:33426,ptovrint:False,ptlb:RotationSpeed,ptin:_RotationSpeed,varname:node_5309,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;proporder:7241-233-44-5309;pass:END;sub:END;*/

Shader "Shader Forge/portal_shader" {
    Properties {
        _Tint ("Tint", Color) = (0.7877358,0.8820755,1,1)
        _PortalTexture ("PortalTexture", 2D) = "white" {}
        _Distort ("Distort", 2D) = "white" {}
        _RotationSpeed ("RotationSpeed", Float ) = 1
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
            uniform float4 _Tint;
            uniform sampler2D _PortalTexture; uniform float4 _PortalTexture_ST;
            uniform sampler2D _Distort; uniform float4 _Distort_ST;
            uniform float _RotationSpeed;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 projPos : TEXCOORD1;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.pos = UnityObjectToClipPos( v.vertex );
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float2 sceneUVs = (i.projPos.xy / i.projPos.w);
////// Lighting:
////// Emissive:
                float4 node_1659 = _Time;
                float node_6287_ang = node_1659.g;
                float node_6287_spd = _RotationSpeed;
                float node_6287_cos = cos(node_6287_spd*node_6287_ang);
                float node_6287_sin = sin(node_6287_spd*node_6287_ang);
                float2 node_6287_piv = float2(0.5,0.5);
                float2 node_6287 = (mul(i.uv0-node_6287_piv,float2x2( node_6287_cos, -node_6287_sin, node_6287_sin, node_6287_cos))+node_6287_piv);
                float4 _Distort_var = tex2D(_Distort,TRANSFORM_TEX(node_6287, _Distort));
                float2 node_665 = (i.uv0*(((sceneUVs * 2 - 1).rg-float2(_Distort_var.r,_Distort_var.g))*0.5+0.5));
                float4 _PortalTexture_var = tex2D(_PortalTexture,TRANSFORM_TEX(node_665, _PortalTexture));
                float3 emissive = saturate((_PortalTexture_var.rgb/(1.0-_Tint.rgb)));
                float3 finalColor = emissive;
                return fixed4(finalColor,1);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
