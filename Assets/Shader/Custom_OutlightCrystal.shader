Shader "Custom/OutlightCrystal" {
	Properties {
		_RefractTex ("RefractTex(折射贴图)", 2D) = "white" {}
		_ReflectTex ("ReflectTex(反射贴图)", Cube) = "white" {}
		_ReflectIntensity ("ReflectIntensity(背面反射强度)", Float) = 2
		_ReflectStrength ("ReflectStrength(正面反射强度)", Float) = 2
		_RimPower ("RimPower(边缘光范围)", Float) = 3
		_RimScale ("RimScale(边缘光强度)", Float) = 1
		_RimBias ("RimBias(边缘光偏移(默认是0))", Float) = 0
		_RimColor ("RimColor(边缘光颜色)", Vector) = (1,1,1,0)
		_Color ("Color ", Vector) = (0,0,0,0)
		_MainTex ("Base 2D", 2D) = "white" {}
		_ColorTexStrength ("主色贴图强度", Range(0, 1)) = 0.5
		[HideInInspector] _texcoord ("", 2D) = "white" {}
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
			float4 _Color;

			struct Fragment_Stage_Input
			{
				float2 uv : TEXCOORD0;
			};

			float4 frag(Fragment_Stage_Input input) : SV_TARGET
			{
				return _MainTex.Sample(sampler_MainTex, input.uv.xy) * _Color;
			}

			ENDHLSL
		}
	}
}