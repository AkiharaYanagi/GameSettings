using System;
using System.IO;
using System.Diagnostics;


namespace ScriptEditor
{
	public class AppSettingsData
	{
		//-------------------------------------------------------
		//フルスクリーン / ウィンドウ
		public bool FullScreen { get; set; } = true;

		//ウィンドウサイズ
		public Resolution Resolution { get; set; } = new Resolution ( (int)RESOLUTION.R0_W, (int)RESOLUTION.R0_H );

		//スタート位置
		public enum START_POS { Cursor, Display };
		public START_POS Start_pos { get; set; } = START_POS.Cursor;

		//ディスプレイ番号
		public int DisplayNum { get; set; } = 0;

		//音量
		public int SoundVolume { get; set; } = 50;

		//-------------------------------------------------------



		//コンストラクタ
		public AppSettingsData ()
		{
		}

		public void Init ()
		{
			FullScreen = true;
			Resolution = new Resolution ( 1280, 960 );
			Start_pos = START_POS.Cursor;
			DisplayNum = 0;
			SoundVolume = 50;
		}

		//書出
		public void Save ( string filename )
		{
			using ( var bw = new BinaryWriter ( new FileStream ( filename, FileMode.Create, FileAccess.Write )) )
			{
				bw.Write ( FullScreen );
				bw.Write ( Resolution.W );
				bw.Write ( Resolution.H );
				bw.Write ( (int)Start_pos );
				bw.Write ( DisplayNum );
				bw.Write ( SoundVolume );
			}
		}

		//読込
		public void Load ( string filename )
		{
			try { _Load ( filename ); }
			catch ( Exception e )
			{
				Debug.WriteLine ( e.ToString () );

				Init ();
				Save ( filename );
			}
		}

		private void _Load ( string filename )
		{
			//ファイルチェック
			if ( File.Exists ( filename ) ) //存在するとき読込
			{
				using ( var br = new BinaryReader ( new FileStream ( filename, FileMode.Open, FileAccess.ReadWrite ) ) )
				{
					FullScreen = br.ReadBoolean ();
					Resolution.W = br.ReadInt32 ();
					Resolution.H = br.ReadInt32 ();
					Start_pos = (START_POS)br.ReadInt32 ();
					DisplayNum = br.ReadInt32 ();
					SoundVolume = br.ReadInt32 ();
				}
			}
			else
			{
				//ファイル作成
				Save ( filename );
			}
		}
	}

}
