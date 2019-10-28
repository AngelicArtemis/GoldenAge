// Shader created with Shader Forge v1.38 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:2,bsrc:0,bdst:0,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:3138,x:33355,y:32702,varname:node_3138,prsc:2|emission-1316-OUT,voffset-3956-OUT;n:type:ShaderForge.SFN_Tex2dAsset,id:703,x:31890,y:33072,ptovrint:False,ptlb:mix_asset,ptin:_mix_asset,varname:node_703,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:6941,x:32080,y:33072,varname:node_6941,prsc:2,ntxv:0,isnm:False|UVIN-1215-OUT,TEX-703-TEX;n:type:ShaderForge.SFN_Multiply,id:1490,x:32326,y:33072,varname:node_1490,prsc:2|A-6941-R,B-3931-OUT;n:type:ShaderForge.SFN_ValueProperty,id:3931,x:32080,y:33207,ptovrint:False,ptlb:vertexOffse_strength,ptin:_vertexOffse_strength,varname:node_3931,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.015;n:type:ShaderForge.SFN_Append,id:3956,x:32506,y:33072,varname:node_3956,prsc:2|A-7121-OUT,B-1490-OUT;n:type:ShaderForge.SFN_Vector1,id:7121,x:32326,y:33018,varname:node_7121,prsc:2,v1:0;n:type:ShaderForge.SFN_Time,id:4463,x:31470,y:32189,varname:node_4463,prsc:2;n:type:ShaderForge.SFN_ValueProperty,id:2176,x:31278,y:32100,ptovrint:False,ptlb:veroff_speed_v,ptin:_veroff_speed_v,varname:node_2176,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:3298,x:31278,y:32018,ptovrint:False,ptlb:verOff_speed_u,ptin:_verOff_speed_u,varname:node_3298,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.1;n:type:ShaderForge.SFN_Append,id:6598,x:31470,y:32042,varname:node_6598,prsc:2|A-3298-OUT,B-2176-OUT;n:type:ShaderForge.SFN_Multiply,id:7195,x:31645,y:32042,varname:node_7195,prsc:2|A-6598-OUT,B-4463-T;n:type:ShaderForge.SFN_Add,id:3532,x:31827,y:32019,varname:node_3532,prsc:2|A-2974-OUT,B-7195-OUT;n:type:ShaderForge.SFN_Set,id:5000,x:31997,y:32019,varname:vertextOffset,prsc:2|IN-3532-OUT;n:type:ShaderForge.SFN_Get,id:1215,x:31890,y:32984,varname:node_1215,prsc:2|IN-5000-OUT;n:type:ShaderForge.SFN_Tex2d,id:2145,x:32080,y:32930,varname:node_2145,prsc:2,ntxv:0,isnm:False|TEX-703-TEX;n:type:ShaderForge.SFN_Time,id:6716,x:31340,y:32656,varname:node_6716,prsc:2;n:type:ShaderForge.SFN_TexCoord,id:7363,x:31470,y:32352,varname:node_7363,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_ValueProperty,id:5397,x:31148,y:32567,ptovrint:False,ptlb:ind_speed_v,ptin:_ind_speed_v,varname:_veroff_speed_v_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:3377,x:31148,y:32485,ptovrint:False,ptlb:ind_speed_u,ptin:_ind_speed_u,varname:_verOff_speed_u_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.1;n:type:ShaderForge.SFN_Append,id:9709,x:31340,y:32509,varname:node_9709,prsc:2|A-3377-OUT,B-5397-OUT;n:type:ShaderForge.SFN_Multiply,id:7358,x:31515,y:32509,varname:node_7358,prsc:2|A-9709-OUT,B-6716-T;n:type:ShaderForge.SFN_Add,id:1335,x:31697,y:32486,varname:node_1335,prsc:2|A-7363-UVOUT,B-7358-OUT;n:type:ShaderForge.SFN_Set,id:9008,x:31875,y:32486,varname:B,prsc:2|IN-1335-OUT;n:type:ShaderForge.SFN_Tex2d,id:2300,x:32080,y:32762,varname:node_2300,prsc:2,ntxv:0,isnm:False|UVIN-1265-OUT,TEX-703-TEX;n:type:ShaderForge.SFN_Get,id:1265,x:31890,y:32762,varname:node_1265,prsc:2|IN-9008-OUT;n:type:ShaderForge.SFN_Multiply,id:4657,x:32326,y:32884,varname:node_4657,prsc:2|A-1583-OUT,B-2145-G;n:type:ShaderForge.SFN_Add,id:1583,x:32326,y:32762,varname:node_1583,prsc:2|A-4602-OUT,B-2300-B;n:type:ShaderForge.SFN_ValueProperty,id:4602,x:32326,y:32688,ptovrint:False,ptlb:tex_strength,ptin:_tex_strength,varname:node_4602,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.1;n:type:ShaderForge.SFN_Time,id:6657,x:31591,y:31639,varname:node_6657,prsc:2;n:type:ShaderForge.SFN_TexCoord,id:7243,x:31591,y:31339,varname:node_7243,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_ValueProperty,id:126,x:31399,y:31550,ptovrint:False,ptlb:hex_speed_v,ptin:_hex_speed_v,varname:_ind_speed_v_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_ValueProperty,id:9188,x:31399,y:31468,ptovrint:False,ptlb:hex_speed_u,ptin:_hex_speed_u,varname:_ind_speed_u_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.1;n:type:ShaderForge.SFN_Append,id:3273,x:31591,y:31492,varname:node_3273,prsc:2|A-9188-OUT,B-126-OUT;n:type:ShaderForge.SFN_Multiply,id:8428,x:31766,y:31492,varname:node_8428,prsc:2|A-3273-OUT,B-6657-T;n:type:ShaderForge.SFN_Add,id:5070,x:31948,y:31469,varname:node_5070,prsc:2|A-4041-OUT,B-8428-OUT;n:type:ShaderForge.SFN_Set,id:4431,x:32126,y:31469,varname:alpha,prsc:2|IN-5070-OUT;n:type:ShaderForge.SFN_Tex2d,id:5972,x:32080,y:32606,varname:node_5972,prsc:2,ntxv:0,isnm:False|UVIN-7892-OUT,TEX-703-TEX;n:type:ShaderForge.SFN_Get,id:7892,x:31890,y:32653,varname:node_7892,prsc:2|IN-4431-OUT;n:type:ShaderForge.SFN_Add,id:8312,x:32629,y:32669,varname:node_8312,prsc:2|A-1921-OUT,B-4657-OUT;n:type:ShaderForge.SFN_Multiply,id:1921,x:32487,y:32491,varname:node_1921,prsc:2|A-6541-OUT,B-5972-A;n:type:ShaderForge.SFN_ValueProperty,id:6541,x:32237,y:32491,ptovrint:False,ptlb:hex_strength,ptin:_hex_strength,varname:node_6541,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.1;n:type:ShaderForge.SFN_Multiply,id:4041,x:31766,y:31339,varname:node_4041,prsc:2|A-3966-OUT,B-7243-UVOUT;n:type:ShaderForge.SFN_Append,id:3966,x:31591,y:31208,varname:node_3966,prsc:2|A-5607-OUT,B-680-OUT;n:type:ShaderForge.SFN_ValueProperty,id:5607,x:31381,y:31208,ptovrint:False,ptlb:hex_tile_u,ptin:_hex_tile_u,varname:node_5607,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_ValueProperty,id:680,x:31381,y:31293,ptovrint:False,ptlb:hex_tile_v,ptin:_hex_tile_v,varname:_hex_tile_u_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_TexCoord,id:6381,x:31471,y:31885,varname:node_6381,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Multiply,id:2974,x:31646,y:31885,varname:node_2974,prsc:2|A-4842-OUT,B-6381-UVOUT;n:type:ShaderForge.SFN_Append,id:4842,x:31471,y:31754,varname:node_4842,prsc:2|A-5556-OUT,B-452-OUT;n:type:ShaderForge.SFN_ValueProperty,id:452,x:31261,y:31839,ptovrint:False,ptlb:ind_tile_v,ptin:_ind_tile_v,varname:_hex_tile_v_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_ValueProperty,id:5556,x:31261,y:31754,ptovrint:False,ptlb:ind_tile_u,ptin:_ind_tile_u,varname:node_5556,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:3;n:type:ShaderForge.SFN_Slider,id:448,x:32629,y:32518,ptovrint:False,ptlb:color_slider,ptin:_color_slider,varname:node_448,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.7521368,max:2;n:type:ShaderForge.SFN_Lerp,id:5208,x:33018,y:32408,varname:node_5208,prsc:2|A-5646-RGB,B-1116-RGB,T-604-OUT;n:type:ShaderForge.SFN_Color,id:5646,x:32666,y:32143,ptovrint:False,ptlb:color1,ptin:_color1,varname:node_5646,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0.6208861,c3:0.1556604,c4:1;n:type:ShaderForge.SFN_Color,id:1116,x:32666,y:32323,ptovrint:False,ptlb:color2,ptin:_color2,varname:node_1116,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.514151,c2:0.9115927,c3:1,c4:1;n:type:ShaderForge.SFN_Multiply,id:604,x:32970,y:32583,varname:node_604,prsc:2|A-448-OUT,B-8312-OUT;n:type:ShaderForge.SFN_Multiply,id:2722,x:32949,y:32812,varname:node_2722,prsc:2|A-5208-OUT,B-4657-OUT;n:type:ShaderForge.SFN_ValueProperty,id:6536,x:32949,y:32963,ptovrint:False,ptlb:emmision,ptin:_emmision,varname:node_6536,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.1;n:type:ShaderForge.SFN_Multiply,id:1316,x:33124,y:32850,varname:node_1316,prsc:2|A-2722-OUT,B-6536-OUT;proporder:703-3931-2176-3298-5397-3377-4602-126-9188-6541-5607-680-452-5556-448-5646-1116-6536;pass:END;sub:END;*/

