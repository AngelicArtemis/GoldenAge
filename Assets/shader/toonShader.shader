// Shader created with Shader Forge v1.38 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:9361,x:33727,y:32554,varname:node_9361,prsc:2|custl-6937-OUT;n:type:ShaderForge.SFN_LightAttenuation,id:8068,x:32268,y:32579,varname:node_8068,prsc:2;n:type:ShaderForge.SFN_LightColor,id:3406,x:32676,y:32904,varname:node_3406,prsc:2;n:type:ShaderForge.SFN_LightVector,id:6869,x:31858,y:32654,varname:node_6869,prsc:2;n:type:ShaderForge.SFN_NormalVector,id:9684,x:31858,y:32782,prsc:2,pt:True;n:type:ShaderForge.SFN_Dot,id:7782,x:32070,y:32697,cmnt:Lambert,varname:node_7782,prsc:2,dt:1|A-6869-OUT,B-9684-OUT;n:type:ShaderForge.SFN_Dot,id:3269,x:32389,y:33031,cmnt:Blinn-Phong,varname:node_3269,prsc:2,dt:1|A-9722-OUT,B-693-OUT;n:type:ShaderForge.SFN_Multiply,id:2746,x:33095,y:33113,cmnt:Specular Contribution,varname:node_2746,prsc:2|A-3255-OUT,B-4865-RGB,C-7727-OUT,D-3406-RGB;n:type:ShaderForge.SFN_Tex2d,id:851,x:32070,y:32349,ptovrint:False,ptlb:Diffuse,ptin:_Diffuse,varname:node_851,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:1941,x:32477,y:32771,cmnt:Diffuse Contribution,varname:node_1941,prsc:2|A-8068-OUT,B-7782-OUT;n:type:ShaderForge.SFN_Color,id:5927,x:32070,y:32534,ptovrint:False,ptlb:Color,ptin:_Color,varname:node_5927,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Slider,id:5328,x:31529,y:33056,ptovrint:False,ptlb:Gloss,ptin:_Gloss,varname:node_5328,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.5,max:1;n:type:ShaderForge.SFN_Power,id:5267,x:32552,y:33073,varname:node_5267,prsc:2|VAL-3269-OUT,EXP-7727-OUT;n:type:ShaderForge.SFN_Multiply,id:5085,x:32833,y:32822,cmnt:Attenuate and Color,varname:node_5085,prsc:2|A-1168-OUT,B-3406-RGB;n:type:ShaderForge.SFN_Color,id:4865,x:32809,y:33253,ptovrint:False,ptlb:Spec Color,ptin:_SpecColor,varname:node_4865,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_AmbientLight,id:7528,x:32790,y:32622,varname:node_7528,prsc:2;n:type:ShaderForge.SFN_Multiply,id:2460,x:33037,y:32605,cmnt:Ambient Light,varname:node_2460,prsc:2|A-544-OUT,B-7528-RGB;n:type:ShaderForge.SFN_Multiply,id:544,x:32370,y:32438,cmnt:Diffuse Color,varname:node_544,prsc:2|A-851-RGB,B-5927-RGB;n:type:ShaderForge.SFN_Step,id:1168,x:32676,y:32771,varname:node_1168,prsc:2|A-2661-OUT,B-1941-OUT;n:type:ShaderForge.SFN_Slider,id:2661,x:32437,y:32657,ptovrint:False,ptlb:shading clamp,ptin:_shadingclamp,varname:node_2661,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Add,id:7064,x:33107,y:32789,varname:node_7064,prsc:2|A-2460-OUT,B-5085-OUT;n:type:ShaderForge.SFN_RgbToHsv,id:4214,x:33272,y:32789,varname:node_4214,prsc:2|IN-7064-OUT;n:type:ShaderForge.SFN_Multiply,id:5634,x:33439,y:32680,varname:node_5634,prsc:2|A-5256-RGB,B-4214-SOUT;n:type:ShaderForge.SFN_Add,id:6937,x:33565,y:32815,varname:node_6937,prsc:2|A-5634-OUT,B-2643-OUT;n:type:ShaderForge.SFN_Tex2d,id:5256,x:33256,y:32511,ptovrint:False,ptlb:MainTex,ptin:_MainTex,varname:node_5256,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:2643,x:33334,y:32952,varname:node_2643,prsc:2|A-1168-OUT,B-9360-SOUT;n:type:ShaderForge.SFN_ViewVector,id:5229,x:31858,y:32951,varname:node_5229,prsc:2;n:type:ShaderForge.SFN_Add,id:925,x:32070,y:32887,varname:node_925,prsc:2|A-6869-OUT,B-5229-OUT;n:type:ShaderForge.SFN_Normalize,id:9722,x:32253,y:32887,varname:node_9722,prsc:2|IN-925-OUT;n:type:ShaderForge.SFN_NormalVector,id:693,x:32211,y:33062,prsc:2,pt:False;n:type:ShaderForge.SFN_Slider,id:7727,x:32190,y:33232,ptovrint:False,ptlb:specularity,ptin:_specularity,varname:node_7727,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Step,id:3255,x:32809,y:33067,varname:node_3255,prsc:2|A-2661-OUT,B-5267-OUT;n:type:ShaderForge.SFN_RgbToHsv,id:9360,x:33275,y:33190,varname:node_9360,prsc:2|IN-2746-OUT;proporder:851-5927-5328-4865-2661-5256-7727;pass:END;sub:END;*/

