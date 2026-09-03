Shader "Custom/BossOutBright" {
	Properties {
		_MainColor ("【主颜色】Main Color", Vector) = (0.5,0.5,0.5,1)
		_TextureDiffuse ("【漫反射纹理】Texture Diffuse", 2D) = "white" {}
		_RimColor ("【边缘发光颜色】Rim Color", Vector) = (0.5,0.5,0.5,1)
		_RimPower ("【边缘发光强度】Rim Power", Range(0, 36)) = 0.1
		_RimIntensity ("【边缘发光强度系数】Rim Intensity", Range(0, 100)) = 3
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
	Fallback "Diffuse"
}