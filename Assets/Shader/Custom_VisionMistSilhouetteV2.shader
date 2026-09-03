Shader "Custom/VisionMistSilhouetteV2" {
	Properties {
		_SilhouetteColor ("轮廓荧光颜色", Vector) = (0.3,0.8,1,1)
		_SilhouetteRimScale ("轮廓边缘渐变速率", Range(0.1, 10)) = 1.5
		_SilhouetteAlpha ("轮廓整体透明度", Range(0, 1)) = 1
		_PlayerUV ("Player Center UV", Vector) = (0.5,0.5,0,0)
		_BrightUV ("Bright Center UV", Vector) = (0.5,0.5,0,0)
		_PlayerRadius ("Player Radius XY", Vector) = (0.2,0.2,0,0)
		_BrightRadius ("Bright Radius XY", Vector) = (0.15,0.15,0,0)
		_PlayerSoftness ("Player Softness", Float) = 0.02
		_BrightSoftness ("Bright Softness", Float) = 0.02
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
}