using System;
using System.IO;
using System.Windows.Forms;
using ScriptEditor;


namespace GameSettings
{
	using STG_STRT = GameSettingsData.Stng_Start;
	using STG_OPRT = GameSettingsData.Stng_Operate;
	using STG_CHAR = GameSettingsData.Stng_Chara;
	using STG_BGM = GameSettingsData.BGM_ID;


	public partial class Ctrl_GameSettings : UserControl
	{
		//-----------------------------------------------------
		//対象データ
		private GameSettingsData stgData = new GameSettingsData ();

		//対象ファイル名
		private string filename = "GameSettings.dat";

		//-----------------------------------------------------
		//コンストラクタ
		public Ctrl_GameSettings ()
		{
			InitializeComponent ();

			//キャラ選択 コンボボックス初期化
			Array ary = Enum.GetValues ( typeof (STG_CHAR) );
			foreach (var item in ary)
			{
				CB_Chara1.Items.Add ( (STG_CHAR)item );
				CB_Chara2.Items.Add ( (STG_CHAR)item );
			}
			CB_Chara1.SelectedIndex = 0;
			CB_Chara2.SelectedIndex = 0;

			//BGM選択 コンボボックス初期化
			Array aryBGM = Enum.GetValues ( typeof (STG_BGM) );
			foreach (var item in aryBGM)
			{
				CB_BGM.Items.Add ( (STG_BGM)item );
			}
			CB_BGM.SelectedIndex = 0;


			//開始時に読込
			string filepath = Directory.GetCurrentDirectory () + "\\" + filename;
			stgData.Load ( filename );
			SetCrtDir ( filepath );


			//データをコントロールに反映
			InitCtrl ();
		}

		public void InitCtrl ()
		{
			//開始状態
			switch ( stgData.Start )
			{ 
			case STG_STRT.General : SelectRB_Start ( RB_General ); break;
			case STG_STRT.Battle : SelectRB_Start ( RB_Battle ); break;
			case STG_STRT.Traning : SelectRB_Start ( RB_Training ); break;
			case STG_STRT.Result : SelectRB_Start ( RB_Result ); break;
			}

			//デモ
			CHK_Demo.Checked = stgData.Demo;

			//操作
			switch ( stgData.Operate1p )
			{
			case STG_OPRT.Player : SelectRB_Operate1 ( RB_Player1 ); break;
			case STG_OPRT.CPU : SelectRB_Operate1 ( RB_CPU1 ); break;
			}
			switch ( stgData.Operate2p )
			{
			case STG_OPRT.Player : SelectRB_Operate2 ( RB_Player2 ); break;
			case STG_OPRT.CPU : SelectRB_Operate2 ( RB_CPU2 ); break;
			}

			//キャラ
			CB_Chara1.SelectedItem = stgData.Chara1p;
			CB_Chara2.SelectedItem = stgData.Chara2p;

			CB_BGM.SelectedItem = stgData.Bgm_id;
		}


		private void SelectRB_Start ( RadioButton rb )
		{
			//全てOFF
			RB_General.Checked = false;
			RB_Battle.Checked = false;
			RB_Training.Checked = false;
			RB_Result.Checked = false;

			//対象をON
			rb.Checked = true;
		}

		private void SelectRB_Operate1 ( RadioButton rb )
		{
			//全てOFF
			RB_Player1.Checked = false;
			RB_CPU1.Checked = false;

			//対象をON
			rb.Checked = true;
		}

		private void SelectRB_Operate2 ( RadioButton rb )
		{
			//全てOFF
			RB_Player2.Checked = false;
			RB_CPU2.Checked = false;

			//対象をON
			rb.Checked = true;
		}

		private void SelectCB_Chara1 ( STG_CHAR ch )
		{
			CB_Chara1.SelectedItem = ch;
		}

		private void SelectCB_Chara2 ( STG_CHAR ch )
		{
			CB_Chara2.SelectedItem = ch;
		}


		//========================================================================
		//	コントロールイベント
		//========================================================================