Shader "Shader Forge/toonShader" {
    Properties {
        _Diffuse ("Diffuse", 2D) = "white" {}
        _Color ("Color", Color) = (0.5,0.5,0.5,1)
        _Gloss ("Gloss", Range(0, 1)) = 0.5
        _SpecColor ("Spec Color", Color) = (1,1,1,1)
        _shadingclamp ("shading clamp", Range(0, 1)) = 0
        _MainTex ("MainTex", 2D) = "white" {}
        _specularity ("specularity", Range(0, 1)) = 0
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
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _Diffuse; uniform float4 _Diffuse_ST;
            uniform float4 _Color;
            uniform float _shadingclamp;
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            uniform float _specularity;
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
                LIGHTING_COORDS(3,4)
                UNITY_FOG_COORDS(5)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float4 _MainTex_var = tex2D(_MainTex,TRANSFORM_TEX(i.uv0, _MainTex));
                float4 _Diffuse_var = tex2D(_Diffuse,TRANSFORM_TEX(i.uv0, _Diffuse));
                float node_1168 = step(_shadingclamp,(attenuation*max(0,dot(lightDirection,normalDirection))));
                float3 node_7064 = (((_Diffuse_var.rgb*_Color.rgb)*UNITY_LIGHTMODEL_AMBIENT.rgb)+(node_1168*_LightColor0.rgb));
                float4 node_4214_k = float4(0.0, -1.0 / 3.0, 2.0 / 3.0, -1.0);
                float4 node_4214_p = lerp(float4(float4(node_7064,0.0).zy, node_4214_k.wz), float4(float4(node_7064,0.0).yz, node_4214_k.xy), step(float4(node_7064,0.0).z, float4(node_7064,0.0).y));
                float4 node_4214_q = lerp(float4(node_4214_p.xyw, float4(node_7064,0.0).x), float4(float4(node_7064,0.0).x, node_4214_p.yzx), step(node_4214_p.x, float4(node_7064,0.0).x));
                float node_4214_d = node_4214_q.x - min(node_4214_q.w, node_4214_q.y);
                float node_4214_e = 1.0e-10;
                float3 node_4214 = float3(abs(node_4214_q.z + (node_4214_q.w - node_4214_q.y) / (6.0 * node_4214_d + node_4214_e)), node_4214_d / (node_4214_q.x + node_4214_e), node_4214_q.x);;
                float3 node_2746 = (step(_shadingclamp,pow(max(0,dot(normalize((lightDirection+viewDirection)),i.normalDir)),_specularity))*_SpecColor.rgb*_specularity*_LightColor0.rgb); // Specular Contribution
                float4 node_9360_k = float4(0.0, -1.0 / 3.0, 2.0 / 3.0, -1.0);
                float4 node_9360_p = lerp(float4(float4(node_2746,0.0).zy, node_9360_k.wz), float4(float4(node_2746,0.0).yz, node_9360_k.xy), step(float4(node_2746,0.0).z, float4(node_2746,0.0).y));
                float4 node_9360_q = lerp(float4(node_9360_p.xyw, float4(node_2746,0.0).x), float4(float4(node_2746,0.0).x, node_9360_p.yzx), step(node_9360_p.x, float4(node_2746,0.0).x));
                float node_9360_d = node_9360_q.x - min(node_9360_q.w, node_9360_q.y);
                float node_9360_e = 1.0e-10;
                float3 node_9360 = float3(abs(node_9360_q.z + (node_9360_q.w - node_9360_q.y) / (6.0 * node_9360_d + node_9360_e)), node_9360_d / (node_9360_q.x + node_9360_e), node_9360_q.x);;
                float3 finalColor = ((_MainTex_var.rgb*node_4214.g)+(node_1168*node_9360.g));
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _Diffuse; uniform float4 _Diffuse_ST;
            uniform float4 _Color;
            uniform float _shadingclamp;
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            uniform float _specularity;
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
                LIGHTING_COORDS(3,4)
                UNITY_FOG_COORDS(5)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float4 _MainTex_var = tex2D(_MainTex,TRANSFORM_TEX(i.uv0, _MainTex));
                float4 _Diffuse_var = tex2D(_Diffuse,TRANSFORM_TEX(i.uv0, _Diffuse));
                float node_1168 = step(_shadingclamp,(attenuation*max(0,dot(lightDirection,normalDirection))));
                float3 node_7064 = (((_Diffuse_var.rgb*_Color.rgb)*UNITY_LIGHTMODEL_AMBIENT.rgb)+(node_1168*_LightColor0.rgb));
                float4 node_4214_k = float4(0.0, -1.0 / 3.0, 2.0 / 3.0, -1.0);
                float4 node_4214_p = lerp(float4(float4(node_7064,0.0).zy, node_4214_k.wz), float4(float4(node_7064,0.0).yz, node_4214_k.xy), step(float4(node_7064,0.0).z, float4(node_7064,0.0).y));
                float4 node_4214_q = lerp(float4(node_4214_p.xyw, float4(node_7064,0.0).x), float4(float4(node_7064,0.0).x, node_4214_p.yzx), step(node_4214_p.x, float4(node_7064,0.0).x));
                float node_4214_d = node_4214_q.x - min(node_4214_q.w, node_4214_q.y);
                float node_4214_e = 1.0e-10;
                float3 node_4214 = float3(abs(node_4214_q.z + (node_4214_q.w - node_4214_q.y) / (6.0 * node_4214_d + node_4214_e)), node_4214_d / (node_4214_q.x + node_4214_e), node_4214_q.x);;
                float3 node_2746 = (step(_shadingclamp,pow(max(0,dot(normalize((lightDirection+viewDirection)),i.normalDir)),_specularity))*_SpecColor.rgb*_specularity*_LightColor0.rgb); // Specular Contribution
                float4 node_9360_k = float4(0.0, -1.0 / 3.0, 2.0 / 3.0, -1.0);
                float4 node_9360_p = lerp(float4(float4(node_2746,0.0).zy, node_9360_k.wz), float4(float4(node_2746,0.0).yz, node_9360_k.xy), step(float4(node_2746,0.0).z, float4(node_2746,0.0).y));
                float4 node_9360_q = lerp(float4(node_9360_p.xyw, float4(node_2746,0.0).x), float4(float4(node_2746,0.0).x, node_9360_p.yzx), step(node_9360_p.x, float4(node_2746,0.0).x));
                float node_9360_d = node_9360_q.x - min(node_9360_q.w, node_9360_q.y);
                float node_9360_e = 1.0e-10;
                float3 node_9360 = float3(abs(node_9360_q.z + (node_9360_q.w - node_9360_q.y) / (6.0 * node_9360_d + node_9360_e)), node_9360_d / (node_9360_q.x + node_9360_e), node_9360_q.x);;
                float3 finalColor = ((_MainTex_var.rgb*node_4214.g)+(node_1168*node_9360.g));
                fixed4 finalRGBA = fixed4(finalColor * 1,0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
