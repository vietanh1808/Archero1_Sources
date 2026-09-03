Shader "Custom/Diamond" {
	Properties {
		[Header(Base Settings)] _Color ("整体颜色 (Main Color)", Vector) = (1,0,0,0)
		[Header(Reflection and Refraction)] _RefractTex ("折射 Cube (Refract)", Cube) = "white" {}
		_ReflectTex ("反射 Cube (Reflect)", Cube) = "white" {}
		_RefInt ("反射强度 (Reflect Intensity)", Range(0, 5)) = 1
		_RefInt1 ("反射区域强度 (Reflect Zone Int)", Range(0, 5)) = 1
		[Header(Fresnel Settings)] _FresnelPower ("菲涅尔指数 (Power)", Float) = 2
		_FresnelInt ("菲涅尔强度 (Intensity)", Float) = 1
		_FresnelBias ("菲涅尔偏移 (Bias)", Float) = 0
		_FresnelColor ("菲涅尔颜色 (Color)", Vector) = (1,1,1,0)
		_MaskIntensity ("Mask Intensity", Range(0, 2)) = 1
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

			struct Vertex_Stage_Input
			{
				float4 pos : POSITION;
			};

			struct Vertex_Stage_Output
			{
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
				return output;
			}

			float4 _Color;

			float4 frag(Vertex_Stage_Output input) : SV_TARGET
			{
				return _Color; // RGBA
			}

			ENDHLSL
		}
	}
	Fallback "Diffuse"
}