		//ファイルのフルパスから表示を設定する
		private void SetCrtDir ( string fullpath )
		{
			string dir = Path.GetDirectoryName ( fullpath );
			Directory.SetCurrentDirectory ( dir );

			string crtDir = Directory.GetCurrentDirectory () + "\\";
			Lbl_Dir.Text = crtDir;
			TLTP_Folder.SetToolTip ( Lbl_Dir, crtDir );

			string filename = Path.GetFileName ( fullpath );
			Lbl_Filepath.Text = filename;
		}

		//----------------------------------------------------------------------
		//入出力ボタン

		//設定ファイル
		private void Btn_StgFile_Click ( object sender, EventArgs e )
		{
			OpenFileDialog dlg = new OpenFileDialog ();
			if ( dlg.ShowDialog () == DialogResult.OK )
			{
				stgData.Load ( dlg.FileName );
				SetCrtDir ( dlg.FileName );
			}
		}

		//フォルダ
		private void Btn_Folder_Click ( object sender, System.EventArgs e )
		{
			FormUtility.OpenCurrentDir ();
			string crtDir = Directory.GetCurrentDirectory () + "\\";
			Lbl_Dir.Text = crtDir;
			TLTP_Folder.SetToolTip ( Lbl_Dir, crtDir );
		}

		//保存
		private void Btn_Decide_Click ( object sender, System.EventArgs e )
		{
			stgData.Save ( filename );
			Application.Exit ();
		}

		//キャンセル
		private void Btn_Cancel_Click ( object sender, System.EventArgs e )
		{
			Application.Exit ();
		}


		//----------------------------------------------------------------------
		//ラジオボタン選択：開始状態
		private void RB_General_CheckedChanged ( object sender, EventArgs e )
		{
			stgData.Start = STG_STRT.General;
		}

		private void RB_Battle_CheckedChanged ( object sender, EventArgs e )
		{
			stgData.Start = STG_STRT.Battle;
		}

		private void RB_Training_CheckedChanged ( object sender, EventArgs e )
		{
			stgData.Start = STG_STRT.Traning;
		}

		private void RB_Result_CheckedChanged ( object sender, EventArgs e )
		{
			stgData.Start = STG_STRT.Result;
		}

		//----------------------------------------------------------------------
		//チェックボックス選択
		
		//デモモード
		private void CHK_Demo_CheckedChanged ( object sender, EventArgs e )
		{
			stgData.Demo = CHK_Demo.Checked;
		}

		//----------------------------------------------------------------------
		//ラジオボタン選択：操作者指定
		private void RB_Player1_CheckedChanged ( object sender, EventArgs e )
		{
			if ( RB_Player1.Checked )
			{
				stgData.Operate1p = STG_OPRT.Player;
			}
		}

		private void RB_CPU1_CheckedChanged ( object sender, EventArgs e )
		{
			if ( RB_CPU1.Checked )
			{
				stgData.Operate1p = STG_OPRT.CPU;
			}
		}

		private void RB_Player2_CheckedChanged ( object sender, EventArgs e )
		{
			if ( RB_Player2.Checked )
			{
				stgData.Operate2p = STG_OPRT.Player;
			}
		}

		private void RB_CPU2_CheckedChanged ( object sender, EventArgs e )
		{
			if ( RB_CPU2.Checked )
			{
				stgData.Operate2p = STG_OPRT.CPU;
			}
		}

		//----------------------------------------------------------------------
		//ドロップダウンリスト選択反映
		private void CB_Chara1_SelectionChangeCommitted ( object sender, EventArgs e )
		{
			stgData.Chara1p = (STG_CHAR)CB_Chara1.SelectedItem;
		}

		private void CB_Chara2_SelectionChangeCommitted ( object sender, EventArgs e )
		{
			stgData.Chara2p = (STG_CHAR)CB_Chara2.SelectedItem;
		}

		private void CB_BGM_SelectionChangeCommitted ( object sender, EventArgs e )
		{
			stgData.Bgm_id = (STG_BGM)CB_BGM.SelectedItem;
		}
	}
}
