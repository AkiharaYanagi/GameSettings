namespace ScriptEditor
{
	partial class AppSettings
	{
		/// <summary> 
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose ( bool disposing )
		{
			if ( disposing && (components != null) )
			{
				components.Dispose ();
			}
			base.Dispose ( disposing );
		}

		#region コンポーネント デザイナーで生成されたコード

		/// <summary> 
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent ()
		{
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.Cb_DisplayN = new System.Windows.Forms.ComboBox();
			this.Rb_Cursor = new System.Windows.Forms.RadioButton();
			this.Rb_Display = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.Rb_Wnd = new System.Windows.Forms.RadioButton();
			this.Rb_Flscr = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.Cb_WndSz = new System.Windows.Forms.ComboBox();
			this.Btn_Folder = new System.Windows.Forms.Button();
			this.Btn_cancel = new System.Windows.Forms.Button();
			this.Btn_Save = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.TB_Sound = new System.Windows.Forms.TextBox();
			this.TrackBar_Sound = new System.Windows.Forms.TrackBar();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TrackBar_Sound)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.Cb_DisplayN);
			this.groupBox2.Controls.Add(this.Rb_Cursor);
			this.groupBox2.Controls.Add(this.Rb_Display);
			this.groupBox2.Enabled = false;
			this.groupBox2.Location = new System.Drawing.Point(3, 90);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(317, 82);
			this.groupBox2.TabIndex = 14;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "スタート位置";
			// 
			// Cb_DisplayN
			// 
			this.Cb_DisplayN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Cb_DisplayN.FormattingEnabled = true;
			this.Cb_DisplayN.Location = new System.Drawing.Point(138, 49);
			this.Cb_DisplayN.Name = "Cb_DisplayN";
			this.Cb_DisplayN.Size = new System.Drawing.Size(164, 20);
			this.Cb_DisplayN.TabIndex = 5;
			this.Cb_DisplayN.SelectionChangeCommitted += new System.EventHandler(this.Cb_DisplayN_SelectedIndexChanged);
			// 
			// Rb_Cursor
			// 
			this.Rb_Cursor.AutoSize = true;
			this.Rb_Cursor.Location = new System.Drawing.Point(15, 18);
			this.Rb_Cursor.Name = "Rb_Cursor";
			this.Rb_Cursor.Size = new System.Drawing.Size(85, 16);
			this.Rb_Cursor.TabIndex = 3;
			this.Rb_Cursor.TabStop = true;
			this.Rb_Cursor.Text = "カーソル位置";
			this.Rb_Cursor.UseVisualStyleBackColor = true;
			this.Rb_Cursor.CheckedChanged += new System.EventHandler(this.Rb_Cursor_CheckedChanged);
			// 
			// Rb_Display
			// 
			this.Rb_Display.AutoSize = true;
			this.Rb_Display.Location = new System.Drawing.Point(15, 50);
			this.Rb_Display.Name = "Rb_Display";
			this.Rb_Display.Size = new System.Drawing.Size(100, 16);
			this.Rb_Display.TabIndex = 4;
			this.Rb_Display.TabStop = true;
			this.Rb_Display.Text = "ディスプレイ中央";
			this.Rb_Display.UseVisualStyleBackColor = true;
			this.Rb_Display.CheckedChanged += new System.EventHandler(this.Rb_Display_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.Rb_Wnd);
			this.groupBox1.Controls.Add(this.Rb_Flscr);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.Cb_WndSz);
			this.groupBox1.Enabled = false;
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(317, 81);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "画面表示";
			// 
			// Rb_Wnd
			// 
			this.Rb_Wnd.AutoSize = true;
			this.Rb_Wnd.Location = new System.Drawing.Point(13, 17);
			this.Rb_Wnd.Name = "Rb_Wnd";
			this.Rb_Wnd.Size = new System.Drawing.Size(66, 16);
			this.Rb_Wnd.TabIndex = 5;
			this.Rb_Wnd.TabStop = true;
			this.Rb_Wnd.Text = "ウィンドウ";
			this.Rb_Wnd.UseVisualStyleBackColor = true;
			this.Rb_Wnd.CheckedChanged += new System.EventHandler(this.Rb_Wnd_CheckedChanged);
			// 
			// Rb_Flscr
			// 
			this.Rb_Flscr.AutoSize = true;
			this.Rb_Flscr.Location = new System.Drawing.Point(13, 48);
			this.Rb_Flscr.Name = "Rb_Flscr";
			this.Rb_Flscr.Size = new System.Drawing.Size(84, 16);
			this.Rb_Flscr.TabIndex = 5;
			this.Rb_Flscr.TabStop = true;
			this.Rb_Flscr.Text = "フルスクリーン";
			this.Rb_Flscr.UseVisualStyleBackColor = true;
			this.Rb_Flscr.CheckedChanged += new System.EventHandler(this.Rb_Flscr_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(117, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "ウィンドウサイズ";
			// 
			// Cb_WndSz
			// 
			this.Cb_WndSz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Cb_WndSz.FormattingEnabled = true;
			this.Cb_WndSz.Location = new System.Drawing.Point(200, 13);
			this.Cb_WndSz.Name = "Cb_WndSz";
			this.Cb_WndSz.Size = new System.Drawing.Size(96, 20);
			this.Cb_WndSz.TabIndex = 2;
			this.Cb_WndSz.SelectionChangeCommitted += new System.EventHandler(this.Cb_WndSz_SelectedIndexChanged);
			// 
			// Btn_Folder
			// 
			this.Btn_Folder.Location = new System.Drawing.Point(18, 364);
			this.Btn_Folder.Name = "Btn_Folder";
			this.Btn_Folder.Size = new System.Drawing.Size(54, 39);
			this.Btn_Folder.TabIndex = 17;
			this.Btn_Folder.Text = "フォルダ";
			this.Btn_Folder.UseVisualStyleBackColor = true;
			this.Btn_Folder.Click += new System.EventHandler(this.Btn_Folder_Click);
			// 
			// Btn_cancel
			// 
			this.Btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.Btn_cancel.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Btn_cancel.Location = new System.Drawing.Point(182, 379);
			this.Btn_cancel.Name = "Btn_cancel";
			this.Btn_cancel.Size = new System.Drawing.Size(123, 24);
			this.Btn_cancel.TabIndex = 16;
			this.Btn_cancel.Text = "キャンセルして終了";
			this.Btn_cancel.UseVisualStyleBackColor = false;
			this.Btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
			// 
			// Btn_Save
			// 
			this.Btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Btn_Save.Location = new System.Drawing.Point(320, 340);
			this.Btn_Save.Name = "Btn_Save";
			this.Btn_Save.Size = new System.Drawing.Size(85, 63);
			this.Btn_Save.TabIndex = 15;
			this.Btn_Save.Text = "保存して終了";
			this.Btn_Save.UseVisualStyleBackColor = false;
			this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.TB_Sound);
			this.groupBox3.Controls.Add(this.TrackBar_Sound);
			this.groupBox3.Location = new System.Drawing.Point(3, 178);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(317, 69);
			this.groupBox3.TabIndex = 18;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "音量";
			// 
			// TB_Sound
			// 
			this.TB_Sound.Location = new System.Drawing.Point(8, 22);
			this.TB_Sound.Name = "TB_Sound";
			this.TB_Sound.Size = new System.Drawing.Size(42, 19);
			this.TB_Sound.TabIndex = 1;
			this.TB_Sound.Text = "50";
			this.TB_Sound.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Sound_KeyPress);
			// 
			// TrackBar_Sound
			// 
			this.TrackBar_Sound.LargeChange = 10;
			this.TrackBar_Sound.Location = new System.Drawing.Point(56, 18);
			this.TrackBar_Sound.Maximum = 100;
			this.TrackBar_Sound.Name = "TrackBar_Sound";
			this.TrackBar_Sound.Size = new System.Drawing.Size(255, 45);
			this.TrackBar_Sound.TabIndex = 0;
			this.TrackBar_Sound.TickFrequency = 10;
			this.TrackBar_Sound.Value = 50;
			this.TrackBar_Sound.Scroll += new System.EventHandler(this.TrackBar_Sound_Scroll);
			// 
			// AppSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.Btn_Folder);
			this.Controls.Add(this.Btn_cancel);
			this.Controls.Add(this.Btn_Save);
			this.Name = "AppSettings";
			this.Size = new System.Drawing.Size(424, 420);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.TrackBar_Sound)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox Cb_DisplayN;
		private System.Windows.Forms.RadioButton Rb_Cursor;
		private System.Windows.Forms.RadioButton Rb_Display;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton Rb_Wnd;
		private System.Windows.Forms.RadioButton Rb_Flscr;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox Cb_WndSz;
		private System.Windows.Forms.Button Btn_Folder;
		private System.Windows.Forms.Button Btn_cancel;
		private System.Windows.Forms.Button Btn_Save;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TrackBar TrackBar_Sound;
		private System.Windows.Forms.TextBox TB_Sound;
	}
}
