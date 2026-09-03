Shader "XR/xr_s_bottlelocal01" {
	Properties {
		_lightcolor1 ("lightcolor", Vector) = (1,1,1,1)
		_shadowcolor1 ("shadowcolor", Vector) = (0.2169811,0.2169811,0.2169811,1)
		_waveTex1 ("waveTex", 2D) = "white" {}
		_nosiescale1 ("nosiescale", Float) = 0.1
		_wavespeed1 ("wavespeed", Float) = 0.1
		_cutVal1 ("cutVal", Float) = 2
		_wavescale1 ("wavescale", Float) = 2
		[Enum(UnityEngine.Rendering.CullMode)] _CullMode1 ("CullMode", Float) = 0
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
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

			float4 frag(Vertex_Stage_Output input) : SV_TARGET
			{
				return float4(1.0, 1.0, 1.0, 1.0); // RGBA
			}

			ENDHLSL
		}
	}
	//CustomEditor "ASEMaterialInspector"
}