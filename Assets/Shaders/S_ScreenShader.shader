// Shader created with Shader Forge v1.40 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.40;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,cpap:True,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:3138,x:32719,y:32712,varname:node_3138,prsc:2|emission-5165-RGB;n:type:ShaderForge.SFN_Time,id:8343,x:29512,y:33121,varname:node_8343,prsc:2;n:type:ShaderForge.SFN_Multiply,id:2453,x:29771,y:33170,varname:node_2453,prsc:2|A-8343-T,B-5208-OUT;n:type:ShaderForge.SFN_ValueProperty,id:5208,x:29512,y:33274,ptovrint:False,ptlb:Speed,ptin:_Speed,varname:node_5208,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.5;n:type:ShaderForge.SFN_ValueProperty,id:8745,x:31544,y:33131,ptovrint:False,ptlb:Offset,ptin:_Offset,varname:node_8745,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Append,id:2240,x:32047,y:32808,varname:node_2240,prsc:2|A-7275-OUT,B-458-V;n:type:ShaderForge.SFN_Add,id:7275,x:31840,y:32808,varname:node_7275,prsc:2|A-458-U,B-1062-OUT;n:type:ShaderForge.SFN_Sin,id:2754,x:30736,y:33140,varname:node_2754,prsc:2|IN-584-OUT;n:type:ShaderForge.SFN_Multiply,id:1062,x:31840,y:32955,varname:node_1062,prsc:2|A-2423-OUT,B-8745-OUT;n:type:ShaderForge.SFN_Add,id:584,x:30439,y:33116,varname:node_584,prsc:2|A-458-V,B-1219-OUT;n:type:ShaderForge.SFN_Tex2d,id:5165,x:32268,y:32752,ptovrint:False,ptlb:MainTex,ptin:_MainTex,varname:node_5165,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-2240-OUT;n:type:ShaderForge.SFN_TexCoord,id:458,x:30073,y:32843,varname:node_458,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_ScreenPos,id:1244,x:30322,y:32666,varname:node_1244,prsc:2,sctp:2;n:type:ShaderForge.SFN_Smoothstep,id:2985,x:31226,y:32959,varname:node_2985,prsc:2|A-7356-OUT,B-7926-OUT,V-2754-OUT;n:type:ShaderForge.SFN_ValueProperty,id:7356,x:30831,y:32905,ptovrint:False,ptlb:Min,ptin:_Min,varname:node_7356,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:-0.05;n:type:ShaderForge.SFN_ValueProperty,id:7926,x:30823,y:33003,ptovrint:False,ptlb:Max,ptin:_Max,varname:node_7926,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.05;n:type:ShaderForge.SFN_ValueProperty,id:2736,x:29915,y:33379,ptovrint:False,ptlb:Width,ptin:_Width,varname:node_2736,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.1;n:type:ShaderForge.SFN_Add,id:7351,x:30439,y:33271,varname:node_7351,prsc:2|A-458-V,B-1219-OUT,C-2736-OUT;n:type:ShaderForge.SFN_Sin,id:2475,x:30699,y:33334,varname:node_2475,prsc:2|IN-7351-OUT;n:type:ShaderForge.SFN_Smoothstep,id:905,x:31226,y:33158,varname:node_905,prsc:2|A-7356-OUT,B-7926-OUT,V-8133-OUT;n:type:ShaderForge.SFN_Multiply,id:2423,x:31544,y:32955,varname:node_2423,prsc:2|A-2985-OUT,B-905-OUT;n:type:ShaderForge.SFN_Multiply,id:8133,x:31022,y:33287,varname:node_8133,prsc:2|A-2475-OUT,B-8626-OUT;n:type:ShaderForge.SFN_Vector1,id:8626,x:30865,y:33415,varname:node_8626,prsc:2,v1:-1;n:type:ShaderForge.SFN_Frac,id:5143,x:29941,y:33170,varname:node_5143,prsc:2|IN-2453-OUT;n:type:ShaderForge.SFN_Multiply,id:1219,x:30189,y:33221,varname:node_1219,prsc:2|A-5143-OUT,B-392-OUT;n:type:ShaderForge.SFN_Tau,id:392,x:29850,y:32956,varname:node_392,prsc:2;proporder:5208-8745-5165-7356-7926-2736;pass:END;sub:END;*/

Shader "Shader Forge/S_ScreenShader" {
    Properties {
        _Speed ("Speed", Float ) = 0.5
        _Offset ("Offset", Float ) = 1
        _MainTex ("MainTex", 2D) = "white" {}
        _Min ("Min", Float ) = -0.05
        _Max ("Max", Float ) = 0.05
        _Width ("Width", Float ) = 0.1
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
            #pragma multi_compile_instancing
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma target 3.0
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            UNITY_INSTANCING_BUFFER_START( Props )
                UNITY_DEFINE_INSTANCED_PROP( float, _Speed)
                UNITY_DEFINE_INSTANCED_PROP( float, _Offset)
                UNITY_DEFINE_INSTANCED_PROP( float, _Min)
                UNITY_DEFINE_INSTANCED_PROP( float, _Max)
                UNITY_DEFINE_INSTANCED_PROP( float, _Width)
            UNITY_INSTANCING_BUFFER_END( Props )
            struct VertexInput {
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                UNITY_VERTEX_INPUT_INSTANCE_ID
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                UNITY_SETUP_INSTANCE_ID( v );
                UNITY_TRANSFER_INSTANCE_ID( v, o );
                o.uv0 = v.texcoord0;
                o.pos = UnityObjectToClipPos( v.vertex );
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                UNITY_SETUP_INSTANCE_ID( i );
////// Lighting:
////// Emissive:
                float _Min_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Min );
                float _Max_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Max );
                float4 node_8343 = _Time;
                float _Speed_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Speed );
                float node_1219 = (frac((node_8343.g*_Speed_var))*6.28318530718);
                float _Width_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Width );
                float _Offset_var = UNITY_ACCESS_INSTANCED_PROP( Props, _Offset );
                float2 node_2240 = float2((i.uv0.r+((smoothstep( _Min_var, _Max_var, sin((i.uv0.g+node_1219)) )*smoothstep( _Min_var, _Max_var, (sin((i.uv0.g+node_1219+_Width_var))*(-1.0)) ))*_Offset_var)),i.uv0.g);
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
