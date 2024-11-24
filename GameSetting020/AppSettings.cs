using System;
using System.Windows.Forms;
using System.ComponentModel;


namespace ScriptEditor
{
	//--------------------------------------------------------
	//	設定コントロール
	//--------------------------------------------------------
	public partial class AppSettings : UserControl
	{
		public const string FileName = "AppSettings.dat" ;
	
		AppSettingsData AppStg = new AppSettingsData ();
		private	ToolTip tltip;
		private BindingList < Resolution > BL_Resol = new BindingList<Resolution> ();

		public AppSettings ()
		{
			InitializeComponent ();

			tltip = new ToolTip ();
			BL_Resol.Add ( new Resolution ( (int)RESOLUTION.R0_W, (int)RESOLUTION.R0_H ) );
			BL_Resol.Add ( new Resolution ( (int)RESOLUTION.R1_W, (int)RESOLUTION.R1_H ) );
			BL_Resol.Add ( new Resolution ( (int)RESOLUTION.R2_W, (int)RESOLUTION.R2_H ) );
			Cb_WndSz.DataSource = BL_Resol;

			AppStg.Load ( FileName );
			SetData ( AppStg );
		}

		//対象データの設定
		public void SetData ( AppSettingsData appsttg )
		{
			//対象データ
			AppStg = appsttg;

			//画面サイズ
			Resolution rslt = new Resolution ( appsttg.Resolution.W, appsttg.Resolution.H );
			int index = BL_Resol.IndexOf ( rslt );
			if ( -1 == index ) { Cb_WndSz.SelectedIndex = 0; }
			else { Cb_WndSz.SelectedIndex = index; }

			//ウィンドウ / フルスクリーン
			Rb_Wnd.Checked = ! appsttg.FullScreen;
			Rb_Flscr.Checked = appsttg.FullScreen;

			//スタート位置
			Rb_Cursor.Checked = ( AppSettingsData.START_POS.Cursor == appsttg.Start_pos );
			Rb_Display.Checked = ! Rb_Cursor.Checked;
//			Cb_DisplayN.Enabled = false;

			//ディスプレイの列挙
			foreach ( Screen scrn in Screen.AllScreens )
			{
				Cb_DisplayN.Items.Add ( scrn.DeviceName );
			}
			Cb_DisplayN.SelectedIndex = 0;
			tltip.SetToolTip ( Cb_DisplayN, Cb_DisplayN.SelectedItem.ToString () );

			//音量
			SetSoundVolume ( AppStg.SoundVolume );
		}


		//ウィンドウサイズ設定時
		private void Cb_WndSz_SelectedIndexChanged ( object sender, EventArgs e )
		{
			AppStg.Resolution = (Resolution) Cb_WndSz.SelectedItem;
		}


		//ディスプレイ番号設定時
		private void Cb_DisplayN_SelectedIndexChanged ( object sender, EventArgs e )
		{
			tltip.SetToolTip ( Cb_DisplayN, Cb_DisplayN.SelectedItem.ToString () );
		}

		//フォルダ
		private void Btn_Folder_Click ( object sender, EventArgs e )
		{
			FormUtility.OpenCurrentDir ();
		}

		//保存して終了
		private void Btn_Save_Click ( object sender, EventArgs e )
		{
			AppStg.Save ( FileName );
			Application.Exit ();
		}

		//キャンセルして終了
		private void Btn_cancel_Click ( object sender, EventArgs e )
		{
			Application.Exit ();
		}

		//-----------------------------------------------------------------------
		private void Rb_Wnd_CheckedChanged ( object sender, EventArgs e )
		{
			AppStg.FullScreen = Rb_Flscr.Checked;
		}

		private void Rb_Flscr_CheckedChanged ( object sender, EventArgs e )
		{
			AppStg.FullScreen = Rb_Flscr.Checked;
		}

		private void Rb_Cursor_CheckedChanged ( object sender, EventArgs e )
		{
			AppStg.Start_pos = AppSettingsData.START_POS.Cursor;
		}

		private void Rb_Display_CheckedChanged ( object sender, EventArgs e )
		{
			AppStg.Start_pos = AppSettingsData.START_POS.Display;
		}

		//-----------------------------------------------------------------------
		//音量

		private void SetSoundVolume ( int n )
		{
			if ( 0 <= n && n <= 100 )
			{
				TB_Sound.Text = n.ToString ();
				TB_Sound.Invalidate ();
				TrackBar_Sound.Value = n;
				TrackBar_Sound.Invalidate ();
			}
		}

		//トラックバー
//		private int sound_volume = 50;

		private void TrackBar_Sound_Scroll ( object sender, EventArgs e )
		{
			AppStg.SoundVolume = TrackBar_Sound.Value;
			TB_Sound.Text = AppStg.SoundVolume.ToString ();
			TB_Sound.Invalidate ();
		}

		//キー押下時(文字列判定)
		private void TB_Sound_KeyPress ( object sender, KeyPressEventArgs e )
		{
			char c = e.KeyChar;

			//数字、BackSpaceだけ入力可能(他は弾く)
			if ( c == '\b' )
			{
				e.Handled = false;
			}
			else if ( ! char.IsDigit ( c ) )
			{
				e.Handled = true;
			}

			//整数値 ( 0 ~ 100 )
			int n = 50;
			try
			{
				n = int.Parse ( TB_Sound.Text );
			}
			catch
			{
				n = 50;
			}

			if ( 0 <= n && n <= 100 )
			{
				AppStg.SoundVolume = n;
				TrackBar_Sound.Value = n;
				TrackBar_Sound.Invalidate ();
			}

			base.OnKeyPress(e);
		}
	}
}
