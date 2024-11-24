using System;
using System.Diagnostics;
using System.IO;


namespace GameSettings
{
	//---------------------------------------------------------------------
	// ◆ GameSettings [ binary ] 20(=4*5) byte
	//	┃
	//	┣(int)	開始状態	( 0:通常(タイトル), 1:戦闘から, 2:トレーニングモード )
	//	┣(bool)	デモ	
	//	┣(int)	操作1p	( 0:プレイヤ, 1:CPU )
	//	┣(int)	操作2p
	//	┣(int)	キャラ1p	( 0:テスト用, 1:楽乃, 2:有嬉乃, 3:ランダム )
	//	┣(int)	キャラ2p
	//	┣(int)	bgm
	//
	//	(enum) -> (int)
	//---------------------------------------------------------------------

	//ゲーム内で用いる設定群
	public class GameSettingsData
	{

		//C++ GameMain 開始状態
#if false
		enum START_MODE
		{
			START_TITLE_INTRO,
			START_INTRO,
			START_CHARA_SELE,
			START_BATTLE,
			START_RESULT,
			START_TRAINING,
			TEST_VOID,
		};
#endif

		//開始状態
		public enum Stng_Start
		{
			General,
			Intro,
			CharaSele,
			Battle, 
			Result,
			Traning, 
		};

		public Stng_Start Start { get; set; } = Stng_Start.General;

		//デモ
		public bool Demo { get; set; } = false;

		//操作
		public enum Stng_Operate
		{
			Player, CPU,
		};

		public Stng_Operate Operate1p { get; set; } = Stng_Operate.Player;
		public Stng_Operate Operate2p { get; set; } = Stng_Operate.Player;

		//キャラ
		public enum Stng_Chara
		{
			Test, Ouka, Sae, Retsudou, Random, 
		};

		public Stng_Chara Chara1p { get; set; } = Stng_Chara.Sae;
		public Stng_Chara Chara2p { get; set; } = Stng_Chara.Sae;

		//BGM
		public enum BGM_ID
		{
			BGM_ID_GABA,
			BGM_ID_OUKA,
			BGM_ID_SAE,
			BGM_ID_RETSU,
		}

		public BGM_ID Bgm_id { get; set; } = BGM_ID.BGM_ID_GABA;


		//-------------------------------------------------------------------
		public void Init ()
		{
			Start = Stng_Start.General;
			Demo = false;
			Operate1p = Stng_Operate.Player;
			Operate2p = Stng_Operate.Player;
			Chara1p = Stng_Chara.Sae;
			Chara2p = Stng_Chara.Sae;
			Bgm_id = BGM_ID.BGM_ID_GABA;
		}

		public void Save ( string filename )
		{
			using ( FileStream fs = new FileStream ( filename, FileMode.Create, FileAccess.Write ) )
			using ( BinaryWriter bw = new BinaryWriter ( fs ) )
			{ 
				bw.Write ( (byte)Start );
				bw.Write ( Demo );			//bool
				bw.Write ( (byte)Operate1p );
				bw.Write ( (byte)Operate2p );
				bw.Write ( (byte)Chara1p );
				bw.Write ( (byte)Chara2p );
				bw.Write ( (byte)Bgm_id );
			}
		}

		public void Load ( string filename )
		{
			try
			{
				using ( FileStream fs = new FileStream ( filename, FileMode.Open, FileAccess.Read ) )
				using ( BinaryReader br = new BinaryReader ( fs ) )
				{ 
					Start = (Stng_Start) br.ReadByte ();
					Demo = br.ReadBoolean ();
					Operate1p = (Stng_Operate) br.ReadByte ();
					Operate2p = (Stng_Operate) br.ReadByte ();
					Chara1p = (Stng_Chara) br.ReadByte ();
					Chara2p = (Stng_Chara) br.ReadByte ();
					Bgm_id = (BGM_ID) br.ReadByte ();
				}

			}
			catch ( Exception e )
			{
				Debug.WriteLine ( e.ToString () );

				//例外時は初期化データ
				Init ();
			}
		}
	}
}
