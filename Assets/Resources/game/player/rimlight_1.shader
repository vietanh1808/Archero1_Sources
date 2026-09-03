Shader "Custom/RimLight_1" {
	Properties {
		_BaseColor ("BaseColor", 2D) = "white" {}
		_RimPower ("RimPower", Float) = 5
		_RimScale ("RimScale", Float) = 1
		_RimBias ("RimBias", Float) = 0
		_RimColor ("RimColor", Vector) = (1,0.6469706,0.4025156,0)
		_InnerAlpha ("InnerAlpha", Float) = 0
		_EmissMap ("EmissMap", 2D) = "white" {}
		_FlowTillingSpeed ("FlowTillingSpeed", Vector) = (0,0,0,0)
		_FlowRimBias ("FlowRimBias", Float) = 0
		_FlowRimScale ("FlowRimScale", Float) = 2
		_FlowLightColor ("FlowLightColor", Vector) = (1,0.909092,0.4119496,0)
		_NebulaTilling ("NebulaTilling", Vector) = (1,1,0,0)
		_NebulaTex ("Nebula Tex", 2D) = "white" {}
		_NebulaDis ("NebulaDis", Float) = 0
		_NebulaIntensity ("NebulaIntensity", Float) = 1
		[HideInInspector] _texcoord ("", 2D) = "white" {}
		[HideInInspector] __dirty ("", Float) = 1
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