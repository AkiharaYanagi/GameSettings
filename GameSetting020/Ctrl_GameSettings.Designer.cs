namespace GameSettings
{
	partial class Ctrl_GameSettings
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
			this.components = new System.ComponentModel.Container();
			this.Btn_Decide = new System.Windows.Forms.Button();
			this.Btn_Cancel = new System.Windows.Forms.Button();
			this.Btn_Folder = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.CB_Chara2 = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.RB_CPU2 = new System.Windows.Forms.RadioButton();
			this.RB_Player2 = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.CB_Chara1 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.RB_CPU1 = new System.Windows.Forms.RadioButton();
			this.RB_Player1 = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.RB_Result = new System.Windows.Forms.RadioButton();
			this.RB_Training = new System.Windows.Forms.RadioButton();
			this.RB_Battle = new System.Windows.Forms.RadioButton();
			this.RB_General = new System.Windows.Forms.RadioButton();
			this.CHK_Demo = new System.Windows.Forms.CheckBox();
			this.Lbl_Filepath = new System.Windows.Forms.Label();
			this.Btn_StgFile = new System.Windows.Forms.Button();
			this.TLTP_Folder = new System.Windows.Forms.ToolTip(this.components);
			this.Lbl_Dir = new System.Windows.Forms.Label();
			this.CB_BGM = new System.Windows.Forms.ComboBox();
			this.Lbl_BGM = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Btn_Decide
			// 
			this.Btn_Decide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Btn_Decide.Location = new System.Drawing.Point(378, 419);
			this.Btn_Decide.Name = "Btn_Decide";
			this.Btn_Decide.Size = new System.Drawing.Size(121, 51);
			this.Btn_Decide.TabIndex = 8;
			this.Btn_Decide.Text = "保存して閉じる";
			this.Btn_Decide.UseVisualStyleBackColor = false;
			this.Btn_Decide.Click += new System.EventHandler(this.Btn_Decide_Click);
			// 
			// Btn_Cancel
			// 
			this.Btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.Btn_Cancel.Location = new System.Drawing.Point(238, 435);
			this.Btn_Cancel.Name = "Btn_Cancel";
			this.Btn_Cancel.Size = new System.Drawing.Size(118, 35);
			this.Btn_Cancel.TabIndex = 9;
			this.Btn_Cancel.Text = "キャンセルして閉じる";
			this.Btn_Cancel.UseVisualStyleBackColor = false;
			this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
			// 
			// Btn_Folder
			// 
			this.Btn_Folder.BackColor = System.Drawing.Color.LemonChiffon;
			this.Btn_Folder.Location = new System.Drawing.Point(11, 12);
			this.Btn_Folder.Name = "Btn_Folder";
			this.Btn_Folder.Size = new System.Drawing.Size(89, 40);
			this.Btn_Folder.TabIndex = 10;
			this.Btn_Folder.Text = "フォルダを\r\n開く";
			this.Btn_Folder.UseVisualStyleBackColor = false;
			this.Btn_Folder.Click += new System.EventHandler(this.Btn_Folder_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
			this.pictureBox1.Location = new System.Drawing.Point(3, 213);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(10, 169);
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.CB_Chara2);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.RB_CPU2);
			this.groupBox3.Controls.Add(this.RB_Player2);
			this.groupBox3.Location = new System.Drawing.Point(22, 307);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(477, 77);
			this.groupBox3.TabIndex = 5;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "2P";
			// 
			// CB_Chara2
			// 
			this.CB_Chara2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CB_Chara2.FormattingEnabled = true;
			this.CB_Chara2.Location = new System.Drawing.Point(271, 29);
			this.CB_Chara2.Name = "CB_Chara2";
			this.CB_Chara2.Size = new System.Drawing.Size(147, 20);
			this.CB_Chara2.TabIndex = 3;
			this.CB_Chara2.SelectionChangeCommitted += new System.EventHandler(this.CB_Chara2_SelectionChangeCommitted);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(214, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 12);
			this.label3.TabIndex = 2;
			this.label3.Text = "キャラ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(10, 26);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 12);
			this.label4.TabIndex = 1;
			this.label4.Text = "操作";
			// 
			// RB_CPU2
			// 
			this.RB_CPU2.AutoSize = true;
			this.RB_CPU2.Location = new System.Drawing.Point(58, 43);
			this.RB_CPU2.Name = "RB_CPU2";
			this.RB_CPU2.Size = new System.Drawing.Size(46, 16);
			this.RB_CPU2.TabIndex = 0;
			this.RB_CPU2.Text = "CPU";
			this.RB_CPU2.UseVisualStyleBackColor = true;
			this.RB_CPU2.CheckedChanged += new System.EventHandler(this.RB_CPU2_CheckedChanged);
			// 
			// RB_Player2
			// 
			this.RB_Player2.AutoSize = true;
			this.RB_Player2.Checked = true;
			this.RB_Player2.Location = new System.Drawing.Point(58, 21);
			this.RB_Player2.Name = "RB_Player2";
			this.RB_Player2.Size = new System.Drawing.Size(70, 16);
			this.RB_Player2.TabIndex = 0;
			this.RB_Player2.TabStop = true;
			this.RB_Player2.Text = "プレイヤー";
			this.RB_Player2.UseVisualStyleBackColor = true;
			this.RB_Player2.CheckedChanged += new System.EventHandler(this.RB_Player2_CheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.CB_Chara1);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.RB_CPU1);
			this.groupBox2.Controls.Add(this.RB_Player1);
			this.groupBox2.Location = new System.Drawing.Point(22, 213);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(477, 77);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "1P";
			// 
			// CB_Chara1
			// 
			this.CB_Chara1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CB_Chara1.FormattingEnabled = true;
			this.CB_Chara1.Location = new System.Drawing.Point(271, 29);
			this.CB_Chara1.Name = "CB_Chara1";
			this.CB_Chara1.Size = new System.Drawing.Size(147, 20);
			this.CB_Chara1.TabIndex = 3;
			this.CB_Chara1.SelectionChangeCommitted += new System.EventHandler(this.CB_Chara1_SelectionChangeCommitted);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(214, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 12);
			this.label2.TabIndex = 2;
			this.label2.Text = "キャラ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 12);
			this.label1.TabIndex = 1;
			this.label1.Text = "操作";
			// 
			// RB_CPU1
			// 
			this.RB_CPU1.AutoSize = true;
			this.RB_CPU1.Location = new System.Drawing.Point(58, 43);
			this.RB_CPU1.Name = "RB_CPU1";
			this.RB_CPU1.Size = new System.Drawing.Size(46, 16);
			this.RB_CPU1.TabIndex = 0;
			this.RB_CPU1.Text = "CPU";
			this.RB_CPU1.UseVisualStyleBackColor = true;
			this.RB_CPU1.CheckedChanged += new System.EventHandler(this.RB_CPU1_CheckedChanged);
			// 
			// RB_Player1
			// 
			this.RB_Player1.AutoSize = true;
			this.RB_Player1.Checked = true;
			this.RB_Player1.Location = new System.Drawing.Point(58, 21);
			this.RB_Player1.Name = "RB_Player1";
			this.RB_Player1.Size = new System.Drawing.Size(70, 16);
			this.RB_Player1.TabIndex = 0;
			this.RB_Player1.TabStop = true;
			this.RB_Player1.Text = "プレイヤー";
			this.RB_Player1.UseVisualStyleBackColor = true;
			this.RB_Player1.CheckedChanged += new System.EventHandler(this.RB_Player1_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.RB_Result);
			this.groupBox1.Controls.Add(this.RB_Training);
			this.groupBox1.Controls.Add(this.RB_Battle);
			this.groupBox1.Controls.Add(this.RB_General);
			this.groupBox1.Location = new System.Drawing.Point(3, 109);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(496, 57);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "開始シーン";
			// 
			// RB_Result
			// 
			this.RB_Result.AutoSize = true;
			this.RB_Result.Location = new System.Drawing.Point(340, 18);
			this.RB_Result.Name = "RB_Result";
			this.RB_Result.Size = new System.Drawing.Size(58, 16);
			this.RB_Result.TabIndex = 1;
			this.RB_Result.Text = "リザルト";
			this.RB_Result.UseVisualStyleBackColor = true;
			this.RB_Result.CheckedChanged += new System.EventHandler(this.RB_Result_CheckedChanged);
			// 
			// RB_Training
			// 
			this.RB_Training.AutoSize = true;
			this.RB_Training.Location = new System.Drawing.Point(222, 18);
			this.RB_Training.Name = "RB_Training";
			this.RB_Training.Size = new System.Drawing.Size(77, 16);
			this.RB_Training.TabIndex = 1;
			this.RB_Training.Text = "トレーニング";
			this.RB_Training.UseVisualStyleBackColor = true;
			this.RB_Training.CheckedChanged += new System.EventHandler(this.RB_Training_CheckedChanged);
			// 
			// RB_Battle
			// 
			this.RB_Battle.AutoSize = true;
			this.RB_Battle.Location = new System.Drawing.Point(130, 18);
			this.RB_Battle.Name = "RB_Battle";
			this.RB_Battle.Size = new System.Drawing.Size(51, 16);
			this.RB_Battle.TabIndex = 1;
			this.RB_Battle.Text = "バトル";
			this.RB_Battle.UseVisualStyleBackColor = true;
			this.RB_Battle.CheckedChanged += new System.EventHandler(this.RB_Battle_CheckedChanged);
			// 
			// RB_General
			// 
			this.RB_General.AutoSize = true;
			this.RB_General.Checked = true;
			this.RB_General.Location = new System.Drawing.Point(31, 18);
			this.RB_General.Name = "RB_General";
			this.RB_General.Size = new System.Drawing.Size(58, 16);
			this.RB_General.TabIndex = 0;
			this.RB_General.TabStop = true;
			this.RB_General.Text = "タイトル";
			this.RB_General.UseVisualStyleBackColor = true;
			this.RB_General.CheckedChanged += new System.EventHandler(this.RB_General_CheckedChanged);
			// 
			// CHK_Demo
			// 
			this.CHK_Demo.AutoSize = true;
			this.CHK_Demo.Location = new System.Drawing.Point(11, 181);
			this.CHK_Demo.Name = "CHK_Demo";
			this.CHK_Demo.Size = new System.Drawing.Size(196, 16);
			this.CHK_Demo.TabIndex = 11;
			this.CHK_Demo.Text = "デモモード(自動CPU_VS_CPU繰返)";
			this.CHK_Demo.UseVisualStyleBackColor = true;
			this.CHK_Demo.CheckedChanged += new System.EventHandler(this.CHK_Demo_CheckedChanged);
			// 
			// Lbl_Filepath
			// 
			this.Lbl_Filepath.AutoSize = true;
			this.Lbl_Filepath.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Lbl_Filepath.Location = new System.Drawing.Point(106, 58);
			this.Lbl_Filepath.Name = "Lbl_Filepath";
			this.Lbl_Filepath.Size = new System.Drawing.Size(62, 16);
			this.Lbl_Filepath.TabIndex = 12;
			this.Lbl_Filepath.Text = "filename";
			// 
			// Btn_StgFile
			// 
			this.Btn_StgFile.Location = new System.Drawing.Point(11, 58);
			this.Btn_StgFile.Name = "Btn_StgFile";
			this.Btn_StgFile.Size = new System.Drawing.Size(89, 20);
			this.Btn_StgFile.TabIndex = 13;
			this.Btn_StgFile.Text = "設定ファイル";
			this.Btn_StgFile.UseVisualStyleBackColor = true;
			this.Btn_StgFile.Click += new System.EventHandler(this.Btn_StgFile_Click);
			// 
			// Lbl_Dir
			// 
			this.Lbl_Dir.AutoSize = true;
			this.Lbl_Dir.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Lbl_Dir.Location = new System.Drawing.Point(106, 22);
			this.Lbl_Dir.Name = "Lbl_Dir";
			this.Lbl_Dir.Size = new System.Drawing.Size(70, 16);
			this.Lbl_Dir.TabIndex = 12;
			this.Lbl_Dir.Text = "Directory";
			// 
			// CB_BGM
			// 
			this.CB_BGM.FormattingEnabled = true;
			this.CB_BGM.Location = new System.Drawing.Point(22, 435);
			this.CB_BGM.Name = "CB_BGM";
			this.CB_BGM.Size = new System.Drawing.Size(185, 20);
			this.CB_BGM.TabIndex = 14;
			this.CB_BGM.SelectionChangeCommitted += new System.EventHandler(this.CB_BGM_SelectionChangeCommitted);
			// 
			// Lbl_BGM
			// 
			this.Lbl_BGM.AutoSize = true;
			this.Lbl_BGM.Location = new System.Drawing.Point(20, 419);
			this.Lbl_BGM.Name = "Lbl_BGM";
			this.Lbl_BGM.Size = new System.Drawing.Size(30, 12);
			this.Lbl_BGM.TabIndex = 15;
			this.Lbl_BGM.Text = "BGM";
			// 
			// Ctrl_GameSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.Lbl_BGM);
			this.Controls.Add(this.CB_BGM);
			this.Controls.Add(this.Btn_StgFile);
			this.Controls.Add(this.Lbl_Dir);
			this.Controls.Add(this.Lbl_Filepath);
			this.Controls.Add(this.CHK_Demo);
			this.Controls.Add(this.Btn_Decide);
			this.Controls.Add(this.Btn_Cancel);
			this.Controls.Add(this.Btn_Folder);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Ctrl_GameSettings";
			this.Size = new System.Drawing.Size(518, 497);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Btn_Decide;
		private System.Windows.Forms.Button Btn_Cancel;
		private System.Windows.Forms.Button Btn_Folder;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ComboBox CB_Chara2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RadioButton RB_CPU2;
		private System.Windows.Forms.RadioButton RB_Player2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox CB_Chara1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton RB_CPU1;
		private System.Windows.Forms.RadioButton RB_Player1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton RB_Training;
		private System.Windows.Forms.RadioButton RB_Battle;
		private System.Windows.Forms.RadioButton RB_General;
		private System.Windows.Forms.CheckBox CHK_Demo;
		private System.Windows.Forms.Label Lbl_Filepath;
		private System.Windows.Forms.Button Btn_StgFile;
		private System.Windows.Forms.RadioButton RB_Result;
		private System.Windows.Forms.ToolTip TLTP_Folder;
		private System.Windows.Forms.Label Lbl_Dir;
		private System.Windows.Forms.ComboBox CB_BGM;
		private System.Windows.Forms.Label Lbl_BGM;
	}
}