Shader "Shader Forge/border_shader" {
    Properties {
        _mix_asset ("mix_asset", 2D) = "white" {}
        _vertexOffse_strength ("vertexOffse_strength", Float ) = 0.015
        _veroff_speed_v ("veroff_speed_v", Float ) = 0
        _verOff_speed_u ("verOff_speed_u", Float ) = 0.1
        _ind_speed_v ("ind_speed_v", Float ) = 0
        _ind_speed_u ("ind_speed_u", Float ) = 0.1
        _tex_strength ("tex_strength", Float ) = 0.1
        _hex_speed_v ("hex_speed_v", Float ) = 0
        _hex_speed_u ("hex_speed_u", Float ) = 0.1
        _hex_strength ("hex_strength", Float ) = 0.1
        _hex_tile_u ("hex_tile_u", Float ) = 1
        _hex_tile_v ("hex_tile_v", Float ) = 1
        _ind_tile_v ("ind_tile_v", Float ) = 1
        _ind_tile_u ("ind_tile_u", Float ) = 3
        _color_slider ("color_slider", Range(0, 2)) = 0.7521368
        _color1 ("color1", Color) = (1,0.6208861,0.1556604,1)
        _color2 ("color2", Color) = (0.514151,0.9115927,1,1)
        _emmision ("emmision", Float ) = 0.1
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
            Blend One One
            Cull Off
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _mix_asset; uniform float4 _mix_asset_ST;
            uniform float _vertexOffse_strength;
            uniform float _veroff_speed_v;
            uniform float _verOff_speed_u;
            uniform float _ind_speed_v;
            uniform float _ind_speed_u;
            uniform float _tex_strength;
            uniform float _hex_speed_v;
            uniform float _hex_speed_u;
            uniform float _hex_strength;
            uniform float _hex_tile_u;
            uniform float _hex_tile_v;
            uniform float _ind_tile_v;
            uniform float _ind_tile_u;
            uniform float _color_slider;
            uniform float4 _color1;
            uniform float4 _color2;
            uniform float _emmision;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                float4 node_4463 = _Time;
                float2 vertextOffset = ((float2(_ind_tile_u,_ind_tile_v)*o.uv0)+(float2(_verOff_speed_u,_veroff_speed_v)*node_4463.g));
                float2 node_1215 = vertextOffset;
                float4 node_6941 = tex2Dlod(_mix_asset,float4(TRANSFORM_TEX(node_1215, _mix_asset),0.0,0));
                v.vertex.xyz += float3(float2(0.0,(node_6941.r*_vertexOffse_strength)),0.0);
                o.pos = UnityObjectToClipPos( v.vertex );
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
////// Lighting:
////// Emissive:
                float4 node_6657 = _Time;
                float2 alpha = ((float2(_hex_tile_u,_hex_tile_v)*i.uv0)+(float2(_hex_speed_u,_hex_speed_v)*node_6657.g));
                float2 node_7892 = alpha;
                float4 node_5972 = tex2D(_mix_asset,TRANSFORM_TEX(node_7892, _mix_asset));
                float4 node_6716 = _Time;
                float2 B = (i.uv0+(float2(_ind_speed_u,_ind_speed_v)*node_6716.g));
                float2 node_1265 = B;
                float4 node_2300 = tex2D(_mix_asset,TRANSFORM_TEX(node_1265, _mix_asset));
                float4 node_2145 = tex2D(_mix_asset,TRANSFORM_TEX(i.uv0, _mix_asset));
                float node_4657 = ((_tex_strength+node_2300.b)*node_2145.g);
                float3 emissive = ((lerp(_color1.rgb,_color2.rgb,(_color_slider*((_hex_strength*node_5972.a)+node_4657)))*node_4657)*_emmision);
                float3 finalColor = emissive;
                return fixed4(finalColor,1);
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Offset 1, 1
            Cull Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_SHADOWCASTER
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _mix_asset; uniform float4 _mix_asset_ST;
            uniform float _vertexOffse_strength;
            uniform float _veroff_speed_v;
            uniform float _verOff_speed_u;
            uniform float _ind_tile_v;
            uniform float _ind_tile_u;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float2 uv0 : TEXCOORD1;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                float4 node_4463 = _Time;
                float2 vertextOffset = ((float2(_ind_tile_u,_ind_tile_v)*o.uv0)+(float2(_verOff_speed_u,_veroff_speed_v)*node_4463.g));
                float2 node_1215 = vertextOffset;
                float4 node_6941 = tex2Dlod(_mix_asset,float4(TRANSFORM_TEX(node_1215, _mix_asset),0.0,0));
                v.vertex.xyz += float3(float2(0.0,(node_6941.r*_vertexOffse_strength)),0.0);
                o.pos = UnityObjectToClipPos( v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
