// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:3138,x:32719,y:32712,varname:node_3138,prsc:2|emission-5165-RGB;n:type:ShaderForge.SFN_Time,id:8343,x:30184,y:33119,varname:node_8343,prsc:2;n:type:ShaderForge.SFN_Multiply,id:2453,x:30460,y:33172,varname:node_2453,prsc:2|A-8343-T,B-5208-OUT;n:type:ShaderForge.SFN_ValueProperty,id:5208,x:30252,y:33289,ptovrint:False,ptlb:Speed,ptin:_Speed,varname:node_5208,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.5;n:type:ShaderForge.SFN_ValueProperty,id:8745,x:31317,y:33317,ptovrint:False,ptlb:Offset,ptin:_Offset,varname:node_8745,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Append,id:2240,x:31946,y:32855,varname:node_2240,prsc:2|A-7275-OUT,B-458-V;n:type:ShaderForge.SFN_Add,id:7275,x:31475,y:32834,varname:node_7275,prsc:2|A-458-U,B-1062-OUT;n:type:ShaderForge.SFN_Sin,id:2754,x:30913,y:33149,varname:node_2754,prsc:2|IN-584-OUT;n:type:ShaderForge.SFN_Step,id:8300,x:31261,y:33149,varname:node_8300,prsc:2|A-1330-OUT,B-5562-OUT;n:type:ShaderForge.SFN_Vector1,id:5562,x:31023,y:33330,varname:node_5562,prsc:2,v1:0;n:type:ShaderForge.SFN_Multiply,id:1062,x:31501,y:33131,varname:node_1062,prsc:2|A-8300-OUT,B-8745-OUT;n:type:ShaderForge.SFN_Add,id:584,x:30738,y:33143,varname:node_584,prsc:2|A-458-V,B-2453-OUT;n:type:ShaderForge.SFN_Tex2d,id:5165,x:32268,y:32752,ptovrint:False,ptlb:MainTex,ptin:_MainTex,varname:node_5165,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-2240-OUT;n:type:ShaderForge.SFN_TexCoord,id:458,x:30367,y:32845,varname:node_458,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Multiply,id:4986,x:30479,y:33357,varname:node_4986,prsc:2|A-8343-TDB,B-5208-OUT;n:type:ShaderForge.SFN_Add,id:9331,x:30738,y:33357,varname:node_9331,prsc:2|A-458-V,B-4986-OUT;n:type:ShaderForge.SFN_Sin,id:8692,x:30914,y:33418,varname:node_8692,prsc:2|IN-9331-OUT;n:type:ShaderForge.SFN_Multiply,id:1330,x:31092,y:33149,varname:node_1330,prsc:2|A-2754-OUT,B-8692-OUT,C-7120-OUT;n:type:ShaderForge.SFN_Multiply,id:8621,x:30479,y:33512,varname:node_8621,prsc:2|A-8343-TSL,B-5208-OUT;n:type:ShaderForge.SFN_Add,id:8240,x:30756,y:33555,varname:node_8240,prsc:2|A-8621-OUT,B-458-V;n:type:ShaderForge.SFN_Sin,id:7120,x:30914,y:33563,varname:node_7120,prsc:2|IN-8240-OUT;proporder:5208-8745-5165;pass:END;sub:END;*/

Shader "Shader Forge/S_ScreenShader" {
    Properties {
        _Speed ("Speed", Float ) = 0.5
        _Offset ("Offset", Float ) = 1
        _MainTex ("MainTex", 2D) = "white" {}
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
            uniform float _Speed;
            uniform float _Offset;
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
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
                o.pos = UnityObjectToClipPos( v.vertex );
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
////// Lighting:
////// Emissive:
                float4 node_8343 = _Time;
                float2 node_2240 = float2((i.uv0.r+(step((sin((i.uv0.g+(node_8343.g*_Speed)))*sin((i.uv0.g+(node_8343.b*_Speed)))*sin(((node_8343.r*_Speed)+i.uv0.g))),0.0)*_Offset)),i.uv0.g);
                float4 _MainTex_var = tex2D(_MainTex,TRANSFORM_TEX(node_2240, _MainTex));
                float3 emissive = _MainTex_var.rgb;
                float3 finalColor = emissive;
                return fixed4(finalColor,1);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
