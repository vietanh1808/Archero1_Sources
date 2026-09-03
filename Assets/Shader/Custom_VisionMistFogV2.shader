Shader "Custom/VisionMistFogV2" {
	Properties {
		_MainTex ("Scene Texture", 2D) = "white" {}
		[Header(Base Fog)] _FogColor ("底色颜色", Vector) = (0.02,0.02,0.05,1)
		_FogAlpha ("底色透明度", Range(0, 1)) = 1
		[Header(Cloud)] _CloudTex ("烟雾贴图", 2D) = "gray" {}
		_CloudColor ("烟雾颜色", Vector) = (0.3,0.3,0.4,1)
		_CloudAlpha ("烟雾透明度", Range(0, 1)) = 0.5
		_CloudScaleX ("烟雾重铺 X", Float) = 2
		_CloudScaleY ("烟雾重铺 Y", Float) = 2
		_CloudSpeed ("烟雾流速 XY", Vector) = (0.03,0.02,0,0)
		[Header(Vision Circles)] _PlayerUV ("Player Center UV", Vector) = (0.5,0.5,0,0)
		_BrightUV ("Bright Center UV", Vector) = (0.5,0.5,0,0)
		_PlayerRadius ("Player Radius XY", Vector) = (0.2,0.2,0,0)
		_BrightRadius ("Bright Radius XY", Vector) = (0.15,0.15,0,0)
		_PlayerSoftness ("Player Edge Soft", Float) = 0.02
		_BrightSoftness ("Bright Edge Soft", Float) = 0.02
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