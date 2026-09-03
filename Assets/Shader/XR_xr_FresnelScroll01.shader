Shader "XR/xr_FresnelScroll01" {
	Properties {
		_MainTEX ("MainTEX", 2D) = "white" {}
		_Uspeed ("Uspeed", Float) = 1
		_Vspeed ("Vspeed", Float) = 1
		_FresnelRangeVal ("FresnelRangeVal", Range(0, 1)) = 0.5
		[Toggle(_USEFORPARTICALSYS_ON)] _UseForParticalSys ("UseForParticalSys", Float) = 1
		_ColorForMesh ("ColorForMesh", Vector) = (1,0,0,1)
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