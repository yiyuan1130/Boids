Shader "iHuman/HeroShow" 
{
	Properties 
	{
		_MainColor("Main Color", Color) = (0.784, 0.784, 0.784, 1)
		_RampColor("Ramp Color", Color) = (0.318, 0.318, 0.318, 0)
		_MainTex("Base (RGB)", 2D) = "white" {}

		_EdgeTex("Edge (RGB)", 2D) = "white" {}
		_EdgePower("Edge Power", Range(0, 2)) = 1
		
		_SpecColor("Spec Color", Color) = (0.043, 0.043, 0.043, 0)
		_SpecPower("Spec Power", Range(1, 128)) = 15
		_SpecMulti("Spec Multi", Range(0, 4)) = 2
	}
	
	SubShader 
	{
		Tags { "RenderType"="Opaque" }
		LOD 200
 		Pass 
 		{
	  		Tags { "RenderType"="Opaque" "LightMode" = "ForwardBase" }
	  		//Fog { Mode Linear }		
			
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#pragma multi_compile_fwdbase
			#pragma multi_compile_fog	
			


			#include "UnityCG.cginc"   
			#include "Lighting.cginc" 
			#include "AutoLight.cginc" 
			
			struct appdata
			{
				float4 vertex : POSITION;
				float3 normal : NORMAL;
				float4 uvcoord : TEXCOORD0;
				float4 tangent : TANGENT;
			};
			
			struct voutput
			{
				float4 pos : SV_POSITION;
				float2 uv0 : TEXCOORD0;
				float3 uv1 : TEXCOORD1;
				float3 uv2 : TEXCOORD2;
				SHADOW_COORDS(3)
				UNITY_FOG_COORDS(4)
			};
			


			float3 _MainColor;
			float3 _RampColor;

			sampler2D _MainTex;
			float4 _MainTex_ST;

			sampler2D _EdgeTex;
			float4 _EdgeTex_ST;

			float _EdgePower;

			float _SpecPower;
			float _SpecMulti;
			
			voutput vert (appdata v) 
			{
				voutput o;
				UNITY_INITIALIZE_OUTPUT(voutput, o);
						  	
				  	
			  	float3 vertNormal = normalize(v.normal);			  		
			  	float3 vertTangent = normalize(v.tangent.xyz);			  		  	
			  	float3 binormal = (((vertNormal.yzx * vertTangent.zxy) - (vertNormal.zxy * vertTangent.yzx)) * v.tangent. w);
			  	float3x3 rotation = float3x3(vertTangent, binormal, vertNormal);				
			    float4 viewDir = float4((_WorldSpaceCameraPos - mul(unity_ObjectToWorld,  v.vertex).xyz), 0);

			    o.pos = UnityObjectToClipPos(v.vertex);
				o.uv0 = TRANSFORM_TEX(v.uvcoord, _MainTex);
				o.uv1 = mul(UNITY_MATRIX_V, mul(unity_ObjectToWorld, float4(vertNormal, 0.0))).xyz;
			    o.uv2 = normalize(mul(rotation, mul(unity_WorldToObject, viewDir).xyz));
				TRANSFER_SHADOW(o);
				UNITY_TRANSFER_FOG(o, o.pos);
			    return o;
		    }
	    
			

		    fixed4 frag(voutput i) : COLOR
		    {
				fixed  shadow = SHADOW_ATTENUATION(i);
				float4 mainColor = tex2D (_MainTex, i.uv0);

				float2 fNormal = normalize(i.uv1);
				float3 albedo = ((mainColor.xyz + 0.15) * tex2D(_EdgeTex, ((fNormal.xy * 0.5) + 0.5)) * _EdgePower).xyz + mainColor.xyz;
			
				float4 finalColor;
				finalColor.xyz = (_RampColor + _MainColor * shadow) * albedo;
				finalColor.w = 1.0;
				
				float nh = max (0.0, normalize(i.uv2).z);
				float3 specColor = _SpecColor * pow(nh, _SpecPower) * _SpecMulti;
				finalColor.xyz = finalColor.xyz + specColor;
				UNITY_APPLY_FOG(i.fogCoord, finalColor);
				return finalColor;
			}
			ENDCG
		}
	}
	Fallback "Diffuse"
}
