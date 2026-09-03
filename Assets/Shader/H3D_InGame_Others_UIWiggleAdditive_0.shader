Shader "H3D/InGame/Others/UIWiggleAdditive" {
	Properties {
		_MainTex ("主颜色(RGB)", 2D) = "white" {}
		_MaskTex ("掩码纹理(Alpha)", 2D) = "white" {}
		_WiggleTex ("扭动纹理(RGB)", 2D) = "white" {}
		_WiggleStrength ("扭动强度", Range(0.01, 10)) = 0.03
		_ScrollX ("主纹理 uv X", Float) = 0
		_ScrollY ("主纹理 uv Y", Float) = 0
		_WiggleScrollX ("扰动纹理 uv X", Float) = 1
		_WiggleScrollY ("扰动纹理 uv Y", Float) = 0
		_Alpha ("透明度", Range(0, 1)) = 1
		_EffectWeaken ("EffectWeaken", Range(0, 1)) = 1
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			float4x4 unity_ObjectToWorld;
			float4x4 unity_MatrixVP;
			float4 _MainTex_ST;

			struct Vertex_Stage_Input
			{
				float4 pos : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct Vertex_Stage_Output
			{
				float2 uv : TEXCOORD0;
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.uv = (input.uv.xy * _MainTex_ST.xy) + _MainTex_ST.zw;
				output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
				return output;
			}

			Texture2D<float4> _MainTex;
			SamplerState sampler_MainTex;

			struct Fragment_Stage_Input
			{
				float2 uv : TEXCOORD0;
			};

			float4 frag(Fragment_Stage_Input input) : SV_TARGET
			{
				return _MainTex.Sample(sampler_MainTex, input.uv.xy);
			}

			ENDHLSL
		}
	}
}